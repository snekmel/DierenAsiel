   M S B A M L   `   `   `  ����F  BDierenAsiel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DierenAsielDierenAsiel  5   	       DierenAsiel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DierenAsiel     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Het Dierenasiel��5	   	   $��754.029��6!   $��1340.573��62    � WindowStyle$ 
ToolWindow=�6C   
����ح�.��5      � $
��Left=�6   $	��700��6&   $��	10,10,0,0q�63   $	��Top=�6F   $
��1301��6^   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ 
datepicker��5      $
��Left=�6)   $��	34,28,0,0q�6D   $	��Top=�6W   $��32��6o   $
��1012��6{   6�   �� 5   
   -   5         ��Name$ label��5      $2��,Dieren die gereserveerd zijn voor vandaag:
��6   $
��Left=�6^   $��	34,65,0,0q�6y   $	��Top=�6�   $��43��6�   $	��464��6�   �� 5   
   -   5         ��Name$ PersoonToevoegenBtn��5      $��Persoon registreren��6.   $
��Left=�6L   $��1124,18,0,0q�6g   $	��Top=�6|   $	��159��6�   $��48��6�   6�   �� 5   
   -   5        $ DierToevoegenBtn��5      $��Dier registreren��6+   $
��Left=�6F   $��1124,72,0,0q�6a   $	��Top=�6v   $	��159��6�   $��52��6�   6�   �� 5   
   -   5        $ label2��5      $��Datum��6    $
��Left=�60   $��
32,289,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label3��5      $
��Dier��6    $
��Left=�6/   $��
34,424,0,0q�6J   $	��Top=�6^    J� RenderTransformOrigin$ -1.421,-0.692&�6v   �� 5   
   -   5        $ label4��5      $��Persoon��6    $
��Left=�62   $��576,424,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ button��5      $��	Reserveer��6!   $
��Left=�65   $��
34,612,0,0q�6P   $	��Top=�6d   $
��1056��6|   $��50��6�   6�   �� 5   
   -	   5         ��Name$ personenListview��5      $
��Left=�6-   $	��148��6H   $��576,450,0,0q�6U   $	��Top=�6j   $	��514��6�    �� View 5      �� 5      .P�5      �� $
��Naam��6%   	 �� Width$	 50��6Y   
 �� DisplayMemberBinding
 63   �� *Naam+6Y   �� 5      $��
Achternaam��6%   $		 100��6e   
 69   �� *
Achternaam+6e   �� 5      $��
Woonplaats��6%   $		 100��6e   
 69   �� *
Woonplaats+6e   �� 5      $��TelefoonNummer��6%   $		 100��6m   
 6=   �� *Telefoonnummer+6m   5      5      �� 5   
   -
   5        $ dierenListview��5      $
��Left=�6+   $	��143��6F   $��
34,450,0,0q�6S   $	��Top=�6g   $	��494��6    5      �� 5       .P�5!      �� $
��Naam��6%   $		 100��6Y   
 63   �� *Naam+6Y   �� 5"      $��Soort��6%   $		 100��6[   
 64   �� *soort+6[   �� 5#      $��Geboorte datum��6%   $		 100��6l   
 6=   �� *GeboorteDatum+6l   5$      5&      &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ dataGrid��5'      $
��Left=�6%   $��-186,393,0,0q�6@   $	��Top=�6V     5(   
   -   5        $ reserveringDatum��5(      $
��Left=�6/   $��
84,290,0,0q�6J   $	��Top=�6^   $��26��6v   $	��320��6�   �� 5)   
   -   5        $ ReserveringListview��5)      $
��Left=�60   $	��113��6K   $��
34,108,0,0q�6X   $	��Top=�6l   $
��1012��6�    5*      �� 5+      .P�5,      �� $
��Dier��6%   
 63   �� *	Dier.Naam+�� 5-      $��Persoon��6%   $	 60��6d   
 66   �� *Persoon.Naam+6d   5.      50      �� 51   
   -   5        $ beheerschermBtn��51      $��Beheerscherm��6*   $
��Left=�6A   $��1124,129,0,0q�6\   $	��Top=�6r   $	��159��6�   $��74��6�   6�   �� 52   
   -   5        $ label1��52      $��Notitie��6    $
��Left=�62   $��
32,332,0,0q�6M   $	��Top=�6a   $ 
-0.359,0.5&�6y   �� 53   
   -   5         ��Name$ notitieTextbox��53      $
��Left=�6.   $��74��6I   $��
84,332,0,0q�6U   $	��Top=�6i   $
��1006��6�   . �54      /� 55      �� 56   
   -   5         ��Name$ groupBox��56      $%��Een nieuwe reservering aanmaken��6%   $
��Left=�6N   $��
10,256,0,0q�6i   $	��Top=�6}   $	��420��6�   $
��1102��6�   �� 57   
   -   5        $ 	groupBox1��57      $��Reserveringen��6&   $
��Left=�6=   $��7,4,0,0q�6X   $	��Top=�6i   $	��247��6�   $
��1105��6�   58      59      