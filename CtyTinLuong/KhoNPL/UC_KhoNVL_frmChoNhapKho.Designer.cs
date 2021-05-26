namespace CtyTinLuong
{
    partial class UC_KhoNVL_frmChoNhapKho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgayChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clIDNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTongTienHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clPheDuyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgungTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.clDaNhapKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.clKhongNhapKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.clThamChieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 35);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.gridControl1.Size = new System.Drawing.Size(879, 571);
            this.gridControl1.TabIndex = 81;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clID,
            this.clNgayChungTu,
            this.clSoChungTu,
            this.clSoHoaDon,
            this.clIDNhaCungCap,
            this.clDienGiai,
            this.clTongTienHang,
            this.clPheDuyet,
            this.clNgungTheoDoi,
            this.clDaNhapKho,
            this.clKhongNhapKho,
            this.clThamChieu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới tại đây";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell_1);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // clSTT
            // 
            this.clSTT.AppearanceCell.Options.UseTextOptions = true;
            this.clSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSTT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.clSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSTT.AppearanceHeader.Options.UseFont = true;
            this.clSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.clSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSTT.Caption = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.OptionsColumn.AllowEdit = false;
            this.clSTT.OptionsColumn.FixedWidth = true;
            this.clSTT.Visible = true;
            this.clSTT.VisibleIndex = 0;
            this.clSTT.Width = 43;
            // 
            // clID
            // 
            this.clID.Caption = "ID_MuaHang";
            this.clID.FieldName = "ID_MuaHang";
            this.clID.Name = "clID";
            // 
            // clNgayChungTu
            // 
            this.clNgayChungTu.AppearanceCell.Options.UseTextOptions = true;
            this.clNgayChungTu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNgayChungTu.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.clNgayChungTu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgayChungTu.AppearanceHeader.Options.UseFont = true;
            this.clNgayChungTu.AppearanceHeader.Options.UseTextOptions = true;
            this.clNgayChungTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNgayChungTu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clNgayChungTu.Caption = "Ngày C Từ";
            this.clNgayChungTu.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clNgayChungTu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clNgayChungTu.FieldName = "NgayChungTu";
            this.clNgayChungTu.GroupFormat.FormatString = "dd/MM/yyyy";
            this.clNgayChungTu.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clNgayChungTu.Name = "clNgayChungTu";
            this.clNgayChungTu.OptionsColumn.AllowEdit = false;
            this.clNgayChungTu.OptionsColumn.FixedWidth = true;
            this.clNgayChungTu.Visible = true;
            this.clNgayChungTu.VisibleIndex = 2;
            this.clNgayChungTu.Width = 117;
            // 
            // clSoChungTu
            // 
            this.clSoChungTu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSoChungTu.AppearanceHeader.Options.UseFont = true;
            this.clSoChungTu.AppearanceHeader.Options.UseTextOptions = true;
            this.clSoChungTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoChungTu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSoChungTu.Caption = "Tham chiếu";
            this.clSoChungTu.FieldName = "SoChungTu";
            this.clSoChungTu.Name = "clSoChungTu";
            this.clSoChungTu.OptionsColumn.AllowEdit = false;
            this.clSoChungTu.OptionsColumn.FixedWidth = true;
            this.clSoChungTu.Visible = true;
            this.clSoChungTu.VisibleIndex = 1;
            this.clSoChungTu.Width = 115;
            // 
            // clSoHoaDon
            // 
            this.clSoHoaDon.AppearanceCell.Options.UseTextOptions = true;
            this.clSoHoaDon.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoHoaDon.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSoHoaDon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSoHoaDon.AppearanceHeader.Options.UseFont = true;
            this.clSoHoaDon.AppearanceHeader.Options.UseTextOptions = true;
            this.clSoHoaDon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoHoaDon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSoHoaDon.Caption = "Số HĐ";
            this.clSoHoaDon.FieldName = "SoHoaDon";
            this.clSoHoaDon.Name = "clSoHoaDon";
            this.clSoHoaDon.OptionsColumn.FixedWidth = true;
            this.clSoHoaDon.Width = 88;
            // 
            // clIDNhaCungCap
            // 
            this.clIDNhaCungCap.Caption = "IDNhaCungCap";
            this.clIDNhaCungCap.FieldName = "IDNhaCungCap";
            this.clIDNhaCungCap.Name = "clIDNhaCungCap";
            // 
            // clDienGiai
            // 
            this.clDienGiai.AppearanceCell.Options.UseTextOptions = true;
            this.clDienGiai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clDienGiai.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clDienGiai.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clDienGiai.AppearanceHeader.Options.UseFont = true;
            this.clDienGiai.AppearanceHeader.Options.UseTextOptions = true;
            this.clDienGiai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clDienGiai.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clDienGiai.Caption = "Diễn giải";
            this.clDienGiai.FieldName = "DienGiai";
            this.clDienGiai.Name = "clDienGiai";
            this.clDienGiai.OptionsColumn.AllowEdit = false;
            this.clDienGiai.Visible = true;
            this.clDienGiai.VisibleIndex = 3;
            this.clDienGiai.Width = 466;
            // 
            // clTongTienHang
            // 
            this.clTongTienHang.AppearanceCell.Options.UseTextOptions = true;
            this.clTongTienHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.clTongTienHang.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clTongTienHang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTongTienHang.AppearanceHeader.Options.UseFont = true;
            this.clTongTienHang.AppearanceHeader.Options.UseTextOptions = true;
            this.clTongTienHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTongTienHang.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clTongTienHang.Caption = "Tổng tiền hàng";
            this.clTongTienHang.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.clTongTienHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clTongTienHang.FieldName = "TongTienHangCoVAT";
            this.clTongTienHang.GroupFormat.FormatString = "{0:#,##0.00}";
            this.clTongTienHang.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clTongTienHang.Name = "clTongTienHang";
            this.clTongTienHang.OptionsColumn.AllowEdit = false;
            this.clTongTienHang.OptionsColumn.FixedWidth = true;
            this.clTongTienHang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienHangCoVAT", "{0:#,##0.00}")});
            this.clTongTienHang.Visible = true;
            this.clTongTienHang.VisibleIndex = 4;
            this.clTongTienHang.Width = 120;
            // 
            // clPheDuyet
            // 
            this.clPheDuyet.AppearanceCell.Options.UseTextOptions = true;
            this.clPheDuyet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clPheDuyet.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clPheDuyet.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clPheDuyet.AppearanceHeader.Options.UseFont = true;
            this.clPheDuyet.AppearanceHeader.Options.UseTextOptions = true;
            this.clPheDuyet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clPheDuyet.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clPheDuyet.Caption = "Trạng thái";
            this.clPheDuyet.FieldName = "PheDuyetNhapKho";
            this.clPheDuyet.Name = "clPheDuyet";
            this.clPheDuyet.OptionsColumn.FixedWidth = true;
            this.clPheDuyet.Width = 100;
            // 
            // clNgungTheoDoi
            // 
            this.clNgungTheoDoi.AppearanceCell.Options.UseTextOptions = true;
            this.clNgungTheoDoi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNgungTheoDoi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clNgungTheoDoi.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.clNgungTheoDoi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgungTheoDoi.AppearanceHeader.Options.UseFont = true;
            this.clNgungTheoDoi.AppearanceHeader.Options.UseTextOptions = true;
            this.clNgungTheoDoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNgungTheoDoi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clNgungTheoDoi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.clNgungTheoDoi.Caption = "Bỏ";
            this.clNgungTheoDoi.ColumnEdit = this.repositoryItemCheckEdit2;
            this.clNgungTheoDoi.FieldName = "NgungTheoDoi";
            this.clNgungTheoDoi.Name = "clNgungTheoDoi";
            this.clNgungTheoDoi.OptionsColumn.FixedWidth = true;
            this.clNgungTheoDoi.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.clNgungTheoDoi.Width = 67;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // clDaNhapKho
            // 
            this.clDaNhapKho.Caption = "Gửi DL";
            this.clDaNhapKho.ColumnEdit = this.repositoryItemCheckEdit1;
            this.clDaNhapKho.FieldName = "GuiDuLieu";
            this.clDaNhapKho.Name = "clDaNhapKho";
            this.clDaNhapKho.OptionsColumn.AllowEdit = false;
            this.clDaNhapKho.OptionsColumn.FixedWidth = true;
            this.clDaNhapKho.Width = 50;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // clKhongNhapKho
            // 
            this.clKhongNhapKho.Caption = "MH nhập";
            this.clKhongNhapKho.ColumnEdit = this.repositoryItemCheckEdit3;
            this.clKhongNhapKho.FieldName = "MuaHangNhapKho";
            this.clKhongNhapKho.Name = "clKhongNhapKho";
            this.clKhongNhapKho.OptionsColumn.AllowEdit = false;
            this.clKhongNhapKho.OptionsColumn.FixedWidth = true;
            this.clKhongNhapKho.Width = 60;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Caption = "Check";
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // clThamChieu
            // 
            this.clThamChieu.Caption = "Tham chiếu";
            this.clThamChieu.FieldName = "ThamChieu";
            this.clThamChieu.Name = "clThamChieu";
            this.clThamChieu.OptionsColumn.AllowEdit = false;
            this.clThamChieu.OptionsColumn.FixedWidth = true;
            this.clThamChieu.Width = 90;
            // 
            // btRefresh
            // 
            this.btRefresh.Image = global::CtyTinLuong.Properties.Resources.ico_Update;
            this.btRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btRefresh.Location = new System.Drawing.Point(3, 6);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(39, 23);
            this.btRefresh.TabIndex = 83;
            this.btRefresh.ToolTip = "Refesh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // UC_KhoNVL_frmChoNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.gridControl1);
            this.Name = "UC_KhoNVL_frmChoNhapKho";
            this.Size = new System.Drawing.Size(900, 606);
            this.Load += new System.EventHandler(this.UC_KhoNVL_frmChoNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clID;
        private DevExpress.XtraGrid.Columns.GridColumn clNgayChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn clSoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn clSoHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn clIDNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn clDienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn clTongTienHang;
        private DevExpress.XtraGrid.Columns.GridColumn clPheDuyet;
        private DevExpress.XtraGrid.Columns.GridColumn clNgungTheoDoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn clDaNhapKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clKhongNhapKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn clThamChieu;
    }
}
