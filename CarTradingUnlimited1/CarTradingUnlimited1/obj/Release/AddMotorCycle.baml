   M S B A M L   `   `   `  ����   CarTradingUnlimited1'    !CarTradingUnlimited.AddMotorCycle   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$
  Page�� N� WindowTitle$
 Page��$��LeftToRight=� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�$��Center=�$��Center=�.��� -    �Name$ 
LayoutRoot��.+�]� ��.  $��Center=�.+��� $
��Wrap=�$��Add Motorcycle��$	��Top=� �� TextAlignment$ Center=�$��26.667(�$
��Bold"�$��Italic$�$��	Underline{����	#FF00CEB6$��Center=��� $��	8,0,8,176q�$	��337��$	��Top=�$	��255��$��Center=�.+��� 
���   ����	#FF00CEB6 �� RadiusY$
 20.5�� �� RadiusX$
 20.5��$	��255��$	��337��$��5���� $	��247��$	��Top=� �� Left$ 15��$	��302��
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
��Wrap=�$��Color��$��Center=�$��117.46��
��������� -   $ 	txt_Color��$
 Wrap=�$��Center=�$��184.54���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��Price��$��Center=�$��117.46��
��������� -   $ 	txt_Price��$
 Wrap=�$��Center=�$��184.54���� $��33��$
 
Horizontal=�.+��� $
��Wrap=�$��Year established��$��Center=�$��117.46��
�������(  "System.Windows.Controls.DatePicker  -     Name$ DTP_Date��$��184.54���� $��33��$
 
Horizontal=�.+��� -    ��Name$ 
can_Browse��$	��116��$��28��$��0q� � Cursor$
 Hand��$��Center=�.+��� -	    ��Name$ _base2��$��23�����	#FFB21D1D$��0��$ 24��$ 18��$	��116������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFC9F1E5�� � Offset$ 0Q�� $ 	#FF3BFDC3��$ 1Q��� -
   $ glow2��$��23�����	#FFB21D1D$��0��$ 24��$ 18��$	��116�� J� Opacity$ 0Q���
�  
� RadiusY$ 0.526Q� 
� GradientOrigin$ 0.455,1.077&� 
� Center$ 
0.494,0.84&� 
� RadiusX$ 0.586Q�.��� $ 	#38000000��$ 1Q�� $ 	#FF656589���� -   $ glass2��$��23�����	#FFB21D1D$��0��$ 24��$ 18��$	��116��$ 0.795Q����� $ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� -    ��Name$ 
Txt_Browse��$
��Wrap=�$	��116��$��21�� J� RenderTransformOrigin$ 0.846,0.482&�$	 2��$ Center=���  � Language$ en-za�$�Browse picture���� $��39��$��	143,0,0,0q�.+��� -    ��Name$ b1��$	��Top=�$
��Auto��$��37��$��0q�
�������$��1.5,0q� �� CornerRadius$ 18��  J� Effect  3  -System.Windows.Media.Effects.DropShadowEffect  !   
BlurRadius$! 5Q�"   Opacity$" .5Q�#   ShadowDepth$# 3Q�._��� -   $ Re��
���   �$��6q�$ 15��._�� .+��� -   $
 mask��
����� �
���   �$��1.5,0q�$ 13���� $ J� OpacityMask$ !� % !� Visual% �� & �� ElementName$
& mask��.+��� -   ' ��Name$' im��$��25���� $��33��$
 
Horizontal=�.+��� -   $ 
can_Submit��$��77��$��29��$��Center=�$��0,0,0,-5q�$
 Hand��.+��� -   $ _base��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF00CEB6$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0Q���
� $ 0.526Q�$ 0.455,1.077&�$ 
0.494,0.84&�$ 0.586Q�.��� $ 	#FFC3D3E2��$ 1Q�� $ 	#FF181A78���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q����� $ 0.489,-0.231&�$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$ 0.846,0.482&�$ 19��$	 8��$ Center=��� $ en-za�$�Submit���� -   $ 	can_Clear��$��77��$��29��$��Center=�$��7,0,0,-5q�$
 Hand��.+��� -   $ _base1��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF00CEB6$��77���� -   $ glow1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0Q���
� $ 0.526Q�$ 0.455,1.077&�$ 
0.494,0.84&�$ 0.586Q�.��� $ 	#FFC3D3E2��$ 1Q�� $ 	#FF181A78���� -   $ glass1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q����� $ 0.489,-0.231&�$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$ 0.5,0.5&�$ 19��$	 8��$ Center=��� $ en-za�$�Clear���� �� $ en-za�