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
    /// Interaction logic for NhaCCQL.xaml
    /// </summary>
    public partial class NhaCCQL : Page
    {
        string connectstr = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBia;Persist Security Info=True;User ID=SA;Password=123456";
        public NhaCCQL()
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
                    string query = "SELECT * FROM NhaCungCap";
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
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    string tbquery = "insert into NhaCungCap(MaNhaCungCap,TenNhaCungCap,DiaChi,DienThoai,Email) VALUES (@mb,@lb,@gt,@tt,@sd)";
                    SqlCommand command = new SqlCommand(tbquery, conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@mb", txtMaNCC.Text);
                    command.Parameters.AddWithValue("@lb", txtTenNCC.Text);
                    command.Parameters.AddWithValue("@gt", txtDiaChi.Text);
                    command.Parameters.AddWithValue("@tt", txtDienThoai.Text);
                    command.Parameters.AddWithValue("@sd", txtEmail.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");

                    hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
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
                        string mancc = selectedRow["MaNhaCungCap"].ToString();

                        string deleteQuery = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = @mb";
                        SqlCommand command = new SqlCommand(deleteQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", mancc);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");

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
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    DataRowView selectedRow = (DataRowView)dgBanChoi.SelectedItem;
                    if (selectedRow != null)
                    {
                        string mancc = selectedRow["MaNhaCungCap"].ToString();

                        string updateQuery = "UPDATE NhaCungCap SET TenNhaCungCap=@aa,DiaChi=@bb,DienThoai=@cc,Email=@dd WHERE MaNhaCungCap = @mb";
                        SqlCommand command = new SqlCommand(updateQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", mancc);
                        command.Parameters.AddWithValue("@aa", txtTenNCC.Text);
                        command.Parameters.AddWithValue("@bb", txtDiaChi.Text);
                        command.Parameters.AddWithValue("@cc", txtDienThoai.Text);
                        command.Parameters.AddWithValue("@dd", txtEmail.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!");

                        hienthi();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bàn cần sửa.");
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

                txtMaNCC.Text = row["MaNhaCungCap"].ToString();
                txtTenNCC.Text = row["TenNhaCungCap"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();
                txtDienThoai.Text = row["DienThoai"].ToString();
                txtEmail.Text = row["Email"].ToString();
            }

        }
    }
}
