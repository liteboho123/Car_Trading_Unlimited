   M S B A M L   `   `   `  ����   CarTradingUnlimited1#    CarTradingUnlimited.ViewParts   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$
  Page�� N� WindowTitle$
 Page��$��LeftToRight=�$	��640��$	��462�� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�.��� -    �Name$ 
LayoutRoot��.+�]� ��.  $��	310,0,0,0q�.+� � -     �Name$ 
Parts_page��$	��330��]� ��.  $��	0,0,334,0q�.+��� $
��Wrap=�$	��Top=�$��26.667(����	#FFA6AF10 �� TextAlignment$ Center=�$
��Bold"�$��Italic$�$��	Underline{���  � Language$ en-za�$�PARTS DETAILS���� -    ��Name$ 	Img_Parts��$��56,0,62,-17.902q�$	��Top=�$��91��.+��� -   	 ��Name$	 b1��$	��Top=�$
��Auto��$��79��$��0q�
�������$��1.5,0q�
 �� CornerRadius$
 18�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q�   Opacity$ .5Q�   ShadowDepth$ 3Q�._��� -   $	 Re��
���   �$��6q�$
 15��._�� .+��� -   $
	 mask��
��� � �
���   �$��1.5,0q�$
 13����  J� OpacityMask !�  !� Visual ��  �� ElementName$
 mask��.+��� -    ��Name$ im��$��67��&   System.Windows.Controls.DataGrid  -	     Name$ 	DGV_Parts��$��8,5,8,0q�$	��Top=�$	��Top=�   RowBackground �	#FFA6AF10
���   �$	��198����Z� �� $��Search parts:��$��8,0,0,0q�$��16(�$��SimSun)����	#FFA6AF10$	��Top=�$
��Left=�$	��290��.���� $��8,0,17.5,7.75q�.+���  �� Orientation$ 
Horizontal=�.+��� $
��Wrap=�$��Details��$��70��$��Center=�$��12(�$��13.6866666666667���� -
    ��Name$ 	txt_Brand�� �� TextWrapping$
 Wrap=�$��Please enter details....��$	��177��$��Center=� �� SelectionOpacity$
 64.4Q�
���   �$��12(�$��15.687����Z� .������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� -   G1�� � Color$ 	#FFFFD6D6��� -   G2��$ 	#FFA6AF10�� � Offset$ 1Q�.�� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� .���� -    ��Name$	 sb1��  g� RepeatBehavior$  Forever��! g� AutoReverse! . .���� " �� 
TargetName$" G1��# �� TargetProperty$# Color�	$ �� To$$ 	#FFA6AF10X�% g� Duration$% 0:0:1D��� $" G2��$# Color�$$ 	#FFFFD6D6X�$% 0:0:1D�.���� $ 
Horizontal=�.+��� $
��Wrap=�$��Manufacturer��$��70��$��Center=�$��12(�$��13.6866666666667���� -   $ txt_Manufacturer��$
 Wrap=�$��Enter manufacturer....��$	��177��$��Center=�$��12(�$��15.6866666666667����Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -   G3��$ 	#FFFFD6D6��� -   G4��$ 	#FFA6AF10��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $  Forever��! . .���� $" G3��$# Color�$$ 	#FFA6AF10X�$% 0:0:1D��� $" G4��$# Color�$$ 	#FFFFD6D6X�$% 0:0:1D�.���� $ 
Horizontal=�.+��� $
��Wrap=�$��Price��$��70��$��Center=�$��13.6866666666667��$��12(��� -   $ 	txt_Price��$
 Wrap=�$��Please enter price....��$	��177��$��15.686��$��Center=�$��12(���Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -   G5��$ 	#FFFFD6D6��� -   G6��$ 	#FFA6AF10��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $  Forever��! . .���� $" G5��$# Color�$$ 	#FFA6AF10X�$% 0:0:1D��� $" G6��$# Color�$$ 	#FFFFD6D6X�$% 0:0:1D�.���� $��Bottom=�$ 
Horizontal=�$	��8,0q�.+��� -   & ��Name$& can_Show��$��58��$��29��$��Bottom=�$��0q�' � Cursor$
' Hand��.+��� -   ( ��Name$( _base��$��29�����	#FFB21D1D$��0��) �� RadiusX$) 24��* �� RadiusY$* 18�����	#FFA6AF10$��58���� -   $
( glow��$��29�����	#FFB21D1D$��0��$) 24��$* 18��$��58��+ J� Opacity$+ 0Q���
� , 
� RadiusY$, 0.526Q�- 
� GradientOrigin$- 0.455,1.077&�. 
� Center$. 
0.494,0.84&�/ 
� RadiusX$/ 0.586Q�.��� $ 	#FFC3D3E2��$ 1Q�� $ 	#FFF7BFC7���� -   $( glass��$��29�����	#FFB21D1D$��0��$) 24��$* 18��$��58��$+ 0.795Q����� $ 0.489,-0.231&�0 � MappingMode$0 RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��1 J� RenderTransformOrigin$1 0.846,0.482&�2 �� Left$2 8��
3 �� Top$3 8��$ Center=��� $ en-za�$
�Show���� �� $ en-za��� -   $& 
can_Delete��$��58��$��29��$��Bottom=�$��0q�$
' Hand��.+��� -   $( _base1��$��29�����	#FFB21D1D$��0��$) 24��$* 18�����	#FFA6AF10$��58���� -   $( glow1��$��29�����	#FFB21D1D$��0��$) 24��$* 18��$��58��$+ 0Q���
� $, 0.526Q�$- 0.455,1.077&�$. 
0.494,0.84&�$/ 0.586Q�.��� $ 	#FFC3D3E2��$ 1Q�� $ 	#FFF7BFC7���� -   $( glass1��$��29�����	#FFB21D1D$��0��$) 24��$* 18��$��58��$+ 0.795Q����� $ 0.489,-0.231&�$0 RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$1 0.846,0.482&�$2 8��$3 8��$ Center=��� $ en-za�$�Delete���� -   $& 	can_Quote��$��58��$��29��$��Bottom=�$��0q�$
' Hand��.+��� -   $( _base3��$��29�����	#FFB21D1D$��0��$) 24��$* 18�����	#FFA6AF10$��58���� -   $( glow3��$��29�����	#FFB21D1D$��0��$) 24��$* 18��$��58��$+ 0Q���
� $, 0.526Q�$- 0.455,1.077&�$. 
0.494,0.84&�$/ 0.586Q�.��� $ 	#FFC3D3E2��$ 1Q�� $ 	#FFF7BFC7���� -   $( glass3��$��29�����	#FFB21D1D$��0��$) 24��$* 18��$��58��$+ 0.795Q����� $ 0.489,-0.231&�$0 RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��58��$��21��$1 0.846,0.482&�$3 8��$ Center=�$��Quote��