namespace CtyTinLuong
{
    partial class UC_SanXuat_LenhSanXuat
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
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
            this.clTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_LoaiMay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_CaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTrangThaiXuatNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.clboolMayIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.clboolMayCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.clboolMayDot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.checkMayIN = new System.Windows.Forms.CheckBox();
            this.checkMayCat = new System.Windows.Forms.CheckBox();
            this.checkMayDOT = new System.Windows.Forms.CheckBox();
            this.checkALL = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::CtyTinLuong.Properties.Resources.ico_Delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 34);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.repositoryItemDateEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4});
            this.gridControl1.Size = new System.Drawing.Size(703, 555);
            this.gridControl1.TabIndex = 75;
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
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
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
            this.clTenNhanVien,
            this.clID_LoaiMay,
            this.clID_CaTruong,
            this.clTrangThaiXuatNhap,
            this.clboolMayIn,
            this.clboolMayCat,
            this.clboolMayDot});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới tại đây";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
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
            this.clID_LenhSanXuat.Caption = "ID_SoPhieu";
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
            this.clCaSanXuat.VisibleIndex = 4;
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::CtyTinLuong.Properties.Resources.ico_Delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.btXoa.Name = "btXoa";
            this.btXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
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
            this.clGhiChu.VisibleIndex = 5;
            this.clGhiChu.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // clTenNhanVien
            // 
            this.clTenNhanVien.Caption = "Công nhân";
            this.clTenNhanVien.FieldName = "TenNhanVien";
            this.clTenNhanVien.Name = "clTenNhanVien";
            this.clTenNhanVien.OptionsColumn.AllowEdit = false;
            this.clTenNhanVien.Visible = true;
            this.clTenNhanVien.VisibleIndex = 3;
            this.clTenNhanVien.Width = 120;
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
            // clTrangThaiXuatNhap
            // 
            this.clTrangThaiXuatNhap.Caption = "Gửi";
            this.clTrangThaiXuatNhap.ColumnEdit = this.repositoryItemCheckEdit1;
            this.clTrangThaiXuatNhap.FieldName = "GuiDuLieu";
            this.clTrangThaiXuatNhap.Name = "clTrangThaiXuatNhap";
            this.clTrangThaiXuatNhap.OptionsColumn.AllowEdit = false;
            this.clTrangThaiXuatNhap.OptionsColumn.FixedWidth = true;
            this.clTrangThaiXuatNhap.Width = 40;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // clboolMayIn
            // 
            this.clboolMayIn.Caption = "IN";
            this.clboolMayIn.ColumnEdit = this.repositoryItemCheckEdit2;
            this.clboolMayIn.FieldName = "boolMayIn";
            this.clboolMayIn.Name = "clboolMayIn";
            this.clboolMayIn.OptionsColumn.AllowEdit = false;
            this.clboolMayIn.OptionsColumn.FixedWidth = true;
            this.clboolMayIn.Width = 40;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // clboolMayCat
            // 
            this.clboolMayCat.Caption = "Cắt";
            this.clboolMayCat.ColumnEdit = this.repositoryItemCheckEdit3;
            this.clboolMayCat.FieldName = "boolMayCat";
            this.clboolMayCat.Name = "clboolMayCat";
            this.clboolMayCat.OptionsColumn.AllowEdit = false;
            this.clboolMayCat.OptionsColumn.FixedWidth = true;
            this.clboolMayCat.Width = 40;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Caption = "Check";
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // clboolMayDot
            // 
            this.clboolMayDot.Caption = "Đột";
            this.clboolMayDot.ColumnEdit = this.repositoryItemCheckEdit4;
            this.clboolMayDot.FieldName = "boolMayDot";
            this.clboolMayDot.Name = "clboolMayDot";
            this.clboolMayDot.OptionsColumn.AllowEdit = false;
            this.clboolMayDot.OptionsColumn.FixedWidth = true;
            this.clboolMayDot.Width = 40;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Caption = "Check";
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // btRefresh
            // 
            this.btRefresh.Image = global::CtyTinLuong.Properties.Resources.ico_Update;
            this.btRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btRefresh.Location = new System.Drawing.Point(12, 5);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(39, 23);
            this.btRefresh.TabIndex = 80;
            this.btRefresh.ToolTip = "Refesh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // checkMayIN
            // 
            this.checkMayIN.AutoSize = true;
            this.checkMayIN.Location = new System.Drawing.Point(514, 11);
            this.checkMayIN.Name = "checkMayIN";
            this.checkMayIN.Size = new System.Drawing.Size(58, 17);
            this.checkMayIN.TabIndex = 84;
            this.checkMayIN.Text = "Máy In";
            this.checkMayIN.UseVisualStyleBackColor = true;
            this.checkMayIN.CheckedChanged += new System.EventHandler(this.checkMayIN_CheckedChanged);
            // 
            // checkMayCat
            // 
            this.checkMayCat.AutoSize = true;
            this.checkMayCat.Location = new System.Drawing.Point(578, 11);
            this.checkMayCat.Name = "checkMayCat";
            this.checkMayCat.Size = new System.Drawing.Size(65, 17);
            this.checkMayCat.TabIndex = 83;
            this.checkMayCat.Text = "Máy Cắt";
            this.checkMayCat.UseVisualStyleBackColor = true;
            this.checkMayCat.CheckedChanged += new System.EventHandler(this.checkMayCat_CheckedChanged);
            // 
            // checkMayDOT
            // 
            this.checkMayDOT.AutoSize = true;
            this.checkMayDOT.Location = new System.Drawing.Point(649, 11);
            this.checkMayDOT.Name = "checkMayDOT";
            this.checkMayDOT.Size = new System.Drawing.Size(66, 17);
            this.checkMayDOT.TabIndex = 82;
            this.checkMayDOT.Text = "Máy Đột";
            this.checkMayDOT.UseVisualStyleBackColor = true;
            this.checkMayDOT.CheckedChanged += new System.EventHandler(this.checkMayDOT_CheckedChanged);
            // 
            // checkALL
            // 
            this.checkALL.AutoSize = true;
            this.checkALL.Location = new System.Drawing.Point(450, 11);
            this.checkALL.Name = "checkALL";
            this.checkALL.Size = new System.Drawing.Size(57, 17);
            this.checkALL.TabIndex = 85;
            this.checkALL.Text = "Tất cả";
            this.checkALL.UseVisualStyleBackColor = true;
            this.checkALL.CheckedChanged += new System.EventHandler(this.checkALL_CheckedChanged);
            // 
            // UC_SanXuat_LenhSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkALL);
            this.Controls.Add(this.checkMayIN);
            this.Controls.Add(this.checkMayCat);
            this.Controls.Add(this.checkMayDOT);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btRefresh);
            this.Name = "UC_SanXuat_LenhSanXuat";
            this.Size = new System.Drawing.Size(727, 606);
            this.Load += new System.EventHandler(this.UC_SanXuat_LenhSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clID_LenhSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clMaLenhSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clNgayThangSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clCaSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clNgungTheoDoi;
        private DevExpress.XtraGrid.Columns.GridColumn clXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clID_CongNhan;
        private DevExpress.XtraGrid.Columns.GridColumn clGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNhanVien;
        private System.Windows.Forms.CheckBox checkMayIN;
        private System.Windows.Forms.CheckBox checkMayCat;
        private System.Windows.Forms.CheckBox checkMayDOT;
        private DevExpress.XtraGrid.Columns.GridColumn clID_LoaiMay;
        private DevExpress.XtraGrid.Columns.GridColumn clID_CaTruong;
        private DevExpress.XtraGrid.Columns.GridColumn clTrangThaiXuatNhap;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clboolMayIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn clboolMayCat;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn clboolMayDot;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private System.Windows.Forms.CheckBox checkALL;
    }
}
