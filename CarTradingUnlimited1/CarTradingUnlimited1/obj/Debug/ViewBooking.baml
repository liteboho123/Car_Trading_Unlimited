   M S B A M L   `   `   `  ����O  KCarTradingUnlimited1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CarTradingUnlimited.ControlCarTradingUnlimited.Control  5   �   %    CarTradingUnlimited.ViewBooking   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6?   =Control)clr-namespace:CarTradingUnlimited.Control     6�   -   5          N�Name$
  Page��5       N� WindowTitle$
 Page��5      $��LeftToRight=�5       N� WindowWidth$	 640Q�5	       N� WindowHeight$	 480Q�6   $	��640��6P   $	��462��6\   .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5   
   ]� ��.  $��	306,0,0,0q�6*   .+�5       � -   5          �Name$ 	Book_page��5      $	��334��6'   5      ]� 5   
   ��.  $��	0,0,334,0q�6*   .+�5      �� $
��Wrap=�6   $	��Top=�6,   $��26.667(�6A   ���	#FF858585 �� TextAlignment$ Center=�6j   $
��Bold"�6�   $��Italic$�6�   $��	Underline{�6�   �� 6�    � Language$ en-za�6�   $�TEST DRIVE DETAILS��6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DGV_TestDrive��5      $��8,5,8,0q�6.   $	��Top=�6?   $	��Top=�6W   	   RowBackground	 �	#FF858585
���   �$	��246��6�   ��6l   Z� 6�   �� 5      $��Search test drives:��6   $��8,0,0,0q�64   $��16(�6E   $��SimSun)�6S   ���	#FF252424$	��Top=�6~   $
��Left=�6�   $	��290��6�   .��5      �� $��8,0,17.5,7.75q�6   .+�5      �� 
 �� Orientation$
 
Horizontal=�6!   .+�5      �� $
��Wrap=�6$   $��	Customer:��68   $��70��6I   $��Center=�6T   $��12(�6o   $��13.6866666666667��6}   �� 5      -   5         ��Name$ txt_Cust��5   "    �� TextWrapping$
 Wrap=�64   $��Please enter name....��6H   $	��177��6e   $��Center=�6q    �� SelectionOpacity$
 64.4Q�6�   
���   �$��12(�6�   $��15.687��6�   ��6�   Z� .��6K  ��5      �� 5   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5   &   � -   5        G1�� � Color$ 	#FFFFD6D6��5   ?   � 5   &   -   5        G2��$ 	#FF858585��5   ?    � Offset$ 1Q�6Q   5   #   .��5   2    � Triggers 5      :� 5   "    :� RoutedEvent$ FrameworkElement.Loaded��6/   .[�5    &   �� .��5!   *   �� -   5         ��Name$	 sb1��5!   5    g� RepeatBehavior$ Forever��6B    g� AutoReverse . .��5"   .   ��  �� 
TargetName$ G1��6=    �� TargetProperty$ Color�6X   	 �� To$ 	#FF858585X�6z    g� Duration$ 0:0:1D�6�   �� 5#   .   $ G2��6=   $ Color�6X   $ 	#FFFFD6D6X�6z   $ 0:0:1D�6�   5$   +   5%   '   5&   #   .��5'   0   5(      5)      �� 5*      $
 
Horizontal=�6!   .+�5+      �� $
��Wrap=�6$   $��Brand:��68   $��70��6F   $��Center=�6Q   $��12(�6l   $��13.6866666666667��6z   �� 5,      -	   5        $ 	txt_Brand��5,   "   $
 Wrap=�65   $!��Please enter brand name....��6I   $	��177��6l   $��Center=�6x   $��12(�6�   $��15.6866666666667��6�   ��6�   Z� .��64  ��5-      �� 5.   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5/   &   � -
   5        G3��$ 	#FFFFD6D6��5/   ?   � 50   &   -   5        G4��$ 	#FF858585��50   ?   $ 1Q�6Q   51   #   .��52   2    53      :� 54   "   $ FrameworkElement.Loaded��6/   .[�55   &   �� .��56   *   �� $ Forever��65    . .��57   .   �� $ G3��6=   $ Color�6X   $ 	#FF858585X�6z   $ 0:0:1D�6�   �� 58   .   $ G4��6=   $ Color�6X   $ 	#FFFFD6D6X�6z   $ 0:0:1D�6�   59   +   5:   '   5;   #   .��5<   0   5=      5>      �� 5?      $
 
Horizontal=�6!   .+�5@      �� $
��Wrap=�6$   $��Model:��68   $��70��6F   $��Center=�6Q   $��13.6866666666667��6l   $��12(�6�   �� 5A      -   5        $ 	txt_Model��5A   "   $
 Wrap=�65   $��Please enter model....��6I   $	��177��6g   $��15.686��6s   $��Center=�6�   $��12(�6�   ��6�   Z� .��6%  ��5B      �� 5C   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5D   &   � -   5        G5��$ 	#FFFFD6D6��5D   ?   � 5E   &   -   5        G6��$ 	#FF858585��5E   ?   $ 1Q�6Q   5F   #   .��5G   2    5H      :� 5I   "   $ FrameworkElement.Loaded��6/   .[�5J   &   �� .��5K   *   �� $ Forever��65    . .��5L   .   �� $ G5��6=   $ Color�6X   $ 	#FF858585X�6z   $ 0:0:1D�6�   �� 5M   .   $ G6��6=   $ Color�6X   $ 	#FFFFD6D6X�6z   $ 0:0:1D�6�   5N   +   5O   '   5P   #   .��5Q   0   5R      5S      �� 5T      $
 
Horizontal=�6!   .+�5U      �� $
��Wrap=�6$   $��
Serial no:��68   $��70��6J   $��Center=�6U   $��12(�6p   �� 5V      -   5        $ txt_SerialNo��5V   "   $
 Wrap=�68   $ ��Please enter serial no....��6L   $	��177��6n   $��Center=�6z   $��12(�6�   $��15.6866666666667��6�   ��6�   Z� .��6?  ��5W      �� 5X   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5Y   &   � -   5        G7��$ 	#FFFFD6D6��5Y   ?   � 5Z   &   -   5        G8��$ 	#FF858585��5Z   ?   $ 1Q�6Q   5[   #   .��5\   2    5]      :� 5^   "   $ FrameworkElement.Loaded��6/   .[�5_   &   �� .��5`   *   �� $ Forever��65    . .��5a   .   �� $ G7��6=   $ Color�6X   $ 	#FF858585X�6z   $ 0:0:1D�6�   �� 5b   .   $ G8��6=   $ Color�6X   $ 	#FFFFD6D6X�6z   $ 0:0:1D�6�   5c   +   5d   '   5e   #   .��5f   0   5g      5h      �� 5i      $
 
Horizontal=�6!   .+�5j      �� $
��Wrap=�6$   $��Price��68   $��70��6E   $��Center=�6P   $��13.6866666666667��6k   $��12(�6�   �� 5k      -   5        $ 	txt_Price��5k   "   $
 Wrap=�65   $��Please enter price....��6I   $	��177��6g   $��Center=�6s   $��12(�6�   $��15.686��6�   ��6�   Z� .��6%  ��5l      �� 5m   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5n   &   � -   5        G9��$ 	#FFFFD6D6��5n   ?   � 5o   &   -   5        G10��$ 	#FF858585��5o   @   $ 1Q�6R   5p   #   .��5q   2    5r      :� 5s   "   $ FrameworkElement.Loaded��6/   .[�5t   &   �� .��5u   *   �� $ Forever��65    . .��5v   .   �� $ G9��6=   $ Color�6X   $ 	#FF858585X�6z   $ 0:0:1D�6�   �� 5w   .   $	 G10��6=   $ Color�6Y   $ 	#FFFFD6D6X�6{   $ 0:0:1D�6�   5x   +   5y   '   5z   #   .��5{   0   5|      5}      5~      5�      �� 5�      $��Bottom=�6   $
 
Horizontal=�61   $	��8,0q�6J   .+�5�      �� -   5         ��Name$ can_Show��5�      $��77��6+   $��29��66   $��Bottom=�6B   $��0q�6]    � Cursor$
 Hand��6�   .+�5�      �� -   5         ��Name$ _base��5�       $��29��6/   ���	#FFB21D1D$��0��6N    �� RadiusX$ 24��6b    �� RadiusY$ 18��6o   ���	#FF858585$��77��6�   �� 5�      -   5        $
 glow��5�       $��29��6.   ���	#FFB21D1D$��0��6M   $ 24��6a   $ 18��6n   $��77��6{     J� Opacity$  0Q�6�   ��5�      
� 5�      ! 
� RadiusY$! 0.526Q�62   " 
� GradientOrigin$" 0.455,1.077&�6B   # 
� Center$# 
0.494,0.84&�6_   $ 
� RadiusX$$ 0.586Q�6s   .��5�   "   � $ 	#FFC3D3E2��6/   � 5�   "   $ 1Q�6/   $ 	#00000000��6:   5�      5�      �� 5�      -   5        $ glass��5�       $��29��6/   ���	#FFB21D1D$��0��6N   $ 24��6b   $ 18��6o   $��77��6|   $  0.795Q�6�   ��5�      �� 5�      $ 0.489,-0.231&�62   % � MappingMode$% RelativeToBoundingBox=�6J   $ 
0.489,1.07&�6n   .��5�   "   � $ 	#00000000��6/   $ 0Q�6A   � 5�   "   $ White��6/   $ 1Q�6=   � 5�   "   $ 	#9B9B9B9B��6/   $ 0.675Q�6A   � 5�   "   $ 	#1B1B1B1B��6/   $ 0.543Q�6A   5�      5�      �� 5�      $
��Wrap=�6    $��39��64   $��21��6?   & J� RenderTransformOrigin$& 0.846,0.482&�6K   ' �� Left$' 19��6o   
( �� Top$( 8��6�   $ Center=�6�   �� 6�   $ en-za�6�   $
�Show��6�   �� 6�   �� 6�   $ en-za�6�   6�   5�      �� 5�      -   5        $ 
can_Delete��5�      $��77��6.   $��29��69   $��Bottom=�6E   $��0q�6`   $
 Hand��6�   .+�5�      �� -   5        $ _base1��5�       $��29��60   ���	#FFB21D1D$��0��6O   $ 24��6c   $ 18��6p   ���	#FF858585$��77��6�   �� 5�      -   5        $ glow1��5�       $��29��6/   ���	#FFB21D1D$��0��6N   $ 24��6b   $ 18��6o   $��77��6|   $  0Q�6�   ��5�      
� 5�      $! 0.526Q�62   $" 0.455,1.077&�6B   $# 
0.494,0.84&�6_   $$ 0.586Q�6s   .��5�   "   � $ 	#FFC3D3E2��6/   � 5�   "   $ 1Q�6/   $ 	#00000000��6:   5�      5�      �� 5�      -   5        $ glass1��5�       $��29��60   ���	#FFB21D1D$��0��6O   $ 24��6c   $ 18��6p   $��77��6}   $  0.795Q�6�   ��5�      �� 5�      $ 0.489,-0.231&�62   $% RelativeToBoundingBox=�6J   $ 
0.489,1.07&�6n   .��5�   "   � $ 	#00000000��6/   $ 0Q�6A   � 5�   "   $ White��6/   $ 1Q�6=   � 5�   "   $ 	#9B9B9B9B��6/   $ 0.675Q�6A   � 5�   "   $ 	#1B1B1B1B��6/   $ 0.543Q�6A   5�      5�      �� 5�      $
��Wrap=�6    $��39��64   $��21��6?   $& 0.846,0.482&�6K   $' 19��6o   $( 8��6�   $ Center=�6�   �� 6�   $ en-za�6�   $�Delete��6�   6�   5�      5�      5�      5�      5�      