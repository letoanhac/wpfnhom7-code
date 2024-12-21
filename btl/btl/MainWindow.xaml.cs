using System;
using System.Collections.Generic;
using System.Windows;

namespace btl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Show Password
        private void ShowPassword(object sender, RoutedEventArgs e)
        {
            txtmkVisible.Text = txtmk.Password; // Copy password to TextBox
            txtmkVisible.Visibility = Visibility.Visible; // Show TextBox
            txtmk.Visibility = Visibility.Collapsed; // Hide PasswordBox
        }

        // Hide Password
        private void HidePassword(object sender, RoutedEventArgs e)
        {
            txtmk.Password = txtmkVisible.Text; 
            txtmk.Visibility = Visibility.Visible;
            txtmkVisible.Visibility = Visibility.Collapsed;
        }

        private void loginapp(object sender, RoutedEventArgs e)
        {
            List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>()
            {
                new TaiKhoan("admin", "123456", "Quản Lý"),
                new TaiKhoan("nv1", "111", "Nhân Viên"),
            };
            string tenDangNhap = txttk.Text;
            string matKhau = txtmk.Password;
            string role = "";

            if (radnv.IsChecked == true)
            {
                role = "Nhân Viên";
            }
            else if (radql.IsChecked == true)
            {
                role = "Quản Lý";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò!");
                return;
            }

            // Kiểm tra đăng nhập
            bool dangNhapThanhCong = false;
            foreach (TaiKhoan tk in danhSachTaiKhoan)
            {
                if (tk.TenDangNhap == tenDangNhap && tk.MatKhau == matKhau && tk.Role == role)
                {
                    dangNhapThanhCong = true;

                    if (role == "Quản Lý")
                    {
                        MessageBox.Show($"Đăng nhập thành công với vai trò: {role}");
                        HomeQLWindow homeQLWindow = new HomeQLWindow(); // Trang chủ Quản Lý
                        homeQLWindow.Show();
                    }
                    else if (role == "Nhân Viên")
                    {
                        MessageBox.Show($"Đăng nhập thành công với vai trò: {role}");
                        HomeNVWindow homeNVWindow = new HomeNVWindow(); // Trang chủ Nhân Viên
                        homeNVWindow.Show();
                    }

                    // Đóng cửa sổ đăng nhập
                    this.Close();
                    return;
                }
            }

            // Thông báo lỗi nếu đăng nhập thất bại
            if (!dangNhapThanhCong)
            {
                MessageBox.Show("Tên đăng nhập, mật khẩu hoặc vai trò không đúng!");
            }
        }

        private void thoatmain(object sender, RoutedEventArgs e)
        {
            // Đóng ứng dụng
            Application.Current.Shutdown();
        }

        // Lớp TaiKhoan để lưu thông tin tài khoản mẫu
        public class TaiKhoan
        {
            public string TenDangNhap { get; set; }
            public string MatKhau { get; set; }
            public string Role { get; set; }

            public TaiKhoan(string tenDangNhap, string matKhau, string role)
            {
                TenDangNhap = tenDangNhap;
                MatKhau = matKhau;
                Role = role;
            }
        }
    }
}
