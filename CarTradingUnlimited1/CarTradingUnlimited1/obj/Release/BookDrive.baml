   M S B A M L   `   `   `  ����   CarTradingUnlimited1#    CarTradingUnlimited.BookDrive   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$  Page_Booking�� N� WindowTitle$
 Page��$��LeftToRight=� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�$��Center=�$��Center=�.��� -    �Name$ 
LayoutRoot��.+�]� $��Center=���.  $	��Top=�$	��442��.+�]� $��50����.  $	��640��$	��Top=�.+��� $ ��State the type of vehicle:��$	��254�����	#FF858585$
��Bold"�$��Italic$���Z� .����  �� Orientation$ 
Horizontal=�.+�	� -    	�Name$ Rad_New��$
��New?��$��78.348��$��Center=�$
��Bold"�$��Italic$�
���   �	� -   $ Rad_Used��$��Used?��$��78.348��$��Center=�
���   �	� -   $ Rad_Demo��$��Demo?��$��78.348��$��Center=�
���   �]� -    ]�Name$ Dock_Decision��$��50����.  $	��640��$	��Top=�$y�	Collapsed=�.+��� -    ��Name$ GRP_Vehicle��$�� ��$��237.697�����	#FF858585$
��Bold"�$��Italic$���Z� .���� $ 
Horizontal=�$��0,0,36,0q�.+��� -   	 ��Name$	 cmbx_Vehicle��$	��186��]� -	   $ Dock_AddDrive����.  $	��342��$	��640��$��Center=�$y�	Collapsed=�.+��� $
��Wrap=�$	��Top=�
 �� TextAlignment$
 Center=�$��26.667(�$
��Bold"�$��Italic$�$��	Underline{����	#FF858585$��Center=�$��0q���  � Language$ en-za�$�Book Test Drive���� $��	0,0,0,176q�$	��288��$	��Top=�$	��160��$��Center=�.+��� 
���   ����	#FF858585 �� RadiusY$
 20.5�� �� RadiusX$
 20.5��$	��160��$	��288��$��5���� $	��152��$	��Top=� �� Left$ 15��$	��252��
 �� Top$ 8��.+��� $��33��$ 
Horizontal=�$	��252��.+��� $
��Wrap=�$��Customer's name��$��Center=�$��97.46��
��������� -
   $	 	cmbx_Cust��$��153.54��$��Center=��� $��33��$ 
Horizontal=�$	��252��.+��� $
��Wrap=�$��Date booked��$��Center=�$��97.46��
�������(  "System.Windows.Controls.DatePicker  -     Name$ DTP_Date��$��153.54���� $��33��$ 
Horizontal=�$	��252��.+��� -    ��Name$ 
can_Submit��$��77��$��29��$��Center=�$��0,0,0,-5q� � Cursor$
 Hand��.+��� -    ��Name$ _base��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF858585$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77�� J� Opacity$ 0Q���
�  
� RadiusY$ 0.526Q� 
� GradientOrigin$ 0.455,1.077&� 
� Center$ 
0.494,0.84&� 
� RadiusX$ 0.586Q�.���  � Color$ 	#FFC3D3E2���  � Offset$ 1Q�$ 	#00000000���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q�����  �� EndPoint$ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21�� J� RenderTransformOrigin$ 0.846,0.482&�$ 19��$ 8��$
 Center=��� $ en-za�$�Submit��