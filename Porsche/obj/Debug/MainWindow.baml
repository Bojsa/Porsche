   M S B A M L   `   `   `  ����B  >Porsche, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PorschePorsche  5   	       Porsche.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Porsche     5   	     � 
ResizeMode$  NoResize=�5       � WindowStartupLocation$ CenterScreen=�60    � Title$ 
MainWindow��5   	   $��515.5��6   $��790.462��6+   ��5	      �� 5
   
    �� ImageSource$ Siva.jpg��6   .��5      � $��	0,0,-8,-1q�6   $
��Left=�6   $	��774��69    � ColumnDefinitions 5   
   �� 5      $
��109* �6   �� 5      $
��684* �6   .+�5   
   �� -   5         ��Name$ labelNaslov��5      $��Porsche��6&   $
��Left=�68   $��
220,10,0,0q�6S   $	��Top=�6g   $	��104��6   $	��210��6�   $��1��6�   $��48(�6�   $��MV Boli)�6�   �� 5      -   5         ��Name$ buttonDodaj��5       � Cursor$
 Hand��6    ���	#FF707070$��Dodaj automobil��6E   $
��Left=�6_   $��
31,191,0,0q�6z   $	��Top=�6�   $	��175��6�    J� RenderTransformOrigin$ 0.4,-1.7&�6�   $��39��6�   
�������$��2��6  $��20(�6!  �� 5   
   -   5        $ buttonIzlaz��5      $
 Hand��6&   ���	#FF707070$��Izlaz��6K   $
��Left=�6[   $��488,191,0,0q�6v   $	��Top=�6�   $	��130��6�   $��39��6�   $��1��6�   
�������$��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 dataGridPorsche��5      
   AutoGenerateColumns
 .     SelectionMode$ Single=�6j      
IsReadOnly . $
��Left=�6�   $	��241��6�   $��
10,244,0,0q�6�   $	��Top=�6�   $	��760��6�   $��2��6�   ��6H   �� *
Porsches+ � 	Resources 5       �� 
TargetType   WrapText �� Property �� Value��%T   &	        �� 5      " ��6   .�5      ��  � ��$
 Wrap=�6&   5      5          Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Porse_Modeli��6!      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Porse_Modeli+6X     5$      $ 	Podnaslov��6      ElementStyle# [  6J   $	 100 6s    6,   �� *	Podnaslov+6s     5%      $ Tekst��6   # [  6B   $	 160 6k    6(   �� *Tekst+6k     5&      $ 
Kategorija��6!   $ 80 6T    65   �� *
Kategorija+6T     5'      $ Vreme izmene��6%   # [  6[   $ 65 6�    6;   �� *DatumIzmene+6�   4  .System.Windows.Controls.DataGridTemplateColumn  5(      $ Slika��6      CellTemplate 5)      �� 5*      .R�5+   	   �� $��65��6(   $	��120��64   $��0,5,0,5q�6@   $��Uniform=�6Q   $��Center=�6c   $��Center=�6�   ��6   �� *Slika+6�   5,   	   5.        5/      $ * 6   $ Opcije��6'    50      �� 51      .R�52   	   �� $��Center=�6   $��Center=�62   .+�53   
   �� $
 read��6   -   5        $��_Read��53      
���   �$��Segoe UI)�6^   ���	#FFFBFB9F
�������$	��125��6�   $��30��6�   $��14(�6�   $��0,2,0,2q�6�   �� 54   
   $ change��6   -   5        $��_Change��54   !   $	��125��6O   $��30��6[   
���   �$��Segoe UI)�6|   ���	#FFFBFB9F
�������$��14(�6�   $��0,2,0,2q�6�   �� 55   
   $ delete��6   -   5        $��_Delete��55   !   $	��125��6O   $��30��6[   
���   �$��Segoe UI)�6|   ���	#FFFBFB9F
�������$��14(�6�   $��0,2,0,2q�6�   56   
   57   	   59      5;      �� 5<   
   $
��Left=�6   $	��150��6+   $��
435,10,0,0q�68   $	��Top=�6L   $	��221��6d   $��Porsche.jpg��6p   $��1��6�   �� 5=   
   $
��Left=�6   $	��150��6+   $��	10,10,0,0q�68   $	��Top=�6K   $	��220��6c   $��Porsche1.jpg��6o   $��2��6�   5?      5@      