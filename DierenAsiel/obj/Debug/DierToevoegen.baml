   M S B A M L   `   `   `  ����F  BDierenAsiel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DierenAsielDierenAsiel  5   	       DierenAsiel.DierToevoegen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DierenAsiel     5   	     � Title$  DierToevoegen��5   	   $��265.963��6   $��317.413��60   
����ح� � WindowStartupLocation$ CenterScreen=�5	       .��5
      � $��0,0,2,1q�6   .+�5   
   �� -   5         ��Name$ label��5      $��Naam
��6   $
��Left=�68   $��	32,10,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ label1��5      $��	Diersoort��6    $
��Left=�64   $��	32,43,0,0q�6O   $	��Top=�6b   �� 5   
   -   5        $ label2��5      $��Geboorte datum��6    $
��Left=�69   $��	32,74,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $ label3��5      $��Vorige Eigenaar��6    $
��Left=�6:   $��
32,100,0,0q�6U   $	��Top=�6i   �� 5   
   -   5         ��Name$ naamTb��5      $
��Left=�6"   $��23��6=   $��
163,14,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   -   5         ��Name$ dierSoortCb��5      $
��Left=�6(   $��
163,47,0,0q�6C   $	��Top=�6W   $	��120��6o   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ geboorteDatum��5      $
��Left=�6,   $��
163,76,0,0q�6G   $	��Top=�6[   $	��120��6s   �� 5   
   -   5        $ vorigeEigenaarCb��5      $
��Left=�6-   $��163,104,0,0q�6H   $	��Top=�6]   $	��120��6u   �� 5   
   -	   5        $ label6��5      $��Geslacht��6    $
��Left=�63   $��
32,131,0,0q�6N   $	��Top=�6b   �� 5   
   -
   5        $ 
geslachtCb��5      $
��Left=�6'   $��163,135,0,0q�6B   $	��Top=�6W   $	��120��6o   �� 5   
   -   5         ��Name$ 
opslaanBtn��5      $��Opslaan��6%   $
��Left=�67   $��163,186,0,0q�6R   $	��Top=�6g   $	��117��6   $��24��6�   6�   5      5      