   M S B A M L   `   `   `  ����B  >Porsche, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PorschePorsche  5   	       Porsche.AddWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Porsche     5   	     � Title$  	AddWindow��5   	   $	��520��6   $	��800��6(   ��5	      �� 5
   
    �� ImageSource$ Siva.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ labelPorse_Modeli_Greska��5      $�� ��63   
���  ��$
��Left=�6O   $��
238,61,0,0q�6j   $	��Top=�6~   $��33��6�   $	��490��6�   $��20(�6�   �� 5   
   -   5        $ labelPorse_Modeli��5      $��Porse_Modeli��6,   $
��Left=�6C   $��	33,12,0,0q�6^   $	��Top=�6q   $��49��6�   $	��131��6�   $��20(�6�   �� 5   
   -   5        $ labelPodnaslov��5      $��	Podnaslov��6(   $
��Left=�6<   $��	33,99,0,0q�6W   $	��Top=�6j   $��58��6�   $	��106��6�   $��20(�6�   �� 5   
   -   5        $ 
labelTekst��5      $
��Text��6$   $
��Left=�63   $��
33,172,0,0q�6N   $	��Top=�6b   $��48��6z   $	��106��6�   $��20(�6�   �� 5   
   -   5        $ labelKategorija��5      $��
Kategorija��6)   $
��Left=�6>   $��
33,330,0,0q�6Y   $	��Top=�6m   $��48��6�   $	��106��6�   $��20(�6�    J� RenderTransformOrigin$ 0.652,2.175&�6�   �� 5   
   -   5         ��Name$ buttonDodaj��5      $��Dodaj��6&   
�������$
��Left=�6I   $��504,435,0,0q�6d   $	��Top=�6y   $	��105��6�   $��40��6�   $��20(�6�   6�   �� 5   
   -   5        $ buttonIzadji��5      
�������$��Izadji��6:   $
��Left=�6K   $��662,435,0,0q�6f   $	��Top=�6{   $��97��6�   $��40��6�   $��20(�6�   $ 0.684,0.425&�6�   6�   �� 5   
   -   5         ��Name$ comboBoxKategorija��5      $
��Left=�6/   $��238,330,0,0q�6J   $	��Top=�6_   $	��281��6w   $��48��6�   $ 0.525,2.251&�6�   �� 5   
   -	   5         ��Name$ textBoxPorse_Modeli��5      $
��Left=�60   $��51��6K   $��
238,10,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��490��6�   $��20(�6�   �� 5   
   -
   5        $ textBoxPodnaslov��5      $
��Left=�6,   $��37��6G   $��
238,99,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��490��6�   $��20(�6�   �� 5   
   -   5        $ textBoxTekst��5      $
��Left=�6)   $	��102��6D   $��238,190,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��490��6�   $��20(�6�   �� 5   
   -   5        $ textBoxSlika��5      $��Naslovna slika��6&   $
��Left=�6?   $��
33,383,0,0q�6Z   $	��Top=�6n   $ -5.304,-1.278&�6�   $��54��6�   $	��167��6�   $��20(�6�   �� 5   
   -   5        $ buttonDodajSliku��5      
�������$��Dodaj SLiku��6>   $
��Left=�6T   $��
40,439,0,0q�6o   $	��Top=�6�   $	��124��6�   $��40��6�   $��20(�6�   $ 0.684,0.425&�6�   6�   �� 5   
   -   5         ��Name$ image1��5      $
��Left=�6    $��92��6;   $��238,383,0,0q�6G   $	��Top=�6\   $	��103��6t   $
��Fill=�5      �� 5   
   -   5        $ labelPodnaslov_Greska��5      
���  ��$��20(�6@   $�� ��6N   $
��Left=�6Y   $��238,141,0,0q�6t   $	��Top=�6�   $��44��6�   $	��422��6�   �� 5   
   -   5        $ labelTekst_Greska��5      
���  ��$��20(�6<   $�� ��6J   $
��Left=�6U   $��238,297,0,0q�6p   $	��Top=�6�   $��33��6�   $	��490��6�   �� 5   
   -   5        $ labelKategorija_Greska��5      
���  ��$��20(�6A   $�� ��6O   $
��Left=�6Z   $	��Top=�6u   $��573,336,0,0q�6�   $ 0.5,0.5&�6�   $��45��6�   $	��173��6�   z�5      V� 5       .~�5!      �� �� 5"      �� 5#      	 �� Angle$	 -0.233Q�6&   T� 5$      5%      5'      �� 5(   
   -   5        $ labelSlika_Greska��5(      
���  ��$��20(�6<   $�� ��6J   $
��Left=�6U   $��346,383,0,0q�6p   $	��Top=�6�   $ -0.337,-0.076&�6�   $��47��6�   $	��263��6�   5*      5+      