using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ChuongTrinhQuanLyKyTuXa_Version3
{
    class function
    {
        protected SqlConnection  getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=THUYENTRUONGRON\VUAVUNGCAO;Database=hostel;Trusted_Connection=True;TrustServerCertificate=Yes;MultipleActiveResultSets=true";
            return con;
        }


        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public void setData(String query, String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
