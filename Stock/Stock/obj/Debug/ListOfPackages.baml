   M S B A M L   `   `   `  ����L  HМой склад, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:StockStock  5   	       Stock.ListOfPackages   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Stock     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Icon$ /Images/Add_icon.ico��6"    � Title$! Выбор упаковки��5	   	   $	��450��6    $	��800��6-    � 	Resources 5
         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 StyleListPackage	 �� 
TargetType
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%I  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   "	 ��6)   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 1q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      "
 ��6&   .R�5)      �� $ border��62   $ 5��6!   #��z��6B   #��z��6n   #��z��6�    . ._�5*      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � �� . . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {� .  . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8 	  � ��6i   5<      5>      5@      5A      5B      .��5D      � .+�5E   
   �� -   5        $ Brd_list_packages��5E      $��0,0,0,0q�6,   $	��450��6=   $	��850��6J   
������� K� ZIndex$ 0��6i   
���   �$��1q�6�   ._�5F      &   System.Windows.Controls.DataGrid  -   5          Name$ gridlistpackage��5F         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �   CanUserAddRows .  "   VerticalScrollBarVisibility$
 Auto=�5G      $��0��6:   $��	0,0,215,0q�6G      RowBackground
 �����   AlternatingRowBackground
 �����$	��500��5H   D   $	��805��6T    �� Left$ 10��6c   
 �� Top$	 102��6t   $	��630��6�      
IsReadOnly . $��14(�6�      Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 183 6a   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6;   �� ! �� Path$! Name_package�6a     5K      $ Размер��6)   $	 180 6W     69   �� $
! Size�6W     5L      $ Количество��6)   $	 216 6d     6=   �� $! Count_package�6d   4  .System.Windows.Controls.DataGridTemplateColumn  5N       5O      �� 5P      -   5        " ��Name$" 	chkHeader��5P   '   6X   #   CellTemplate# 5R      �� 5S      .R�5T   "   �� $ d� 	IsChecked$ 6+   �� *
IsSelected+% �� UpdateSourceTrigger$% PropertyChanged=�5V      5X      5Z      5\      �� 5]   
   -   5        & ��Name$& btn_add_packages��5]   <   #��� 
 6   $��Добавить��6V   $��648,166,25.6,214q�6i   $	��110��6�   $��33��6�   $��16(�6�   ���	#FFB4D2FA6�   �� 5^   
   -   5        $& btn_WithoutPackage��5^   <   #��� 
 6   $��Без упаковки��6X   $��642,222,16.6,158q�6o   $	��110��6�   $��33��6�   $��16(�6�   ���	#FFB4D2FA6�   5_      5`      