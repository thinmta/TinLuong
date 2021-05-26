namespace CtyTinLuong
{
    partial class UCThanhPham_DaNhapKho
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.clTenDaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_DaiLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTongTienHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgayChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_NhapKhoThanhPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSoChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_VTHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenVTHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThamChieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRefresh
            // 
            this.btRefresh.Image = global::CtyTinLuong.Properties.Resources.ico_Update;
            this.btRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btRefresh.Location = new System.Drawing.Point(3, 3);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(39, 23);
            this.btRefresh.TabIndex = 100;
            this.btRefresh.ToolTip = "Refesh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // clTenDaiLy
            // 
            this.clTenDaiLy.Caption = "Đại lý";
            this.clTenDaiLy.FieldName = "TenDaiLy";
            this.clTenDaiLy.Name = "clTenDaiLy";
            this.clTenDaiLy.OptionsColumn.AllowEdit = false;
            this.clTenDaiLy.OptionsColumn.FixedWidth = true;
            this.clTenDaiLy.Visible = true;
            this.clTenDaiLy.VisibleIndex = 4;
            this.clTenDaiLy.Width = 122;
            // 
            // clID_DaiLy
            // 
            this.clID_DaiLy.Caption = "ID_DaiLy";
            this.clID_DaiLy.FieldName = "ID_DaiLy";
            this.clID_DaiLy.Name = "clID_DaiLy";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::CtyTinLuong.Properties.Resources.ico_Delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // clXoa
            // 
            this.clXoa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clXoa.AppearanceHeader.Options.UseFont = true;
            this.clXoa.AppearanceHeader.Options.UseTextOptions = true;
            this.clXoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clXoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clXoa.Caption = "Xóa";
            this.clXoa.ColumnEdit = this.repositoryItemButtonEdit1;
            this.clXoa.Name = "clXoa";
            this.clXoa.OptionsColumn.FixedWidth = true;
            this.clXoa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.clXoa.Width = 40;
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
            this.clTongTienHang.VisibleIndex = 6;
            this.clTongTienHang.Width = 120;
            // 
            // clDienGiai
            // 
            this.clDienGiai.AppearanceCell.Options.UseTextOptions = true;
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
            this.clDienGiai.VisibleIndex = 5;
            this.clDienGiai.Width = 77;
            // 
            // clNgayChungTu
            // 
            this.clNgayChungTu.AppearanceCell.Options.UseTextOptions = true;
            this.clNgayChungTu.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.clNgayChungTu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgayChungTu.AppearanceHeader.Options.UseFont = true;
            this.clNgayChungTu.AppearanceHeader.Options.UseTextOptions = true;
            this.clNgayChungTu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNgayChungTu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clNgayChungTu.Caption = "Ngày C Từ";
            this.clNgayChungTu.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clNgayChungTu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clNgayChungTu.FieldName = "NgayChungTu";
            this.clNgayChungTu.GroupFormat.FormatString = "dd/MM/yyyy";
            this.clNgayChungTu.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clNgayChungTu.Name = "clNgayChungTu";
            this.clNgayChungTu.OptionsColumn.AllowEdit = false;
            this.clNgayChungTu.OptionsColumn.FixedWidth = true;
            this.clNgayChungTu.Visible = true;
            this.clNgayChungTu.VisibleIndex = 3;
            this.clNgayChungTu.Width = 80;
            // 
            // clID_NhapKhoThanhPham
            // 
            this.clID_NhapKhoThanhPham.Caption = "ID_NhapKho_ThanhPham";
            this.clID_NhapKhoThanhPham.FieldName = "ID_NhapKho_ThanhPham";
            this.clID_NhapKhoThanhPham.Name = "clID_NhapKhoThanhPham";
            this.clID_NhapKhoThanhPham.Visible = true;
            this.clID_NhapKhoThanhPham.VisibleIndex = 7;
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
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clID_NhapKhoThanhPham,
            this.clNgayChungTu,
            this.clSoChungTu,
            this.clDienGiai,
            this.clTongTienHang,
            this.clXoa,
            this.clID_DaiLy,
            this.clTenDaiLy,
            this.clID_VTHH,
            this.clTenVTHH,
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
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            this.clSoChungTu.Width = 70;
            // 
            // clID_VTHH
            // 
            this.clID_VTHH.Caption = "ID_VTHH";
            this.clID_VTHH.FieldName = "ID_VTHH";
            this.clID_VTHH.Name = "clID_VTHH";
            // 
            // clTenVTHH
            // 
            this.clTenVTHH.Caption = "Tên VTHH";
            this.clTenVTHH.FieldName = "TenVTHH";
            this.clTenVTHH.Name = "clTenVTHH";
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
            this.clThamChieu.Width = 80;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(897, 574);
            this.gridControl1.TabIndex = 97;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // UCThanhPham_DaNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.gridControl1);
            this.Name = "UCThanhPham_DaNhapKho";
            this.Size = new System.Drawing.Size(900, 606);
            this.Load += new System.EventHandler(this.UCThanhPham_DaNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn clTenDaiLy;
        private DevExpress.XtraGrid.Columns.GridColumn clID_DaiLy;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clXoa;
        private DevExpress.XtraGrid.Columns.GridColumn clTongTienHang;
        private DevExpress.XtraGrid.Columns.GridColumn clDienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn clNgayChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn clID_NhapKhoThanhPham;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSoChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn clID_VTHH;
        private DevExpress.XtraGrid.Columns.GridColumn clTenVTHH;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn clThamChieu;
    }
}
