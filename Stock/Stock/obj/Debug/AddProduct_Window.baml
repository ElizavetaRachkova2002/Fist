   M S B A M L   `   `   `  ����L  HМой склад, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:StockStock  5   	       Stock.AddProduct_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Stock     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Icon$ /Images/Add_icon.ico��6"    � Title$' !Добавление товара��5	   	   $	��430��6#   $��506.9��60    � WindowStartupLocation$ Manual=�5
   	   
 � Top$	 200��5   	    � Left$	 250��6    � 	Resources 5         FocusVisual �� Property �� Value	 J� SnapsToDevicePixels
 �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 StyleAddProduct �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%I  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   	 . #��� ��6J   $��1��6�   $	
 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5    
   $ 	#FFF4F4F4��6=   �� 5!   
   $ 	#FFADB2B5��69   �� 5"   
   $ 	#FF838383��6=   �� 5#   
   " ��6(   .�5$      ��  �@�FocusVisualStyle8   61   �� 5%       � ��8  6+   �� 5&       � ��8  6,   �� 5'       � ��# � ��6+   �� 5(       � ��$ 1q�60   �� 5)       � ��$ Center=�6;   �� 5*       � ��$ Center=�69   �� 5+       � ��$ 1q�6(   �� 5,       � �� 5-      �� 5.      " ��6&   .R�5/      �� $ border��62   $ 5��6!   #��z��6B   #��z��6n   #��z��6�   	 . ._�50      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. #	 z	 6�   #��z��6  51       52      P� 53       �@��IsDefaulted . . �54   "   �� $ border��6@   # � ��6T    � ��55      P� 56       �@J�IsMouseOver . . �57   "   �� $ border��6?   8   � ��6S   �� 58   "   $ border��6@   8   � ��6T   59      P� 5:       � �� . . �5;   "   �� $ border��6?   8   � ��6S   �� 5<   "   $ border��6@   8   � ��6T   5=      P� 5>       � {� .  . �5?   "   �� $ border��6?   8   � ��6S   �� 5@   "   $ border��6@   8   � ��6T   �� 5A   "   $ contentPresenter��6K   8 	  � ��6i   5B      5D      5F      5G      5H      .��5J      � $��	0,0,4,0.4q�6   .+�5L   
   �� -   5        $��BtnExistingProduct��5L      $��16(�6+   $��Существующий��69    J� RenderTransformOrigin$ 0.643,0.771&�6q   $��0,0,243.8,361.4q�6�   �� 5M   
   -   5        $��BtnAddNewProduct��5M      $��
Новый��6)   $��16(�69   $��253,0,-5.2,361.4q�6f   �� 5N   
   -   5         ��Name$ BrdAddExistingProduct��5N      
�������$	��497��6C   $��0,44,-0.2,6.4q�6O   .+�5O      �� $	��100��6   $��18(�6$   $��23,32,373.8,267.2q�62   $��Название:��6M   �� 5P      $	��100��6   $��18(�6$   $��23,82,373.8,267.2q�62   $��Количество:��6M   �� 5Q      -   5         ��Name$ Btn_Add_Existing_Product��5Q   ?   #��� 
 6   $	��120��6a   $��40��6m   $��Добавить��6y   $��20(�6�    �� Left$	 367��6�   
 �� Top$	 292��6�   ���	#FFB4D2FA6�   �� 5R      -   5         ��Name$ Combo_product_add��5R      $	 128��64   $ 35��6F   $	��359��6V   $��22��6b   �� 5S      -   5         ��Name$ TB_Exist_Count��5S      $��24��6.   $	 160��6:    �� TextWrapping$
 Wrap=�6L   $ 85��6`   $	��327��6p   5T      �� 5U   
   -   5        $��BrdAddNewProduct��5U      
�������$	��497��6<   $��0,44,-0.2,33.4q�6H   .+�5V      �� $	��100��6   $��18(�6$   $��23,32,373.8,267.2q�62   $��Название:��6M   �� 5W      $	��100��6   $��18(�6$   $��Юр. лицо:��62   $ 23��6C   $ 81��6T   �� 5X      $	��100��6   $��18(�6$   $��Бренд:��62   $ 23��6@   $	 126��6Q   �� 5Y      $	��100��6   $��18(�6$   $��Артикул:��62   $ 23��6B   $	 171��6S   �� 5Z      $	��100��6   $��18(�6$   $��Штрихкод:��62   $ 23��6C   $	 214��6T   �� 5[      $	��100��6   $��18(�6$   $��Упаковка:��62   $ 23��6C   $	 262��6T   �� 5\      $	��100��6   $��18(�6$   $��Кол-во��62   $ 23��6@   $	 301��6Q   �� 5]      -   5        $ Btn_Add_New_Product��5]   ?   #��� 
 6   $	��120��6]   $��40��6i   $��Добавить��6u   $��20(�6�   $	 367��6�   $	 292��6�   ���	#FFB4D2FA6�   �� 5^      -	   5        $ TB_New_Legal_Entity��5^      $	 128��64   $ 81��6F   $	��359��6V   $��26��6b   5_      �� 5`      -
   5        $ TB_New_Name��5`      $��24��6+   $	 128��67   $
 Wrap=�6I   $ 32��6]   $	��359��6m   �� 5a      -   5        $ TB_New_Vendor_Code��5a      $��24��62   $	 128��6>   $
 Wrap=�6P   $	 171��6d   $	��359��6u   .��6�   ��5b      �� 5c       �� Path$ Vendor_code�6   5e      .��5f       5g      �� 5h      -   5        $ TB_New_Barcode��5h      $��24��6.   $	 128��6:   $
 Wrap=�6L   $	 214��6`   $	��359��6q   .��6}   5j      �� 5k      -   5        $ TB_New_Brand��5k      $	 128��6-   $	 124��6?   $	��359��6P   $��26��6\   5l      �� 5m      -   5        $ TB_NewProduct_Count��5m      $��24��63   $	 128��6@   $
 Wrap=�6R   $	 301��6f   $	��231��6w   .��6�   5o      �� 5r      -   5        $ 	Add_Brand��5r      $��Р��6(   $��20��64   $	 130��6@   $��20��6Q   $��Center=�6\   $��Center=�6�   $ 3��6�   $ 	0.49,0.54&�6�   �� 5s      -   5        $ Add_LegalEnity��5s      $��Р��6-   $��20��69   $ 85��6E   $��20��6U   $��Center=�6`   $��Center=�6�   $ 3��6�   �� 5t      -   5        $ Add_More_Package_btn��5t      $��Выбрать��63   $��26��6E   $	 260��6Q   $��68��6b   $��Center=�6m   $��Center=�6�   $	 128��6�   6�   �� 5u      -   5        $  TB_NewProduct_Package_Name��5u      $��24��6;   $	 214��6G    �� 
IsReadOnly . $
 Wrap=�6k   $�� ��6   $	 262��6�   $	��273��6�   5v      5w      5x      