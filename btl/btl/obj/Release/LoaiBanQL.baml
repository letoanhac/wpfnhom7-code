   M S B A M L   `   `   `  ����   btl    btl.LoaiBanQL   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  Loại bàn��.��� $��20q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��2* ��� $��2* �.+��� $��0��$��0��$��2��$!��THÔNG TIN LOẠI BÀN BIDA��$��30(�$
��Bold"�$��Center=�$��Center=�$��60��$
��0,10q��� $��1��$��0��$��10q�$	��Top=�.+��� $��Mã Loại Bàn:��$��14(�$
��Bold"�$	��0,5q��� -    ��Name$ txtMaLoaiBan��$	��220��$��30��$��14(�$	��0,5q�$��5q��� $��Tên Loại Bàn:��$��14(�$
��Bold"�$	��0,5q��� -   $ txtTenLoaiBan��$	��220��$��30��$��14(�$	��0,5q�$��5q��� $��Giá Thuê:��$��14(�$
��Bold"�$	��0,5q��� -   $ 
txtGiaThue��$	��220��$��30��$��14(�$	��0,5q�$��5q��� $��1��$��1��$��
70,10,90,0q�$	��Top=�.+��� -   $��Thêm��$	��200��$��50�����#37594d
�������$	��0,5q��� -   $
��Xóa��$	��200��$��50�����#37594d
�������$	��0,5q��� -   $��Cập Nhật��$	��200��$��50�����#37594d
�������$	��0,5q�&   System.Windows.Controls.DataGrid  -   $��	dgBanChoi��$��1��$��0��$��2��   AutoGenerateColumns .  $��10,270,10,10q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Loại Bàn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	MaLoaiBan+  $ Tên Loại Bàn��$ 1*  �� *
TenLoaiBan+  $ 
Giá Thuê��$ 1*  �� *	GiaThue+