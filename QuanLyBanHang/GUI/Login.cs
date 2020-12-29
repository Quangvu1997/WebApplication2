using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Common;

namespace QuanLyBanHang.GUI
{
    public partial class Login : Form
    {
        LopDungChung lopDungChung = new LopDungChung();
        

        public Login()
        {
            InitializeComponent();
        }
            
        int dem = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string strChuoiKetNoi = @"Data Source=.;Initial Catalog=BikeStoreShopping;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strChuoiKetNoi);
            string sql = @"SELECT * FROM [BikeStoreShopping].[nhan_vien].[nhan_viens] WHERE TaiKhoan = '" + txt_taikhoan.Text + "' AND Password = '" + txt_matkhau.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read() == true)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                dem++;
                MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes) { Application.Exit(); }

        }  
    }
}
