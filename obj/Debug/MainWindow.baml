   M S B A M L   `   `   `  ����D  @RainDrops, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RainDrops	RainDrops  5   	       RainDrops.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:RainDrops     5   	     � Title$  	Raindrops��5   	   $��450.314��6   $��515.481��6,   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ paperCanvas��5      $	��100��6&   $��1��69   $��10q�6I   $��Stretch=�6U   $��Stretch=�6t   $��0��6�   
�������}�. 6�   �� 5   
   -   5         ��Name$ startButton��5      $��0��6&   $��0��63   $��10q�6C   $
��auto��6O   $��Center=�6\   $	��100��6y   $��Center=�6�   $��25��6�   $��Start��6�   6�   �� 5   
   -   5        $ 
stopButton��5      $��1��6%   $��0��62   $��10q�6B   $
��auto��6N   $��Center=�6[   $	��100��6x   $��Center=�6�   $��25��6�   $
��Stop��6�   6�   �� 5   
   -   5        $ clearButton��5      $��2��6&   $��0��63   $��10q�6C   $
��auto��6O   $��Center=�6\   $	��100��6y   $��Center=�6�   $��25��6�   $��Clear��6�   6�   �� 5   
   -   5         ��Name$ intervalSlider��5      $��3��6)   $��0��66   $��10q�6F   $	��150��6R   $��Stretch=�6a   $��Bottom=�6   $��25��6�    � SmallChange$ 1Q�6�    � LargeChange$ 99Q�6�    � Minimum$ 50Q�6�   	 � Maximum$
	 1000Q�6�   
 � Value$	
 500Q�6�   6�   �� 5   
   -   5         ��Name$ intervalSize��5      $��3��6&   $��0��63   $��10q�6C   $	��Top=�6O   $��Stretch=�6g   $��
500 ms gap��6�   �� 5   
   -   5        $ minAlphaLabel��5      $��4��6'   $��0��64   $��10q�6D   $	��Top=�6P   $��Stretch=�6h   $��Alpha: x��6�   �� 5   
   -   5        $ minAlphaSlider��5      $��4��6)   $��0��66   $��10q�6F   $��Bottom=�6R   $��Stretch=�6m   $��25��6�   $		 255Q�6�   $ 1Q�6�   $ 10Q�6�   $	
 100Q�6�   6�   �� 5   
   -	   5        $ 
saveButton��5      $��5��6%   $��0��62   $��10q�6B   $��Center=�6N   $��Stretch=�6i   $
��Save��6�   $��25��6�   6�   5      5       