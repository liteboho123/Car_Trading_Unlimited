   M S B A M L   `   `   `  ����  CarTradingUnlimited1#    CarTradingUnlimited.BookDrive   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6?   -   5          N�Name$  Page_Booking��5       N� WindowTitle$
 Page��5      $��LeftToRight=�5       N� WindowWidth$	 640Q�5	       N� WindowHeight$	 480Q�6   $��Center=�6m   $��Center=�6�   .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5      ]� $��Center=�6   ��.  $	��Top=�6A   $	��442��6Y   .+�5      ]� $��50��6   ��.  $	��640��61   $	��Top=�6=   .+�5      �� $ ��State the type of vehicle:��6   $	��254��63   ���	#FF858585$
��Bold"�6V   $��Italic$�6h   ��6{   Z� .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      	� -   5         	�Name$ Rad_New��5      $
��New?��6%   $��78.348��64   $��Center=�6C   $
��Bold"�6^   $��Italic$�6p   
���   �6�   	� 5      -   5        $ Rad_Used��5      $��Used?��6&   $��78.348��66   $��Center=�6E   
���   �6s   	� 5      -   5        $ Rad_Demo��5      $��Demo?��6&   $��78.348��66   $��Center=�6E   
���   �6s   5      5      5      ]� 5      -   5         ]�Name$ Dock_Decision��5      $��50��6&   ��.  $	��640��6H   $	��Top=�6T   $y�	Collapsed=�6i   .+�5      �� -   5         ��Name$ GRP_Vehicle��5      $�� ��6$   $��237.697��6.   ���	#FF858585$
��Bold"�6U   $��Italic$�6g   ��6z   Z� .��5      �� $ 
Horizontal=�6   $��0,0,36,0q�6+   .+�5      �� -   5        	 ��Name$	 cmbx_Vehicle��5      $	��186��6'   63   5      5      5      ]� 5      -	   5        $ Dock_AddDrive��5      ��.  $	��342��6<   $	��640��6I   $��Center=�6x   $y�	Collapsed=�6�   .+�5      �� $
��Wrap=�6   $	��Top=�6$   
 �� TextAlignment$
 Center=�69   $��26.667(�6P   $
��Bold"�6b   $��Italic$�6t   $��	Underline{�6�   ���	#FF858585$��Center=�6�   $��0q�6�   �� 6�    � Language$ en-za�6�   $�Book Test Drive��6�   6  �� 5      $��	0,0,0,176q�6   $	��288��6    $	��Top=�6,   $	��160��6A   $��Center=�6N   .+�5       �� 
���   ����	#FF858585 �� RadiusY$
 20.5��61    �� RadiusX$
 20.5��6@   $	��160��6O   $	��288��6\   $��5��6h   �� 5!      $	��152��6   $	��Top=�6    �� Left$ 15��67   $	��252��6H   
 �� Top$ 8��6T   .+�5"      �� $��33��6   $ 
Horizontal=�6   $	��252��68   .+�5#   	   �� $
��Wrap=�6   $��Customer's name��6'   $��Center=�6>   $��97.46��6Y   
�������6g   �� 5$   	   -
   5        $	 	cmbx_Cust��5$      $��153.54��6%   $��Center=�64   5%   	   �� 5&      $��33��6   $ 
Horizontal=�6   $	��252��68   .+�5'   	   �� $
��Wrap=�6   $��Date booked��6'   $��Center=�6:   $��97.46��6U   
�������6c   (  "System.Windows.Controls.DatePicker  5(   	   -   5          Name$ DTP_Date��5(      $��153.54��6&   5)   	   �� 5*      $��33��6   $ 
Horizontal=�6   $	��252��68   .+�5+   	   �� -   5         ��Name$ 
can_Submit��5+      $��77��6$   $��29��6/   $��Center=�6;   $��0,0,0,-5q�6V    � Cursor$
 Hand��6h   .+�5,   
   �� -   5         ��Name$ _base��5,      $��29��6#   ���	#FFB21D1D$��0��6B   $ 24��6V   $ 18��6c   ���	#FF858585$��77��6�   �� 5-   
   -   5        $
 glow��5-      $��29��6"   ���	#FFB21D1D$��0��6A   $ 24��6U   $ 18��6b   $��77��6o    J� Opacity$ 0Q�6z   ��5.      
� 5/       
� RadiusY$ 0.526Q�6     
� GradientOrigin$ 0.455,1.077&�60    
� Center$ 
0.494,0.84&�6M    
� RadiusX$ 0.586Q�6a   .��50      �  � Color$ 	#FFC3D3E2��6   � 51       � Offset$ 1Q�6   $ 	#00000000��6%   52      54      �� 55   
   -   5        $ glass��55      $��29��6#   ���	#FFB21D1D$��0��6B   $ 24��6V   $ 18��6c   $��77��6p   $ 0.795Q�6{   ��56      �� 57       �� EndPoint$ 0.489,-0.231&�6     � MappingMode$ RelativeToBoundingBox=�68    �� 
StartPoint$ 
0.489,1.07&�6\   .��58      � $ 	#00000000��6   $ 0Q�6,   � 59      $ White��6   $ 1Q�6(   � 5:      $ 	#9B9B9B9B��6   $ 0.675Q�6,   � 5;      $ 	#1B1B1B1B��6   $ 0.543Q�6,   5<      5>      �� 5?   
   $
��Wrap=�6   $��39��6(   $��21��63    J� RenderTransformOrigin$ 0.846,0.482&�6?   $ 19��6c   $ 8��6t   $
 Center=�6�   �� 6�   $ en-za�6�   $�Submit��6�   6�   5@   
   5A      5B      5C      5D      5E      5F      5G      