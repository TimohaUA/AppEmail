   M S B A M L   `   `   `  ����C  ?AppEmail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AppEmailAppEmail  5   	       AppEmail.SendNewLetter   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:AppEmail  5   	     � Title$  SendNewLetter��5	   	   $	��450��6   $	��800��6,   .��5
      � -   5         �Name$ grid_newLetter��5
       � DataContext 6#   �� .+�5   
   ]� .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $	��760��6   $��45��6)   $ 
Horizontal=�65   .+�5      �� $��25(�6   $��	0,0,300,0q�6*   $��40��6=   $��
Tekton Pro)�6I   $��5,8,5,5q�6a   ���#0D8BE6.��6�   
New Mail6�   �� 5      -   5        $��SendBtn��5      $��0,0,20,0q�6,   $��40��6>   $	��150��6J   ���#73BCF1$��1q�5      ���	#FFAED8F6
���   ���6\   �� *
ButtonSend+.��6{   Відправити6�   �� 5      -   5        $��	CancelBtn��5      $��40��6.   $	��150��6:   ���#73BCF1$��1q�5      ���#AED8F6.��6G   Відмінити6R   5      �� 5      -   5        $��
ReceiverTB��5      $	��760��6,   ���#EDF6FD���#0F4B86$��15(�5   /   $��10,2,2,2q�6=   $��0q�6P   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email@example.com...��5      ��6D   �� *
EMAIL_TO+6`   �� 5      -   5        $��	SubjectTB��5      $	��760��6+   $��0,5,0,0q�67   ���#EDF6FD���#0F4B86$��15(�5   D   $��10,2,2,2q�6R   $��0q�5      $ 
Subject...��6.   ��6N   �� *	SUBJECT+6i   �� 5      $ 
Horizontal=�6   $��0,5,0,0q�66   $��Center=�6G   .+�5      �� -   5        $��AttachFileTB��5      $	��560��62   {�.  ���#1770C6$��15(�6e   $��10,2,2,2q�5      $��0q�61   $ Select your attachment...��6E   6v   �� 5       -   5        $��	AttachBtn��5       $��95��6.   $��5,0,0,0q�69   ���#0D8BE6���#EDF6FD$��0q�5!   2   .��6F   Додати файл6S   �� 5"      -   5        $��	DeleteBtn��5"      $��95��6.   $��5,0,0,0q�69   ���#0D8BE6���#EDF6FD$��0q�5#   2   .��6F   Видалити6P   5$      �� 5%      -	   5         ��Name$ sp_emailBody��5%      .+�5&      �� -
   5        $��	MessageTB��5'       �� AcceptsReturn .  �� TextAlignment$ Justify=�5&   /    �� TextWrapping$
 Wrap=�6G   $��0q�6[   $��0,10,0,0q�5'   +   $��5q�6=   ���#EDF6FD���#0F4B86$��14(�5)   Y   $��Arial Unicode)�5*      $ Write Your Email Here...��5+      ��5(   /   �� 	 �� ElementName$	 sp_emailBody��
 �� Path$
 ActualWidth���5)      �� $	 sp_emailBody��$
 ActualHeight���5+   H   �� *
BodyText+6d   5,      5-      5.      5/      50      