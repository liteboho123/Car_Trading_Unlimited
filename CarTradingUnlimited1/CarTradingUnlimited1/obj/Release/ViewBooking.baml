   M S B A M L   `   `   `  ���� O  KCarTradingUnlimited1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CarTradingUnlimited.ControlCarTradingUnlimited.Control  %    CarTradingUnlimited.ViewBooking   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     =Control)clr-namespace:CarTradingUnlimited.Control     -     N�Name$
  Page�� N� WindowTitle$
 Page��$��LeftToRight=� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�$	��640��$	��462��.��� -    �Name$ 
LayoutRoot��.+�]� ��.  $��	306,0,0,0q�.+� � -     �Name$ 	Book_page��$	��334��]� ��.  $��	0,0,334,0q�.+��� $
��Wrap=�$	��Top=�$��26.667(����	#FF858585 �� TextAlignment$ Center=�$
��Bold"�$��Italic$�$��	Underline{���  � Language$ en-za�$�TEST DRIVE DETAILS��&   System.Windows.Controls.DataGrid  -     Name$ DGV_TestDrive��$��8,5,8,0q�$	��Top=�$	��Top=�	   RowBackground	 �	#FF858585
���   �$	��246����Z� �� $��Search test drives:��$��8,0,0,0q�$��16(�$��SimSun)����	#FF252424$	��Top=�$
��Left=�$	��290��.���� $��8,0,17.5,7.75q�.+��� 
 �� Orientation$
 
Horizontal=�.+��� $
��Wrap=�$��	Customer:��$��70��$��Center=�$��12(�$��13.6866666666667���� -    ��Name$ txt_Cust�� �� TextWrapping$
 Wrap=�$��Please enter name....��$	��177��$��Center=� �� SelectionOpacity$
 64.4Q�
���   �$��12(�$��15.687����Z� .������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� -   G1�� � Color$ 	#FFFFD6D6��� -   G2��$ 	#FF858585�� � Offset$ 1Q�.�� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� .���� -    ��Name$	 sb1�� g� RepeatBehavior$ Forever�� g� AutoReverse . .����  �� 
TargetName$ G1�� �� TargetProperty$ Color�	 �� To$ 	#FF858585X� g� Duration$ 0:0:1D��� $ G2��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $
 
Horizontal=�.+��� $
��Wrap=�$��Brand:��$��70��$��Center=�$��12(�$��13.6866666666667���� -	   $ 	txt_Brand��$
 Wrap=�$!��Please enter brand name....��$	��177��$��Center=�$��12(�$��15.6866666666667����Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -
   G3��$ 	#FFFFD6D6��� -   G4��$ 	#FF858585��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $ Forever�� . .���� $ G3��$ Color�$ 	#FF858585X�$ 0:0:1D��� $ G4��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $
 
Horizontal=�.+��� $
��Wrap=�$��Model:��$��70��$��Center=�$��13.6866666666667��$��12(��� -   $ 	txt_Model��$
 Wrap=�$��Please enter model....��$	��177��$��15.686��$��Center=�$��12(���Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -   G5��$ 	#FFFFD6D6��� -   G6��$ 	#FF858585��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $ Forever�� . .���� $ G5��$ Color�$ 	#FF858585X�$ 0:0:1D��� $ G6��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $
 
Horizontal=�.+��� $
��Wrap=�$��
Serial no:��$��70��$��Center=�$��12(��� -   $ txt_SerialNo��$
 Wrap=�$ ��Please enter serial no....��$	��177��$��Center=�$��12(�$��15.6866666666667����Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -   G7��$ 	#FFFFD6D6��� -   G8��$ 	#FF858585��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $ Forever�� . .���� $ G7��$ Color�$ 	#FF858585X�$ 0:0:1D��� $ G8��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $
 
Horizontal=�.+��� $
��Wrap=�$��Price��$��70��$��Center=�$��13.6866666666667��$��12(��� -   $ 	txt_Price��$
 Wrap=�$��Please enter price....��$	��177��$��Center=�$��12(�$��15.686����Z� .������ $ 0.5,1&�$ 0.5,0&�.��� -   G9��$ 	#FFFFD6D6��� -   G10��$ 	#FF858585��$ 1Q�.�� :� $ FrameworkElement.Loaded��.[��� .���� $ Forever�� . .���� $ G9��$ Color�$ 	#FF858585X�$ 0:0:1D��� $	 G10��$ Color�$ 	#FFFFD6D6X�$ 0:0:1D�.���� $��Bottom=�$
 
Horizontal=�$	��8,0q�.+��� -    ��Name$ can_Show��$��77��$��29��$��Bottom=�$��0q� � Cursor$
 Hand��.+��� -    ��Name$ _base��$��29�����	#FFB21D1D$��0�� �� RadiusX$ 24�� �� RadiusY$ 18�����	#FF858585$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��  J� Opacity$  0Q���
� ! 
� RadiusY$! 0.526Q�" 
� GradientOrigin$" 0.455,1.077&�# 
� Center$# 
0.494,0.84&�$ 
� RadiusX$$ 0.586Q�.��� $ 	#FFC3D3E2��� $ 1Q�$ 	#00000000���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$  0.795Q����� $ 0.489,-0.231&�% � MappingMode$% RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��& J� RenderTransformOrigin$& 0.846,0.482&�' �� Left$' 19��
( �� Top$( 8��$ Center=��� $ en-za�$
�Show���� �� $ en-za��� -   $ 
can_Delete��$��77��$��29��$��Bottom=�$��0q�$
 Hand��.+��� -   $ _base1��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF858585$��77���� -   $ glow1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$  0Q���
� $! 0.526Q�$" 0.455,1.077&�$# 
0.494,0.84&�$$ 0.586Q�.��� $ 	#FFC3D3E2��� $ 1Q�$ 	#00000000���� -   $ glass1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$  0.795Q����� $ 0.489,-0.231&�$% RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$& 0.846,0.482&�$' 19��$( 8��$ Center=��� $ en-za�$�Delete��