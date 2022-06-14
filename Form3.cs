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
    public partial class FormDoimatkhau : Form
    {
        public FormDoimatkhau()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QLyNhanSu;Integrated Security=True");
        private void FormDoimatkhau_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        private void chkShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtMatkhaucu.UseSystemPasswordChar = false;
                txtMatkhaumoi.UseSystemPasswordChar = false;
                txtMatkhaulai.UseSystemPasswordChar = false;
            }
            if (!chkShowPass.Checked)
            {
                txtMatkhaucu.UseSystemPasswordChar = true;
                txtMatkhaumoi.UseSystemPasswordChar = true;
                txtMatkhaulai.UseSystemPasswordChar = true;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Length == 0 || txtMatkhaucu.Text.Length == 0 || txtMatkhaumoi.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from [User] where UserName like '%" + txtTenTK.Text + "%' and PassWord like '%" + txtMatkhaucu.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                errorProvider1.Clear();
                if (dt.Rows.Count > 0)
                {
                    if (txtMatkhaumoi.Text == txtMatkhaucu.Text)
                    {
                        errorProvider1.SetError(txtMatkhaumoi, " Mật khẩu đã được sử dụng!");
                    }
                    else
                    {
                        if (txtMatkhaumoi.Text == txtMatkhaulai.Text)
                        {
                            if (txtMatkhaumoi.Text.Length > 0)
                            {
                                SqlDataAdapter sda1 = new SqlDataAdapter("Update [User] set PassWord = N'" + txtMatkhaumoi.Text + "' where UserName = N'" + txtTenTK.Text + "' and PassWord = N'" + txtMatkhaucu.Text + "'", conn);
                                DataTable dt1 = new DataTable();
                                sda1.Fill(dt1);
                                MessageBox.Show("Đổi mật khẩu thành công !", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                errorProvider1.SetError(txtMatkhaumoi, " Độ dài mật khẩu không đủ!");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(txtMatkhaumoi, "Bạn chưa điền mật khẩu mới!");
                            errorProvider1.SetError(txtMatkhaulai, "Mật khẩu nhập lại chưa đúng!");
                        }
                    }
                }
                else
                {
                    errorProvider1.SetError(txtTenTK, "Tên tài khoản không đúng!");
                    errorProvider1.SetError(txtMatkhaucu, "Mật khẩu cũ không đúng!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTenTK.Clear();
            txtMatkhaucu.Clear();
            txtMatkhaumoi.Clear();
            txtMatkhaulai.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn hủy ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

