   M S B A M L   `   `   `  ����M  Ifoglalasmanagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:foglalasmanagement.Viewsfoglalasmanagement.Views  5      -    'foglalasmanagement.Views.SzallasLekeres   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:foglalasmanagement.Views     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   $��1��6;   $��6��6K   .+�5      �� $��Vezetéknév:��6   $	��0,0q�6*   �� 5   
   -   5         ��Name$ tbx_vnev��5      $	��100��6$   $	��0,0q�60   �� 5   
   $��Keresztnév:��6   $	��0,0q�6&   �� 5   
   -   5        $ tbx_knev��5      $	��100��6$   $	��0,0q�60   �� 5    
   -   5         ��Name$ 	btn_keres��5       $	��106��6$   $��Keresés��60   $��10,0,0,0q�6B   6T   �� 5!   
   -   5        $ btn_hozzaad��5!      $��Foglalás felvétele��6&   $��10,0,0,0q�6C   6U   �� 5"   
   -   5        $ 	btn_torol��5"      $��Foglalás Törlése��6$   $��10,0,0,0q�6?   6Q   5#      �� 5$   
   -   5         ��Name$ lv_FoglalasInfo��5$      $��3��6,   $��1��69   $��2��6I   $��6��6Z   $��10q�6n    �� View 5%      �� 5&       �� AllowsColumnReorder .  �� ColumnHeaderToolTip$ Foglalas Informacio��66   .P�5'      �� $��Vezetéknév��6P   	 �� Width$		 150��6d   
 �� DisplayMemberBinding
 6%   ��  �� Path$
 Vnev�6d   �� 5(      $��Keresztnév��6P   $		 150��6d   
 6%   �� $
 Knev�6d   �� 5)      $��Dátum��6Q   $		 160��6`   
 6%   �� $ Datum�6`   5*      5,      5-      5.      