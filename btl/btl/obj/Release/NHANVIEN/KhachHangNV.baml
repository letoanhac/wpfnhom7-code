   M S B A M L   `   `   `  ����   btl    btl.KhachHangNV   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  Khách hàng��$	��667��$	��800��.��� 
����� �$��20q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��2* ��� $��2* �.+��� $��0��$��0��$��2��$��QUẢN LÝ KHÁCH HÀNG��$��30(�$
��Bold"�$��Center=�$��Center=�$��60��$
��0,10q��� 
�������$��1��$��0��$��10q�$	��Top=�.+��� $��Mã Khách Hàng:���� -    ��Name$ txtKhachHang��$	��170���� $��Tên Khách Hàng:���� -   $ txtTenKhachHang��$	��170���� $��Địa Chỉ:���� -   $ 	txtDiaChi��$	��170���� $��Điện Thoại:���� -   $ txtDienThoai��$	��170���� $��Email:���� -   $ txtEmai��$	��170���� $��Điểm tích lũy:���� -   $ txtDiemTichLuy��$	��170���� $��1��$��1��$��
70,10,90,0q�$	��Top=�.+��� -   $��Thêm KH��$	��200��$��50��
��� � �
�������$	��0,5q��� -   $��Xóa KH��$	��200��$��50��
���  ��
�������$	��0,5q��� -	   $��Sửa Thông Tin KH��$	��200��$��50�����#37594d
�������$	��0,5q�&   System.Windows.Controls.DataGrid  -
   $��	dgBanChoi��$��1��$��0��$��2��   AutoGenerateColumns .  $��10,320,10,10q�$��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Khách Hàng��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *MaKhachHang+  $ Tên Khách Hàng��$ 1*  �� *TenKhachHang+  $ Địa Chỉ��$ 1*  �� *DiaChi+  $ Điện Thoại��$ 1*  �� *	DienThoai+  $ Email��$ 1*  �� *Email+  $ Điểm Tích Lũy��$ 1*  �� *DiemTichLuy+