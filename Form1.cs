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

namespace QlyNhansu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SCLUTM;Initial Catalog=QLyNhanSu;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtUser.Text;
                string mk = txtPassword.Text;
                string sql = "select * from [User] where UserName='" + tk + "'and PassWord='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Form2 form = new Form2(tk);
                    form.Show();
                    this.Hide();
                    form.Logout += F_Logout;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                       
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }


        }
        private void F_Logout(object sender, EventArgs e)
        {
            (sender as Form2).isExit = false;
            (sender as Form2).Close();
            this.Show();
            txtUser.Clear();
            txtPassword.Clear();
            ckbShowpsw.Checked = false;
        }
        private void ckbShowpsw_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowpsw.Checked)
                txtPassword.UseSystemPasswordChar = false;
            if (!ckbShowpsw.Checked)
                txtPassword.UseSystemPasswordChar = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel);
            if (tb == DialogResult.OK)
                Application.Exit();
        }
    }
}
