namespace QlyNhansu
{
    partial class FormDoimatkhau
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtMatkhaulai = new System.Windows.Forms.TextBox();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShowPass);
            this.groupBox1.Controls.Add(this.txtTenTK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.txtMatkhaulai);
            this.groupBox1.Controls.Add(this.txtMatkhaumoi);
            this.groupBox1.Controls.Add(this.txtMatkhaucu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(649, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(252, 285);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(163, 25);
            this.chkShowPass.TabIndex = 8;
            this.chkShowPass.Text = "Hiển thị mật khẩu";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged_1);
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(252, 64);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(351, 28);
            this.txtTenTK.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên tài khoản";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(512, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Nhập lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(55, 379);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(91, 33);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Hoàn tất";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtMatkhaulai
            // 
            this.txtMatkhaulai.Location = new System.Drawing.Point(252, 221);
            this.txtMatkhaulai.Name = "txtMatkhaulai";
            this.txtMatkhaulai.Size = new System.Drawing.Size(351, 28);
            this.txtMatkhaulai.TabIndex = 7;
            this.txtMatkhaulai.UseSystemPasswordChar = true;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(252, 166);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(351, 28);
            this.txtMatkhaumoi.TabIndex = 5;
            this.txtMatkhaumoi.UseSystemPasswordChar = true;
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Location = new System.Drawing.Point(252, 116);
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(351, 28);
            this.txtMatkhaucu.TabIndex = 3;
            this.txtMatkhaucu.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đổi mật khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDoimatkhau_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtMatkhaulai;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.TextBox txtMatkhaucu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}