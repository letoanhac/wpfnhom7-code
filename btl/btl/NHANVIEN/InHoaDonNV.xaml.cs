using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace btl
{
    public partial class InHoaDonNV : Page
    {
        public InHoaDonNV()
        {
            InitializeComponent();
        }

        // Sự kiện nhấn nút In Hóa Đơn
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            string invoiceId = txtMaHD.Text; // Ví dụ mã hóa đơn cần in
            GetInvoiceFromDatabase(invoiceId);
        }

        // Hàm lấy dữ liệu hóa đơn từ CSDL
        private void GetInvoiceFromDatabase(string invoiceId)
        {
            string connectionString = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBiA;Persist Security Info=True;User ID=SA;Password=123456";
            string query = "SELECT MaHoaDon, MaKhachHang, NgayLap, TongTien FROM HoaDon WHERE MaHoaDon = @MaHoaDon";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHoaDon", invoiceId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string maHoaDon = reader["MaHoaDon"].ToString();
                        string maKhachHang = reader["MaKhachHang"].ToString();
                        string ngayThanhToan = Convert.ToDateTime(reader["NgayLap"]).ToString("dd/MM/yyyy");
                        string tongTien = Convert.ToDecimal(reader["TongTien"]).ToString("N0") + " VND";

                        // Hiển thị bản xem trước hóa đơn
                        ShowInvoicePreview(maHoaDon, maKhachHang, ngayThanhToan, tongTien);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void ShowInvoicePreview(string maHoaDon, string maKhachHang, string ngayThanhToan, string tongTien)
        {
            // Tạo instance của thiết kế hóa đơn
            var invoiceTemplate = new designin
            {
                DataContext = new
                {
                    MaHoaDon = maHoaDon,
                    MaKhachHang = maKhachHang,
                    NgayThanhToan = ngayThanhToan,
                    TongTien = tongTien
                }
            };

            // Hiển thị hóa đơn trong cửa sổ xem trước
            var previewWindow = new PreviewWindow();
            previewWindow.SetInvoice(invoiceTemplate);
            previewWindow.ShowDialog();
        }

        // Hàm in hóa đơn
        private void PrintInvoice(string maHoaDon, string maKhachHang, string ngayThanhToan, string tongTien)
        {
            var invoiceTemplate = new designin
            {
                DataContext = new
                {
                    MaHoaDon = maHoaDon,
                    MaKhachHang = maKhachHang,
                    NgayThanhToan = ngayThanhToan,
                    TongTien = tongTien
                }
            };

            PrintXamlTemplate(invoiceTemplate);
        }

        // Hàm in UserControl
        private void PrintXamlTemplate(UserControl invoiceControl)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                invoiceControl.Measure(new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight));
                invoiceControl.Arrange(new Rect(new Point(0, 0), invoiceControl.DesiredSize));

                printDialog.PrintVisual(invoiceControl, "In hóa đơn");
            }
        }
    }
}
