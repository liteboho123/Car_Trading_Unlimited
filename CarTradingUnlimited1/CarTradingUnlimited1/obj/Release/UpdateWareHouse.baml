   M S B A M L   `   `   `  ����   CarTradingUnlimited1)    #CarTradingUnlimited.UpdateWareHouse   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  Window_WareHouse�� � Title$ UpdateWareHouse�� � AllowsTransparency .  � WindowStyle$
 None=� � Icon$ Images/car.ico����Z� .��� -    �Name$ 
LayoutRoot��.+��� $��9,0,8,0q�$	��411��$	��384��$��Center=�$��Center=�.+��� -    ��Name$ Rec_Ware�� �� RadiusY$ 63�� �� RadiusX$ 63��$	��411��$	��384��$��5��	 J� Opacity$	 0.535Q���
� .��� 
 � Color$
 Black�� � Offset$ 1Q�� $
 White��]� $
��Left=���.  $	��Top=�$	��411��.+�]� -    ]�Name$ Dock_Decision��$��86����.  $	��384��$	��Top=�.+��� $
��Wrap=�$	��Top=�$��21.333(����	#FFF1FF00 �� TextAlignment$ Center=�$
��Bold"�$��Italic$�$��	Underline{���  � Language$ en-za�$"�Update Vehicles In Warehouse���� -    ��Name$ GRP_Cust��$��Select a vehicle:��$��237.697�����	#FFF1FF00$
��Bold"�$��Italic$�$��26,0,0,0q���Z� .����  �� Orientation$ 
Horizontal=�$��0,0,36,0q�.+��� -    ��Name$ 	cmbx_Ware��$	��186��]� -   $ DOCK_AddWare����.  $	��384��$��0,0,0,30q�.+��� $��0,16,0,0q�$	��337��$	��Top=�$	��255��$��Center=�$��Center=�.+��� 
���   ����	#FFF1FF00$
 20.5��$
 20.5��$	��255��$	��337��$��5���� $	��247��$	��Top=� �� Left$ 15��$	��302��
 �� Top$ 8��.+��� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��
Brand name��$��Center=�$��117.46��
��������� -    ��Name$ 	txt_Brand�� �� TextWrapping$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��
Model/Type��$��Center=�$��117.46��
��������� -	   $ 	txt_Model��$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Serial number��$��Center=�$��117.46��
��������� -
   $ 
txt_serial��$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Color��$��Center=�$��117.46��
��������� -   $ 	txt_Color��$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Price��$��Center=�$��117.46��
��������� -   $ 	txt_Price��$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Year established��$��Center=�$��117.46��
�������(  "System.Windows.Controls.DatePicker  -     Name$ DTP_Year��$��184.54���� $��33��$ 
Horizontal=�.+��� -    ��Name$ 
can_Submit��$��77��$��29��$��Center=�$��0,0,0,-5q� � Cursor$
 Hand��.+��� -   $ _base��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FFF1FF00$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$	 0Q���
�  
� RadiusY$ 0.526Q� 
� GradientOrigin$ 0.455,1.077&� 
� Center$ 
0.494,0.84&� 
� RadiusX$ 0.586Q�.��� $
 	#FFC3D3E2��� $ 1Q�$
 	#00CAB904���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$	 0.795Q�����  �� EndPoint$ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 
0.489,1.07&�.��� $
 	#00000000��$ 0Q�� $
 White��$ 1Q�� $
 	#9B9B9B9B��$ 0.675Q�� $
 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��  J� RenderTransformOrigin$  0.846,0.482&�$ 19��$ 8��$ Center=��� $ en-za�$�Submit���� -   $ 	can_Clear��$��77��$��29��$��Center=�$��7,0,0,-5q�$
 Hand��.+��� -   $ _base1��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FFF1FF00$��77���� -   $ glow1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$	 0Q���
� $ 0.526Q�$ 0.455,1.077&�$ 
0.494,0.84&�$ 0.586Q�.��� $
 	#FFC3D3E2��� $ 1Q�$
 	#00CAB904���� -   $ glass1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$	 0.795Q����� $ 0.489,-0.231&�$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $
 	#00000000��$ 0Q�� $
 White��$ 1Q�� $
 	#9B9B9B9B��$ 0.675Q�� $
 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$  0.5,0.5&�$ 19��$ 8��$ Center=��� $ en-za�$�Clear���� �� $ en-za��� -   $ can_Back��$��77��$��29��$��Center=�$��7,0,0,-5q�$
 Hand��.+��� -   $ _base2��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FFF1FF00$��77���� -   $ glow2��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$	 0Q���
� $ 0.526Q�$ 0.455,1.077&�$ 
0.494,0.84&�$ 0.586Q�.��� $
 	#FFC3D3E2��� $ 1Q�$
 	#00CAB904���� -   $ glass2��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$	 0.795Q����� $ 0.489,-0.231&�$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $
 	#00000000��$ 0Q�� $
 White��$ 1Q�� $
 	#9B9B9B9B��$ 0.675Q�� $
 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��77��$��21��$  0.5,0.5&�$ 8��$ Center=��� $ en-za�$�Go back���� �� $ en-za�