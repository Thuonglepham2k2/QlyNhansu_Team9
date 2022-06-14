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
    public partial class frmTTNV : Form
    {
        public frmTTNV()
        {
            InitializeComponent();
            hienthiPBan();
            hienthiBP();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QlyNhansu1;Integrated Security=True");
        private void frmTTNV_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from TTNV", cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TTNV", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvNV.DataSource = dt;

        }
        public void hienthiPBan()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from PhongBan", cn);
            sda.Fill(dt);
            cbMaPB.DataSource = dt;
            cbMaPB.DisplayMember = "MaPB";
            cbMaPB.ValueMember = "MaPB";
        }
        public void hienthiBP()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from BoPhan", cn);
            sda.Fill(dt);
            cbMaBP.DataSource = dt;
            cbMaBP.DisplayMember = "MaBP";
            cbMaBP.ValueMember = "MaBoPhan";
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (cbMaBP.Text.Length == 0 || cbMaPB.Text.Length == 0 || txtMaNV.Text.Length == 0 || txtHoTen.Text.Length == 0 || cbNoiSinh.Text.Length == 0 || dtNS.Text.Length == 0 || cbGioiTinh.Text.Length == 0 || txtTTHN.Text.Length == 0 || txtCMTND.Text.Length == 0 || txtNC.Text.Length == 0 || txtChucVu.Text.Length == 0 || txtTĐHV.Text.Length == 0 || txtTG.Text.Length == 0 || dtNgayKy.Text.Length == 0 || dtNHH.Text.Length == 0 || txtGC.Text.Length == 0 )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try {
                    SqlCommand cmd = new SqlCommand("insert into TTNV Values ('" + cbMaBP.SelectedValue.ToString() + "','" + cbMaPB.SelectedValue.ToString() + "','" + txtMaNV.Text + "', N'" + txtHoTen.Text + "', N'" + cbNoiSinh.Text + "', N'" + dtNS.Text + "', N'" + cbGioiTinh.Text + "', N'" + txtTTHN.Text + "', N'" + txtCMTND.Text + "', N'" + txtNC.Text + "', N'" + txtChucVu.Text + "', N'" + txtTĐHV.Text + "', N'" + txtTG.Text + "', N'" + dtNgayKy.Text + "', N'" + dtNHH.Text + "', N'" + txtGC.Text + "');", cn);
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from TTNV", cn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvNV.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã NV vừa nhập đã tồn tại");
                }
                
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaBP.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            cbMaPB.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            txtMaNV.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
            txtHoTen.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            cbNoiSinh.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            dtNS.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
            cbGioiTinh.Text = dgvNV.CurrentRow.Cells[6].Value.ToString();
            txtTTHN.Text = dgvNV.CurrentRow.Cells[7].Value.ToString();
            txtCMTND.Text = dgvNV.CurrentRow.Cells[8].Value.ToString();
            txtNC.Text = dgvNV.CurrentRow.Cells[9].Value.ToString();
            txtChucVu.Text = dgvNV.CurrentRow.Cells[10].Value.ToString();
            txtTĐHV.Text = dgvNV.CurrentRow.Cells[11].Value.ToString();
            txtTG.Text = dgvNV.CurrentRow.Cells[11].Value.ToString();
            dtNgayKy.Text = dgvNV.CurrentRow.Cells[13].Value.ToString();
            dtNHH.Text = dgvNV.CurrentRow.Cells[14].Value.ToString();
            txtGC.Text = dgvNV.CurrentRow.Cells[15].Value.ToString();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TTNV set MaBoPhan='" + cbMaBP.SelectedValue.ToString() + "',MaPB='" + cbMaPB.SelectedValue.ToString() + "',HoTen=N'" + txtHoTen.Text + "',NoiSinh=N'" + cbNoiSinh.Text + "',NgaySinh= N'" + dtNS.Text + "',GioiTinh=N'" + cbGioiTinh.Text + "',TTHonNhan = N'" + txtTTHN.Text + "',CMTND= N'" + txtCMTND.Text + "',NoiCap= N'" + txtNC.Text + "',ChucVu= N'" + txtChucVu.Text + "',TĐHocVan= N'" + txtTĐHV.Text + "',ThoiGian = N'" + txtTG.Text + "',NgayKy= N'" + dtNgayKy.Text + "',NgayHetHan= N'" + dtNHH.Text + "',GhiChu = N'" + txtGC.Text + "' where MaNV=N'" + txtMaNV.Text + "'", cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TTNV", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvNV.DataSource = dt;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from TTNV where MaNV = N'" + txtMaNV.Text + "'", cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TTNV", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvNV.DataSource = dt;

        }

        private void btnKhoiTaoNV_Click(object sender, EventArgs e)
        {
            cbMaBP.Text = String.Empty;
            cbMaPB.Text = String.Empty;
            txtMaNV.Clear();
            txtHoTen.Clear();
            cbNoiSinh.Text = String.Empty;
            dtNS.Text = DateTime.Now.ToString();
            cbGioiTinh.Text = String.Empty;
            txtTTHN.Clear();
            txtCMTND.Clear();
            txtNC.Clear();
            txtChucVu.Clear();
            txtTĐHV.Clear();
            txtTG.Text = String.Empty;
            dtNgayKy.Text = DateTime.Now.ToString();
            dtNHH.Text = String.Empty;
            txtGC.Clear();
        }

        private void btnThoatNV_Click(object sender, EventArgs e)
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
