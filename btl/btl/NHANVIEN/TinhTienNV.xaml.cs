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
    /// Interaction logic for TinhTienNV.xaml
    /// </summary>
    public partial class TinhTienNV : Page
    {
        string connectstr = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBia;Persist Security Info=True;User ID=SA;Password=123456";
        public TinhTienNV()
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
                    string query = "SELECT * from SuDungBan";
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
            string maban = txtMaBan.Text;
            string makhachhang = txtMaKH.Text;

            if (string.IsNullOrWhiteSpace(maban) || string.IsNullOrWhiteSpace(makhachhang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã bàn và mã khách hàng!", "Thông báo");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectstr))
            {
                // Kiểm tra trạng thái bàn
                string checkQuery = "SELECT TrangThai FROM BanChoi WHERE MaBan = @MaBan";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@MaBan", maban);

                connection.Open();
                var trangthai = checkCommand.ExecuteScalar()?.ToString();
                connection.Close();

                if (trangthai == "Hết Bàn")
                {
                    MessageBox.Show("Bàn này đã hết chỗ, vui lòng chọn bàn khác!", "Thông báo");
                    return;
                }

                if (trangthai == "Còn Bàn")
                {
                    string existQuery = "SELECT COUNT(*) FROM SuDungBan WHERE MaBan = @MaBan AND ThoiGianTat IS NULL";
                    SqlCommand existCommand = new SqlCommand(existQuery, connection);
                    existCommand.Parameters.AddWithValue("@MaBan", maban);

                    connection.Open();
                    int count = (int)existCommand.ExecuteScalar();
                    connection.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Bàn này đang được sử dụng. Vui lòng chọn bàn khác!", "Thông báo");
                        return;
                    }
                    string query = "INSERT INTO SuDungBan (MaBan, MaKhachHang, ThoiGianBat) VALUES (@MaBan, @MaKhachHang, @ThoiGianBat)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaBan", maban);
                    command.Parameters.AddWithValue("@MaKhachHang", makhachhang);
                    command.Parameters.AddWithValue("@ThoiGianBat", DateTime.Now);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Bàn đã được bật thành công!", "Thông báo");
                    hienthi();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn hoặc trạng thái không hợp lệ!", "Thông báo");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string maBan = txtMaBan.Text;

            if (string.IsNullOrWhiteSpace(maBan))
            {
                MessageBox.Show("Vui lòng nhập mã bàn!", "Thông báo");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectstr))
            {
                connection.Open();

                // Lấy thông tin bật bàn
                string queryGet = "SELECT TOP 1 ThoiGianBat, GiaThue FROM SuDungBan sb INNER JOIN BanChoi bc ON sb.MaBan = bc.MaBan WHERE sb.MaBan = @MaBan AND sb.ThoiGianTat IS NULL";
                SqlCommand commandGet = new SqlCommand(queryGet, connection);
                commandGet.Parameters.AddWithValue("@MaBan", maBan);
                SqlDataReader reader = commandGet.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Không tìm thấy bàn đang bật!", "Thông báo");
                    connection.Close();
                    return;
                }

                DateTime thoiGianBat = reader.GetDateTime(0);
                float giaThue = (float)reader.GetDouble(1);
                reader.Close();

                // Tính thời gian và chi phí
                DateTime thoiGianTat = DateTime.Now;
                TimeSpan thoiGianSuDung = thoiGianTat - thoiGianBat;
                double chiPhi = thoiGianSuDung.TotalHours * giaThue;

                // Cập nhật SuDungBan
                string queryUpdate = "UPDATE SuDungBan SET ThoiGianTat = @ThoiGianTat, ChiPhi = @ChiPhi WHERE MaBan = @MaBan AND ThoiGianTat IS NULL";
                SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection);
                commandUpdate.Parameters.AddWithValue("@ThoiGianTat", thoiGianTat);
                commandUpdate.Parameters.AddWithValue("@ChiPhi", chiPhi);
                commandUpdate.Parameters.AddWithValue("@MaBan", maBan);
                commandUpdate.ExecuteNonQuery();
                MessageBox.Show($"Bàn đã được tắt. Chi phí: {chiPhi:C}", "Thông báo");
                hienthi();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    DataRowView selectedRow = (DataRowView)dgBanChoi.SelectedItem;
                    if (selectedRow != null)
                    {
                        string maBan = selectedRow["MaBan"].ToString();

                        string deleteQuery = "DELETE FROM SuDungBan WHERE MaBan = @mb";
                        SqlCommand command = new SqlCommand(deleteQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", maBan);
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string maBan = txtMaBan.Text;
            string maKhachHang = txtMaKH.Text;

            if (string.IsNullOrWhiteSpace(maBan) || string.IsNullOrWhiteSpace(maKhachHang))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã bàn và mã khách hàng!", "Thông báo");
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBiA;Persist Security Info=True;User ID=SA;Password=123456"))
            {
                connection.Open();

                // Lấy thông tin sử dụng bàn để tính tổng tiền
                string queryGetUsage = "SELECT TOP 1 ThoiGianBat, ChiPhi FROM SuDungBan WHERE MaBan = @MaBan AND ThoiGianTat IS NOT NULL ORDER BY ThoiGianTat DESC";
                SqlCommand commandGetUsage = new SqlCommand(queryGetUsage, connection);
                commandGetUsage.Parameters.AddWithValue("@MaBan", maBan);

                SqlDataReader reader = commandGetUsage.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu sử dụng bàn đã tắt để lập hóa đơn!", "Thông báo");
                    reader.Close();
                    connection.Close();
                    return;
                }

                DateTime thoiGianBat = reader.GetDateTime(0);
                double tongTien = reader.GetDouble(1);
                reader.Close();
                string queryInsertHoaDon = "INSERT INTO HoaDon (MaHoaDon, MaKhachHang, NgayLap, TongTien, TienDaTT) VALUES (@MaHoaDon, @MaKhachHang, @NgayLap, @TongTien, @TienDaTT)";
                SqlCommand commandInsertHoaDon = new SqlCommand(queryInsertHoaDon, connection);
                commandInsertHoaDon.Parameters.AddWithValue("@MaHoaDon", txtMaHD.Text);
                commandInsertHoaDon.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                commandInsertHoaDon.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                commandInsertHoaDon.Parameters.AddWithValue("@TongTien", tongTien);
                commandInsertHoaDon.Parameters.AddWithValue("@TienDaTT", tongTien);

                commandInsertHoaDon.ExecuteNonQuery();

                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo");
            }
        }
    }
}
