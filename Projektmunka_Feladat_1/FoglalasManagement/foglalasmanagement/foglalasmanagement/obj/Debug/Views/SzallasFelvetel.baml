   M S B A M L   `   `   `  ����M  Ifoglalasmanagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:foglalasmanagement.Viewsfoglalasmanagement.Views  5   	   .    (foglalasmanagement.Views.SzallasFelvetel   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:foglalasmanagement.Views     5   	     � Title$  SzallasFelvetel��5   	   $	��300��6!   $	��600��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ tbx_vnev��5   $   $��Vezetéknév��6   $	��150��66   $��30��6B   $��1��6N   $��1��6[   $��5q�6k   �� 5   
   -   5        $ tbx_knev��5   $   $��Keresztnév��6   $	��150��66   $��30��6B   $��2��6N   $��1��6[   $��5q�6k   �� 5   
   -   5        $ tbx_azon��5      $��1��6$   $��2��61   $��5q�6A    �� 
IsReadOnly . 6L   �� 5   
   -   5        $��Azonosito Generalasa��5      $��2��60   $��2��6=   $��5q�6M   6X   �� 5   
   $��Dátum Kezdet:��6   $��1��6(   $��3��65   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	dp_kezdet��5      $��2��6(   $��3��65   �� 5   
   $��Dátum Vég:��6   $��1��6%   $��4��62     5    
   -   5        $ dp_veg��5       $��2��6%   $��4��62   �� 5!   
   -   5         ��Name$ 
btn_mentes��5!      $��Mentés��6%   $��3��66   $��1��6C   6S   5"      5#      