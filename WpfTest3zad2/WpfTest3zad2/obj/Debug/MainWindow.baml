   M S B A M L   `   `   `  ����G  CWpfTest3zad2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfTest3zad2WpfTest3zad2  5   	       WpfTest3zad2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfTest3zad2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
inkCanvas1��5
       �� DefaultDrawingAttributes 5      *  $System.Windows.Ink.DrawingAttributes  5      -   5        InkAttr��   Color$	 Red��5   5      Height$ 10Q�6A      Width$ 10Q�6M   5      �� 5   
   -   5         ��Name$ MSlider��5      $��25��6"   $	��100��6.    � Minimum$ 1Q�6:    � Maximum$ 50Q�6F   	 � Value$	 10Q�6S   $	��Top=�6^   6v   �� 5   
   -   5        
 ��Name$
 	comboBox1��5       �� SelectedIndex$ 0��6&   $��20��68   $	��100��6D   $	��Top=�6P   $
��Left=�6h   .@�5      �� -   5        $	��Red��5      6)   �� 5      -   5        $��Green��5      6+   �� 5      -   5        $
��Blue��5      6*   5      	� 5   
   -   5         	�Name$ rbDraw��5      $
��Draw��6&   $��120,3.5,0,0q�6J   $��50��6_   $��20��6j   $
��Left=�6v   $	��Top=�6�   	� 5   
   -	   5        $ rbEdit��5      $
��Edit��6&   $��180,3.5,0,0q�6J   $��50��6_   $��20��6j   $
��Left=�6v   $	��Top=�6�   	� 5   
   -
   5        $ rbDelete��5      $��Delete��6(   $��230,3.5,0,0q�6P   $��55��6e   $��20��6p   $
��Left=�6|   $	��Top=�6�   5      5      