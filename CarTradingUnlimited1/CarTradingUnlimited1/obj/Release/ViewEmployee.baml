   M S B A M L   `   `   `  ����   CarTradingUnlimited1&     CarTradingUnlimited.ViewEmployee   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$
  Page�� N� WindowTitle$
 Page��$��LeftToRight=�$	��640��$	��462�� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�.��� -    �Name$ 
LayoutRoot��.+�]� ��.  $��	310,0,0,0q�.+� � -     �Name$ Employee_page��$	��330��]� ��.  $��	0,0,334,0q�.+��� $
��Wrap=�$	��Top=�$��26.667(����	#FF13FF00 �� TextAlignment$ Center=�$
��Bold"�$��Italic$�$��	Underline{���  � Language$ en-za�$�EMPLOYEE DETAILS��&   System.Windows.Controls.DataGrid  -     Name$ DGV_Employee��$��8,5,8,0q�$	��Top=�$	��Top=�	   RowBackground	 �	#FF13FF00
���   �$	��246����Z� �� $��Search employee:��$��8,0,0,0q�$��16(�$��SimSun)����	#FF13FF00$	��Top=�$
��Left=�$	��290��.���� $��8,0,17.5,7.75q�.+��� 
 �� Orientation$
 
Horizontal=�.+��� $
��Wrap=�$��
Firstname:��$��70��$��Center=�$��12(�$��13.6866666666667���� -    ��Name$ txt_Name�� �� TextWrapping$
 Wrap=�$ ��Please enter firstname....��$	��177��$��Center=� �� SelectionOpacity$
 64.4Q�
���   �$��12(�$��15.687����Z� .������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� -   G1�� � Color$ 	#FFFFD6D6��� -   G2��$ 	#FF13FF00�� � Offset$ 1Q�.�� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� .���� -    ��Name$	 sb1�� g� RepeatBehavior$ Forever�� g� AutoReverse . .����  �� 
TargetName$ G1�� �� TargetProperty$ Color�	 �� To$ 	#FF13FF00X� g� Duration$ 0:0:1D��� $ G2��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $
 
Horizontal=�.+��� $
��Wrap=�$��Surname:��$��70��$��Center=�$��13.6866666666667��$��12(��� -	   $ txt_Surname��$
 Wrap=�$��Please enter surname....��$	��177��$��15.686��$��Center=�$��12(���Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -
   G5��$ 	#FFFFD6D6��� -   G6��$ 	#FF13FF00��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $ Forever�� . .���� $ G5��$ Color�$ 	#FF13FF00X�$ 0:0:1D��� $ G6��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $
 
Horizontal=�.+��� $
��Wrap=�$��
ID number:��$��70��$��Center=�$��12(�$��13.6866666666667���� -   $ txt_ID��$
 Wrap=�$��Please enter ID....��$	��177��$��Center=�$��12(�$��15.6866666666667����Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -   G3��$ 	#FFFFD6D6��� -   G4��$ 	#FF13FF00��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $ Forever�� . .���� $ G3��$ Color�$ 	#FF13FF00X�$ 0:0:1D��� $ G4��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $
 
Horizontal=�.+��� $
��Wrap=�$��	Username:��$��70��$��Center=�$��12(��� -   $ txt_Username��$
 Wrap=�$��Please enter username....��$	��177��$��Center=�$��12(�$��15.6866666666667����Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -   G7��$ 	#FFFFD6D6��� -   G8��$ 	#FF13FF00��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $ Forever�� . .���� $ G7��$ Color�$ 	#FF13FF00X�$ 0:0:1D��� $ G8��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $
 
Horizontal=�.+��� $
��Wrap=�$��	Password:��$��70��$��Center=�$��13.6866666666667��$��12(��� -   $ txt_Password��$
 Wrap=�$��Please enter password....��$	��177��$��Center=�$��12(�$��15.686����Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -   G9��$ 	#FFFFD6D6��� -   G10��$ 	#FF13FF00��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $ Forever�� . .���� $ G9��$ Color�$ 	#FF13FF00X�$ 0:0:1D��� $	 G10��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $��Bottom=�$
 
Horizontal=�$	��8,0q�.+��� -    ��Name$ can_Show��$��77��$��29��$��Bottom=�$��0q� � Cursor$
 Hand��.+��� -    ��Name$ _base��$��29�����	#FFB21D1D$��0�� �� RadiusX$ 24�� �� RadiusY$ 18�����	#FF13FF00$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��  J� Opacity$  0Q���
� ! 
� RadiusY$! 0.526Q�" 
� GradientOrigin$" 0.455,1.077&�# 
� Center$# 
0.494,0.84&�$ 
� RadiusX$$ 0.586Q�.��� $ 	#FFC3D3E2��� $ 1Q�$ 	#000E8769���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$  0.795Q����� $ 0.489,-0.231&�% � MappingMode$% RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��& J� RenderTransformOrigin$& 0.846,0.482&�' �� Left$' 19��
( �� Top$( 8��$ Center=��� $ en-za�$
�Show���� �� $ en-za��� -   $ 
can_Delete��$��77��$��29��$��Bottom=�$��0q�$
 Hand��.+��� -   $ _base1��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF13FF00$��77���� -   $ glow1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$  0Q���
� $! 0.526Q�$" 0.455,1.077&�$# 
0.494,0.84&�$$ 0.586Q�.��� $ 	#FFC3D3E2��� $ 1Q�$ 	#000E8769���� -   $ glass1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$  0.795Q����� $ 0.489,-0.231&�$% RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$& 0.846,0.482&�$' 19��$( 8��$ Center=��� $ en-za�$�Delete��