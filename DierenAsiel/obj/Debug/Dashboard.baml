   M S B A M L   `   `   `  ����F  BDierenAsiel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DierenAsielDierenAsiel  5   	       DierenAsiel.Dashboard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DierenAsiel     5   	     � Title$  	Dashboard��5   	   $��668.857��6   $��807.984��6,    � WindowStartupLocation$ CenterScreen=�6<   
����ح�.��5	      � .+�5
   
   �� -   5         ��Name$ personenListview��5
      $
��Left=�6-   $	��249��6H   $��	10,54,0,0q�6U   $	��Top=�6h   $	��768��6�    �� View 5      �� 5      .P�5      �� $
��Naam��6%    �� Width$ 50��6Y    �� DisplayMemberBinding 63   �� *Naam+6Y   �� 5      $��
Achternaam��6%   $	 100��6e    69   �� *
Achternaam+6e   �� 5      $��
Woonplaats��6%   $	 100��6e    69   �� *
Woonplaats+6e   �� 5      $��Straat��6%   $	 100��6]    65   �� *Straat+6]   �� 5      $��
Huisnummer��6%   $	 100��6e    69   �� *
Huisnummer+6e   �� 5      $��Postcode��6%   $	 100��6a    67   �� *
Postcode+6a   �� 5      $��TelefoonNummer��6%   $	 100��6m    6=   �� *Telefoonnummer+6m   �� 5      $��Email��6%   $	 100��6[    64   �� *Email+6[   5      5      �� 5   
   -   5         ��Name$ naamfilterTb��5      $
��Left=�6(   $��23��6C   $��
115,21,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   6�   �� 5   
   -   5         ��Name$ label��5      $
��Left=�6   $��	16,13,0,0q�6:   $	��Top=�6M   .��5      �� -   5        $ label1��5      $��Filter op naam:��6$   5      �� 5   
   -   5        $ label2��5      $��Filter op naam:��6    $
��Left=�6:   $��
16,398,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ dierfilterTb��5      $
��Left=�6(   $��23��6C   $��115,402,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5        $ listView��5      $
��Left=�6%   $	��179��6@   $��
16,429,0,0q�6M   $	��Top=�6a   $	��762��6y    5      �� 5       .P�5!      �� 5"      5$      5%      5&      