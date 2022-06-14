namespace QlyNhansu
{
    partial class FormBP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ghichu = new System.Windows.Forms.TextBox();
            this.textBox_mabp = new System.Windows.Forms.TextBox();
            this.comboBox_ten = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ghichu);
            this.groupBox1.Controls.Add(this.textBox_mabp);
            this.groupBox1.Controls.Add(this.comboBox_ten);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(437, 315);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các thông tin về bộ phận";
            // 
            // textBox_ghichu
            // 
            this.textBox_ghichu.Location = new System.Drawing.Point(141, 224);
            this.textBox_ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ghichu.Name = "textBox_ghichu";
            this.textBox_ghichu.Size = new System.Drawing.Size(199, 22);
            this.textBox_ghichu.TabIndex = 7;
            // 
            // textBox_mabp
            // 
            this.textBox_mabp.Location = new System.Drawing.Point(141, 52);
            this.textBox_mabp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_mabp.Name = "textBox_mabp";
            this.textBox_mabp.Size = new System.Drawing.Size(160, 22);
            this.textBox_mabp.TabIndex = 6;
            // 
            // comboBox_ten
            // 
            this.comboBox_ten.FormattingEnabled = true;
            this.comboBox_ten.Items.AddRange(new object[] {
            "Kế Toán",
            "Bảo Vệ",
            "Giám Đốc"});
            this.comboBox_ten.Location = new System.Drawing.Point(141, 108);
            this.comboBox_ten.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_ten.Name = "comboBox_ten";
            this.comboBox_ten.Size = new System.Drawing.Size(160, 24);
            this.comboBox_ten.TabIndex = 5;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(141, 160);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(265, 22);
            this.dateTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Bộ Phận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bộ Phận";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(492, 45);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(572, 382);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết về bộ phận";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(556, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.Color.LightCoral;
            this.button_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoa.Location = new System.Drawing.Point(337, 398);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(100, 28);
            this.button_xoa.TabIndex = 8;
            this.button_xoa.Text = "Xoá";
            this.button_xoa.UseVisualStyleBackColor = false;
            // 
            // button_sua
            // 
            this.button_sua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_sua.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_sua.Location = new System.Drawing.Point(170, 398);
            this.button_sua.Margin = new System.Windows.Forms.Padding(4);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(100, 28);
            this.button_sua.TabIndex = 7;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = false;
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.SystemColors.Info;
            this.button_them.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_them.Location = new System.Drawing.Point(29, 398);
            this.button_them.Margin = new System.Windows.Forms.Padding(4);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(100, 28);
            this.button_them.TabIndex = 6;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            // 
            // FormBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Name = "FormBP";
            this.Text = "FormBP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ghichu;
        private System.Windows.Forms.TextBox textBox_mabp;
        private System.Windows.Forms.ComboBox comboBox_ten;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
    }
}