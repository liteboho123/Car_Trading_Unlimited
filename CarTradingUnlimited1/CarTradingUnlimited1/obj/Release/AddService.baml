   M S B A M L   `   `   `  ����   CarTradingUnlimited1$    CarTradingUnlimited.AddService   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$  Page_Service�� N� WindowTitle$
 Page��$��LeftToRight=� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�$
��Auto��$
��Auto��.��� -    �Name$ 
LayoutRoot��.+�]� $��Center=���.  $	��Top=�$	��442��.+�]� $��50����.  $	��640��$	��Top=�.+��� $/��)Did the customer render for service plan?��$��267.697�����	#FF5FBC87$
��Bold"�$��Italic$���Z� .����  �� Orientation$ 
Horizontal=�.+�	� -    	�Name$ Rad_Yes��$
��Yes?��$��78.348��$��Center=�$
��Bold"�$��Italic$�
���   �	� -   $ Rad_No��$	��No?��$��78.348��$��Center=�
���   �]� -    ]�Name$ Dock_Decision��$��50����.  $	��640��$	��Top=�$y�	Collapsed=�.+��� -    ��Name$ GRP_Cust��$&�� Select the name of the customer:��$��237.697�����	#FF5FBC87$
��Bold"�$��Italic$���Z� .���� $ 
Horizontal=�$��0,0,36,0q�.+��� -   	 ��Name$	 	cmbx_Cust��$	��186���� -   
 ��Name$
 Stck_Notice��$ 
Horizontal=�$��41,0,111,22.96q�$	��Top=�$��50��.+��� $
��Wrap=�$2��,Cannot render service without a service plan�� �� TextAlignment$ Center=�$��Center=�$��Center=�$��27.996��$��244.303��$
��Bold"�$��Italic$����	#FFFF0303$��10.667(��� $��0��$	��Top=�$	��120��]� -	   $ Dock_AddService����.  $	��640��$y�	Collapsed=�.+��� $
��Wrap=�$��Render Service��$	��Top=�$ Center=�$��26.667(�$
��Bold"�$��Italic$�$��	Underline{����	#FF5FBC87$
��Left=�$��85,0,0,0q��� $��
31,0,0,176q�$	��288��$	��Top=�$	��255��$
��Left=�.+��� 
���   ����	#FF5FBC87 �� RadiusY$
 20.5�� �� RadiusX$
 20.5��$	��255��$	��288��$��5���� $	��247��$	��Top=� �� Left$ 15��$	��252��
 �� Top$ 8��.+��� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Customer's car��$��Center=�$��97.46��
��������� -
    ��Name$ txt_CustCar�� �� TextWrapping$
 Wrap=�$��Center=�$��153.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Date booked��$��Center=�$��97.46��
�������(  "System.Windows.Controls.DatePicker  -     Name$ DTP_Date��$��153.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Problem��$��Center=�$��97.46��
��������� -   $ txt_Prob��$
 Wrap=�$��Center=�$	��154��$��33���� $��33��$ 
Horizontal=�.+��� -    ��Name$ ___No_Name_��$
��Wrap=�$��Mechanic's name��$��Center=�$��97.46��
�������$��0,8,0,9q��� -   $	 	cmbx_Mech��$	��154��$��0,8,0,0q��� $��33��$ 
Horizontal=�.+��� -    ��Name$ 
can_Submit��$��77��$��29��$��Center=�$��0,0,0,-5q� � Cursor$
 Hand��.+��� -    ��Name$ _base��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF5FBC87$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77�� J� Opacity$ 0Q���
� .���  � Color$ 	#FFC3D3E2��� $ 	#001D0147�� � Offset$ 1Q��� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q�����  �� EndPoint$ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21�� J� RenderTransformOrigin$ 0.846,0.482&�$ 19��$ 8��$ Center=���  � Language$ en-za�$�Submit���� -   $ 	can_Clear��$��77��$��29��$��Center=�$��7,0,0,-5q�$
 Hand��.+��� -   $ _base1��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF5FBC87$��77���� -   $ glow1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0Q���
�  
� RadiusY$ 0.526Q�  
� GradientOrigin$  0.455,1.077&�! 
� Center$! 
0.494,0.84&�" 
� RadiusX$" 0.586Q�.��� $ 	#FFC3D3E2��� $ 1Q�$ 	#001D0147���� -   $ glass1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q����� $ 0.489,-0.231&�$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$ 0.5,0.5&�$ 19��$ 8��$ Center=��� $ en-za�$�Clear���� �� $ en-za�