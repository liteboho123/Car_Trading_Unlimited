   M S B A M L   `   `   `  ����   CarTradingUnlimited1&     CarTradingUnlimited.IssueInvoice   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$  Page_Invoice�� N� WindowTitle$
 Page��$��LeftToRight=� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�$	��442��$��Center=�$��Center=�.��� -    �Name$ 
LayoutRoot��$	��442��$��Center=�$��Center=�.+�]� $��Center=���.  $��Center=�$	��442��.+�]� -    ]�Name$ Dock_Decision��$��50����.  $	��640��$	��Top=�.+��� -    ��Name$ GRP_Cust��$&�� Select the name of the customer:��$��237.697�����	#FF646E38$
��Bold"�$��Italic$���Z� .����  �� Orientation$ 
Horizontal=�$��0,0,36,0q�.+��� -    ��Name$ 	cmbx_Cust��$	��186��]� -   $ DOCK_IssueInvoice����.  $	��640��$��Center=�$��Center=�.+��� $
��Wrap=�$��Issue Invoice��$	��Top=�	 �� TextAlignment$	 Center=�$��26.667(�$
��Bold"�$��Italic$�$��	Underline{����	#FF646E38�� $��0q�$	��337��$	��Top=�$��Center=�$��Center=�$	��334��.+��� 
���   ����	#FF646E38
 �� RadiusY$

 20.5�� �� RadiusX$
 20.5��$	��334��$	��337��$��5���� $	��318��$	��Top=� �� Left$ 15��$	��302��
 �� Top$ 8��.+��� -    ��Name$ 
Stck_Sales��$��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Salesman��$��Center=�$��117.46��
��������� -   $ cmbx_SalesMan��$��184.54��$��0,8,0,0q�$��Center=�$��Center=�$��25���� -	   $ 	Stck_Mech��$��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Mechanic��$��Center=�$��117.46��
��������� -
   $ 	cmbx_Mech��$	��185��$��0,8,0,0q�$��Center=�$��Center=�$��25���� -   $ 	Stck_Serv��$��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Service Plan��$��Center=�$��117.46��
��������� $��GroupBox��$��0q�$��0,0,0,2q�$��181.54��.���� $ 
Horizontal=�$��184.54��$��	0,-16,0,0q�$��33��.+�	� -    	�Name$ Rad_Yes��$	��Yes��
���/���$��Center=�	� -   $ Rad_No��$��No��
���/���$��Center=�$��72,0,0,0q�$��56.057���� -   $ 
Stck_Price��$��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Price��$��Center=�$��117.46��
��������� -    ��Name$ 	txt_Price�� �� TextWrapping$
 Wrap=�$��Center=�$��184.54���� -   $ 	Stck_Date��$��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Date Issued��$��Center=�$��117.46��
�������(  "System.Windows.Controls.DatePicker  -     Name$ DTP_Date��$	��185���� -   $ Stck_Car��$��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Name of Vehicle��$��Center=�$��117.46��
��������� -   $ cmbx_Car��$	��185��$��0q�$��Center=�$��Center=�$��25���� -   $ 
Stck_Parts��$��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Name of Parts��$��Center=�$��117.46��
��������� -   $ 
cmbx_Parts��$	��185��$��0,8,0,0q�$��Center=�$��Center=�$��25���� -   $ 	Stck_Prob��$��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Problem��$��Center=�$��117.46��
��������� -   $ txt_Prob��$
 Wrap=�$	��185��$��0,8,0,7q�$��Center=�$��Center=��� $��33��$ 
Horizontal=�.+��� -    ��Name$ 
can_Submit��$��77��$��29��$��Center=�$��0,0,0,-5q� � Cursor$
 Hand��.+��� -    ��Name$ _base��$��29�����	#FFB21D1D$��0��$ 24��$
 18�����	#FF646E38$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$
 18��$��77�� J� Opacity$ 0Q���
�  
� RadiusY$ 0.526Q� 
� GradientOrigin$ 0.455,1.077&� 
� Center$ 
0.494,0.84&� 
� RadiusX$ 0.586Q�.���  � Color$ 	#FFC3D3E2���  � Offset$ 1Q�$ 	#00E8F508���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$
 18��$��77��$ 0.795Q�����  �� EndPoint$ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��  J� RenderTransformOrigin$  0.846,0.482&�$ 19��$ 8��$	 Center=��� ! � Language$! en-za�$�Submit��