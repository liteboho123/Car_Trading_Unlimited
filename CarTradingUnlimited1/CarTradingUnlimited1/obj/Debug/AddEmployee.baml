   M S B A M L   `   `   `  ����  CarTradingUnlimited1%    CarTradingUnlimited.AddEmployee   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6?   -   5          N�Name$  
Page_Eploy��5       N� WindowTitle$
 Page��5      $��LeftToRight=�5       N� WindowWidth$	 640Q�5	       N� WindowHeight$	 480Q�6   $��Center=�6P   $��Center=�6m   .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5      ]� ��.  .+�5      ]� -   5         ]�Name$ 	DOCK_ROLE��5      ��.  $	��640��68   $	��Top=�6D   .+�5      �� -   5         ��Name$ GRP_Cust��5      $&�� Select the role of the employee:��6!   $��237.697��6K   ���	#FF5FBC87$
��Bold"�6r   $��Italic$�6�   $��50��6�   $	��Top=�6�   $
��Left=�6�   ��6�   Z� .��5      ��  �� Orientation$ 
Horizontal=�6   $��0,0,36,0q�6+   .+�5      �� -   5         ��Name$ 	cmbx_Role��5      $��184.54��6$   $��Center=�63   6N   5      5      5      ]� 5      -   5        $ DOCK_ADDEMPLOYEE��5      ��.  $	��Top=�6?   $��Center=�6T   $��Center=�6q   .+�5      �� $
��Wrap=�6   $��Add Employee��6$   $	��Top=�68   	 �� TextAlignment$	 Center=�6M   $��26.667(�6d   $
��Bold"�6v   $��Italic$�6�   $��	Underline{�6�   ���	#FF13FF00$��Center=�6�   �� 5      $��	0,0,0,176q�6   $	��337��6    $	��Top=�6,   $	��280��6A   $
��Left=�6N   .+�5      �� 
���   ����	#FF13FF00
 �� RadiusY$

 20.5��61    �� RadiusX$
 20.5��6@   $	��280��6O   $	��337��6\   $��5��6h   �� 5      $	��272��6   $	��Top=�6    �� Left$ 15��67   $	��302��6H   
 �� Top$ 8��6T   .+�5      �� $��33��6   $ 
Horizontal=�6   .+�5   	   �� $
��Wrap=�6   $��	Firstname��6'   $��Center=�68   $��117.46��6S   
�������6b   �� 5   	   -   5         ��Name$ txt_FirstName��5       �� TextWrapping$
 Wrap=�6(   $��Center=�6<   $��184.54��6W   5   	   �� 5      $��33��6   $ 
Horizontal=�6   .+�5   	   �� $
��Wrap=�6   $��Surname��6'   $��Center=�66   $��117.46��6Q   
�������6`   �� 5   	   -   5        $ txt_Surname��5      $
 Wrap=�6&   $��Center=�6:   $��184.54��6U   5    	   �� 5!      $��33��6   $ 
Horizontal=�6   .+�5"   	   �� $
��Wrap=�6   $��	ID number��6'   $��Center=�68   $��117.46��6S   
�������6b   �� 5#   	   -	   5        $ txt_IDnumber��5#      $
 Wrap=�6'   $��Center=�6;   $��184.54��6V   5$   	   �� 5%      $��33��6   $ 
Horizontal=�6   .+�5&   	   �� $
��Wrap=�6   $��Username��6'   $��Center=�67   $��117.46��6R   
�������6a   �� 5'   	   -
   5        $ txt_UserName��5'      $
 Wrap=�6'   $��Center=�6;   $��184.54��6V   5(   	   �� 5)      $��33��6   $ 
Horizontal=�6   .+�5*   	   �� $
��Wrap=�6   $��Password��6'   $��Center=�67   $��117.46��6R   
�������6a   �� 5+   	   -   5        $ txt_Password��5+      $
 Wrap=�6'   $��Center=�6;   $��184.54��6V   5,   	   �� 5-      $��33��6   $ 
Horizontal=�6   .+�5.   	   �� -   5         ��Name$ 
can_Submit��5.      $��77��6%   $��29��60   $��Center=�6<   $��0,0,0,-5q�6W    � Cursor$
 Hand��6i   .+�5/   
   �� -   5         ��Name$ _base��5/      $��29��6#   ���	#FFB21D1D$��0��6B   $ 24��6V   $
 18��6c   ���	#FF13FF00$��77��6�   �� 50   
   -   5        $
 glow��50      $��29��6"   ���	#FFB21D1D$��0��6A   $ 24��6U   $
 18��6b   $��77��6o    J� Opacity$ 0Q�6z   ��51      
� 52       
� RadiusY$ 0.526Q�6     
� GradientOrigin$ 0.455,1.077&�60    
� Center$ 
0.494,0.84&�6M    
� RadiusX$ 0.586Q�6a   .��53      �  � Color$ 	#FFC3D3E2��6   � 54       � Offset$ 1Q�6   $ 	#000E8769��6%   55      57      �� 58   
   -   5        $ glass��58      $��29��6#   ���	#FFB21D1D$��0��6B   $ 24��6V   $
 18��6c   $��77��6p   $ 0.795Q�6{   ��59      �� 5:       �� EndPoint$ 0.489,-0.231&�6     � MappingMode$ RelativeToBoundingBox=�68    �� 
StartPoint$ 
0.489,1.07&�6\   .��5;      � $ 	#00000000��6   $ 0Q�6,   � 5<      $ White��6   $ 1Q�6(   � 5=      $ 	#9B9B9B9B��6   $ 0.675Q�6,   � 5>      $ 	#1B1B1B1B��6   $ 0.543Q�6,   5?      5A      �� 5B   
   $
��Wrap=�6   $��39��6(   $��21��63    J� RenderTransformOrigin$ 0.846,0.482&�6?   $ 19��6c   $ 8��6t   $	 Center=�6�   �� 6�    � Language$ en-za�6�   $�Submit��6�   6�   5C   
   �� 5D   	   -   5        $ 	can_Clear��5D      $��77��6$   $��29��6/   $��Center=�6;   $��7,0,0,-5q�6V   $
 Hand��6h   .+�5E   
   �� -   5        $ _base1��5E      $��29��6$   ���	#FFB21D1D$��0��6C   $ 24��6W   $
 18��6d   ���	#FF13FF00$��77��6�   �� 5F   
   -   5        $ glow1��5F      $��29��6#   ���	#FFB21D1D$��0��6B   $ 24��6V   $
 18��6c   $��77��6p   $ 0Q�6{   ��5G      
� 5H      $ 0.526Q�6    $ 0.455,1.077&�60   $ 
0.494,0.84&�6M   $ 0.586Q�6a   .��5I      � $ 	#FFC3D3E2��6   � 5J      $ 1Q�6   $ 	#000E8769��6%   5K      5M      �� 5N   
   -   5        $ glass1��5N      $��29��6$   ���	#FFB21D1D$��0��6C   $ 24��6W   $
 18��6d   $��77��6q   $ 0.795Q�6|   ��5O      �� 5P      $ 0.489,-0.231&�6    $ RelativeToBoundingBox=�68   $ 
0.489,1.07&�6\   .��5Q      � $ 	#00000000��6   $ 0Q�6,   � 5R      $ White��6   $ 1Q�6(   � 5S      $ 	#9B9B9B9B��6   $ 0.675Q�6,   � 5T      $ 	#1B1B1B1B��6   $ 0.543Q�6,   5U      5W      �� 5X   
   $
��Wrap=�6   $��39��6(   $��21��63   $ 0.5,0.5&�6?   $ 19��6_   $ 8��6p   $	 Center=�6   �� 6�   $ en-za�6�   $�Clear��6�   �� 6�   �� 6�   $ en-za�6�   6�   5Y   
   5Z   	   5[      5\      5]      5^      5_      5`      