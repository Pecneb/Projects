   M S B A M L   `   `   `  ����M  Ifoglalasmanagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:foglalasmanagementfoglalasmanagement  5   	   K*clr-namespace:foglalasmanagement.ViewModelfoglalasmanagement.ViewModel  5   	   C&clr-namespace:foglalasmanagement.Viewsfoglalasmanagement.Views  5   	   #    foglalasmanagement.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:foglalasmanagement     5   	   A
viewmodels*clr-namespace:foglalasmanagement.ViewModel     5   	   8views&clr-namespace:foglalasmanagement.Views     5   	     � Title$  
Foglalasok��5
   	   $	��450��6   $	��800��6)    � 	Resources 5       �� DataType5   /foglalasmanagement.ViewModel.KonferenciaLekeres*   $foglalasmanagement.Views.Konferencia � DataContext1   +foglalasmanagement.ViewModel.SzallasLekeres-   'foglalasmanagement.Views.SzallasLekeres��%�   (��       5   5   *, +)(�� Y     5   1   *, +)�� 5   
   konferencialekerView��"  65   .R�5         6    �� 5      �� 5   
   szallaslekerView��"  61   .R�5         6#   �� 5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       .+�5"   
   ]� 
����iA�$��0��6+   $��0��68   $��5��6H   .+�5#      �� .+�5$      �� -   5         ��Name$# btn_Szallasfoglalasmanagement��5$      
������ 
������ $��Foglalas Management��6s   $��50��6�   6�   �� 5%      -   5        $&  btn_Konerenciafoglalasmanagement��5%      
������ 
������ $��Konferencia Management��6v   $��50��6�   6�   5&      5'      �� 5(   
   $��0��6   $��1��6&   $��4��66   $��5��6J   ��6[   �� 5)      5*      