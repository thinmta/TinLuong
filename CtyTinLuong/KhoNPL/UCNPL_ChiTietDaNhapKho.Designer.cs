﻿namespace CtyTinLuong
{
    partial class UCNPL_ChiTietDaNhapKho
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
            this.components = new System.ComponentModel.Container();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_VTHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTonTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgungTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMaVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenVTHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgayChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoTenVTHH = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dteTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.btLayDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.dteNgay = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTenVTHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(900, 567);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.memoTenVTHH});
            this.gridControl1.Size = new System.Drawing.Size(896, 563);
            this.gridControl1.TabIndex = 93;
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
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clID_VTHH,
            this.clSoLuong,
            this.clDonGia,
            this.clTonTai,
            this.clNgungTheoDoi,
            this.clMaVT,
            this.clTenVTHH,
            this.clDonViTinh,
            this.clThanhTien,
            this.clNgayChungTu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", this.clThanhTien, "{0:#,##0.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", this.clSoLuong, "{0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "TenVTHH", this.clTenVTHH, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // clSTT
            // 
            this.clSTT.Caption = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.OptionsColumn.AllowEdit = false;
            this.clSTT.OptionsColumn.FixedWidth = true;
            this.clSTT.Visible = true;
            this.clSTT.VisibleIndex = 5;
            this.clSTT.Width = 30;
            // 
            // clID_VTHH
            // 
            this.clID_VTHH.Caption = "ID_VTHH";
            this.clID_VTHH.FieldName = "ID_VTHH";
            this.clID_VTHH.Name = "clID_VTHH";
            // 
            // clSoLuong
            // 
            this.clSoLuong.Caption = "Số lượng";
            this.clSoLuong.FieldName = "SoLuong";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.OptionsColumn.AllowEdit = false;
            this.clSoLuong.OptionsColumn.FixedWidth = true;
            this.clSoLuong.Visible = true;
            this.clSoLuong.VisibleIndex = 2;
            this.clSoLuong.Width = 70;
            // 
            // clDonGia
            // 
            this.clDonGia.AppearanceCell.Options.UseTextOptions = true;
            this.clDonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.clDonGia.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clDonGia.Caption = "Đơn giá (đ)";
            this.clDonGia.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.clDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clDonGia.FieldName = "DonGia";
            this.clDonGia.GroupFormat.FormatString = "{0:#,##0.00}";
            this.clDonGia.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.OptionsColumn.AllowEdit = false;
            this.clDonGia.OptionsColumn.FixedWidth = true;
            this.clDonGia.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.clDonGia.Width = 120;
            // 
            // clTonTai
            // 
            this.clTonTai.Caption = "TonTai";
            this.clTonTai.FieldName = "TonTai";
            this.clTonTai.Name = "clTonTai";
            // 
            // clNgungTheoDoi
            // 
            this.clNgungTheoDoi.Caption = "NgungTheoDoi";
            this.clNgungTheoDoi.FieldName = "NgungTheoDoi";
            this.clNgungTheoDoi.Name = "clNgungTheoDoi";
            // 
            // clMaVT
            // 
            this.clMaVT.Caption = "Mã VT";
            this.clMaVT.FieldName = "MaVT";
            this.clMaVT.Name = "clMaVT";
            this.clMaVT.OptionsColumn.AllowEdit = false;
            this.clMaVT.OptionsColumn.FixedWidth = true;
            this.clMaVT.Visible = true;
            this.clMaVT.VisibleIndex = 0;
            this.clMaVT.Width = 83;
            // 
            // clTenVTHH
            // 
            this.clTenVTHH.AppearanceCell.Options.UseTextOptions = true;
            this.clTenVTHH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clTenVTHH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clTenVTHH.Caption = "Tên hàng hóa";
            this.clTenVTHH.ColumnEdit = this.memoTenVTHH;
            this.clTenVTHH.FieldName = "TenVTHH";
            this.clTenVTHH.Name = "clTenVTHH";
            this.clTenVTHH.OptionsColumn.AllowEdit = false;
            this.clTenVTHH.Visible = true;
            this.clTenVTHH.VisibleIndex = 1;
            this.clTenVTHH.Width = 325;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.Caption = "ĐVT";
            this.clDonViTinh.FieldName = "DonViTinh";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.OptionsColumn.AllowEdit = false;
            this.clDonViTinh.OptionsColumn.FixedWidth = true;
            this.clDonViTinh.Visible = true;
            this.clDonViTinh.VisibleIndex = 3;
            this.clDonViTinh.Width = 60;
            // 
            // clThanhTien
            // 
            this.clThanhTien.AppearanceCell.Options.UseTextOptions = true;
            this.clThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.clThanhTien.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clThanhTien.Caption = "Thành tiền (đ)";
            this.clThanhTien.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.clThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clThanhTien.FieldName = "ThanhTien";
            this.clThanhTien.GroupFormat.FormatString = "{0:#,##0.00}";
            this.clThanhTien.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.OptionsColumn.AllowEdit = false;
            this.clThanhTien.OptionsColumn.FixedWidth = true;
            this.clThanhTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", "{0:#,##0.00} (đ)")});
            this.clThanhTien.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.clThanhTien.Visible = true;
            this.clThanhTien.VisibleIndex = 4;
            this.clThanhTien.Width = 120;
            // 
            // clNgayChungTu
            // 
            this.clNgayChungTu.Caption = "Ngày";
            this.clNgayChungTu.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clNgayChungTu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clNgayChungTu.FieldName = "NgayChungTu";
            this.clNgayChungTu.GroupFormat.FormatString = "dd/MM/yyyy";
            this.clNgayChungTu.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clNgayChungTu.Name = "clNgayChungTu";
            this.clNgayChungTu.OptionsColumn.AllowEdit = false;
            this.clNgayChungTu.OptionsColumn.FixedWidth = true;
            this.clNgayChungTu.Width = 100;
            // 
            // memoTenVTHH
            // 
            this.memoTenVTHH.Name = "memoTenVTHH";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btRefresh;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(872, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(28, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btRefresh
            // 
            this.btRefresh.ImageOptions.Image = global::CtyTinLuong.Properties.Resources.ico_Update;
            this.btRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btRefresh.Location = new System.Drawing.Point(874, 2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(24, 22);
            this.btRefresh.StyleController = this.dataLayoutControl1;
            this.btRefresh.TabIndex = 92;
            this.btRefresh.ToolTip = "Refesh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.dteTuNgay);
            this.dataLayoutControl1.Controls.Add(this.btRefresh);
            this.dataLayoutControl1.Controls.Add(this.btLayDuLieu);
            this.dataLayoutControl1.Controls.Add(this.dteNgay);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 13);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(900, 593);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // dteTuNgay
            // 
            this.dteTuNgay.EditValue = null;
            this.dteTuNgay.Location = new System.Drawing.Point(52, 2);
            this.dteTuNgay.Name = "dteTuNgay";
            this.dteTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteTuNgay.Size = new System.Drawing.Size(303, 20);
            this.dteTuNgay.StyleController = this.dataLayoutControl1;
            this.dteTuNgay.TabIndex = 91;
            // 
            // btLayDuLieu
            // 
            this.btLayDuLieu.ImageOptions.Image = global::CtyTinLuong.Properties.Resources.button_yellow;
            this.btLayDuLieu.Location = new System.Drawing.Point(790, 2);
            this.btLayDuLieu.Name = "btLayDuLieu";
            this.btLayDuLieu.Size = new System.Drawing.Size(80, 22);
            this.btLayDuLieu.StyleController = this.dataLayoutControl1;
            this.btLayDuLieu.TabIndex = 89;
            this.btLayDuLieu.Text = "Lấy dữ liệu";
            this.btLayDuLieu.Click += new System.EventHandler(this.btLayDuLieu_Click);
            // 
            // dteNgay
            // 
            this.dteNgay.EditValue = null;
            this.dteNgay.Location = new System.Drawing.Point(409, 2);
            this.dteNgay.Name = "dteNgay";
            this.dteNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNgay.Size = new System.Drawing.Size(377, 20);
            this.dteNgay.StyleController = this.dataLayoutControl1;
            this.dteNgay.TabIndex = 88;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(900, 593);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dteNgay;
            this.layoutControlItem1.CustomizationFormText = "Đến ngày";
            this.layoutControlItem1.Location = new System.Drawing.Point(357, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(431, 26);
            this.layoutControlItem1.Text = "Đến ngày";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(47, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btLayDuLieu;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(788, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(84, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dteTuNgay;
            this.layoutControlItem5.CustomizationFormText = "Từ ngày";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(357, 26);
            this.layoutControlItem5.Text = "Từ ngày";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(47, 13);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataLayoutControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(900, 606);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // UCNPL_ChiTietDaNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCNPL_ChiTietDaNhapKho";
            this.Size = new System.Drawing.Size(900, 606);
            this.Load += new System.EventHandler(this.UCNPL_ChiTietDaNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTenVTHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clID_VTHH;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn clDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn clTonTai;
        private DevExpress.XtraGrid.Columns.GridColumn clNgungTheoDoi;
        private DevExpress.XtraGrid.Columns.GridColumn clMaVT;
        private DevExpress.XtraGrid.Columns.GridColumn clTenVTHH;
        private DevExpress.XtraGrid.Columns.GridColumn clDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn clThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn clNgayChungTu;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit memoTenVTHH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.DateEdit dteTuNgay;
        private DevExpress.XtraEditors.SimpleButton btLayDuLieu;
        private DevExpress.XtraEditors.DateEdit dteNgay;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
