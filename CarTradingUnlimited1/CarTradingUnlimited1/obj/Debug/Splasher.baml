   M S B A M L   `   `   `  ����O  KCarTradingUnlimited1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CarTradingUnlimited.ControlCarTradingUnlimited.Control  5      "    CarTradingUnlimited.Splasher   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      =control)clr-namespace:CarTradingUnlimited.Control     5      -   5          �Name$  SplashScreen��5   	    � Title$ 
MainWindow��5      $	��300��6   $	��300��6%    � AllowsTransparency .  � WindowStyle$
 None=�6a    � WindowStartupLocation$ CenterScreen=�6t    � Icon$ Images/car.ico��6�   ��61   Z� .��5      � .+�5   
   �� $
��Left=�6   $��10,54.686,0,0q�6/   $
��Wrap=�6F   $	��Top=�6Z   $	��280��6r    �� TextAlignment$ Center=�6~   $��18(�6�   $��
Welcome To��6�   ���	#FF0F3E5Fz�5      V� 5	      .~�5
      T� -   5        
trans1�� T� X$	 282Q�5
   9    T� Y$	 -50Q�6A   5      	 � Triggers	 5      :� 5      
 :� RoutedEvent$
 Window.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ trans1��6.    �� TargetProperty$ X�6M   	 W� To$ 0X�6k    g� Duration$ 0:0:4D�6r    g� 	BeginTime$ 0:0:8X�6�   W� 5      $ trans1��6.   $ Y�6M   $ 0X�6k   $ 0:0:4D�6r   $ 0:0:8X�6�   5      5      5      5      �� 5   
   $
��Wrap=�6   $��Car Trading Unlimited��6(   $��10,221.909,10,55.13q�6E   $ Center=�6b   $��18(�6y   ���	#FF0F3E5Fz�5      V� 5      .~�5      T� -   5        
trans2��$
 -300Q�5   9   $	 100Q�6B   5      	 5      :� 5      $
 Window.Loaded��6   .[�5       �� .��5!      �� .��5"      W� $ trans2��6.   $ X�6M   $ 0X�6k   $ 0:0:4D�6r   $ 0:0:12X�6�   W� 5#      $ trans2��6.   $ Y�6M   $ 0X�6k   $ 0:0:4D�6r   $ 0:0:12X�6�   5$      5%      5&      5(      2   ,CarTradingUnlimited.Control.LoadingAnimation  5)   
   $��Center=�6#   $��Center=�6@   5*      5+      