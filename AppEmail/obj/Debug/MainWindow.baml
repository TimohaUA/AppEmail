   M S B A M L   `   `   `  ����C  ?AppEmail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AppEmailAppEmail  5   	       AppEmail.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:AppEmail  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
         AppEmail.Autorization   WinAutor��%   &	          5   
   6   5      .��5      �  � DataContext# [  6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFB8B1FB��6    � Offset$ 0.003Q�61   � 5      $ 	#FFD3CA73��6   $ 1Q�61   � 5      $ 	#FFE88888��6   $ 0.503Q�61   5       � ColumnDefinitions 5   
   �� 5      $��3* �6   6,   �� 5      $��6* �6   6,    � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $��2* �6   6*   �� 5      $��2* �6   6*   �� 5      $��2* �6   6*   �� 5      $��* �6   6)   .+�5    
   �� $��2��6   $��Bottom=�6(   $��Center=�6C   $��40(�6`   $��Segoe Print)�5!      $
��Bold"�6-   Авторизація6L   �� 5"   
   $��1��6   $��Center=�6!   $��Center=�6<   $��25(�6Y   $��Segoe Print)�5#      $
��Bold"�6-   Email6F   �� 5$   
   $��2��6   $��Center=�6!   $��Center=�6<   $��25(�6Y   $��Segoe Print)�5%      $
��Bold"�6-   Пароль6G   �� 5&   
   -   5        	 ��Name$	 sp_email��5&      $��1��6'   $��1��64   $��Center=�6D   .+�5'      �� -   5        
 ��Name$
 tb_email��5'      $��Center=�6(   $��Stretch=�6C   $��25(�6a   $��0 0 50 0q�6o   $��Segoe Print)�5(      $
��Bold"�6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введіть емейл��6A   ��5)      �� *EMAIL+5*      �� 5+   
   -   5        $	 
sp_pasword��5+      $��2��6)   $��1��66   $��Center=�6F   .+�5,      �� -   5        $
 tb_passw��5,      $��Center=�6)   $��Stretch=�6D   $��25(�6b   $��0 0 50 0q�6p   $��Segoe Print)�5-      $
��Bold"�6-   $! Введіть пароль��6?   ��5.      �� *
PASSWORD+5/      �� 50   
   -   5         ��Name$ btn_Autoriz��50      $��3��6&   $��2��63   $	��Top=�6G   $��Center=�51      $��30(�6.   $��Segoe Print)�6<   $
��Bold"�6U   $��30 10 30 10q�52      $��80��6'   ��63   �� *ButtonAutoriz+.��6U   Авторизуватись6e   54      55      