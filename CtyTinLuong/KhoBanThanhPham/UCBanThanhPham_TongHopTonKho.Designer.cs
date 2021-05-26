namespace CtyTinLuong
{
    partial class UCBanThanhPham_TongHopTonKho
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
            this.btPrint = new DevExpress.XtraEditors.SimpleButton();
            this.clSoLuongTonCuoiKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGiaTriXuatTrongKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuongXuatTrongKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTriNhapTrongKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuongNhapTrongKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGiaTriTonDauKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuongTonDauKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.clTenVTHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMaVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_VTHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clGiaTriTonCuoiKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPrint
            // 
            this.btPrint.Image = global::CtyTinLuong.Properties.Resources.ico_Print;
            this.btPrint.Location = new System.Drawing.Point(833, 3);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(64, 22);
            this.btPrint.TabIndex = 104;
            this.btPrint.Text = "Print";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // clSoLuongTonCuoiKy
            // 
            this.clSoLuongTonCuoiKy.AppearanceCell.Options.UseTextOptions = true;
            this.clSoLuongTonCuoiKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoLuongTonCuoiKy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSoLuongTonCuoiKy.Caption = "SL Tồn";
            this.clSoLuongTonCuoiKy.DisplayFormat.FormatString = "{0:N0}";
            this.clSoLuongTonCuoiKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clSoLuongTonCuoiKy.FieldName = "SoLuongTon_CuoiKy";
            this.clSoLuongTonCuoiKy.GroupFormat.FormatString = "{0:N0}";
            this.clSoLuongTonCuoiKy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clSoLuongTonCuoiKy.Name = "clSoLuongTonCuoiKy";
            this.clSoLuongTonCuoiKy.OptionsColumn.AllowEdit = false;
            this.clSoLuongTonCuoiKy.OptionsColumn.FixedWidth = true;
            this.clSoLuongTonCuoiKy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuongTon_CuoiKy", "{0:N0}")});
            this.clSoLuongTonCuoiKy.Visible = true;
            this.clSoLuongTonCuoiKy.VisibleIndex = 4;
            this.clSoLuongTonCuoiKy.Width = 100;
            // 
            // clGiaTriXuatTrongKy
            // 
            this.clGiaTriXuatTrongKy.AppearanceCell.Options.UseTextOptions = true;
            this.clGiaTriXuatTrongKy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clGiaTriXuatTrongKy.Caption = "Giá trị";
            this.clGiaTriXuatTrongKy.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.clGiaTriXuatTrongKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clGiaTriXuatTrongKy.FieldName = "GiaTriXuatTrongKy";
            this.clGiaTriXuatTrongKy.GroupFormat.FormatString = "{0:#,##0.00}";
            this.clGiaTriXuatTrongKy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clGiaTriXuatTrongKy.Name = "clGiaTriXuatTrongKy";
            this.clGiaTriXuatTrongKy.OptionsColumn.AllowEdit = false;
            this.clGiaTriXuatTrongKy.OptionsColumn.FixedWidth = true;
            this.clGiaTriXuatTrongKy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GiaTriXuatTrongKy", "{0:#,##0.00}")});
            this.clGiaTriXuatTrongKy.Width = 120;
            // 
            // clSoLuongXuatTrongKy
            // 
            this.clSoLuongXuatTrongKy.AppearanceCell.Options.UseTextOptions = true;
            this.clSoLuongXuatTrongKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoLuongXuatTrongKy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSoLuongXuatTrongKy.Caption = "SL";
            this.clSoLuongXuatTrongKy.FieldName = "SoLuongXuatTrongKy";
            this.clSoLuongXuatTrongKy.Name = "clSoLuongXuatTrongKy";
            this.clSoLuongXuatTrongKy.OptionsColumn.AllowEdit = false;
            this.clSoLuongXuatTrongKy.OptionsColumn.FixedWidth = true;
            this.clSoLuongXuatTrongKy.Width = 60;
            // 
            // GiaTriNhapTrongKy
            // 
            this.GiaTriNhapTrongKy.AppearanceCell.Options.UseTextOptions = true;
            this.GiaTriNhapTrongKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GiaTriNhapTrongKy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GiaTriNhapTrongKy.Caption = "Giá trị";
            this.GiaTriNhapTrongKy.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.GiaTriNhapTrongKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.GiaTriNhapTrongKy.FieldName = "GiaTriNhapTrongKy";
            this.GiaTriNhapTrongKy.GroupFormat.FormatString = "{0:#,##0.00}";
            this.GiaTriNhapTrongKy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.GiaTriNhapTrongKy.Name = "GiaTriNhapTrongKy";
            this.GiaTriNhapTrongKy.OptionsColumn.AllowEdit = false;
            this.GiaTriNhapTrongKy.OptionsColumn.FixedWidth = true;
            this.GiaTriNhapTrongKy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GiaTriNhapTrongKy", "{0:#,##0.00}")});
            this.GiaTriNhapTrongKy.Width = 120;
            // 
            // clSoLuongNhapTrongKy
            // 
            this.clSoLuongNhapTrongKy.AppearanceCell.Options.UseTextOptions = true;
            this.clSoLuongNhapTrongKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoLuongNhapTrongKy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSoLuongNhapTrongKy.Caption = "SL";
            this.clSoLuongNhapTrongKy.FieldName = "SoLuongNhapTrongKy";
            this.clSoLuongNhapTrongKy.Name = "clSoLuongNhapTrongKy";
            this.clSoLuongNhapTrongKy.OptionsColumn.AllowEdit = false;
            this.clSoLuongNhapTrongKy.OptionsColumn.FixedWidth = true;
            this.clSoLuongNhapTrongKy.Width = 60;
            // 
            // clGiaTriTonDauKy
            // 
            this.clGiaTriTonDauKy.AppearanceCell.Options.UseTextOptions = true;
            this.clGiaTriTonDauKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.clGiaTriTonDauKy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clGiaTriTonDauKy.Caption = "Giá trị";
            this.clGiaTriTonDauKy.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.clGiaTriTonDauKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clGiaTriTonDauKy.FieldName = "GiaTriTonDauKy";
            this.clGiaTriTonDauKy.GroupFormat.FormatString = "{0:#,##0.00}";
            this.clGiaTriTonDauKy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clGiaTriTonDauKy.Name = "clGiaTriTonDauKy";
            this.clGiaTriTonDauKy.OptionsColumn.AllowEdit = false;
            this.clGiaTriTonDauKy.OptionsColumn.FixedWidth = true;
            this.clGiaTriTonDauKy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GiaTriTonDauKy", "{0:#,##0.00}")});
            this.clGiaTriTonDauKy.Width = 120;
            // 
            // clSoLuongTonDauKy
            // 
            this.clSoLuongTonDauKy.AppearanceCell.Options.UseTextOptions = true;
            this.clSoLuongTonDauKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSoLuongTonDauKy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSoLuongTonDauKy.Caption = "SL";
            this.clSoLuongTonDauKy.FieldName = "SoLuongTonDauKy";
            this.clSoLuongTonDauKy.Name = "clSoLuongTonDauKy";
            this.clSoLuongTonDauKy.OptionsColumn.AllowEdit = false;
            this.clSoLuongTonDauKy.OptionsColumn.FixedWidth = true;
            this.clSoLuongTonDauKy.Width = 60;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.AppearanceCell.Options.UseTextOptions = true;
            this.clDonViTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clDonViTinh.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clDonViTinh.Caption = "ĐVT";
            this.clDonViTinh.FieldName = "DonViTinh";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.OptionsColumn.AllowEdit = false;
            this.clDonViTinh.Visible = true;
            this.clDonViTinh.VisibleIndex = 3;
            this.clDonViTinh.Width = 79;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // clTenVTHH
            // 
            this.clTenVTHH.AppearanceCell.Options.UseTextOptions = true;
            this.clTenVTHH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clTenVTHH.Caption = "Tên VTHH";
            this.clTenVTHH.ColumnEdit = this.repositoryItemMemoEdit1;
            this.clTenVTHH.FieldName = "TenVTHH";
            this.clTenVTHH.Name = "clTenVTHH";
            this.clTenVTHH.OptionsColumn.AllowEdit = false;
            this.clTenVTHH.Visible = true;
            this.clTenVTHH.VisibleIndex = 2;
            this.clTenVTHH.Width = 407;
            // 
            // clMaVT
            // 
            this.clMaVT.AppearanceCell.Options.UseTextOptions = true;
            this.clMaVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clMaVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clMaVT.Caption = "Mã VT";
            this.clMaVT.FieldName = "MaVT";
            this.clMaVT.Name = "clMaVT";
            this.clMaVT.OptionsColumn.AllowEdit = false;
            this.clMaVT.OptionsColumn.FixedWidth = true;
            this.clMaVT.Visible = true;
            this.clMaVT.VisibleIndex = 1;
            this.clMaVT.Width = 80;
            // 
            // clID_VTHH
            // 
            this.clID_VTHH.AppearanceCell.Options.UseTextOptions = true;
            this.clID_VTHH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clID_VTHH.Caption = "ID_VTHH";
            this.clID_VTHH.FieldName = "ID_VTHH";
            this.clID_VTHH.Name = "clID_VTHH";
            // 
            // clSTT
            // 
            this.clSTT.AppearanceCell.Options.UseTextOptions = true;
            this.clSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clSTT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.clSTT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clID_VTHH,
            this.clMaVT,
            this.clTenVTHH,
            this.clDonViTinh,
            this.clSoLuongTonDauKy,
            this.clGiaTriTonDauKy,
            this.clSoLuongNhapTrongKy,
            this.GiaTriNhapTrongKy,
            this.clSoLuongXuatTrongKy,
            this.clGiaTriXuatTrongKy,
            this.clSoLuongTonCuoiKy,
            this.clGiaTriTonCuoiKy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới tại đây";
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // clGiaTriTonCuoiKy
            // 
            this.clGiaTriTonCuoiKy.AppearanceCell.Options.UseTextOptions = true;
            this.clGiaTriTonCuoiKy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.clGiaTriTonCuoiKy.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clGiaTriTonCuoiKy.Caption = "Giá trị";
            this.clGiaTriTonCuoiKy.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.clGiaTriTonCuoiKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clGiaTriTonCuoiKy.FieldName = "GiaTriTonCuoiKy";
            this.clGiaTriTonCuoiKy.GroupFormat.FormatString = "{0:#,##0.00}";
            this.clGiaTriTonCuoiKy.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clGiaTriTonCuoiKy.Name = "clGiaTriTonCuoiKy";
            this.clGiaTriTonCuoiKy.OptionsColumn.AllowEdit = false;
            this.clGiaTriTonCuoiKy.OptionsColumn.FixedWidth = true;
            this.clGiaTriTonCuoiKy.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GiaTriTonCuoiKy", "{0:#,##0.00}")});
            this.clGiaTriTonCuoiKy.Width = 120;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-24, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(921, 575);
            this.gridControl1.TabIndex = 103;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::CtyTinLuong.Properties.Resources.ico_Delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // UCBanThanhPham_TongHopTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.gridControl1);
            this.Name = "UCBanThanhPham_TongHopTonKho";
            this.Size = new System.Drawing.Size(900, 606);
            this.Load += new System.EventHandler(this.UCBanThanhPham_TongHopTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btPrint;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongTonCuoiKy;
        private DevExpress.XtraGrid.Columns.GridColumn clGiaTriXuatTrongKy;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongXuatTrongKy;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTriNhapTrongKy;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongNhapTrongKy;
        private DevExpress.XtraGrid.Columns.GridColumn clGiaTriTonDauKy;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongTonDauKy;
        private DevExpress.XtraGrid.Columns.GridColumn clDonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clTenVTHH;
        private DevExpress.XtraGrid.Columns.GridColumn clMaVT;
        private DevExpress.XtraGrid.Columns.GridColumn clID_VTHH;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clGiaTriTonCuoiKy;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
