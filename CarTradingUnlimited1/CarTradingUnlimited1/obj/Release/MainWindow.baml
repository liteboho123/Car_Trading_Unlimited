   M S B A M L   `   `   `  ����   CarTradingUnlimited1$    CarTradingUnlimited.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  Window�� � Title$ 
MainWindow��$��1220.5��$
��1173��$y�	Collapsed=� � 
ResizeMode$ CanMinimize=� � WindowStartupLocation$ CenterOwner=� � AllowsTransparency .  � WindowStyle$
 None=� � Icon$ Images/car.ico����Z� .��� -    �Name$ 
LayoutRoot��$��0,0,-8,0q�.+�� $��1212.5��$��	8,0,8,115q� � RowDefinitions �� $	��146 ��� $��48.408 ��� $��109.355 ��� $��367.467 ��� $��109.27 ��� -   	 ��Name$		 bb1��$��0,26,8,8q�._�� .+��� -   
 ��Name$	
 Rec�� �� RadiusY$	 288�� �� RadiusX$	 288��$��5�� J� RenderTransformOrigin$ 	0.506,0.5&� J� Opacity$	 0.8Q�
���   ���
� .��� -   G1�� � Color$ Black�� � Offset$ 1Q�� -   G2��$ White��$ 0.249Q� � Triggers :�  :� RoutedEvent$ Window.Loaded��.[��� .���� .��W�  �� 
TargetName$	 bb1�� �� TargetProperty$ Opacity� W� From$ 0X� g� Duration$ 0:0:3D��� -    ��Name$ can_btn�� ^� ToolTip$ Return to login��$��569.5,0,584,8q�$��67��$��64��$��Bottom=�.+��� -   $
 _base��$��34�����	#FFB21D1D$��0��$ 24��$ 18�����	#FF172974$��67��
 �� Top$ 20���� -	   $

 glow��$��34�����	#FFB21D1D$��0��$ 24��$ 18��$��67��$ 0Q�$ 20����
�  
� RadiusY$ 0.526Q� 
� GradientOrigin$ 0.455,1.077&� 
� Center$ 
0.494,0.84&� 
� RadiusX$ 0.586Q�.��� $ 	#FFC3D3E2��� $ 1Q�$ 	#00448ACC���� -
   $
 glass��$��34�����	#FFB21D1D$��0��$ 24��$ 18��$��67��$ 0.795Q�$ 20������  �� EndPoint$ 0.489,-0.231&� � MappingMode$ RelativeToBoundingBox=�  �� 
StartPoint$  
0.489,1.07&�.��� $ 	#00000000��$ 0Q�� $ White��$ 1Q�� $ 	#9B9B9B9B��$ 0.675Q�� $ 	#1B1B1B1B��$ 0.543Q��� -   ! ��Name$! TxtBlk_LogOut��$
��Wrap=�$��14.667(�$��67��$��34��$ 0.846,0.482&�$ 20���� $�	 Log-out?���� -   " ��Name$" 	Btn_Close��$ Close the application��$��Button��$��36��$��39��$��Right=�$	��Top=�$��0,32,251.5,0q�
������ # � Cursor$
# Hand������ .R��� $��/Images/Close.jpeg���� -   $" Btn_Minimize��$ Minimize the application��$��Button��$��36��$��39��$��Right=�$	��Top=�$��0,32,208.5,0q�
������ $
# Hand��$ 0.59,-0.667&����� .R��� $��Images/Minimize.jpeg��]� $��94����.  $	��Top=�$��111.27,117,173.5,0q�.+��� $	��Top=�$��65��$ �� Orientation$$ 
Horizontal=�$��0,0,47.73,0q�$��Center=�$��Center=�.+��� -   $" Btn_Customer��$��Button��$
��Left=�$��68��$��29��$	��Top=����� .R��� $��/Images/Customers.jpeg���� -   $" Btn_Employee��$��Button��$��68��
������ $��29��$	��Top=�$
# Hand��$
��Left=����� .R��� $��/Images/Employees.jpeg���� -   $" Btn_NewVehicles��$��Button��$��68��
������ $��29��$	��Top=�$
# Hand������ .R��� $��/Images/NewVehicles.jpeg���� -   $" Btn_OldVehicles��$��Button��$��68��
������ $��29��$	��Top=�$
# Hand������ .R��� $��/Images/OldVehicles.jpeg���� -   $" Btn_TestDrive��$��Button��$��68��
������ $��29��$	��Top=�$
# Hand������ .R��� $��Images/TestDrive.jpeg���� -   $" Btn_Service��$��Button��$��68��
������ $��29��$	��Top=�$
# Hand������ .R��� $��Images/Service.jpeg      ���� -   $" 	Btn_Parts��$��Button��$��68��
������ $��29��$	��Top=�$
# Hand������ .R��� $��Images/Parts.jpeg���� -   $" Btn_Invoice��$��Button��$��68��
������ $��29��$	��Top=�$
# Hand������ .R��� $��Images/Invoice.jpeg���� -   $" Btn_Motorcycle��$��Button��$��68��
������ $��29��$	��Top=�$
# Hand������ .R��� $��Images/Motorcycle.jpeg���� $��547.73��$��Bottom=�$��29��$ 0.5,0.5&�.+��� -   $! TxtBlK_TaskName��$
��Wrap=�$��30��% �� TextAlignment$% Center=�$��18.667(�$��0,0,47.73,0q�$��547.73�����	#FF0085EB$��Center=�$��Center=�]� $��Stretch=�$��Stretch=�$��55.52,211,78,72q�.+� � -   &  �Name$& 
_mainFrame��$��Stretch=�$��Stretch=�$�� ��$��1086.98��'  � NavigationUIVisibility$' Hidden=�]� $��45����.  $	��Top=�$��111.27,72,174,0q�.+��� -   $! TxtBlk_Department��$
��Wrap=�$��0,0,47.73,0q�$��45��$��24(�$% Center=����	#FF0085EB$	��Top=�$��Center=�$��Center=�