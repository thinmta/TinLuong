namespace CtyTinLuong
{
    partial class UCbanThanhPham_DaXuatKho
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
            this.clID_XuatKhoBTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.clNgayNhapKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTongTienHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgungTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThamChieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 34);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2});
            this.gridControl1.Size = new System.Drawing.Size(897, 568);
            this.gridControl1.TabIndex = 89;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clID_XuatKhoBTP,
            this.clDienGiai,
            this.clNgayNhapKho,
            this.clSoChungTu,
            this.clTongTienHang,
            this.clNgungTheoDoi,
            this.clThamChieu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới tại đây";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            // clID_XuatKhoBTP
            // 
            this.clID_XuatKhoBTP.Caption = "ID_XuatKhoBTP";
            this.clID_XuatKhoBTP.FieldName = "ID_XuatKhoBTP";
            this.clID_XuatKhoBTP.Name = "clID_XuatKhoBTP";
            this.clID_XuatKhoBTP.Width = 46;
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
            this.clDienGiai.ColumnEdit = this.repositoryItemMemoEdit1;
            this.clDienGiai.FieldName = "DienGiai";
            this.clDienGiai.Name = "clDienGiai";
            this.clDienGiai.OptionsColumn.AllowEdit = false;
            this.clDienGiai.Visible = true;
            this.clDienGiai.VisibleIndex = 4;
            this.clDienGiai.Width = 288;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // clNgayNhapKho
            // 
            this.clNgayNhapKho.AppearanceCell.Options.UseTextOptions = true;
            this.clNgayNhapKho.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNgayNhapKho.Caption = "Ngày C Từ";
            this.clNgayNhapKho.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clNgayNhapKho.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clNgayNhapKho.FieldName = "NgayChungTu";
            this.clNgayNhapKho.GroupFormat.FormatString = "dd/MM/yyyy";
            this.clNgayNhapKho.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clNgayNhapKho.Name = "clNgayNhapKho";
            this.clNgayNhapKho.OptionsColumn.AllowEdit = false;
            this.clNgayNhapKho.Visible = true;
            this.clNgayNhapKho.VisibleIndex = 3;
            this.clNgayNhapKho.Width = 76;
            // 
            // clSoChungTu
            // 
            this.clSoChungTu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSoChungTu.AppearanceHeader.Options.UseFont = true;
            this.clSoChungTu.AppearanceHeader.Options.UseTextOptions = true;
            this.clSoChungTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoChungTu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSoChungTu.Caption = "Số C Từ";
            this.clSoChungTu.FieldName = "SoChungTu";
            this.clSoChungTu.Name = "clSoChungTu";
            this.clSoChungTu.OptionsColumn.AllowEdit = false;
            this.clSoChungTu.OptionsColumn.FixedWidth = true;
            this.clSoChungTu.Visible = true;
            this.clSoChungTu.VisibleIndex = 2;
            this.clSoChungTu.Width = 100;
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
            this.clTongTienHang.FieldName = "TongTienHang";
            this.clTongTienHang.GroupFormat.FormatString = "{0:#,##0.00}";
            this.clTongTienHang.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clTongTienHang.Name = "clTongTienHang";
            this.clTongTienHang.OptionsColumn.AllowEdit = false;
            this.clTongTienHang.OptionsColumn.FixedWidth = true;
            this.clTongTienHang.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TongTienHang", "{0:#,##0.00}")});
            this.clTongTienHang.Visible = true;
            this.clTongTienHang.VisibleIndex = 5;
            this.clTongTienHang.Width = 140;
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
            this.clNgungTheoDoi.FieldName = "NgungTheoDoi";
            this.clNgungTheoDoi.Name = "clNgungTheoDoi";
            this.clNgungTheoDoi.OptionsColumn.FixedWidth = true;
            this.clNgungTheoDoi.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.clNgungTheoDoi.Width = 67;
            // 
            // clThamChieu
            // 
            this.clThamChieu.Caption = "Tham chiếu";
            this.clThamChieu.FieldName = "ThamChieu";
            this.clThamChieu.Name = "clThamChieu";
            this.clThamChieu.OptionsColumn.AllowEdit = false;
            this.clThamChieu.OptionsColumn.FixedWidth = true;
            this.clThamChieu.Visible = true;
            this.clThamChieu.VisibleIndex = 1;
            this.clThamChieu.Width = 90;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // btRefresh
            // 
            this.btRefresh.Image = global::CtyTinLuong.Properties.Resources.ico_Update;
            this.btRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btRefresh.Location = new System.Drawing.Point(3, 5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(39, 23);
            this.btRefresh.TabIndex = 90;
            this.btRefresh.ToolTip = "Refesh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // UCbanThanhPham_DaXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btRefresh);
            this.Name = "UCbanThanhPham_DaXuatKho";
            this.Size = new System.Drawing.Size(900, 606);
            this.Load += new System.EventHandler(this.UCbanThanhPham_DaXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clID_XuatKhoBTP;
        private DevExpress.XtraGrid.Columns.GridColumn clDienGiai;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clNgayNhapKho;
        private DevExpress.XtraGrid.Columns.GridColumn clSoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn clTongTienHang;
        private DevExpress.XtraGrid.Columns.GridColumn clNgungTheoDoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn clThamChieu;
    }
}
