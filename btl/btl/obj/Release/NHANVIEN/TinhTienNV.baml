   M S B A M L   `   `   `  ����   btl    btl.TinhTienNV   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  Tìm Kiếm��$	��667��$	��800��.��� 
����� �$��20q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��2* ��� $��2* �.+��� $��0��$��0��$��2��$6��0BẬT BÀN VÀ QUẢN LÝ DỮ LIỆU HÓA ĐƠN��$��30(�$
��Bold"�$��Center=�$��Center=�$��60��$
��0,10q��� 
�������$��1��$��0��$��10q�$	��Top=�.+��� $��	Mã Bàn:���� -    ��Name$ txtMaBan��$	��170���� $��Mã Khách Hàng:���� -   $ txtMaKH��$	��170���� $��Mã Hóa Đơn:���� -   $ txtMaHD��$	��170���� -   $+��%LƯU DỮ LIỆU BÀN VÀO HÓA ĐƠN��$	��225��$��40��
��� � �
�������$
��0,25q��� $��1��$��1��$��
70,10,90,0q�$	��Top=�.+��� -   $��
Bật Bàn��$	��200��$��50��
��� � �
�������$	��0,5q��� -   $��
Tắt Bàn��$	��200��$��50��
���  ��
�������$	��0,5q��� -   $��Xóa Dữ Liệu��$	��200��$��50�����#37594d
�������$	��0,5q�&   System.Windows.Controls.DataGrid  -   $��	dgBanChoi��$��2��$��0��$��2��   AutoGenerateColumns .  $��10q�$	��300��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Bàn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *MaBan+  $ Mã Khách Hàng��$ 1*  �� *MaKhachHang+  $ Thời Gian Bật��$ 1*  �� *ThoiGianBat+  $ Thời Gian Tắt��$ 1*  �� *ThoiGianTat+  $ Chi Phí��$ 1*  �� *ChiPhi+