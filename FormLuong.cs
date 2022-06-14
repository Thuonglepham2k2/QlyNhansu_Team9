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
    public partial class FormLuong : Form
    {
        static string constring = @"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QLyNhanSu;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constring);
        public FormLuong()
        {
            InitializeComponent();
        }
        private void XoaTextBox()
        {
            textBox_maluong.Clear();
            textBox_mabp.Clear();
            textBox_luongcb.Clear();
            textBox_luongpc.Clear();
            textBox_ghichu.Clear();
            textBox_maluong.Focus();

        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Update luongns set maluong=@maluong,mabophan=@mabophan,luongcb=@luongcb,phucap=@phucap,ghichu=@ghichu where maluong=@maluong", conn);
                cmd.Parameters.AddWithValue("@maluong", textBox_maluong.Text);
                cmd.Parameters.AddWithValue("@mabophan", textBox_mabp.Text);
                cmd.Parameters.AddWithValue("@luongcb", int.Parse(textBox_luongcb.Text));
                cmd.Parameters.AddWithValue("@phucap", int.Parse(textBox_luongpc.Text));
                cmd.Parameters.AddWithValue("@ghichu", textBox_ghichu.Text);
                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                FormLuong_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FormLuong_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from luongns", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_them_Click_1(object sender, EventArgs e)
        {
            if (textBox_maluong.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox_mabp.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox_luongcb.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (textBox_luongpc.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox_maluong.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox_mabp.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textBox_luongcb.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (textBox_luongpc.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into luongns values(@maluong,@MaBoPhan,@luongcb,@phucap,@ghichu)", conn);
                cmd.Parameters.AddWithValue("@maluong", textBox_maluong.Text);
                cmd.Parameters.AddWithValue("@MaBoPhan", textBox_mabp.Text);
                cmd.Parameters.AddWithValue("@luongcb", int.Parse(textBox_luongcb.Text));
                cmd.Parameters.AddWithValue("@phucap", int.Parse(textBox_luongpc.Text));
                cmd.Parameters.AddWithValue("@ghichu", textBox_ghichu.Text);
                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                FormLuong_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox_maluong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox_mabp.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox_luongcb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox_luongpc.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox_ghichu.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button_sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Update luongns set maluong=@maluong,mabophan=@mabophan,luongcb=@luongcb,phucap=@phucap,ghichu=@ghichu where maluong=@maluong", conn);
                cmd.Parameters.AddWithValue("@maluong", textBox_maluong.Text);
                cmd.Parameters.AddWithValue("@mabophan", textBox_mabp.Text);
                cmd.Parameters.AddWithValue("@luongcb", int.Parse(textBox_luongcb.Text));
                cmd.Parameters.AddWithValue("@phucap", int.Parse(textBox_luongpc.Text));
                cmd.Parameters.AddWithValue("@ghichu", textBox_ghichu.Text);
                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                FormLuong_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from luongns where maluong='" + textBox_maluong.Text + "'", conn);

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                FormLuong_Load(sender, e);
                XoaTextBox();

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_timkiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("select *from luongns where maluong=@maluong ", conn);
                cmd.Parameters.AddWithValue("@maluong", textBox_maluong.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                //Form1_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
