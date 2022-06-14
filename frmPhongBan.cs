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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
            hienthiCB();

        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QlyNhansu1;Integrated Security=True");
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from PhongBan", cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from PhongBan", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPhongBan.DataSource = dt;
            
        }
        public void hienthiCB()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from BoPhan", cn);
            sda.Fill(dt);
            cbMaBP.DataSource = dt;
            cbMaBP.DisplayMember = "TenBoPhan";
            cbMaBP.ValueMember = "MaBoPhan";
        }
       
        private void btnThemPB_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Length == 0 || cbTenPB.Text.Length == 0 || txtVTPB.Text.Length == 0 || cbNVPB.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try {
                    SqlCommand cmd = new SqlCommand("insert into PhongBan Values ('" + cbMaBP.SelectedValue.ToString() + "','" + txtMaPB.Text + "', N'" + cbTenPB.Text + "', N'" + txtVTPB.Text + "', N'" + cbNVPB.Text + "');", cn);
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from PhongBan", cn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvPhongBan.DataSource = dt;
                }
                catch(Exception)
                {
                    MessageBox.Show("Mã PB vừa nhập đã tồn tại");
                }
               
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaBP.Text = dgvPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtMaPB.Text = dgvPhongBan.CurrentRow.Cells[1].Value.ToString();
            cbTenPB.Text = dgvPhongBan.CurrentRow.Cells[2].Value.ToString();
            txtVTPB.Text = dgvPhongBan.CurrentRow.Cells[3].Value.ToString();
            cbNVPB.Text = dgvPhongBan.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSuaPB_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update PhongBan set MaBoPhan=N'" + cbMaBP.Text + "',TenPB=N'" + cbTenPB.Text + "',ViTri=N'" + txtVTPB.Text + "',NhiemVu=N'" + cbNVPB.Text + "' where MaPB=N'" + txtMaPB.Text + "'", cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from PhongBan", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPhongBan.DataSource = dt;
        }

        private void btnXoaPB_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from PhongBan where MaPB = N'" + txtMaPB.Text + "'", cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from PhongBan", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPhongBan.DataSource = dt;
            txtMaPB.Text = "";
            cbTenPB.Text = "";
            txtVTPB.Text = "";
            cbNVPB.Text = "";

        }

        private void btnKhoiTaoPB_Click(object sender, EventArgs e)
        {
            cbMaBP.Text = String.Empty;
            txtMaPB.Clear();
            cbTenPB.Text = String.Empty;
            txtVTPB.Clear();
            cbNVPB.Text = String.Empty;
        }

        private void btnThoatPB_Click(object sender, EventArgs e)
        {
            DialogResult rf = MessageBox.Show("Bạn có muốn thoát không ??? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rf == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
