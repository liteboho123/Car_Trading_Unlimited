   M S B A M L   `   `   `  ����   CarTradingUnlimited1+    %CarTradingUnlimited.UpdateOldVehicles   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     N�Name$
  Page�� N� WindowTitle$
 Page��$��LeftToRight=� N� WindowWidth$	 640Q� N� WindowHeight$	 480Q�$	��650��$	��455��$��Center=�$��Center=�.��� -    �Name$ 
LayoutRoot��$��Center=�$��Center=�.+�]� ��.  $��0q�$��Center=�.+��� $
��Wrap=�$	��Top=� �� TextAlignment$ Center=�$��24(�$
��Bold"�$��Italic$�$��	Underline{����	#FFC300CE$��Center=�$��Center=�$��0q�$��357.734���� $�Update ����  � Language$ en-za�$�Used/Demo Vehicles���� $��0q�$	��Top=�$	��278��$	��337��$��Center=�.+��� 
���   ����	#FFC300CE �� RadiusY$
 20.5�� �� RadiusX$
 20.5��$	��278��$	��337��$��3���� $	��270��$	��Top=�	 �� Left$	 15��$	��302��

 �� Top$
 8��.+��� $��26�� �� Orientation$ 
Horizontal=�.+��� $
��Wrap=�$��
Brand name��$��Center=�$��117.46��
�������$��9.333(��� -    ��Name$ 	txt_Brand�� �� TextWrapping$
 Wrap=�$��Center=�$��184.54��$��13��$��9.333(��� $��26��$ 
Horizontal=�.+��� $
��Wrap=�$��
Model/Type��$��Center=�$��117.46��
�������$��9.333(��� -   $ 	txt_Model��$
 Wrap=�$��Center=�$��184.54��$��13��$��9.333(��� $��26��$ 
Horizontal=�.+��� $
��Wrap=�$��Serial number��$��Center=�$��117.46��
�������$��9.333(��� -   $ 
txt_serial��$
 Wrap=�$��Center=�$��184.54��$��13��$��9.333(��� $��26��$ 
Horizontal=�.+��� $
��Wrap=�$��Color��$��Center=�$��117.46��
�������$��9.333(��� -   $ 	txt_Color��$
 Wrap=�$��Center=�$��184.54��$��13��$��9.333(��� $��26��$ 
Horizontal=�.+��� $
��Wrap=�$��Vehicle type��$��Center=�$��117.46��
�������$��9.333(��� $��GroupBox��$��0q�.���� $ 
Horizontal=�$��184.54��$��0,-17,0,-5.96q�.+�	� -    	�Name$ Rad_Used��$
��Used�����	#FFC300CE$��Center=�$��9.333(�	� -   $ Rad_Demo��$
��Demo�����	#FFC300CE$��Center=�$��80,0,0,0q�$��9.333(��� $��26��$ 
Horizontal=�.+��� $
��Wrap=�$��Price��$��Center=�$��117.46��
�������$��9.333(��� -	   $ 	txt_Price��$
 Wrap=�$��Center=�$��184.54��$��13��$��9.333(��� $��26��$ 
Horizontal=�.+��� $
��Wrap=�$��Service history��$��Center=�$��117.46��
�������$��9.333(��� -
   $ txt_serviceHis��$
 Wrap=�$��Center=�$	��185��$��26��$��9.333(��� $��26��$ 
Horizontal=�.+��� $
��Wrap=�$��Speed��$��Center=�$��117.46��
�������$��9.333(��� -   $ 	txt_Speed��$
 Wrap=�$��Center=�$��184.54��$��13��$��9.333(��� $��33��$ 
Horizontal=�.+��� $
��Wrap=�$��	Condition��$��Center=�$��117.46��
�������$��9.333(��� $��GroupBox��$��0q���Z� ��Z� .���� $ 
Horizontal=�$��184.54��$��	0,-18,0,0q�$��33��.+�	� -   $ Rad_Good��$
��Good�����	#FFC300CE$��Center=�$��9.333(�	� -   $ Rad_Average��$��Average�����	#FFC300CE$��Center=�$��12,0,0,0q�$��9.333(�	� -   $ Rad_Bad��$	��Bad�����	#FFC300CE$��Center=�$��16,0,0,0q�$��9.333(��� $��33��$ 
Horizontal=�.+��� -    ��Name$ 
can_Submit��$��77��$��20��$	��Top=�$��0,0,0,-5q� � Cursor$
 Hand��.+��� -    ��Name$ _base��$��20�����	#FFB21D1D$��0��$ 24��$ 18�����	#FFC300CE$��77���� -   $
 glow��$��20�����	#FFB21D1D$��0��$ 24��$ 18��$��77�� J� Opacity$ 0Q���
�  
� RadiusY$ 0.526Q� 
� GradientOrigin$ 0.455,1.077&� 
� Center$ 
0.494,0.84&� 
� RadiusX$ 0.586Q�.���  � Color$ 	#FFC3D3E2�� � Offset$ 1Q�� $ 	#FFFBF445���� -   $ glass��$��20�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q�����  �� EndPoint$ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=� �� 
StartPoint$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��77��$��20�� J� RenderTransformOrigin$ 0.846,0.482&�$ Center=��� $ en-za�$�Submit���� -   $ 	can_Clear��$��77��$��20��$	��Top=�$��7,0,0,-5q�$
 Hand��.+��� -   $ _base1��$��20�����	#FFB21D1D$��0��$ 24��$ 18�����	#FFC300CE$��77���� -   $ glow1��$��20�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0Q���
� $ 0.526Q�$ 0.455,1.077&�$ 
0.494,0.84&�$ 0.586Q�.��� $ 	#FFC3D3E2��$ 1Q�� $ 	#FFFBF445���� -   $ glass1��$��20�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q����� $ 0.489,-0.231&�$ RelativeToBoundingBox=�$ 
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� $
��Wrap=�$��77��$��20��$ 0.846,0.482&�$ Center=��� $ en-za�$�Clear���� -   $ Can_AddOldCar��$��Bottom=�$��Center=�$	��175��$	��142��$��Center=�$��0q�.+��� -   $ can_BGcircle��$	��100��$	 22��$
 25��$	��131��$
 Hand��$��Center=�$��Center=� � Triggers :�  :� RoutedEvent$ UIElement.MouseEnter��.[��� .���� -    ��Name$	 sb1��  g� RepeatBehavior$  Forever��.���� ! �� 
TargetName$	! EP1��" �� TargetProperty$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� # �� KeyTime$# 0:0:0.2��$ �� Value$$ Black��p� $# 0:0:0.4��$$ Violet���� $	! EP2��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:0.4��$$ Black��p� $# 0:0:0.6��$$ Violet���� $	! EP3��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:0.6��$$ Black��p� $# 0:0:0.8��$$ Violet���� $	! EP4��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:0.8��$$ Black��p� $# 0:0:1��$$ Violet���� $	! EP5��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:1��$$ Black��p� $# 0:0:1.2��$$ Violet���� $	! EP6��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:1.2��$$ Black��p� $# 0:0:1.4��$$ Violet���� $	! EP7��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:1.4��$$ Black��p� $# 0:0:1.6��$$ Violet���� $	! EP8��$*" $(Shape.Fill).(SolidColorBrush.Color)�.g�p� $# 0:0:0��$$ Black��p� $# 0:0:0.2��$$ Violet��.+��� $	��100��$	��131��.+�A� -   % A�Name$% elipse_AddOldCar��$	��100����
� .��� $ Black��$ 1Q�� $ 	#FFC300CE��$ 0.335Q��� $��15.96��$	��131��$
 42��.+��� -   & ��Name$& TxtBlk_AddOldCar��$
��Wrap=�$��Add used/demo vehicles?��$��129.057��$��Center=�$��Center=�$��10.667(�$��5,0,0,0q�$ Center=��� -   $ Can_Circles��$	��142��$	��175��$��0q�$y�	Collapsed=�.+�A� -   $	% EP1��$��13��$��18��$		 135��$
 25��
������A� -   $	% EP2��$��13��$��18��$		 157��$
 69.96��
������A� -   $	% EP3��$��13��$��18��$ 
-0.5,2.695&�$		 135��$	
 112��
������A� -    $	% EP4��$��13��$ 
-0.5,2.695&�$	 75��$	
 129��$��18��
������A� -!   $	% EP5��$��13��$ 
-0.5,2.695&�$��18��$	 22��$	
 112��
������A� -"   $	% EP6��$��13��$ 
-0.5,2.695&�$��18��$
 69.96��
������A� -#   $	% EP7��$��13��$ 
-0.5,2.695&�$��18��$	 22��$
 25��
������A� -$   $	% EP8��$��13��$ 
-0.5,2.695&�$	 75��$��18��
���   �$
 8��