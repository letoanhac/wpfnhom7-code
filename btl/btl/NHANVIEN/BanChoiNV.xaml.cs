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
    /// Interaction logic for BanChoiNV.xaml
    /// </summary>
    public partial class BanChoiNV : Page
    {
        string connectstr = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBia;Persist Security Info=True;User ID=SA;Password=123456";
        public BanChoiNV()
        {
            InitializeComponent();
            hienthibanchoi();
        }
        void hienthibanchoi()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstr))
                {
                    conn.Open();
                    string query = "SELECT MaBan, LoaiBan, GiaThue, TrangThai FROM BanChoi";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable == null || dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để hiển thị.");
                        return;
                    }
                    if (dgvBanChoi != null)
                    {
                        dgvBanChoi.ItemsSource = dataTable.DefaultView;
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
                    string tbquery = "insert into BanChoi(MaBan,LoaiBan,GiaThue,TrangThai) VALUES (@mb,@lb,@gt,@tt)";
                    SqlCommand command = new SqlCommand(tbquery, conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@mb", txtMaBan.Text);
                    command.Parameters.AddWithValue("@lb", txtLoaiBan.Text);
                    command.Parameters.AddWithValue("@gt", txtGiaThue.Text);
                    command.Parameters.AddWithValue("@tt", cmbTrangThai.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    hienthibanchoi();
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
                    DataRowView selectedRow = (DataRowView)dgvBanChoi.SelectedItem;
                    if (selectedRow != null)
                    {
                        string maBan = selectedRow["MaBan"].ToString();

                        string deleteQuery = "DELETE FROM BanChoi WHERE MaBan = @mb";
                        SqlCommand command = new SqlCommand(deleteQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", maBan);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        hienthibanchoi();
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
                    DataRowView selectedRow = (DataRowView)dgvBanChoi.SelectedItem;
                    if (selectedRow != null)
                    {
                        string maBan = selectedRow["MaBan"].ToString();

                        string updateQuery = "UPDATE BanChoi SET LoaiBan = @lb, GiaThue = @gt, TrangThai = @tt WHERE MaBan = @mb";
                        SqlCommand command = new SqlCommand(updateQuery, conn);
                        conn.Open();
                        command.Parameters.AddWithValue("@mb", maBan);
                        command.Parameters.AddWithValue("@lb", txtLoaiBan.Text);
                        command.Parameters.AddWithValue("@gt", txtGiaThue.Text);
                        command.Parameters.AddWithValue("@tt", cmbTrangThai.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công!");
                        hienthibanchoi();
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

        private void dgvBanChoi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvBanChoi.SelectedItem != null)
            {
                DataRowView row = (DataRowView)dgvBanChoi.SelectedItem;

                txtMaBan.Text = row["MaBan"].ToString();
                txtLoaiBan.Text = row["LoaiBan"].ToString();
                txtGiaThue.Text = row["GiaThue"].ToString();
                cmbTrangThai.Text = row["TrangThai"].ToString();
            }
        }
    }
}
