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
    public partial class FormUser : Form
    {
        int index = -1;
        public void loadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SCLUTM;Initial Catalog=QLyNhanSu;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [User]", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvListUser.DataSource = dt;
        }
        public FormUser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SCLUTM;Initial Catalog=QLyNhanSu;Integrated Security=True");
        private void FormUser_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SCLUTM;Initial Catalog=QLyNhanSu;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [User]", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvListUser.DataSource = dt;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0 || cbType.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into [User] Values ('" + txtUsername.Text + "', N'" + txtPassword.Text + "', N'" + cbType.Text + "');", con);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from [User]", con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvListUser.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Tài khoản vừa nhập đã tồn tại");
                }

            }
        }

        private void dgvListUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dgvListUser.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgvListUser.CurrentRow.Cells[1].Value.ToString();
            cbType.Text = dgvListUser.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update [User] set UserName=N'" + txtUsername.Text + "',PassWord=N'" + txtPassword.Text + "',Type=N'" + cbType.Text + "' where UserName=N'" + txtUsername.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [User]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvListUser.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from [User] where UserName = N'" + txtUsername.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [User]", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvListUser.DataSource = dt;
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbType.Text = "";
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cbType.Text = String.Empty;
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QLyNhanSu;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [User] where UserName like '%" + txtUsername.Text + "%' and Type like '%" + cbType.Text + "%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvListUser.DataSource = dt;
        }
    }
}
