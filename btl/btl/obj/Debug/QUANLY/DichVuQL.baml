   M S B A M L   `   `   `  ����  btl    btl.DichVuQL   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  Dịch vụ��5      $	��667��6   $	��800��6$   .��5      � 
����� �$��20q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��QUẢN LÝ DỊCH VỤ��5      $��30(�6"   $
��Bold"�60   $��Center=�5      $��Center=�6%   $��60��5   	   $
��0,10q�6   �� 5   
   
�������$��1��61   $��0��6>   $��10q�6N   $	��Top=�6Z   .+�5      �� $��Mã Dịch Vụ:��6   �� 5      -   5         ��Name$ txtMaDV��5      $	��170��6'   �� 5      $��Tên Dịch Vụ:��6   �� 5      -   5        $ txtTenDV��5      $	��170��6(   �� 5!      $��Giá Dịch Vụ:��6   �� 5"      -   5        $ txtGiaDV��5"      $	��170��6(   5#      �� 5&   
   $��1��6   $��1��6"   $��
70,10,90,0q�62   $	��Top=�6F   .+�5'      �� -   5        $��Thêm Dịch Vụ��5'   *   $	��200��6A   $��50��6M   
��� � �
�������$	��0,5q�6   �� 5(      -   5        $��Xóa Dịch Vụ��5(   ,   $	��200��6B   $��50��6N   
���  ��
�������$	��0,5q�6~   �� 5)      -   5        $��Cập Nhật��5)   ,   $	��200��6?   $��50��6K   ���#37594d
�������$	��0,5q�6   5*      &   System.Windows.Controls.DataGrid  5-   
   -   5        $��	dgBanChoi��5-   r   $��2��6A   $��0��6N   $��2��6^      AutoGenerateColumns .  $��10q�6�   $	��300��6�      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Dịch Vụ��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
MaDichVu+6V     50      $ Tên Dịch Vụ��6%   $ 1* 6X    6:   �� *	TenDichVu+6X     51      $ Giá Dịch Vụ��6%   $ 1* 6X    6:   �� *	GiaDichVu+6X   53      54      55      