using System.Windows;

namespace btl
{
    /// <summary>
    /// Interaction logic for HomeNVWindow.xaml
    /// </summary>
    public partial class HomeNVWindow : Window
    {
        public HomeNVWindow()
        {
            InitializeComponent();

            // Điều hướng đến trang Bàn Chơi ngay khi cửa sổ mở
            MainFrame.Navigate(new BanChoiNV());
        }

        // Sự kiện cho nút "Bàn chơi"
        private void OnBanChoiNVClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BanChoiNV());
        }

        // Sự kiện cho nút "Tình trạng bàn"
        private void OnKhachHangNVClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new KhachHangNV());
        }

        // Sự kiện cho nút "Dịch vụ"
        private void OnDichVuNVClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DichVuNV());
        }

        // Sự kiện cho nút "Tính tiền"
        private void OnTinhTienNVClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TinhTienNV());
        }

        // Sự kiện cho nút "In hóa đơn"
        private void OnInHoaDonNVClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InHoaDonNV());
        }

        // Sự kiện cho nút "Đăng Xuất"
        private void OnLogoutClick(object sender, RoutedEventArgs e)
        {
            // Mở lại cửa sổ đăng nhập
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();

            // Đóng cửa sổ hiện tại
            this.Close();
        }
    }
}
