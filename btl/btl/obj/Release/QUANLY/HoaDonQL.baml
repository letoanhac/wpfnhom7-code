   M S B A M L   `   `   `  ����   btl    btl.HoaDonQL   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  
Hóa Đơn��$	��667��$	��800��.��� 
�������$��20q� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��0��$��QUẢN LÝ HÓA ĐƠN��$��32(�$
��Bold"�$��Center=�$��Center=�$
��0,20q�� 
�������$��1��$��10q� � ColumnDefinitions �� $��1* ��� $��1* �.+��� $��0��$��20q�$��Center=�$
��Left=�.+��� $��Mã Hóa Đơn:��$
��Bold"�$��14(����#37594d�� -    ��Name$ txtMaHD��$	��300��$��35��$
��0,10q�$��5q����#37594d$��1q�$��14(��� $��1��$��Center=�$��Center=�.+��� -   $��	Tra Cứu��$	��200��$��50��$��10q�
��� � �
�������$��16(�$
��Bold"�
������ �� -   $��Xóa Hóa Đơn��$	��200��$��50��$��10q�
���  ��
�������$��16(�$
��Bold"�
������ �� -   $��Reset Bảng��$	��200��$��50��$��10q����#37594d
�������$��16(�$
��Bold"�
������ &   System.Windows.Controls.DataGrid  -   $��	dgBanChoi��$��2��   AutoGenerateColumns .  $��10q����#37594d$��1q�   	RowHeight$ 40Q�   HeadersVisibility$ Column=�$��14(�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Hóa Đơn��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 2* 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *
MaHoaDon+  $ Mã Khách Hàng��$	 2* 
 �� *MaKhachHang+  $ Ngày Lập��$	 2* 
 �� *	NgayLap+  $ Tổng Tiền��$	 2* 
 �� *
TongTien+  $ Tiền Đã Thanh Toán��$	 2* 
 �� *
TienDaTT+