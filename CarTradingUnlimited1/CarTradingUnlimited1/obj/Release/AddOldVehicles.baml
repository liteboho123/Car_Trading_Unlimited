   M S B A M L   `   `   `  ����   CarTradingUnlimited1(    "CarTradingUnlimited.AddOldVehicles   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$
  Page�� N� WindowTitle$
 Page��$��LeftToRight=� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�$��Center=�$��Center=�.��� -    �Name$ 
LayoutRoot��$��Center=�$��Center=�.+�]� ��.  $��Center=�$��Center=�.+��� $
��Wrap=�$��Add Used/Demo Vehicles��$	��Top=� �� TextAlignment$ Center=�$��26.667(�$
��Bold"�$��Italic$�$��	Underline{����	#FFC300CE�� $��	0,0,0,176q�$	��337��$	��Top=�$	��367��$��Center=�.+��� 
���   ����	#FFC300CE �� RadiusY$
 20.5�� �� RadiusX$
 20.5��$	��367��$	��337��$��5���� $	��359��$	��Top=� �� Left$ 15��$	��302��
	 �� Top$	 8��.+��� $��33��
 �� Orientation$
 
Horizontal=�.+��� $
��Wrap=�$��
Brand name��$��Center=�$��117.46��
��������� -    ��Name$ 	txt_Brand�� �� TextWrapping$
 Wrap=�$��Center=�$��184.54���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��
Model/Type��$��Center=�$��117.46��
��������� -   $ 	txt_Model��$
 Wrap=�$��Center=�$��184.54���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��Serial number��$��Center=�$��117.46��
��������� -   $ 
txt_Serial��$
 Wrap=�$��Center=�$��184.54���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��Color��$��Center=�$��117.46��
��������� -   $ 	txt_Color��$
 Wrap=�$��Center=�$��184.54���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��Vehicle type��$��Center=�$��117.46��
��������� $��GroupBox��$��0q�.���� $
 
Horizontal=�$��184.54��$��	0,-16,0,0q�$��33��.+�	� -    	�Name$ Rad_Used��$
��Used�����	#FFC300CE$��Center=�	� -   $ Rad_Demo��$
��Demo�����	#FFC300CE$��Center=�$��80,0,0,0q��� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��Price��$��Center=�$��117.46��
��������� -	   $ 	txt_Price��$
 Wrap=�$��Center=�$��184.54���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��Service history��$��Center=�$��117.46��
��������� -
   $ txt_ServiceHis��$
 Wrap=�$��Center=�$	��185��$��33���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��Speed��$��Center=�$��117.46��
��������� -   $ 	txt_Speed��$
 Wrap=�$��Center=�$��184.54���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��	Condition��$��Center=�$��117.46��
��������� $��GroupBox��$��0q���Z� ��Z� .���� $
 
Horizontal=�$��184.54��$��	0,-18,0,0q�$��33��.+�	� -   $ Rad_Good��$
��Good�����	#FFC300CE$��Center=�	� -   $ Rad_Average��$��Average�����	#FFC300CE$��Center=�$��12,0,0,0q�	� -   $ Rad_Bad��$	��Bad�����	#FFC300CE$��Center=�$��16,0,0,0q��� $��33��$
 
Horizontal=�.+��� -    ��Name$ 
can_Submit��$��77��$��29��$��Center=�$��0,0,0,-5q� � Cursor$
 Hand��.+��� -    ��Name$ _base��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FFC300CE$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77�� J� Opacity$ 0Q���
�  
� RadiusY$ 0.526Q� 
� GradientOrigin$ 0.455,1.077&� 
� Center$ 
0.494,0.84&� 
� RadiusX$ 0.586Q�.���  � Color$ 	#FFC3D3E2�� � Offset$ 1Q�� $ 	#FFFBF445���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q�����  �� EndPoint$ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21�� J� RenderTransformOrigin$ 0.846,0.482&�$ 19��$	 8��$ Center=���  � Language$ en-za�$�Submit���� -   $ 	can_Clear��$��77��$��29��$��Center=�$��7,0,0,-5q�$
 Hand��.+��� -   $ _base1��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FFC300CE$��77���� -   $ glow1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0Q���
� $ 0.526Q�$ 0.455,1.077&�$ 
0.494,0.84&�$ 0.586Q�.��� $ 	#FFC3D3E2��$ 1Q�� $ 	#FFFBF445���� -   $ glass1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q����� $ 0.489,-0.231&�$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$ 0.5,0.5&�$ 19��$	 8��$ Center=��� $ en-za�$�Clear���� �� $ en-za�