using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Common
{
    class LopDungChung
    {
        SqlConnection conn;
        //GUI.frm_hoadon frmhd;
        string strChuoiKetNoi = @"Data Source=QUANGVU97;Initial Catalog=BikeStoreShopping;Integrated Security=True";
        //public Lopdungchung(GUI.frm_hoadon f)
        //{
        //    frmhd = f;
        //}

        public LopDungChung()
        {
            conn = new SqlConnection(strChuoiKetNoi);
        }

        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(strChuoiKetNoi);
            return conn;
        }

        public void Mo()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Dong()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            int ketqua = comm.ExecuteNonQuery();
            Dong();
            return ketqua;
        }
        public object ExcuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            object ketqua = comm.ExecuteScalar();
            Dong();
            return ketqua;
        }



        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
