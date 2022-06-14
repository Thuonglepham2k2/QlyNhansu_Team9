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
    public partial class FormBP : Form
    {
        static string constring = @"Data Source=DESKTOP-5SCLUTM;Initial Catalog=QlyNhansu1;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constring);
        public FormBP()
        {
            InitializeComponent();
        }

        private void XoaTextBox()
        {

            textBox_mabp.Clear();
            textBox_ghichu.Clear();
            textBox_mabp.Focus();

        }
        private void FormBP_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from BoPhan", conn);
                    cmd.ExecuteNonQuery();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            textBox_mabp.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox_ten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dateTime.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox_ghichu.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void button_them_Click(object sender, EventArgs e)
        {

            if (textBox_mabp.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comboBox_ten.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dateTime.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into BoPhan values(@mabophan,@tenbophan,@ngaylap,@ghichu)", conn);

                cmd.Parameters.AddWithValue("@mabophan", textBox_mabp.Text);
                cmd.Parameters.AddWithValue("@tenbophan", comboBox_ten.Text);
                cmd.Parameters.AddWithValue("@ngaylap", dateTime.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@ghichu", textBox_ghichu.Text);
                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                FormBP_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Update bophanns set mabophan=@mabophan,tenbophan=@tenbophan,ngaylap=@ngaylap,ghichu=@ghichu where mabophan=@mabophan", conn);

                cmd.Parameters.AddWithValue("@mabophan", textBox_mabp.Text);
                cmd.Parameters.AddWithValue("@tenbophan", comboBox_ten.Text);
                cmd.Parameters.AddWithValue("@ngaylap", dateTime.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@ghichu", textBox_ghichu.Text);
                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                FormBP_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from BoPhan where mabophan ='" + textBox_mabp.Text + "' ", conn);

                cmd.Parameters.AddWithValue("@mabophan", textBox_mabp.Text);

                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                FormBP_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
