﻿#pragma checksum "..\..\..\Views\SzallasLekeres.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A05DF1F3D48571CDD95B161B2F0112779AFB3867A4EDA5AC2AC9907D91471306"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using foglalasmanagement.Views;


namespace foglalasmanagement.Views {
    
    
    /// <summary>
    /// SzallasLekeres
    /// </summary>
    public partial class SzallasLekeres : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Views\SzallasLekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_vnev;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\SzallasLekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_knev;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\SzallasLekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_keres;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\SzallasLekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_hozzaad;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\SzallasLekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_foglalasok;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\SzallasLekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_FoglalasInfo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/foglalasmanagement;component/views/szallaslekeres.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SzallasLekeres.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbx_vnev = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbx_knev = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btn_keres = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Views\SzallasLekeres.xaml"
            this.btn_keres.Click += new System.Windows.RoutedEventHandler(this.btn_keres_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_hozzaad = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Views\SzallasLekeres.xaml"
            this.btn_hozzaad.Click += new System.Windows.RoutedEventHandler(this.btn_hozzaad_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cb_foglalasok = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.lv_FoglalasInfo = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

