   M S B A M L   `   `   `  ����   CarTradingUnlimited1(    "CarTradingUnlimited.UpdateEmployee   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$  Page_Employee�� N� WindowTitle$
 Page��$��LeftToRight=� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�$	��462��.��� -    �Name$ 
LayoutRoot��.+�]� ��.  $��0q�.+��� $
��Wrap=�$	��Top=� �� TextAlignment$ Center=�$��26.667(�$
��Bold"�$��Italic$�$��	Underline{����	#FF13FF00�� $�Update ����  � Language$ en-za�$�Employee���� $��152,0,151,0q�$	��Top=�$	��281��$	��337��$��Center=�$��Center=�.+��� 
���   ����	#FF13FF00 �� RadiusY$
 20.5�� �� RadiusX$
 20.5��$	��281��$	��337��$��5���� $	��273��$	��Top=�	 �� Left$	 15��$	��302��

 �� Top$
 8��.+��� $��33�� �� Orientation$ 
Horizontal=�.+��� $
��Wrap=�$��	Firstname��$��Center=�$��117.46��
��������� -    ��Name$ txt_Firstname�� �� TextWrapping$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Surname��$��Center=�$��117.46��
��������� -   $ txt_Surname��$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��	ID number��$��Center=�$��117.46��
��������� -   $ txt_IDnumber��$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Username��$��Center=�$��117.46��
��������� -   $ txt_Username��$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��Password��$��Center=�$��117.46��
��������� -   $ txt_Password��$
 Wrap=�$��Center=�$��184.54���� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$
��Role��$��Center=�$��117.46��
��������� -    ��Name$ 	cmbx_Role��$��184.54��$��Center=��� $��33��$ 
Horizontal=�.+��� -	    ��Name$ 
can_Submit��$��77��$��29��$��Center=�$��0,0,0,-5q� � Cursor$
 Hand��.+��� -
    ��Name$ _base��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF13FF00$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77�� J� Opacity$ 0Q���
�  
� RadiusY$ 0.526Q� 
� GradientOrigin$ 0.455,1.077&� 
� Center$ 
0.494,0.84&� 
� RadiusX$ 0.586Q�.���  � Color$ 	#FFC3D3E2���  � Offset$ 1Q�$ 	#000E8769���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q�����  �� EndPoint$ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21�� J� RenderTransformOrigin$ 0.846,0.482&�$	 19��$
 8��$ Center=��� $ en-za�$�Submit���� -   $ 	can_Clear��$��77��$��29��$��Center=�$��7,0,0,-5q�$
 Hand��.+��� -   $ _base1��$��29�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF13FF00$��77���� -   $ glow1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0Q���
� $ 0.526Q�$ 0.455,1.077&�$ 
0.494,0.84&�$ 0.586Q�.��� $ 	#FFC3D3E2��� $ 1Q�$ 	#000E8769���� -   $ glass1��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q����� $ 0.489,-0.231&�$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��39��$��21��$ 0.846,0.482&�$	 19��$
 8��$ Center=��� $ en-za�$�Clear���� -   $ Can_AddEmployee��$��Bottom=�$��Center=�$	��175��$	��143��$��Center=�.+��� -   $ can_BGcircle��$	��100��$	 22��$
 25��$	��131��$
 Hand��$��Center=�$��Center=�$��0,-2,0,0q� � Triggers :�  :� RoutedEvent$ UIElement.MouseEnter��.[��� .���� -    ��Name$	 sb1��  g� RepeatBehavior$  Forever��.���� ! �� 
TargetName$	! EP1��" �� TargetProperty$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� # �� KeyTime$# 0:0:0.2��$ �� Value$$ Black��p� $# 0:0:0.4��$$ Green���� $	! EP2��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:0.4��$$ Black��p� $# 0:0:0.6��$$ Green���� $	! EP3��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:0.6��$$ Black��p� $# 0:0:0.8��$$ Green���� $	! EP4��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:0.8��$$ Black��p� $# 0:0:1��$$ Green���� $	! EP5��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:1��$$ Black��p� $# 0:0:1.2��$$ Green���� $	! EP6��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:1.2��$$ Black��p� $# 0:0:1.4��$$ Green���� $	! EP7��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:1.4��$$ Black��p� $# 0:0:1.6��$$ Green���� $	! EP8��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:0��$$ Black��p� $# 0:0:0.2��$$ Green��.+��� $	��100��$	��131��.+�A� -   % A�Name$% elipse_AddEmployee��$	��100����
� .��� $ Black��$ 1Q�� $ 	#FF13FF00��$ 0.335Q��� $��15.96��$	��131��$
 42��.+��� -   & ��Name$& TxtBlk_AddEmployee��$
��Wrap=�$��Add employee?��$��83.46��$��Center=�$��Center=��� -   $ Can_Circles��$	��144��$	��175��$��0q�$
 -1��$y�	Collapsed=�.+�A� -   $	% EP1��$��13��$��18��$		 135��$
 25��
��� � �A� -   $	% EP2��$��13��$��18��$		 157��$
 69.96��
��� � �A� -   $	% EP3��$��13��$��18��$ 
-0.5,2.695&�$		 135��$	
 112��
��� � �A� -   $	% EP4��$��13��$ 
-0.5,2.695&�$	 75��$	
 129��$��18��
��� � �A� -   $	% EP5��$��13��$ 
-0.5,2.695&�$��18��$	 22��$	
 112��
��� � �A� -   $	% EP6��$��13��$ 
-0.5,2.695&�$��18��$
 69.96��
��� � �A� -   $	% EP7��$��13��$ 
-0.5,2.695&�$��18��$	 22��$
 25��
��� � �A� -   $	% EP8��$��13��$ 
-0.5,2.695&�$	 75��$��18��
���   �$
 8��