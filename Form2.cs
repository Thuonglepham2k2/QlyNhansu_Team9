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
    public partial class Form2 : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public Form2(string tk)
        {
            InitializeComponent();
            lbUser.Text = tk;
        }
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isExit)
                Application.Exit();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser form1 = new FormUser();
            form1.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoimatkhau formdmk = new FormDoimatkhau();
            formdmk.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formtrogiup formtg = new Formtrogiup();
            formtg.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QlyNhansu1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TTNV", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvDSNV.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtManv.Text.Length == 0 && cbPhongban.Text.Length == 0 && txtHoten.Text.Length == 0 && txtHoten.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QlyNhansu1;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from TTNV where MaNV like '%" + txtManv.Text + "%' And MaPB like '%" + cbPhongban.Text + "%'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvDSNV.DataSource = dt;
            }
        }


        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTTNV f = new frmTTNV();
            f.ShowDialog();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongBan f = new frmPhongBan();
            f.ShowDialog();
        }

        private void chếĐộThaiSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchedothaisan f = new frmchedothaisan();
            f.ShowDialog();
        }

        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBP f = new FormBP();
            f.ShowDialog();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLuong f = new FormLuong();
            f.ShowDialog();
        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHoten.Text = dgvDSNV.CurrentRow.Cells[3].Value.ToString();
            cbPhongban.Text = dgvDSNV.CurrentRow.Cells[1].Value.ToString();
            txtManv.Text = dgvDSNV.CurrentRow.Cells[2].Value.ToString();
            dtNgaysinh.Text = dgvDSNV.CurrentRow.Cells[5].Value.ToString();
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThem f = new FormThem();
            f.ShowDialog();
        }

        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtHoten.Clear();
            txtManv.Clear();
            dtNgaysinh.Text = String.Empty;
            cbPhongban.Text = String.Empty;
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QlyNhansu1;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TTNV", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvDSNV.DataSource = dt;
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }  
}
