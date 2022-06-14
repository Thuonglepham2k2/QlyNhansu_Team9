namespace QlyNhansu
{
    partial class frmPhongBan
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
            this.cbMaBP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNVPB = new System.Windows.Forms.ComboBox();
            this.cbTenPB = new System.Windows.Forms.ComboBox();
            this.txtVTPB = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.lable5 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKhoiTaoPB = new System.Windows.Forms.Button();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.btnThoatPB = new System.Windows.Forms.Button();
            this.btnXoaPB = new System.Windows.Forms.Button();
            this.btnSuaPB = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaBP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbNVPB);
            this.groupBox1.Controls.Add(this.cbTenPB);
            this.groupBox1.Controls.Add(this.txtVTPB);
            this.groupBox1.Controls.Add(this.txtMaPB);
            this.groupBox1.Controls.Add(this.lable5);
            this.groupBox1.Controls.Add(this.lable3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Phòng Ban";
            // 
            // cbMaBP
            // 
            this.cbMaBP.FormattingEnabled = true;
            this.cbMaBP.Location = new System.Drawing.Point(113, 35);
            this.cbMaBP.Name = "cbMaBP";
            this.cbMaBP.Size = new System.Drawing.Size(196, 21);
            this.cbMaBP.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã Bộ Phận";
            // 
            // cbNVPB
            // 
            this.cbNVPB.FormattingEnabled = true;
            this.cbNVPB.Items.AddRange(new object[] {
            "Quản lý tài sản",
            "Đại diện quyền lợi của CT",
            "Nhận TT  của khách hàng",
            "Ký kết các văn bản hợp tác",
            "Xây dựng và quản lý hệ thống chăm sóc khách hàng"});
            this.cbNVPB.Location = new System.Drawing.Point(274, 112);
            this.cbNVPB.Name = "cbNVPB";
            this.cbNVPB.Size = new System.Drawing.Size(196, 21);
            this.cbNVPB.TabIndex = 7;
            // 
            // cbTenPB
            // 
            this.cbTenPB.FormattingEnabled = true;
            this.cbTenPB.Items.AddRange(new object[] {
            "Tài chính",
            "Phòng Đại diện",
            "Phòng Marketing",
            "Phòng Quan hệ quốc tế",
            "Phòng chăm sóc khách hàng"});
            this.cbTenPB.Location = new System.Drawing.Point(483, 30);
            this.cbTenPB.Name = "cbTenPB";
            this.cbTenPB.Size = new System.Drawing.Size(200, 21);
            this.cbTenPB.TabIndex = 6;
            // 
            // txtVTPB
            // 
            this.txtVTPB.Location = new System.Drawing.Point(483, 75);
            this.txtVTPB.Name = "txtVTPB";
            this.txtVTPB.Size = new System.Drawing.Size(200, 20);
            this.txtVTPB.TabIndex = 5;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(113, 78);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(196, 20);
            this.txtMaPB.TabIndex = 4;
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(204, 120);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(53, 13);
            this.lable5.TabIndex = 3;
            this.lable5.Text = "Nhiệm Vụ";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(422, 78);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(35, 13);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "Ví Trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng Ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoatPB);
            this.groupBox2.Controls.Add(this.btnKhoiTaoPB);
            this.groupBox2.Controls.Add(this.btnXoaPB);
            this.groupBox2.Controls.Add(this.btnSuaPB);
            this.groupBox2.Controls.Add(this.btnThemPB);
            this.groupBox2.Location = new System.Drawing.Point(30, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnKhoiTaoPB
            // 
            this.btnKhoiTaoPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoiTaoPB.Location = new System.Drawing.Point(463, 28);
            this.btnKhoiTaoPB.Name = "btnKhoiTaoPB";
            this.btnKhoiTaoPB.Size = new System.Drawing.Size(112, 23);
            this.btnKhoiTaoPB.TabIndex = 3;
            this.btnKhoiTaoPB.Text = "Khởi tạo";
            this.btnKhoiTaoPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhoiTaoPB.UseVisualStyleBackColor = true;
            this.btnKhoiTaoPB.Click += new System.EventHandler(this.btnKhoiTaoPB_Click);
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(30, 285);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(733, 121);
            this.dgvPhongBan.TabIndex = 2;
            this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
            // 
            // btnThoatPB
            // 
            this.btnThoatPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatPB.Location = new System.Drawing.Point(607, 28);
            this.btnThoatPB.Name = "btnThoatPB";
            this.btnThoatPB.Size = new System.Drawing.Size(107, 23);
            this.btnThoatPB.TabIndex = 4;
            this.btnThoatPB.Text = "Thoát";
            this.btnThoatPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatPB.UseVisualStyleBackColor = true;
            this.btnThoatPB.Click += new System.EventHandler(this.btnThoatPB_Click);
            // 
            // btnXoaPB
            // 
            this.btnXoaPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPB.Location = new System.Drawing.Point(306, 28);
            this.btnXoaPB.Name = "btnXoaPB";
            this.btnXoaPB.Size = new System.Drawing.Size(125, 23);
            this.btnXoaPB.TabIndex = 2;
            this.btnXoaPB.Text = "Xóa";
            this.btnXoaPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPB.UseVisualStyleBackColor = true;
            this.btnXoaPB.Click += new System.EventHandler(this.btnXoaPB_Click);
            // 
            // btnSuaPB
            // 
            this.btnSuaPB.Location = new System.Drawing.Point(158, 28);
            this.btnSuaPB.Name = "btnSuaPB";
            this.btnSuaPB.Size = new System.Drawing.Size(112, 23);
            this.btnSuaPB.TabIndex = 1;
            this.btnSuaPB.Text = "Sửa ";
            this.btnSuaPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaPB.UseVisualStyleBackColor = true;
            this.btnSuaPB.Click += new System.EventHandler(this.btnSuaPB_Click);
            // 
            // btnThemPB
            // 
            this.btnThemPB.Location = new System.Drawing.Point(20, 28);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(102, 23);
            this.btnThemPB.TabIndex = 0;
            this.btnThemPB.Text = "Thêm";
            this.btnThemPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPB.UseVisualStyleBackColor = true;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhongBan";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNVPB;
        private System.Windows.Forms.ComboBox cbTenPB;
        private System.Windows.Forms.TextBox txtVTPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoatPB;
        private System.Windows.Forms.Button btnKhoiTaoPB;
        private System.Windows.Forms.Button btnXoaPB;
        private System.Windows.Forms.Button btnSuaPB;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.ComboBox cbMaBP;
        private System.Windows.Forms.Label label4;
    }
}