   M S B A M L   `   `   `  ����   btl    btl.BanChoiQL   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  
Bàn chơi��$	��667��$	��800��.��� 
����ح�$��20q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��2* ��� $��2* �.+��� $��0��$��0��$��2��$��QUẢN LÝ BÀN CHƠI��$��30(�$
��Bold"�$��Center=�$��Center=�$��60��$
��0,10q��� $��1��$��0��$��10q�$	��Top=�.+���  �� Orientation$ 
Horizontal=�$	��0,5q�.+��� $��	Mã Bàn:��$	��100��$��Center=��� -    ��Name$ txtMaBan��$	��170���� $ 
Horizontal=�$	��0,5q�.+��� $��Loại Bàn:��$	��100��$��Center=��� -   $ 
txtLoaiBan��$	��170���� $ 
Horizontal=�$	��0,5q�.+��� $��Giá Thuê:��$	��100��$��Center=��� -   $ 
txtGiaThue��$	��170���� $ 
Horizontal=�$	��0,5q�.+��� $��Trạng Thái:��$	��100��$��Center=��� -    ��Name$ cmbTrangThai��$	��170��.@��� $��	Còn Bàn���� $��
Hết Bàn���� $��1��$��1��$��
70,10,90,0q�$	��Top=�.+��� -   $��
Thêm Bàn��$	��200��$��50��
��� � �
�������$	��0,5q��� -   $��	Xóa Bàn��$	��200��$��50��
���  ��
�������$	��0,5q��� -   $��
Sửa Bàn��$	��200��$��50��
�������
�������$	��0,5q�&   System.Windows.Controls.DataGrid  -   $��
dgvBanChoi��$��2��$��0��$��2��   AutoGenerateColumns .  $��10q�$	��300��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Bàn��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *MaBan+  $ Loại Bàn��$	 1* 
 �� *	LoaiBan+  $ 
Giá Thuê��$	 1* 
 �� *	GiaThue+  $ Trạng Thái��$	 1* 
 �� *	TrangThai+