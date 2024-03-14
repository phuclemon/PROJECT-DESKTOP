using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ChuongTrinhQuanLyKyTuXa_Version3
{
    public partial class Danh_cho_nguoi_hoc : Form
    {
        public Danh_cho_nguoi_hoc()
        {
            InitializeComponent();
        }
        function fn = new function();

        private void txbTendangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                if (string.IsNullOrWhiteSpace(txbTendangnhap.Text))
                {
                    errorPic1.Visible = true;
                    MessageBox.Show("Thiếu tên đăng nhập hoặc mật khẩu !");
                }
            }
        }

        private void txbMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txbMatkhau.Text))
                {
                    errorPic2.Visible = true;
                    MessageBox.Show("Thiếu tên đăng nhập hoặc mật khẩu !");
                }
                else
                {
                    CheckLogin();
                }

            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTendangnhap.Text) || string.IsNullOrWhiteSpace(txbMatkhau.Text))
            {
                errorPic1.Visible = true;
                errorPic2.Visible = true;
                MessageBox.Show("Thiếu tên đăng nhập hoặc mật khẩu !");
            }
            else
            {
                CheckLogin();
            }

        }
        // Hàm riêng, dùng để add vào function.cs
        // 01
        private void CheckLogin()
        {
            string name = txbTendangnhap.Text;
            string password = txbMatkhau.Text;

            // Tạo câu lệnh SQL để kiểm tra tên đăng nhập và mật khẩu
            string query = $"SELECT COUNT(*) FROM Users WHERE Username_ = '{name}' AND Password_ = '{password}'";
            try
            {
                // Sử dụng hàm getData để thực thi câu lệnh SQL và lấy kết quả
                DataSet ds = fn.getData(query);
                int result = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                // Kiểm tra kết quả
                if (result > 0)
                {
                    // Tên đăng nhập và mật khẩu hợp lệ
                    MessageBox.Show("Đăng nhập thành công!");
                    
                    // Form hiện ra sau khi đăng nhập
                    StudentFees studentFees = new StudentFees();
                    studentFees.Show(); 
                }
                else
                {
                    // Tên đăng nhập hoặc mật khẩu không đúng
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // database thêm bảng mới 
        /* 
            CREATE DATABASE Users
            (
                Username_ nvarchar(50)
                Password_ nvarchar(50)
            )
            INSERT INTO Users (Username_, Password_)
            VALUE ('admin','admin')
         */
    }
}
