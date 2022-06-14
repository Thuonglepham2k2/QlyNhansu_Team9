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
    public partial class frmchedothaisan : Form
    {
       
        public frmchedothaisan()
        {
            InitializeComponent();
            hienthiTS();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QlyNhansu1;Integrated Security=True");
        private void frmchedothaisan_Load(object sender, EventArgs e)
        {
            
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from ThaiSan", cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from ThaiSan", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTS.DataSource = dt;
            dtNS.CustomFormat = " dd/ MM / yyyy ";
            dtNNS.CustomFormat = "dd/ MM / yyyy ";
            dtNLTL.CustomFormat = " dd/MM / yyyy ";
           

        }
        public void hienthiTS()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from TTNV", cn);
            sda.Fill(dt);
            cbMaNV.DataSource = dt;
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";
            


        }

        public static DataTable GetData(string s)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QlyNhansu1;Integrated Security=True");
            DataTable table = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(s, cn);
            ad.Fill(table);
            return table;

        }
        private void btnThemTS_Click(object sender, EventArgs e)
        {
            if (txtMaBP.Text.Length == 0 || txtMaPB.Text.Length == 0 || cbMaNV.Text.Length == 0 || txtHoTen.Text.Length == 0 || dtNS.Text.Length == 0 || dtNNS.Text.Length == 0 || dtNLTL.Text.Length == 0 || txtTCCT.Text.Length == 0 || txtGC.Text.Length == 0 )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into ThaiSan Values ('" + txtMaBP.Text + "','" + txtMaPB.Text + "','" + cbMaNV.Text + "', N'" + txtHoTen.Text + "', N'" + dtNS.Text + "', N'" + dtNNS.Text + "', N'" + dtNLTL.Text + "', N'" + txtTCCT.Text + "', N'" + txtGC.Text + "');", cn);
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from ThaiSan", cn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvTS.DataSource = dt;
                }catch(Exception) 
                {
                    MessageBox.Show("Mã SV vừa nhập đã tồn tại");
                 }
                
            }
        }

        private void dgvTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBP.Text = dgvTS.CurrentRow.Cells[0].Value.ToString();
            txtMaPB.Text = dgvTS.CurrentRow.Cells[1].Value.ToString();
            cbMaNV.Text = dgvTS.CurrentRow.Cells[2].Value.ToString();
            txtHoTen.Text = dgvTS.CurrentRow.Cells[3].Value.ToString();
            dtNS.Text = dgvTS.CurrentRow.Cells[4].Value.ToString();
            dtNNS.Text = dgvTS.CurrentRow.Cells[5].Value.ToString();
            dtNLTL.Text = dgvTS.CurrentRow.Cells[6].Value.ToString();
            txtTCCT.Text = dgvTS.CurrentRow.Cells[7].Value.ToString();
            txtGC.Text = dgvTS.CurrentRow.Cells[8].Value.ToString();

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string str,s;
            DataTable tb = new DataTable();
            //MessageBox.Show(str);
            str ="select * from TTNV where MaNV = '"+cbMaNV.Text+"'";
             SqlDataAdapter sda = new SqlDataAdapter(str,cn);
             sda.Fill(tb);
            foreach(DataRow dr in tb.Rows)
            {
                txtMaBP.Text = dr["MaBoPhan"].ToString();
                txtMaPB.Text = dr["MaPB"].ToString();
                txtHoTen.Text = dr["HoTen"].ToString();
                dtNS.Text = dr["NgaySinh"].ToString();
            }

            s = "select * from ThaiSan  where MaNV = '" + cbMaNV.Text + "'";
            SqlDataAdapter sd = new SqlDataAdapter(s, cn);
            sd.Fill(tb);
            foreach (DataRow dr in tb.Rows)
            {
                dtNNS.Text = dr["NgayNghiSinh"].ToString();
                dtNLTL.Text = dr["NgayLamTroLai"].ToString();
                txtTCCT.Text = dr["TroCapCTY"].ToString();
                txtGC.Text = dr["Ghichu"].ToString();
            }


        }

        private void btnSuaTS_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update ThaiSan set HoTen=N'" + txtHoTen.Text + "',NgaySinh=N'" + dtNS.Text + "',NgayNghiSinh= N'" + dtNNS.Text + "',NgayLamTroLai=N'" + dtNLTL.Text + "',TroCapCTY= N'" + txtTCCT.Text + "',GhiChu= N'" + txtGC.Text + "'where MaNV=N'" + cbMaNV.Text + "'" , cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from ThaiSan", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTS.DataSource = dt;
        }

        private void btnXoaTS_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from ThaiSan where MaNV = N'" + cbMaNV.Text + "'", cn);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from ThaiSan", cn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTS.DataSource = dt;
        }

        private void btnKhoiTaoTS_Click(object sender, EventArgs e)
        {
            txtMaBP.Clear();
            txtMaPB.Clear();
            cbMaNV.Text = String.Empty;
            txtHoTen.Clear();
            dtNS.Text = DateTime.Now.ToString();
            dtNNS.Text = DateTime.Now.ToString();
            dtNLTL.Text = DateTime.Now.ToString();
            txtTCCT.Clear();
            txtGC.Clear();
           
        }

        private void btnThoatTS_Click(object sender, EventArgs e)
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
