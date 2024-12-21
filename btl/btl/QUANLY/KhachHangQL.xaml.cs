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
    /// Interaction logic for KhachHangQL.xaml
    /// </summary>
    public partial class KhachHangQL : Page
    {
        public KhachHangQL()
        {
            InitializeComponent();
            hienthikhachhang();
        }

        string connectstr = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBia;Persist Security Info=True;User ID=SA;Password=123456";
        void hienthikhachhang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    conn.Open();
                    string query = "select MaKhachHang,TenKhachHang,DiaChi,DienThoai,Email,DiemTichLuy from KhachHang";
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectstr))
            {
                string themquery = "insert into KhachHang(MaKhachHang,TenKhachHang,DiaChi,DienThoai,Email,DiemTichLuy) values(@mkh,@tkh,@dc,@dt,@em,@dtl)";
                SqlCommand command = new SqlCommand(themquery, conn);
                conn.Open();
                command.Parameters.AddWithValue("@mkh", txtKhachHang.Text);
                command.Parameters.AddWithValue("@tkh", txtTenKhachHang.Text);
                command.Parameters.AddWithValue("@dc", txtDiaChi.Text);
                command.Parameters.AddWithValue("@dt", txtDienThoai.Text);
                command.Parameters.AddWithValue("@em", txtEmail.Text);
                command.Parameters.AddWithValue("@dtl", txtDiemTichLuy.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");

                hienthikhachhang();
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
                        string makh = selectedRow["MaKhachHang"].ToString();

                        string deleteQuery = "DELETE FROM KhachHang WHERE MaKhachHang = @mb";
                        SqlCommand command = new SqlCommand(deleteQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", makh);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");

                        // Cập nhật lại DataGrid sau khi xóa
                        hienthikhachhang();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
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

            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    DataRowView selectedRow = (DataRowView)dgBanChoi.SelectedItem;
                    if (selectedRow != null)
                    {
                        string makh = selectedRow["MaKhachHang"].ToString();

                        string updateQuery = "UPDATE KhachHang SET TenKhachHang=@tkh,DiaChi=@dc,DienThoai=@dt,Email=@ema,DiemTichLuy=@dtl WHERE MaKhachHang = @mb";
                        SqlCommand command = new SqlCommand(updateQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", makh);
                        command.Parameters.AddWithValue("@tkh", txtTenKhachHang.Text);
                        command.Parameters.AddWithValue("@dc", txtDiaChi.Text);
                        command.Parameters.AddWithValue("@dt", txtDienThoai.Text);
                        command.Parameters.AddWithValue("@ema", txtEmail.Text);
                        command.Parameters.AddWithValue("@dtl", txtDiemTichLuy.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!");

                        hienthikhachhang();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }

        private void dgBanChoi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (dgBanChoi.SelectedItem != null)
            {
                DataRowView row = (DataRowView)dgBanChoi.SelectedItem;

                txtKhachHang.Text = row["MaKhachHang"].ToString();
                txtTenKhachHang.Text = row["TenKhachHang"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();
                txtDienThoai.Text = row["DienThoai"].ToString();
                txtEmail.Text = row["Email"].ToString();
                txtDiemTichLuy.Text = row["DiemTichLuy"].ToString();
            }

        }
    }
}
