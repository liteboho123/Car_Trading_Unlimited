   M S B A M L   `   `   `  ����   CarTradingUnlimited1%    CarTradingUnlimited.LoginWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  	Win_Login�� � Title$ LoginWindow��$	��493��$	��480�� � WindowStyle$
 None=� � 
ResizeMode$ CanMinimize=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=� � Icon$ Images/car.ico����Z� .��� .+��� -    �� CornerRadius$ 20,20,20,20�� J� Opacity$	 0.7Q���
� .��� -   c1��	 � Color$	 	#FF10314B��
 � Offset$
 0Q�� -   c2��$	 	#FFACDBFF��$
 1Q� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� .����  g� RepeatBehavior$ Forever�� g� AutoReverse . .����  �� 
TargetName$ c1�� �� TargetProperty$ Color�	 �� To$ 	#FFACDBFFX� g� Duration$ 0:0:2D��� $ c2��$ Color�$ 	#FF10314BX�$ 0:0:2D��� $
��Left=�$	��480��$	��Top=�$	��493�� � Cursor$
 Hand��.+��� -    ��Name$ 	Btn_Close��$��Button��$��36��$��39��$��Right=�$	��Top=�
������  �� Left$	 446��
 �� Top$ 8��$
 Hand������ .R��� $��/Images/Close.jpeg���� -    ��Name$ Txt_Username�� �� TextWrapping$
 Wrap=�$ 322.447��$	 347��$��162.553���� $
��Wrap=�$��Login Window��$	 152��$ 8��$��26.667(�$��36���� $
��Wrap=�$��	Username:��$	 347��$��17.96��$��16(�$ 8���� $
��Wrap=�$��	Password:��$	 383�� J� RenderTransformOrigin$ 0.515,1.253&�$��17.96��$��16(�$ 8��]� $	��166����.  $	��477��$ 8��$	 135��.+��� -    ��Name$ Txt_Department��$	��477��$��26��$
��Wrap=�$	��Top=� �� TextAlignment$ Center=�$��18.667(��� -    ��Name$ 
Can_images��$	��477��$��0,0,0,33q�$��Bottom=�$	��140��$ 0.5,0.5&����� �� -	   $ can_btn��$��77��$��29��$��Bottom=�$	 408��$	 433��$
 Hand��.+��� -
    ��Name$ _base��$��29�����	#FFB21D1D$��0�� �� RadiusX$ 24�� �� RadiusY$ 18�����	#FF172974$��77���� -   $
 glow��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0Q���
�   
� RadiusY$  0.526Q�! 
� GradientOrigin$! 0.455,1.077&�" 
� Center$" 
0.494,0.84&�# 
� RadiusX$# 0.586Q�.��� $	 	#FFC3D3E2��� $
 1Q�$	 	#00448ACC���� -   $ glass��$��29�����	#FFB21D1D$��0��$ 24��$ 18��$��77��$ 0.795Q����� $ �� EndPoint$$ 0.489,-0.231&�% � MappingMode$% RelativeToBoundingBox=�& �� 
StartPoint$& 
0.489,1.07&�.��� $	 	#00000000��$
 0Q�� $	 White��$
 1Q�� $	 	#9B9B9B9B��$
 0.675Q�� $	 	#1B1B1B1B��$
 0.543Q��� $
��Wrap=�$��39��$��21��$ 0.846,0.482&�$ 19��$ 8��
��������� $� Login��G� -   ' G�Name$' Txt_Password��$ 322.447��$	 383��$��162.553��( G� PasswordChar$( *���� -   $ Btn_Minimize��$��Button��$��36��$��39��$��Right=�$	��Top=�
������ $	 403��$ 8��$
 Hand������ .R��� $��Images/Minimize.jpeg���� $
��Wrap=�$��Select a department��$	 152��$ 56.17��$��169.797��$ Center=�$��18.667(�$ 
0.37,0.396&��� -   ) ��Name$) cmbx_Department��$	 152��$ 85��$��169.797��$
 Hand��