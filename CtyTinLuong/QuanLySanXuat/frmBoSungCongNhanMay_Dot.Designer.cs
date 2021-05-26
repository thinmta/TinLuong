namespace CtyTinLuong
{
    partial class frmBoSungCongNhanMay_Dot
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dteNgaySanXuat_May_DOT = new DevExpress.XtraEditors.DateEdit();
            this.cbCaSanXuat_May_DOT = new System.Windows.Forms.ComboBox();
            this.txtToTruong = new System.Windows.Forms.TextBox();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_SoPhieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_CongNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clID_CaTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgaySanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clCaSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clHienThi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgaySanXuat_May_DOT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgaySanXuat_May_DOT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Appearance.Options.UseFont = true;
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.ImageOptions.Image = global::CtyTinLuong.Properties.Resources.ico_Abort;
            this.btThoat.Location = new System.Drawing.Point(463, 431);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(88, 22);
            this.btThoat.StyleController = this.layoutControl1;
            this.btThoat.TabIndex = 108;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dteNgaySanXuat_May_DOT);
            this.layoutControl1.Controls.Add(this.cbCaSanXuat_May_DOT);
            this.layoutControl1.Controls.Add(this.txtToTruong);
            this.layoutControl1.Controls.Add(this.btLuu);
            this.layoutControl1.Controls.Add(this.btThoat);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 16);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(555, 457);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dteNgaySanXuat_May_DOT
            // 
            this.dteNgaySanXuat_May_DOT.EditValue = null;
            this.dteNgaySanXuat_May_DOT.Location = new System.Drawing.Point(55, 4);
            this.dteNgaySanXuat_May_DOT.Name = "dteNgaySanXuat_May_DOT";
            this.dteNgaySanXuat_May_DOT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgaySanXuat_May_DOT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgaySanXuat_May_DOT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dteNgaySanXuat_May_DOT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteNgaySanXuat_May_DOT.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dteNgaySanXuat_May_DOT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dteNgaySanXuat_May_DOT.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dteNgaySanXuat_May_DOT.Size = new System.Drawing.Size(267, 20);
            this.dteNgaySanXuat_May_DOT.StyleController = this.layoutControl1;
            this.dteNgaySanXuat_May_DOT.TabIndex = 114;
            // 
            // cbCaSanXuat_May_DOT
            // 
            this.cbCaSanXuat_May_DOT.FormattingEnabled = true;
            this.cbCaSanXuat_May_DOT.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2"});
            this.cbCaSanXuat_May_DOT.Location = new System.Drawing.Point(377, 4);
            this.cbCaSanXuat_May_DOT.Name = "cbCaSanXuat_May_DOT";
            this.cbCaSanXuat_May_DOT.Size = new System.Drawing.Size(174, 21);
            this.cbCaSanXuat_May_DOT.TabIndex = 113;
            // 
            // txtToTruong
            // 
            this.txtToTruong.Location = new System.Drawing.Point(55, 29);
            this.txtToTruong.Name = "txtToTruong";
            this.txtToTruong.Size = new System.Drawing.Size(496, 20);
            this.txtToTruong.TabIndex = 114;
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.ImageOptions.Image = global::CtyTinLuong.Properties.Resources.ico_Save;
            this.btLuu.Location = new System.Drawing.Point(384, 431);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 22);
            this.btLuu.StyleController = this.layoutControl1;
            this.btLuu.TabIndex = 113;
            this.btLuu.Text = "Lưu ";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.gridMaNhanVien});
            this.gridControl1.Size = new System.Drawing.Size(547, 374);
            this.gridControl1.TabIndex = 111;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaNhanVien,
            this.clSTT,
            this.clID_SoPhieu,
            this.clID_CongNhan,
            this.clID_CaTruong,
            this.clNgaySanXuat,
            this.clCaSanXuat,
            this.clTenNhanVien,
            this.gridColumn1,
            this.clHienThi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridView1_CustomRowFilter);
            // 
            // clMaNhanVien
            // 
            this.clMaNhanVien.Caption = "Mã CN";
            this.clMaNhanVien.ColumnEdit = this.gridMaNhanVien;
            this.clMaNhanVien.FieldName = "MaNhanVien";
            this.clMaNhanVien.Name = "clMaNhanVien";
            this.clMaNhanVien.Visible = true;
            this.clMaNhanVien.VisibleIndex = 1;
            this.clMaNhanVien.Width = 111;
            // 
            // gridMaNhanVien
            // 
            this.gridMaNhanVien.AutoHeight = false;
            this.gridMaNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridMaNhanVien.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_NhanSu", "ID_NhanSu", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNhanVien", "Mã CN", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNhanVien", "Họ tên", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.gridMaNhanVien.Name = "gridMaNhanVien";
            // 
            // clSTT
            // 
            this.clSTT.Caption = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.Visible = true;
            this.clSTT.VisibleIndex = 0;
            this.clSTT.Width = 46;
            // 
            // clID_SoPhieu
            // 
            this.clID_SoPhieu.Caption = "ID_SoPhieu";
            this.clID_SoPhieu.FieldName = "ID_SoPhieu";
            this.clID_SoPhieu.Name = "clID_SoPhieu";
            // 
            // clID_CongNhan
            // 
            this.clID_CongNhan.Caption = "ID_CongNhan";
            this.clID_CongNhan.FieldName = "ID_CongNhan";
            this.clID_CongNhan.Name = "clID_CongNhan";
            // 
            // clID_CaTruong
            // 
            this.clID_CaTruong.Caption = "ID_CaTruong";
            this.clID_CaTruong.FieldName = "ID_CaTruong";
            this.clID_CaTruong.Name = "clID_CaTruong";
            // 
            // clNgaySanXuat
            // 
            this.clNgaySanXuat.Caption = "Ngày";
            this.clNgaySanXuat.FieldName = "NgaySanXuat";
            this.clNgaySanXuat.Name = "clNgaySanXuat";
            this.clNgaySanXuat.Width = 137;
            // 
            // clCaSanXuat
            // 
            this.clCaSanXuat.Caption = "Ca SX";
            this.clCaSanXuat.FieldName = "CaSanXuat";
            this.clCaSanXuat.Name = "clCaSanXuat";
            this.clCaSanXuat.Width = 45;
            // 
            // clTenNhanVien
            // 
            this.clTenNhanVien.AppearanceCell.Options.UseTextOptions = true;
            this.clTenNhanVien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.clTenNhanVien.Caption = "Họ tên";
            this.clTenNhanVien.FieldName = "TenNhanVien";
            this.clTenNhanVien.Name = "clTenNhanVien";
            this.clTenNhanVien.OptionsColumn.AllowEdit = false;
            this.clTenNhanVien.Visible = true;
            this.clTenNhanVien.VisibleIndex = 2;
            this.clTenNhanVien.Width = 256;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Xoá";
            this.gridColumn1.ColumnEdit = this.btXoa;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 40;
            // 
            // btXoa
            // 
            this.btXoa.AutoHeight = false;
            editorButtonImageOptions2.Image = global::CtyTinLuong.Properties.Resources.ico_Delete;
            this.btXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btXoa.Name = "btXoa";
            this.btXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btXoa_ButtonClick);
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // clHienThi
            // 
            this.clHienThi.Caption = "Hiển thị";
            this.clHienThi.FieldName = "HienThi";
            this.clHienThi.Name = "clHienThi";
            this.clHienThi.Width = 76;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(555, 457);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(551, 378);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btThoat;
            this.layoutControlItem2.Location = new System.Drawing.Point(459, 427);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 427);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(380, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btLuu;
            this.layoutControlItem3.Location = new System.Drawing.Point(380, 427);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(79, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtToTruong;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(551, 24);
            this.layoutControlItem4.Text = "Tổ trưởng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbCaSanXuat_May_DOT;
            this.layoutControlItem5.Location = new System.Drawing.Point(322, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(229, 25);
            this.layoutControlItem5.Text = "Ca SX";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dteNgaySanXuat_May_DOT;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(322, 25);
            this.layoutControlItem6.Text = "Ngày SX";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 13);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 476);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // frmBoSungCongNhanMay_Dot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBoSungCongNhanMay_Dot";
            this.Text = "Công nhân phụ máy Đột";
            this.Load += new System.EventHandler(this.frmBoSungCongNhanMay_Dot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteNgaySanXuat_May_DOT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgaySanXuat_May_DOT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btThoat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clSTT;
        private DevExpress.XtraGrid.Columns.GridColumn clID_SoPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn clID_CongNhan;
        private DevExpress.XtraGrid.Columns.GridColumn clID_CaTruong;
        private DevExpress.XtraGrid.Columns.GridColumn clNgaySanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clCaSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.TextBox txtToTruong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraGrid.Columns.GridColumn clHienThi;
        private DevExpress.XtraEditors.DateEdit dteNgaySanXuat_May_DOT;
        private System.Windows.Forms.ComboBox cbCaSanXuat_May_DOT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn clMaNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gridMaNhanVien;
    }
}