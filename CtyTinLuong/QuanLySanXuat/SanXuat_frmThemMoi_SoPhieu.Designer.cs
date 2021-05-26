namespace CtyTinLuong
{
    partial class SanXuat_frmThemMoi_SoPhieu
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
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenCaTruong = new System.Windows.Forms.TextBox();
            this.gridMaCaTruong = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clID_NhanSuCaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMaNhanVienCaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNhanVienCaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbCaLamViec = new System.Windows.Forms.ComboBox();
            this.dteNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btLuu_gui_Copy = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu_Gui_Dong = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaCaTruong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // btLuu
            // 
            this.btLuu.Image = global::CtyTinLuong.Properties.Resources.ico_Save;
            this.btLuu.Location = new System.Drawing.Point(445, 232);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(128, 23);
            this.btLuu.TabIndex = 72;
            this.btLuu.Text = "Chỉ Lưu và đóng";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThoat
            // 
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.Image = global::CtyTinLuong.Properties.Resources.ico_Abort;
            this.btThoat.Location = new System.Drawing.Point(579, 232);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 71;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 214);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtGhiChu);
            this.layoutControl1.Controls.Add(this.txtTenCaTruong);
            this.layoutControl1.Controls.Add(this.gridMaCaTruong);
            this.layoutControl1.Controls.Add(this.cbCaLamViec);
            this.layoutControl1.Controls.Add(this.dteNgayLap);
            this.layoutControl1.Controls.Add(this.txtMaPhieu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 16);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(636, 195);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(72, 123);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(562, 70);
            this.txtGhiChu.TabIndex = 12;
            // 
            // txtTenCaTruong
            // 
            this.txtTenCaTruong.Location = new System.Drawing.Point(72, 99);
            this.txtTenCaTruong.Name = "txtTenCaTruong";
            this.txtTenCaTruong.ReadOnly = true;
            this.txtTenCaTruong.Size = new System.Drawing.Size(562, 20);
            this.txtTenCaTruong.TabIndex = 11;
            // 
            // gridMaCaTruong
            // 
            this.gridMaCaTruong.Location = new System.Drawing.Point(72, 75);
            this.gridMaCaTruong.Name = "gridMaCaTruong";
            this.gridMaCaTruong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridMaCaTruong.Properties.View = this.gridLookUpEdit4View;
            this.gridMaCaTruong.Size = new System.Drawing.Size(245, 20);
            this.gridMaCaTruong.StyleController = this.layoutControl1;
            this.gridMaCaTruong.TabIndex = 10;
            this.gridMaCaTruong.EditValueChanged += new System.EventHandler(this.gridMaCaTruong_EditValueChanged);
            // 
            // gridLookUpEdit4View
            // 
            this.gridLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clID_NhanSuCaTruong,
            this.clMaNhanVienCaTruong,
            this.clTenNhanVienCaTruong});
            this.gridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit4View.Name = "gridLookUpEdit4View";
            this.gridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // clID_NhanSuCaTruong
            // 
            this.clID_NhanSuCaTruong.Caption = "ID";
            this.clID_NhanSuCaTruong.FieldName = "ID_NhanSu";
            this.clID_NhanSuCaTruong.Name = "clID_NhanSuCaTruong";
            // 
            // clMaNhanVienCaTruong
            // 
            this.clMaNhanVienCaTruong.Caption = "Mã";
            this.clMaNhanVienCaTruong.FieldName = "MaNhanVien";
            this.clMaNhanVienCaTruong.Name = "clMaNhanVienCaTruong";
            this.clMaNhanVienCaTruong.Visible = true;
            this.clMaNhanVienCaTruong.VisibleIndex = 0;
            this.clMaNhanVienCaTruong.Width = 60;
            // 
            // clTenNhanVienCaTruong
            // 
            this.clTenNhanVienCaTruong.Caption = "Họ tên";
            this.clTenNhanVienCaTruong.FieldName = "TenNhanVien";
            this.clTenNhanVienCaTruong.Name = "clTenNhanVienCaTruong";
            this.clTenNhanVienCaTruong.Visible = true;
            this.clTenNhanVienCaTruong.VisibleIndex = 1;
            this.clTenNhanVienCaTruong.Width = 200;
            // 
            // cbCaLamViec
            // 
            this.cbCaLamViec.FormattingEnabled = true;
            this.cbCaLamViec.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2"});
            this.cbCaLamViec.Location = new System.Drawing.Point(72, 50);
            this.cbCaLamViec.Name = "cbCaLamViec";
            this.cbCaLamViec.Size = new System.Drawing.Size(307, 21);
            this.cbCaLamViec.TabIndex = 6;
            // 
            // dteNgayLap
            // 
            this.dteNgayLap.EditValue = null;
            this.dteNgayLap.Location = new System.Drawing.Point(72, 26);
            this.dteNgayLap.Name = "dteNgayLap";
            this.dteNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayLap.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dteNgayLap.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dteNgayLap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteNgayLap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteNgayLap.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteNgayLap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteNgayLap.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNgayLap.Size = new System.Drawing.Size(245, 20);
            this.dteNgayLap.StyleController = this.layoutControl1;
            this.dteNgayLap.TabIndex = 5;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(72, 2);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(243, 20);
            this.txtMaPhieu.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem18,
            this.layoutControlItem2,
            this.layoutControlItem19,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlItem31,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(636, 195);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaPhieu;
            this.layoutControlItem1.CustomizationFormText = "Mã Phiếu";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(317, 24);
            this.layoutControlItem1.Text = "Mã Phiếu";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.gridMaCaTruong;
            this.layoutControlItem18.CustomizationFormText = "Mã ca  trưởng";
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem18.Text = "Mã ca  trưởng";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dteNgayLap;
            this.layoutControlItem2.CustomizationFormText = "Ngày lập";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(319, 24);
            this.layoutControlItem2.Text = "Ngày lập";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(67, 13);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.txtTenCaTruong;
            this.layoutControlItem19.CustomizationFormText = "Họ tên";
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 97);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(636, 24);
            this.layoutControlItem19.Text = "Họ tên";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(67, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(319, 73);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(317, 24);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(381, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(255, 25);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbCaLamViec;
            this.layoutControlItem3.CustomizationFormText = "Ca làm việc";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(381, 25);
            this.layoutControlItem3.Text = "Ca sản xuất";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(67, 13);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(319, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(317, 24);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.txtGhiChu;
            this.layoutControlItem31.CustomizationFormText = "Ghi chú";
            this.layoutControlItem31.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(636, 74);
            this.layoutControlItem31.Text = "Ghi chú";
            this.layoutControlItem31.TextSize = new System.Drawing.Size(67, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(317, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(319, 24);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btLuu_gui_Copy
            // 
            this.btLuu_gui_Copy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu_gui_Copy.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btLuu_gui_Copy.Appearance.Options.UseFont = true;
            this.btLuu_gui_Copy.Appearance.Options.UseForeColor = true;
            this.btLuu_gui_Copy.Image = global::CtyTinLuong.Properties.Resources.ico_Save;
            this.btLuu_gui_Copy.Location = new System.Drawing.Point(12, 232);
            this.btLuu_gui_Copy.Name = "btLuu_gui_Copy";
            this.btLuu_gui_Copy.Size = new System.Drawing.Size(242, 23);
            this.btLuu_gui_Copy.TabIndex = 74;
            this.btLuu_gui_Copy.Text = "Lưu + Gửi dữ liệu + Copy và tạo mới";
            this.btLuu_gui_Copy.Click += new System.EventHandler(this.btLuuVaCopy_Click);
            // 
            // btLuu_Gui_Dong
            // 
            this.btLuu_Gui_Dong.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu_Gui_Dong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btLuu_Gui_Dong.Appearance.Options.UseFont = true;
            this.btLuu_Gui_Dong.Appearance.Options.UseForeColor = true;
            this.btLuu_Gui_Dong.Image = global::CtyTinLuong.Properties.Resources.ico_Save;
            this.btLuu_Gui_Dong.Location = new System.Drawing.Point(260, 232);
            this.btLuu_Gui_Dong.Name = "btLuu_Gui_Dong";
            this.btLuu_Gui_Dong.Size = new System.Drawing.Size(179, 23);
            this.btLuu_Gui_Dong.TabIndex = 75;
            this.btLuu_Gui_Dong.Text = "Lưu + Gửi dữ liệu + Đóng";
            this.btLuu_Gui_Dong.Click += new System.EventHandler(this.btLuu_Gui_Dong_Click);
            // 
            // SanXuat_frmThemMoi_SoPhieu
            // 
            this.AcceptButton = this.btLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(676, 267);
            this.Controls.Add(this.btLuu_Gui_Dong);
            this.Controls.Add(this.btLuu_gui_Copy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SanXuat_frmThemMoi_SoPhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới số phiếu";
            this.Load += new System.EventHandler(this.SanXuat_frmThemMoi_SoPhieu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMaCaTruong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenCaTruong;
        private DevExpress.XtraEditors.GridLookUpEdit gridMaCaTruong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit4View;
        private DevExpress.XtraGrid.Columns.GridColumn clID_NhanSuCaTruong;
        private DevExpress.XtraGrid.Columns.GridColumn clMaNhanVienCaTruong;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNhanVienCaTruong;
        private System.Windows.Forms.ComboBox cbCaLamViec;
        private DevExpress.XtraEditors.DateEdit dteNgayLap;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.SimpleButton btLuu_gui_Copy;
        private DevExpress.XtraEditors.SimpleButton btLuu_Gui_Dong;
    }
}