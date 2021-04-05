using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace foglalasmanagement.DataStruct
{
    public class Foglalas
    {
        public string Nev { get; set; }
        public string Azonosito { get; set; }
        public string Tol { get; set; }
        public string Ig { get; set; }
        public string Datum 
        {
            get {
                return Tol + " - " + Ig;
            }
        }
    }
    public class SzallasFoglalas : Foglalas
    {
        public string Vnev { get; set; }
        public string Knev { get; set; }
        public SzallasFoglalas(string vnev, string knev, string azon, string tol, string ig)
        {
            Vnev = vnev;
            Knev = knev;
            this.Nev = Vnev + ' ' + Knev;
            this.Azonosito = azon;
            this.Tol = tol;
            this.Ig = ig;
        }
    }
    public class KonferenciaFoglalas : Foglalas
    {
        public string Cegnev { get; set; }
        public int Letszam { get; set; }
        public KonferenciaFoglalas(string nev, string ceg, string azon, string tol, string ig, int letszam)
        {
            this.Nev = nev;
            this.Azonosito = azon;
            this.Tol = tol;
            this.Ig = ig;
            Cegnev = ceg;
            Letszam = letszam;
        }
    }
    public class Szemely
    {
        public string KeresztNev { get; set; }
        public string VezetekNev { get; set; }
        public List<SzallasFoglalas> SzallasFoglalasok { get; set; }
        public List<KonferenciaFoglalas> KonferenciaFoglalasok { get; set; }
        public Szemely(string vnev, string knev)
        {
            KeresztNev = knev;
            VezetekNev = vnev;
            SzallasFoglalasok = new List<SzallasFoglalas>();
            KonferenciaFoglalasok = new List<KonferenciaFoglalas>();
        }
        public int PersonIndexInList(List<Szemely> ppl)
        {
            ///This method gives back the persons index in a given List
            ///If the person is not found the method returns -1 and
            ///the count of the list
            int i = 0;
            while (i < ppl.Count && (ppl[i].VezetekNev != this.VezetekNev && ppl[i].KeresztNev != this.KeresztNev))
            {
                i++;
            }
            if (i < ppl.Count)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
    public class DataParser
    {
        /// My very own data parser KEKW
        public string Filename { get; set; }
        public DataParser(string filename)
        {
            this.Filename = filename;
        }
        public List<Szemely> ParseToSzemely()
        {
            List<Szemely> users = new List<Szemely>();
            StreamReader sr = new StreamReader(Filename);
            List<string> sor = new List<string>();
            int i = 0;
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine().Split(';').ToList();
                // Van szallas es konferencia foglalasa
                if(sor[2] == "1" && sor[3] == "1")
                {
                    users.Add(new Szemely(sor[0], sor[1]));
                    string foglalas;
                    do
                    {
                        foglalas = sr.ReadLine();
                        if (foglalas != "EOF" && foglalas != "Szallasfoglalasok:" && foglalas != "Konferenciafoglalasok:")
                        {
                            users[i].SzallasFoglalasok.Add(new SzallasFoglalas(users[i].VezetekNev, users[i].KeresztNev, foglalas.Split(';').ToList()[2], foglalas.Split(';').ToList()[3], foglalas.Split(';').ToList()[4]));
                        }
                    } while (foglalas != "Konferenciafoglalasok:");
                    do
                    {
                        foglalas = sr.ReadLine();
                        if (foglalas != "EOF" && foglalas != "Szallasfoglalasok:" && foglalas != "Konferenciafoglalasok:")
                        {
                            users[i].KonferenciaFoglalasok.Add(new KonferenciaFoglalas(foglalas.Split(';').ToList()[0], foglalas.Split(';').ToList()[1], foglalas.Split(';').ToList()[2], foglalas.Split(';').ToList()[3], foglalas.Split(';').ToList()[4], int.Parse(foglalas.Split(';').ToList()[5])));
                        }
                    } while (foglalas != "EOF");
                }
                // Csak szallas foglalasa van
                else if(sor[2] == "1" && sor[3] == "0")
                {
                    users.Add(new Szemely(sor[0], sor[1]));
                    string foglalas;
                    do
                    {
                        foglalas = sr.ReadLine();
                        if(foglalas != "EOF" && foglalas != "Szallasfoglalasok:" && foglalas != "Konferenciafoglalasok:")
                        {
                            users[i].SzallasFoglalasok.Add(new SzallasFoglalas(users[i].VezetekNev, users[i].KeresztNev, foglalas.Split(';').ToList()[2], foglalas.Split(';').ToList()[3], foglalas.Split(';').ToList()[4]));
                        }
                    } while (foglalas != "EOF");
                }
                // Csak konferenciafoglalasa van
                else if(sor[2] == "0" && sor[3] == "1")
                {
                    users.Add(new Szemely(sor[0], sor[1]));
                    string foglalas;
                    do
                    {
                        foglalas = sr.ReadLine();
                        if (foglalas != "EOF" && foglalas != "Szallasfoglalasok:" && foglalas != "Konferenciafoglalasok:")
                        {
                            users[i].KonferenciaFoglalasok.Add(new KonferenciaFoglalas(foglalas.Split(';').ToList()[0], foglalas.Split(';').ToList()[1], foglalas.Split(';').ToList()[2], foglalas.Split(';').ToList()[3], foglalas.Split(';').ToList()[4], int.Parse(foglalas.Split(';').ToList()[5])));
                        }
                    } while (foglalas != "EOF");
                }
                i++;
            }
            sr.Close();
            return users;
        }
        public void SzemelyToText(List<Szemely> szl)
        {
            List<Szemely> users = szl;
            StreamWriter sw = new StreamWriter(Filename);
            foreach (Szemely sz in users)
            {
                if(sz.SzallasFoglalasok.Count > 0 && sz.KonferenciaFoglalasok.Count > 0)
                {
                    sw.WriteLine($"{sz.VezetekNev};{sz.KeresztNev};1;1");
                    sw.WriteLine("SzallasFoglalasok:");
                    foreach (SzallasFoglalas f in sz.SzallasFoglalasok)
                    {
                        sw.WriteLine($"{f.Vnev};{f.Knev};{f.Azonosito};{f.Tol};{f.Ig}");
                    }
                    sw.WriteLine("Konferenciafoglalasok:");
                    foreach (KonferenciaFoglalas f in sz.KonferenciaFoglalasok)
                    {
                        sw.WriteLine($"{f.Nev};{f.Cegnev};{f.Azonosito};{f.Tol};{f.Ig};{f.Letszam}");
                    }
                    sw.WriteLine("EOF");
                }
                else if(sz.SzallasFoglalasok.Count > 0)
                {
                    sw.WriteLine($"{sz.VezetekNev};{sz.KeresztNev};1;0");
                    sw.WriteLine("Szallasfoglalasok:");
                    foreach (SzallasFoglalas f in sz.SzallasFoglalasok)
                    {
                        sw.WriteLine($"{f.Vnev};{f.Knev};{f.Azonosito};{f.Tol};{f.Ig}");
                
                    }
                    sw.WriteLine("EOF");
                }
                else if(sz.KonferenciaFoglalasok.Count > 0)
                {
                    sw.WriteLine($"{sz.VezetekNev};{sz.KeresztNev};0;1");
                    sw.WriteLine("Konferenciafoglalasok:");
                    foreach (KonferenciaFoglalas f in sz.KonferenciaFoglalasok)
                    {
                        sw.WriteLine($"{f.Nev};{f.Cegnev};{f.Azonosito};{f.Tol};{f.Ig};{f.Letszam}");
                    }
                    sw.WriteLine("EOF");
                }
            }
            sw.Close();
        }
    }
}
