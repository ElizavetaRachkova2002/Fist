   M S B A M L   `   `   `  ����L  HМой склад, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:StockStock  5   	       Stock.History_Window   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Stock     5   	     � Icon$  /Images/history_icon.ico��6+    � 
ResizeMode$ CanMinimize=�5   	    � Title$ История��5	   	   $	��450��6   $	��650��6&    � WindowStartupLocation$ CenterOwner=�5
   	   .��5      � $��
0,0,3.6,-5q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ HistoryGrid��5         AutoGenerateColumns .     HorizontalGridLinesBrush �	#FFB7B7B7   CanUserAddRows .  "   VerticalScrollBarVisibility$
 Auto=�5      $��0��6:   	   RowBackground
	 �����
   AlternatingRowBackground

 �����$	��500��5   D      
IsReadOnly . $��14(�6f   $��
0,0,-0.2,0q�6t      VerticalGridLinesBrush �	#FFB7B7B7   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 170 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ��  �� Path$
 Time�6Q     5      $ Действие��6%   $	 450 6Z    67   �� $ 	Operation�6Z   5      5      5      