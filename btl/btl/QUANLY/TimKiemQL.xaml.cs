using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for TimKiemQL.xaml
    /// </summary>
    public partial class TimKiemQL : Page
    {
        string connectstr = @"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBia;Persist Security Info=True;User ID=SA;Password=123456";
        public TimKiemQL()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string timban = txtMaBan.Text.Trim();
            if (string.IsNullOrWhiteSpace(timban))
            {
                MessageBox.Show("Nhập cái mã bàn vào mới tìm được chứ!", "Thông báo");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBiA;Persist Security Info=True;User ID=SA;Password=123456"))
            {
                connection.Open();
                string query = "select MaBan,LoaiBan,GiaThue,TrangThai from BanChoi where MaBan ='" + txtMaBan.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("MaBan", timban);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string lb = reader["LoaiBan"].ToString();
                    string gt = reader["GiaThue"].ToString();
                    string tt = reader["TrangThai"].ToString();
                    MessageBox.Show($"Thông tin bàn tìm được như sau: \nMã bàn: {timban}\nLoại Bàn: {lb}\nGiá Thuê: {gt}\nTrạng thái: {tt}", "Kết quả");
                }
                else
                {
                    MessageBox.Show("Khôngg tìm được thông tin bàn vì không có thông tin mã bàn để truy vấn!", "Thông báo");
                }
                reader.Close();
            }
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string timdichvu = txtMaDV.Text.Trim();
            if (string.IsNullOrWhiteSpace(timdichvu))
            {
                MessageBox.Show("Nhập cái mã dịch vụ vào mới tìm được chứ!", "Thông báo");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectstr))
            {
                connection.Open();
                string query = "select MaDichVu,TenDichVu,GiaDichVu from DichVu where MaDichVu = '" + txtMaDV.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("MaDichVu", timdichvu);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string tendv = reader["TenDichVu"].ToString();
                    string giadv = reader["GiaDichVu"].ToString();
                    MessageBox.Show($"Thông tin dịch vụ tìm được như sau: \n Mã dịch vụ: {timdichvu}\nTên dịch vụ: {tendv}\n Giá dịch vụ: {giadv}", "Kết quả");
                }
                else
                {
                    MessageBox.Show("Không tìm được thông tin dịch vụ!", "Thông báo");
                }
                reader.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string timkhach = txtMaKH.Text.Trim();
            if (string.IsNullOrWhiteSpace(timkhach))
            {
                MessageBox.Show("Nhập mã khách hàng!", "Thông báo");
                return;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QRPB238;Initial Catalog=QuanLyBiA;Persist Security Info=True;User ID=SA;Password=123456"))
            {
                connection.Open();
                string query = "select * from KhachHang where MaKhachHang ='" + txtMaKH.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("MaKhachHang", timkhach);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string tenkh = reader["TenKhachHang"].ToString();
                    string diachi = reader["DiaChi"].ToString();
                    string dienthoai = reader["DienThoai"].ToString();
                    string email = reader["Email"].ToString();
                    string diemtichluy = reader["DiemTichLuy"].ToString();
                    MessageBox.Show($"Thông tin khách hàng tìm được như sau: \n Mã khách hàng: {timkhach}\nTên khách hàng: {tenkh}\n Địa chỉ: {diachi}\nĐiện thoại: {dienthoai}\nEmail khách: {email}\nĐiểm tích lũy thành viên: {diemtichluy}", "Kết quả");
                }
                else
                {
                    MessageBox.Show("Không tìm được thông tin khách hàng!", "Thông báo");
                }
                reader.Close();
            }
        }
    }
}
