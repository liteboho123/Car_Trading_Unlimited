   M S B A M L   `   `   `  ����  CarTradingUnlimited1%    CarTradingUnlimited.ViewInvoice   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6?   -   5          N�Name$  Page_Invoice��5       N� WindowTitle$
 Page��5      $��LeftToRight=�5      $	��640��5	      $	��462��6    N� WindowWidth$	 640Q�5
       N� WindowHeight$	 480Q�6   .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5      ]� ��.  $��	310,0,0,0q�6$   .+�5       � -   5          �Name$ Invoice_page��5      $	��330��6!   5      ]� 5      ��.  $��	0,0,334,0q�6$   .+�5      �� $
��Wrap=�6   $	��Top=�6#   $��26.667(�68   ���	#FF646E38 �� TextAlignment$ Center=�6a   $
��Bold"�6x   $��Italic$�6�   $��	Underline{�6�   �� 6�    � Language$ en-za�6�   $�INVOICE DETAILS��6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DGV_Invoice��5      $��8,5,8,0q�6#   $	��Top=�64   $	��Top=�6L      red	   RowBackground#	 �   6w   
���   �$	��246��6�   ��6a   Z� 6�   �� 5      $��Search Invoice:��6   $��8,0,0,0q�6'   $��16(�68   $��SimSun)�6F   ���	#FF646E38$	��Top=�6q   $
��Left=�6�   $	��290��6�   .��5      �� $��8,0,17.5,7.75q�6   .+�5      �� 
 �� Orientation$
 
Horizontal=�6   .+�5      �� $
��Wrap=�6   $��	Customer:��6&   $��70��67   $��Center=�6B   $��12(�6]   $��13.6866666666667��6k   ���	#FF646E386�   �� 5      -   5         ��Name$ txt_Cust��5       �� TextWrapping$
 Wrap=�6"   $��Please enter name....��66   $	��177��6S   $��Center=�6_    �� SelectionOpacity$
 64.4Q�6z   
���   �$��12(�6�   $��15.687��6�   ��6�   Z� .��69  ��5   	   �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      � -   5        G1�� � Color$ 	#FFFFD6D6��5   $   � 5      -   5        G2��$ 	#FF646E38��5   $    � Offset$ 1Q�66   5      .��5       � Triggers 5   	   :� 5    
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5!      �� .��5"      �� -   5         ��Name$	 sb1��5"       g� RepeatBehavior$ Forever��6$    g� AutoReverse . .��5#      ��  �� 
TargetName$ G1��6    �� TargetProperty$ Color�67   	 �� To$ 	#FF646E38X�6Y    g� Duration$ 0:0:1D�6h   �� 5$      $ G2��6   $ Color�67   $ 	#FFFFD6D6X�6Y   $ 0:0:1D�6h   5%      5&      5'      .��5(      5)   	   5*      �� 5+      -	   5         ��Name$ Stack_Vehicle��5+      $
 
Horizontal=�6)   .+�5,      �� $
��Wrap=�6   $��Vehicle:��6&   $��70��66   $��Center=�6A   $��12(�6\   $��13.6866666666667��6j   �� 5-      -
   5        $ txt_Vehicle��5-      $
 Wrap=�6%   $!��Please enter brand name....��69   $	��177��6\   $��Center=�6h   $��12(�6�   $��15.6866666666667��6�   ��6�   Z� .��6*  ��5.   	   �� 5/   
   $ 0.5,1&�6   $ 0.5,0&�6/   .��50      � -   5        G3��$ 	#FFFFD6D6��50   $   � 51      -   5        G4��$ 	#FF646E38��51   $   $ 1Q�66   52      .��53       54   	   :� 55   
   $ FrameworkElement.Loaded��6   .[�56      �� .��57      �� $ Forever��6    . .��58      �� $ G3��6   $ Color�67   $ 	#FF646E38X�6Y   $ 0:0:1D�6h   �� 59      $ G4��6   $ Color�67   $ 	#FFFFD6D6X�6Y   $ 0:0:1D�6h   5:      5;      5<      .��5=      5>   	   5?      �� 5@      -   5        $ 
Stck_Parts��5@      $
 
Horizontal=�6&   .+�5A      �� $
��Wrap=�6   $��Parts:��6&   $��70��64   $��Center=�6?   $��13.6866666666667��6Z   $��12(�6t   �� 5B      -   5        $ 	txt_Parts��5B      $
 Wrap=�6#   $!��Please enter parts name....��67   $	��177��6Z   $��15.686��6f   $��Center=�6v   $��12(�6�   ��6�   Z� .��6  ��5C   	   �� 5D   
   $ 0.5,1&�6   $ 0.5,0&�6/   .��5E      � -   5        G5��$ 	#FFFFD6D6��5E   $   � 5F      -   5        G6��$ 	#FF646E38��5F   $   $ 1Q�66   5G      .��5H       5I   	   :� 5J   
   $ FrameworkElement.Loaded��6   .[�5K      �� .��5L      �� $ Forever��6    . .��5M      �� $ G5��6   $ Color�67   $ 	#FF646E38X�6Y   $ 0:0:1D�6h   �� 5N      $ G6��6   $ Color�67   $ 	#FFFFD6D6X�6Y   $ 0:0:1D�6h   5O      5P      5Q      .��5R      5S   	   5T      �� 5U      -   5        $ Stck_ServPlan��5U      $
 
Horizontal=�6)   .+�5V      �� $
��Wrap=�6   $��S.Plan:��6&   $��70��65   $��Center=�6@   $��12(�6[   �� 5W      -   5        $ txt_ServPlan��5W      $
 Wrap=�6&   $��Please enter service....��6:   $	��177��6Z   $��Center=�6f   $��12(�6�   $��15.6866666666667��6�   ��6�   Z� .��6+  ��5X   	   �� 5Y   
   $ 0.5,1&�6   $ 0.5,0&�6/   .��5Z      � -   5        G7��$ 	#FFFFD6D6��5Z   $   � 5[      -   5        G8��$ 	#FF646E38��5[   $   $ 1Q�66   5\      .��5]       5^   	   :� 5_   
   $ FrameworkElement.Loaded��6   .[�5`      �� .��5a      �� $ Forever��6    . .��5b      �� $ G7��6   $ Color�67   $ 	#FF646E38X�6Y   $ 0:0:1D�6h   �� 5c      $ G8��6   $ Color�67   $ 	#FFFFD6D6X�6Y   $ 0:0:1D�6h   5d      5e      5f      .��5g      5h   	   5i      5j      5l      �� 5m      $��Bottom=�6   $
 
Horizontal=�6(   $	��8,0q�6A   .+�5n      �� -   5         ��Name$ can_Show��5n      $��77��6   $��29��6*   $��Bottom=�66   $��0q�6Q    � Cursor$
 Hand��6�   .+�5o      �� -   5         ��Name$ _base��5o      $��29��6    ���	#FFB21D1D$��0��6?    �� RadiusX$ 24��6S     �� RadiusY$  18��6`   ���	#FF646E38$��77��6~   �� 5p      -   5        $
 glow��5p      $��29��6   ���	#FFB21D1D$��0��6>   $ 24��6R   $  18��6_   $��77��6l   ! J� Opacity$! 0Q�6w   ��5q      
� 5r   	   " 
� RadiusY$" 0.526Q�6   # 
� GradientOrigin$# 0.455,1.077&�6-   $ 
� Center$$ 
0.494,0.84&�6J   % 
� RadiusX$% 0.586Q�6^   .��5s   
   � $ 	#FFC3D3E2��6   � 5t   
   $ 1Q�6   $ 	#00E8F508��6"   5u   
   5w      �� 5x      -   5        $ glass��5x      $��29��6    ���	#FFB21D1D$��0��6?   $ 24��6S   $  18��6`   $��77��6m   $! 0.795Q�6x   ��5y      �� 5z   	   $ 0.489,-0.231&�6   & � MappingMode$& RelativeToBoundingBox=�65   $ 
0.489,1.07&�6Y   .��5{   
   � $ 	#00000000��6   $ 0Q�6)   � 5|   
   $ White��6   $ 1Q�6%   � 5}   
   $ 	#9B9B9B9B��6   $ 0.675Q�6)   � 5~   
   $ 	#1B1B1B1B��6   $ 0.543Q�6)   5   
   5�      �� 5�      $
��Wrap=�6   $��39��6%   $��21��60   ' J� RenderTransformOrigin$' 0.846,0.482&�6<   ( �� Left$( 19��6`   
) �� Top$) 8��6q   $ Center=�6�   �� 6�   $ en-za�6�   $
�Show��6�   �� 6�   �� 6�   $ en-za�6�   6�   5�      �� 5�      -   5        $ 
can_Delete��5�      $��77��6"   $��29��6-   $��Bottom=�69   $��0q�6T   $
 Hand��6�   .+�5�      �� -   5        $ _base1��5�      $��29��6!   ���	#FFB21D1D$��0��6@   $ 24��6T   $  18��6a   ���	#FF646E38$��77��6   �� 5�      -   5        $ glow1��5�      $��29��6    ���	#FFB21D1D$��0��6?   $ 24��6S   $  18��6`   $��77��6m   $! 0Q�6x   ��5�      
� 5�   	   $" 0.526Q�6   $# 0.455,1.077&�6-   $$ 
0.494,0.84&�6J   $% 0.586Q�6^   .��5�   
   � $ 	#FFC3D3E2��6   � 5�   
   $ 1Q�6   $ 	#00E8F508��6"   5�   
   5�      �� 5�      -   5        $ glass1��5�      $��29��6!   ���	#FFB21D1D$��0��6@   $ 24��6T   $  18��6a   $��77��6n   $! 0.795Q�6y   ��5�      �� 5�   	   $ 0.489,-0.231&�6   $& RelativeToBoundingBox=�65   $ 
0.489,1.07&�6Y   .��5�   
   � $ 	#00000000��6   $ 0Q�6)   � 5�   
   $ White��6   $ 1Q�6%   � 5�   
   $ 	#9B9B9B9B��6   $ 0.675Q�6)   � 5�   
   $ 	#1B1B1B1B��6   $ 0.543Q�6)   5�   
   5�      �� 5�      $
��Wrap=�6   $��39��6%   $��21��60   $' 0.846,0.482&�6<   $( 19��6`   $) 8��6q   $ Center=�6�   �� 6�   $ en-za�6�   $�Delete��6�   6�   5�      5�      5�      5�      5�      