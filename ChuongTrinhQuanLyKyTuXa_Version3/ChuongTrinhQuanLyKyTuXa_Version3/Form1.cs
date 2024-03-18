using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChuongTrinhQuanLyKyTuXa_Version3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                Dashboard dbs = new Dashboard();
                dbs.Show();
                this.Hide();
            }
        }
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    string connectionString = 
        //        "Server=tcp:[server-name].database.windows.net,1433;" +
        //        "Initial Catalog=[phucvo];Persist Security Info=False;" +
        //        "User ID={phucvo};" +
        //        "Password={Phucvo@123};" +
        //        "MultipleActiveResultSets=False;" +
        //        "Encrypt=True;" +
        //        "TrustServerCertificate=False;" +
        //        "Connection Timeout=30;";

        //    SqlConnection conn = new SqlConnection(connectionString);

        //    try
        //    {
        //        conn.Open();
        //        // Thực hiện các thao tác với cơ sở dữ liệu tại đây.
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //}
    }
}
