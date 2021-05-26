﻿namespace CtyTinLuong
{
    partial class UCNPL_XuatKhoTheoLSXToGapDan
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clTenLoaiMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_LenhSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMaLenhSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgayThangSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.clCaSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgungTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clID_CongNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.clCongNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_LoaiMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_CaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clCaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.btfresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::CtyTinLuong.Properties.Resources.ico_Delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // clTenLoaiMay
            // 
            this.clTenLoaiMay.AppearanceCell.Options.UseTextOptions = true;
            this.clTenLoaiMay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clTenLoaiMay.Caption = "Máy";
            this.clTenLoaiMay.FieldName = "ten";
            this.clTenLoaiMay.Name = "clTenLoaiMay";
            this.clTenLoaiMay.OptionsColumn.AllowEdit = false;
            this.clTenLoaiMay.Width = 62;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clSTT,
            this.clID_LenhSanXuat,
            this.clMaLenhSanXuat,
            this.clNgayThangSanXuat,
            this.clCaSanXuat,
            this.clNgungTheoDoi,
            this.clXoa,
            this.clID_CongNhan,
            this.clGhiChu,
            this.clCongNhan,
            this.clID_LoaiMay,
            this.clID_CaTruong,
            this.clTenLoaiMay,
            this.clCaTruong});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới tại đây";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
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
            // clID_LenhSanXuat
            // 
            this.clID_LenhSanXuat.Caption = "ID_LenhSanXuat";
            this.clID_LenhSanXuat.FieldName = "ID_LenhSanXuat";
            this.clID_LenhSanXuat.Name = "clID_LenhSanXuat";
            // 
            // clMaLenhSanXuat
            // 
            this.clMaLenhSanXuat.Caption = "Mã lệnh";
            this.clMaLenhSanXuat.FieldName = "MaLenhSanXuat";
            this.clMaLenhSanXuat.Name = "clMaLenhSanXuat";
            this.clMaLenhSanXuat.OptionsColumn.AllowEdit = false;
            this.clMaLenhSanXuat.OptionsColumn.FixedWidth = true;
            this.clMaLenhSanXuat.Visible = true;
            this.clMaLenhSanXuat.VisibleIndex = 1;
            this.clMaLenhSanXuat.Width = 80;
            // 
            // clNgayThangSanXuat
            // 
            this.clNgayThangSanXuat.AppearanceCell.Options.UseTextOptions = true;
            this.clNgayThangSanXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clNgayThangSanXuat.Caption = "Ngày lập";
            this.clNgayThangSanXuat.ColumnEdit = this.repositoryItemDateEdit1;
            this.clNgayThangSanXuat.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.clNgayThangSanXuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clNgayThangSanXuat.FieldName = "NgayThangSanXuat";
            this.clNgayThangSanXuat.GroupFormat.FormatString = "dd/MM/yyyy";
            this.clNgayThangSanXuat.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.clNgayThangSanXuat.Name = "clNgayThangSanXuat";
            this.clNgayThangSanXuat.OptionsColumn.AllowEdit = false;
            this.clNgayThangSanXuat.OptionsColumn.FixedWidth = true;
            this.clNgayThangSanXuat.Visible = true;
            this.clNgayThangSanXuat.VisibleIndex = 2;
            this.clNgayThangSanXuat.Width = 117;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.repositoryItemDateEdit1.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // clCaSanXuat
            // 
            this.clCaSanXuat.AppearanceCell.Options.UseTextOptions = true;
            this.clCaSanXuat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clCaSanXuat.Caption = "Ca";
            this.clCaSanXuat.FieldName = "CaSanXuat";
            this.clCaSanXuat.Name = "clCaSanXuat";
            this.clCaSanXuat.OptionsColumn.AllowEdit = false;
            this.clCaSanXuat.OptionsColumn.FixedWidth = true;
            this.clCaSanXuat.Visible = true;
            this.clCaSanXuat.VisibleIndex = 5;
            this.clCaSanXuat.Width = 70;
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
            this.clNgungTheoDoi.Width = 60;
            // 
            // clXoa
            // 
            this.clXoa.Caption = "Xóa";
            this.clXoa.ColumnEdit = this.btXoa;
            this.clXoa.Name = "clXoa";
            this.clXoa.OptionsColumn.FixedWidth = true;
            this.clXoa.Width = 50;
            // 
            // btXoa
            // 
            this.btXoa.AutoHeight = false;
            this.btXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::CtyTinLuong.Properties.Resources.ico_Delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btXoa.Name = "btXoa";
            this.btXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // clID_CongNhan
            // 
            this.clID_CongNhan.Caption = "ID_CongNhan";
            this.clID_CongNhan.FieldName = "ID_CongNhan";
            this.clID_CongNhan.Name = "clID_CongNhan";
            this.clID_CongNhan.OptionsColumn.FixedWidth = true;
            // 
            // clGhiChu
            // 
            this.clGhiChu.AppearanceCell.Options.UseTextOptions = true;
            this.clGhiChu.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.clGhiChu.Caption = "Ghi chú";
            this.clGhiChu.ColumnEdit = this.repositoryItemMemoEdit1;
            this.clGhiChu.FieldName = "GhiChu";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.OptionsColumn.AllowEdit = false;
            this.clGhiChu.OptionsColumn.FixedWidth = true;
            this.clGhiChu.Visible = true;
            this.clGhiChu.VisibleIndex = 6;
            this.clGhiChu.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // clCongNhan
            // 
            this.clCongNhan.Caption = "Công nhân";
            this.clCongNhan.FieldName = "CongNhan";
            this.clCongNhan.Name = "clCongNhan";
            this.clCongNhan.OptionsColumn.AllowEdit = false;
            this.clCongNhan.Visible = true;
            this.clCongNhan.VisibleIndex = 3;
            this.clCongNhan.Width = 118;
            // 
            // clID_LoaiMay
            // 
            this.clID_LoaiMay.Caption = "ID_LoaiMay";
            this.clID_LoaiMay.FieldName = "ID_LoaiMay";
            this.clID_LoaiMay.Name = "clID_LoaiMay";
            // 
            // clID_CaTruong
            // 
            this.clID_CaTruong.Caption = "ID_CaTruong";
            this.clID_CaTruong.FieldName = "ID_CaTruong";
            this.clID_CaTruong.Name = "clID_CaTruong";
            // 
            // clCaTruong
            // 
            this.clCaTruong.Caption = "Ca trưởng";
            this.clCaTruong.FieldName = "CaTruong";
            this.clCaTruong.Name = "clCaTruong";
            this.clCaTruong.Visible = true;
            this.clCaTruong.VisibleIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.repositoryItemDateEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(894, 563);
            this.gridControl1.TabIndex = 101;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btfresh
            // 
            this.btfresh.Image = global::CtyTinLuong.Properties.Resources.ico_Update;
            this.btfresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btfresh.Location = new System.Drawing.Point(12, 11);
            this.btfresh.Name = "btfresh";
            this.btfresh.Size = new System.Drawing.Size(39, 23);
            this.btfresh.TabIndex = 102;
            this.btfresh.ToolTip = "Refesh";
            this.btfresh.Click += new System.EventHandler(this.btfresh_Click);
            // 
            // UCNPL_XuatKhoTheoLSXToGapDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btfresh);
            this.Controls.Add(this.gridControl1);
            this.Name = "UCNPL_XuatKhoTheoLSXToGapDan";
            this.Size = new System.Drawing.Size(900, 606);
            this.Load += new System.EventHandler(this.UCNPL_XuatKhoTheoLSXToGapDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clTenLoaiMay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clID_LenhSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clMaLenhSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clNgayThangSanXuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clCaSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clNgungTheoDoi;
        private DevExpress.XtraGrid.Columns.GridColumn clXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraGrid.Columns.GridColumn clID_CongNhan;
        private DevExpress.XtraGrid.Columns.GridColumn clGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clCongNhan;
        private DevExpress.XtraGrid.Columns.GridColumn clID_LoaiMay;
        private DevExpress.XtraGrid.Columns.GridColumn clID_CaTruong;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btfresh;
        private DevExpress.XtraGrid.Columns.GridColumn clCaTruong;
    }
}
