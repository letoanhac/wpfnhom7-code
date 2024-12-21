using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace btl
{
    /// <summary>
    /// Interaction logic for HoaDonQL.xaml
    /// </summary>
    public partial class HoaDonQL : Page
    {
        string connectstr = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBia;Persist Security Info=True;User ID=SA;Password=123456";
        public HoaDonQL()
        {
            InitializeComponent();
            hienthi();
        }
        void hienthi()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    conn.Open();
                    string query = "SELECT * from HoaDon";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable == null || dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.");
                        return;
                    }
                    if (dgBanChoi != null)
                    {
                        dgBanChoi.ItemsSource = dataTable.DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: gridbanchoi chưa được khởi tạo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string maHoaDon = txtMaHD.Text.Trim();

            if (string.IsNullOrWhiteSpace(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo");
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBiA;Persist Security Info=True;User ID=SA;Password=123456"))
            {
                connection.Open();

                string query = "SELECT hd.MaHoaDon, hd.NgayLap, hd.TongTien, kh.TenKhachHang " +
                               "FROM HoaDon hd " +
                               "LEFT JOIN KhachHang kh ON hd.MaKhachHang = kh.MaKhachHang " +
                               "WHERE hd.MaHoaDon = @MaHoaDon";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string ngayLap = reader["NgayLap"].ToString();
                    string tongTien = reader["TongTien"].ToString();
                    string tenKhachHang = reader["TenKhachHang"].ToString();
                    hienthi();
                    MessageBox.Show($"Hóa đơn: {maHoaDon}\nKhách hàng: {tenKhachHang}\nNgày lập: {ngayLap}\nTổng tiền: {tongTien} VND",
                                    "Thông tin hóa đơn");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn với mã vừa nhập!", "Thông báo");
                }

                reader.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    DataRowView selectedRow = (DataRowView)dgBanChoi.SelectedItem;
                    if (selectedRow != null)
                    {
                        string mahd = selectedRow["MaHoaDon"].ToString();

                        string deleteQuery = "DELETE FROM HoaDon WHERE MaHoaDon = @mb";
                        SqlCommand command = new SqlCommand(deleteQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", mahd);
                        command.ExecuteNonQuery();

                        // Cập nhật lại DataGrid sau khi xóa
                        hienthi();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bàn cần xóa.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            hienthi();
        }
    }
}
