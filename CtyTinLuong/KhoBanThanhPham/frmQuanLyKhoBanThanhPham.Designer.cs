namespace CtyTinLuong
{
    partial class frmQuanLyKhoBanThanhPham
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
            this.btThooat = new DevExpress.XtraEditors.SimpleButton();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem25 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navXuatKhoRaDaiLyGiaCong = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_XK_LSX_I_C_D = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navDaXuatKho = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navXuatKhoGapDan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navDaNhapKho = new DevExpress.XtraNavBar.NavBarItem();
            this.NK_LSX_In_Cat_Dot = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navNhapKhoDaiLy2222222222222 = new DevExpress.XtraNavBar.NavBarItem();
            this.navNhapKhoGapDan = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btThooat
            // 
            this.btThooat.ImageOptions.Image = global::CtyTinLuong.Properties.Resources.ico_Abort;
            this.btThooat.Location = new System.Drawing.Point(1013, 626);
            this.btThooat.Name = "btThooat";
            this.btThooat.Size = new System.Drawing.Size(75, 23);
            this.btThooat.TabIndex = 67;
            this.btThooat.Text = "Thoát";
            this.btThooat.Click += new System.EventHandler(this.btThooat_Click);
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "6. Chính thức";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.Tag = "Chính thức";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "5. Thử việc";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.Tag = "Thử việc";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "4. Học việc";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.Tag = "Học việc";
            // 
            // navBarItem25
            // 
            this.navBarItem25.Caption = "* Tất cả";
            this.navBarItem25.Name = "navBarItem25";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Báo cáo";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "Báo cáo NXT";
            this.navBarItem12.Name = "navBarItem12";
            this.navBarItem12.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem12_LinkClicked);
            // 
            // navXuatKhoRaDaiLyGiaCong
            // 
            this.navXuatKhoRaDaiLyGiaCong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navXuatKhoRaDaiLyGiaCong.Appearance.Options.UseFont = true;
            this.navXuatKhoRaDaiLyGiaCong.Caption = "Xuất kho ra Đại lý";
            this.navXuatKhoRaDaiLyGiaCong.Name = "navXuatKhoRaDaiLyGiaCong";
            this.navXuatKhoRaDaiLyGiaCong.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // nav_XK_LSX_I_C_D
            // 
            this.nav_XK_LSX_I_C_D.Caption = "XK LSX I-C-Đ";
            this.nav_XK_LSX_I_C_D.Name = "nav_XK_LSX_I_C_D";
            this.nav_XK_LSX_I_C_D.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem7_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Xuất Kho";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nav_XK_LSX_I_C_D),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navXuatKhoRaDaiLyGiaCong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDaXuatKho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navXuatKhoGapDan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navDaXuatKho
            // 
            this.navDaXuatKho.Caption = "Đã xuất kho";
            this.navDaXuatKho.Name = "navDaXuatKho";
            this.navDaXuatKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem8_LinkClicked);
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "Chi tiết đã xuất kho _ALL";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem11_LinkClicked);
            // 
            // navXuatKhoGapDan
            // 
            this.navXuatKhoGapDan.Caption = "Xuất kho gấp dán";
            this.navXuatKhoGapDan.Name = "navXuatKhoGapDan";
            this.navXuatKhoGapDan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navXuatKhoGapDan_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Xuất kho _ Khác";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked_1);
            // 
            // navDaNhapKho
            // 
            this.navDaNhapKho.Caption = "Đã nhập kho";
            this.navDaNhapKho.Name = "navDaNhapKho";
            this.navDaNhapKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // NK_LSX_In_Cat_Dot
            // 
            this.NK_LSX_In_Cat_Dot.Caption = "NK LSX I_C_Đ";
            this.NK_LSX_In_Cat_Dot.Name = "NK_LSX_In_Cat_Dot";
            this.NK_LSX_In_Cat_Dot.Tag = "Ban Giám đốc";
            this.NK_LSX_In_Cat_Dot.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Nhập kho";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.NK_LSX_In_Cat_Dot),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDaNhapKho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navNhapKhoDaiLy2222222222222),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navNhapKhoGapDan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "Chi tiết đã nhập kho _ALL";
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem10_LinkClicked);
            // 
            // navNhapKhoDaiLy2222222222222
            // 
            this.navNhapKhoDaiLy2222222222222.Caption = "Nhập kho từ Đại lý";
            this.navNhapKhoDaiLy2222222222222.Name = "navNhapKhoDaiLy2222222222222";
            this.navNhapKhoDaiLy2222222222222.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navNhapKhoDaiLy_LinkClicked);
            // 
            // navNhapKhoGapDan
            // 
            this.navNhapKhoGapDan.Caption = "Nhập kho gấp dán";
            this.navNhapKhoGapDan.Name = "navNhapKhoGapDan";
            this.navNhapKhoGapDan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navNhapKhoGapDan_LinkClicked);
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Nhập kho _ Khác";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked_1);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup3,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.NK_LSX_In_Cat_Dot,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem25,
            this.navDaNhapKho,
            this.nav_XK_LSX_I_C_D,
            this.navXuatKhoRaDaiLyGiaCong,
            this.navDaXuatKho,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem12,
            this.navXuatKhoGapDan,
            this.navNhapKhoDaiLy2222222222222,
            this.navNhapKhoGapDan,
            this.navBarItem2,
            this.navBarItem3});
            this.navBarControl1.Location = new System.Drawing.Point(6, 13);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 180;
            this.navBarControl1.Size = new System.Drawing.Size(180, 606);
            this.navBarControl1.TabIndex = 66;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(192, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(900, 606);
            this.panelControl1.TabIndex = 68;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 631);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 13);
            this.linkLabel1.TabIndex = 69;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cài mặc định người ký";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmQuanLyKhoBanThanhPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btThooat);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyKhoBanThanhPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Bán Thành Phẩm";
            this.Load += new System.EventHandler(this.frmQuanLyKhoBanThanhPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btThooat;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem25;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navXuatKhoRaDaiLyGiaCong;
        private DevExpress.XtraNavBar.NavBarItem nav_XK_LSX_I_C_D;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navDaXuatKho;
        private DevExpress.XtraNavBar.NavBarItem navDaNhapKho;
        private DevExpress.XtraNavBar.NavBarItem NK_LSX_In_Cat_Dot;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraNavBar.NavBarItem navXuatKhoGapDan;
        private DevExpress.XtraNavBar.NavBarItem navNhapKhoDaiLy2222222222222;
        private DevExpress.XtraNavBar.NavBarItem navNhapKhoGapDan;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}