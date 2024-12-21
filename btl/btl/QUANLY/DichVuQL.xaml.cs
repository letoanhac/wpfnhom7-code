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
    /// Interaction logic for DichVuQL.xaml
    /// </summary>
    public partial class DichVuQL : Page
    {
        string connectstr = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBia;Persist Security Info=True;User ID=SA;Password=123456";
        public DichVuQL()
        {
            InitializeComponent();
            hienthidichvu();
        }
        void hienthidichvu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    conn.Open();
                    string query = "SELECT * from DichVu";
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
                        MessageBox.Show("Lỗi: griddvu chưa được khởi tạo.");
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
                    string tbquery = "insert into DichVu(MaDichVu,TenDichVu,GiaDichVu) VALUES (@mb,@lb,@gt)";
                    SqlCommand command = new SqlCommand(tbquery, conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@mb", txtMaDV.Text);
                    command.Parameters.AddWithValue("@lb", txtTenDV.Text);
                    command.Parameters.AddWithValue("@gt", txtGiaDV.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");

                    hienthidichvu();
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
                        string madv = selectedRow["MaDichVu"].ToString();

                        string deleteQuery = "DELETE FROM DichVu WHERE MaDichVu = @mb";
                        SqlCommand command = new SqlCommand(deleteQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", madv);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");

                        // Cập nhật lại DataGrid sau khi xóa
                        hienthidichvu();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn dich vu cần xóa.");
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
                        string madv = selectedRow["MaDichVu"].ToString();

                        string updateQuery = "UPDATE DichVu SET TenDichVu = @lb, GiaDichVu = @gt WHERE MaDichVu = @mb";
                        SqlCommand command = new SqlCommand(updateQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", madv);
                        command.Parameters.AddWithValue("@lb", txtTenDV.Text);
                        command.Parameters.AddWithValue("@gt", txtGiaDV.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!");

                        hienthidichvu();
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

                txtMaDV.Text = row["MaDichVu"].ToString();
                txtTenDV.Text = row["TenDichVu"].ToString();
                txtGiaDV.Text = row["GiaDichVu"].ToString();
            }

        }
    }
}
