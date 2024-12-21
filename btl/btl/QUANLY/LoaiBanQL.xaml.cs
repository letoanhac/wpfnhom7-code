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
    /// Interaction logic for LoaiBanQL.xaml
    /// </summary>
    public partial class LoaiBanQL : Page
    {
        string connectstr = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBia;Persist Security Info=True;User ID=SA;Password=123456";
        public LoaiBanQL()
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
                    string query = "SELECT * FROM LoaiBan";
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
                    string tbquery = "insert into LoaiBan(MaLoaiBan,TenLoaiBan,GiaThue) VALUES (@mb,@lb,@gt)";
                    SqlCommand command = new SqlCommand(tbquery, conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@mb", txtMaLoaiBan.Text);
                    command.Parameters.AddWithValue("@lb", txtTenLoaiBan.Text);
                    command.Parameters.AddWithValue("@gt", txtGiaThue.Text);
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
                        string malb = selectedRow["MaLoaiBan"].ToString();

                        string deleteQuery = "DELETE FROM LoaiBan WHERE MaLoaiBan = @mb";
                        SqlCommand command = new SqlCommand(deleteQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", malb);
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
                        string malb = selectedRow["MaLoaiBan"].ToString();

                        string updateQuery = "UPDATE LoaiBan SET TenLoaiBan=@tlb, GiaThue = @gt WHERE MaLoaiBan = @mb";
                        SqlCommand command = new SqlCommand(updateQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", malb);
                        command.Parameters.AddWithValue("@tlb", txtTenLoaiBan.Text);
                        command.Parameters.AddWithValue("@gt", txtGiaThue.Text);
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

                txtMaLoaiBan.Text = row["MaLoaiBan"].ToString();
                txtTenLoaiBan.Text = row["TenLoaiBan"].ToString();
                txtGiaThue.Text = row["GiaThue"].ToString();
            }

        }
    }
}
