   M S B A M L   `   `   `  ����L  HМой склад, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:StockStock  5   	       Stock.List_Brak   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Stock     5   	     � Icon$  /Images/brak_icon.ico��5   P    � Title$1 +Список товаров с браком��5   	   $	��450��6)   $	��800��66    � 
ResizeMode$ CanMinimize=�5	   	    � WindowStartupLocation$ CenterOwner=�5
   	    � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 	StyleBrak
 �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%I  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   $	 	#FFBEE6FD��6>   �� 5   
   $	 	#FF3C7FB1��6:   �� 5   
   $	 	#FFC4E5F6��6<   �� 5   
   $	 	#FF2C628B��68   �� 5   
   $	 	#FFF4F4F4��6=   �� 5   
   $	 	#FFADB2B5��69   �� 5   
   $	 	#FF838383��6=   �� 5   
   "
 ��6"   .�5      ��  �@�FocusVisualStyle8   61   �� 5        � ��8  6+   �� 5!       � ��8  6,   �� 5"       � ��# � ��6+   �� 5#       � ��$ 1q�60   �� 5$       � ��$ Center=�6;   �� 5%       � ��$ Center=�69   �� 5&       � ��$ 1q�6(   �� 5'       � �� 5(      �� 5)      " ��6&   .R�5*      �� $ border��62   $ 5��6!   #��z��6B   #��z��6n   #��z��6�    . ._�5+      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5,       5-      P� 5.       �@��IsDefaulted . . �5/   "   �� $ border��6@   # � ��6T    � ��50      P� 51       �@J�IsMouseOver . . �52   "   �� $ border��6?   8   � ��6S   �� 53   "   $ border��6@   8   � ��6T   54      P� 55       � �� . . �56   "   �� $ border��6?   8   � ��6S   �� 57   "   $ border��6@   8   � ��6T   58      P� 59       � {� .  . �5:   "   �� $ border��6?   8   � ��6S   �� 5;   "   $ border��6@   8   � ��6T   �� 5<   "   $ contentPresenter��6K   8 	  � ��6i   5=      5?      5A      5B      5C      .��5E      � .+�5G   
   �� -   5        $ Brd_list_brak��5G      $��0,0,0,0q�6(   $	��450��69   $	��850��6F   
������� K� ZIndex$ 0��6e   
���   �$��1q�6�   ._�5H   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridlistbrak��5H         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �   CanUserAddRows .  "   VerticalScrollBarVisibility$
 Auto=�5I      $��0��6:   $��-0.8,-0.8,218.8,0.8q�6G      RowBackground
 �����   AlternatingRowBackground
 �����$	��500��5J   D   $	��805��6T    �� Left$ 10��6c   
 �� Top$	 102��6t   $	��630��6�      
IsReadOnly . $��14(�6�      Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Бренд��6%       Width5  /System.Windows.Controls.DataGridLengthConverter$	  143 6S   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 64   �� " �� Path$" Brand�6S     5M      $ Артикул��6%   $	  140 6[   ! 66   �� $" Vendor_code�6[     5N      $ Название��6%   $	  210 6U   ! 67   �� $
" Name�6U     5O      $ Брак��6%   $  86 6Q   ! 63   �� $
" Brak�6Q   4  .System.Windows.Controls.DataGridTemplateColumn  5P       5Q      �� 5R      -   5        # ��Name$# 	chkHeader��5R   '   6X   $   CellTemplate$ 5T      �� 5U      .R�5V   "   �� % d� 	IsChecked% 6+   �� *
IsSelected+& �� UpdateSourceTrigger$& PropertyChanged=�5X      5Z      5\      5]      �� 5_   
   -   5        ' ��Name$' Btn_part_brak��5_   5   #��� 
 6   $��	630,0,0,0q�6L   $	��110��6_   $��33��6k   $��Списать��6w   $��16(�6�   $	 367��6�   $	 292��6�   ���	#FFB4D2FA6�   5`      5b      