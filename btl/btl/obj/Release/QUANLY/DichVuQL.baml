   M S B A M L   `   `   `  ����   btl    btl.DichVuQL   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       N� Title$  Dịch vụ��$	��667��$	��800��.��� 
����� �$��20q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��2* ��� $��2* �.+��� $��0��$��0��$��2��$��QUẢN LÝ DỊCH VỤ��$��30(�$
��Bold"�$��Center=�$��Center=�$��60��$
��0,10q��� 
�������$��1��$��0��$��10q�$	��Top=�.+��� $��Mã Dịch Vụ:���� -    ��Name$ txtMaDV��$	��170���� $��Tên Dịch Vụ:���� -   $ txtTenDV��$	��170���� $��Giá Dịch Vụ:���� -   $ txtGiaDV��$	��170���� $��1��$��1��$��
70,10,90,0q�$	��Top=�.+��� -   $��Thêm Dịch Vụ��$	��200��$��50��
��� � �
�������$	��0,5q��� -   $��Xóa Dịch Vụ��$	��200��$��50��
���  ��
�������$	��0,5q��� -   $��Cập Nhật��$	��200��$��50�����#37594d
�������$	��0,5q�&   System.Windows.Controls.DataGrid  -   $��	dgBanChoi��$��2��$��0��$��2��   AutoGenerateColumns .  $��10q�$	��300��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Dịch Vụ��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
MaDichVu+  $ Tên Dịch Vụ��$ 1*  �� *	TenDichVu+  $ Giá Dịch Vụ��$ 1*  �� *	GiaDichVu+