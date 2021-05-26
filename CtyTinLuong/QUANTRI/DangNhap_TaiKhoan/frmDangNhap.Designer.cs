namespace CtyTinLuong
{
    partial class frmDangNhap
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
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Image = global::CtyTinLuong.Properties.Resources.ico_Check;
            this.btOK.Location = new System.Drawing.Point(99, 83);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(94, 23);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "Đăng nhập";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(99, 6);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(165, 20);
            this.txtTen.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(99, 34);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(165, 20);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Image = global::CtyTinLuong.Properties.Resources.ico_Abort;
            this.btThoat.Location = new System.Drawing.Point(205, 83);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(216, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Hiện";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(291, 115);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btThoat;
        private DevExpress.XtraEditors.SimpleButton btOK;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

