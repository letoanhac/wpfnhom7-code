using System.Windows;
using System.Windows.Controls;

namespace btl
{
    public partial class HomeQLWindow : Window
    {
        public HomeQLWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new BanChoiQL());
        }

        // Khi nhấn vào button "Bàn chơi"
        private void OnBanChoiQLClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BanChoiQL());  
        }

        // Khi nhấn vào button "Loại bàn"
        private void OnLoaiBanQLClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoaiBanQL());  
        }

        // Khi nhấn vào button "Khách hàng"
        private void OnKhachHangQLClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new KhachHangQL());  
        }

        // Khi nhấn vào button "Nhân viên"
        private void OnNhanVienQLClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new NhanVienQL());  
        }

        // Khi nhấn vào button "Nhà cung cấp"
        private void OnNhaCCQLClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new NhaCCQL());  
        }

        // Khi nhấn vào button "Dịch vụ"
        private void OnDichVuQLClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DichVuQL());  
        }

        // Khi nhấn vào button "Hóa đơn"
        private void OnHoaDonQLClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HoaDonQL());  
        }

        // Khi nhấn vào button "Tìm kiếm"
        private void OnTimKiemQLClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TimKiemQL());  
        }

        // Sự kiện cho nút "Đăng Xuất"
        private void OnLogoutClick(object sender, RoutedEventArgs e)
        {
            // Mở lại cửa sổ đăng nhập
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();

            this.Close();
        }
    }
}
