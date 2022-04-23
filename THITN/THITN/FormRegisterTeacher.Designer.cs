
namespace THITN
{
    partial class FormRegisterTeacher
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
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterTeacher));
            this.DSRegisterTeacher = new THITN.DSRegisterTeacher();
            this.BDSRegisterTeacher = new System.Windows.Forms.BindingSource(this.components);
            this.TARegisterTeacher = new THITN.DSRegisterTeacherTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new THITN.DSRegisterTeacherTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemove = new DevExpress.XtraBars.BarButtonItem();
            this.btnModify = new DevExpress.XtraBars.BarButtonItem();
            this.btnNote = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GCRegisterTeacher = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTHOIGIAN = new System.Windows.Forms.TextBox();
            this.tbSOCAUTHI = new System.Windows.Forms.TextBox();
            this.cbbLAN = new System.Windows.Forms.ComboBox();
            this.deNGAYTHI = new DevExpress.XtraEditors.DateEdit();
            this.cbbTRINHDO = new System.Windows.Forms.ComboBox();
            this.tbMALOP = new System.Windows.Forms.TextBox();
            this.tbMAMH = new System.Windows.Forms.TextBox();
            this.tbMAGV = new System.Windows.Forms.TextBox();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSRegisterTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSRegisterTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCRegisterTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(632, 115);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(0, 17);
            sOCAUTHILabel.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(873, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(82, 23);
            label8.TabIndex = 9;
            label8.Text = "MAMH:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(102, 95);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(90, 23);
            label7.TabIndex = 8;
            label7.Text = "MALOP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(82, 168);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(110, 23);
            label6.TabIndex = 7;
            label6.Text = "TRINHDO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(474, 30);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(107, 23);
            label5.TabIndex = 6;
            label5.Text = "NGAYTHI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(899, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 23);
            label4.TabIndex = 5;
            label4.Text = "LAN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(460, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 23);
            label3.TabIndex = 4;
            label3.Text = "SOCAUTHI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(462, 170);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 23);
            label2.TabIndex = 3;
            label2.Text = "THOIGIAN:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(110, 30);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(77, 23);
            mAGVLabel.TabIndex = 1;
            mAGVLabel.Text = "MAGV:";
            // 
            // DSRegisterTeacher
            // 
            this.DSRegisterTeacher.DataSetName = "DSRegisterTeacher";
            this.DSRegisterTeacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDSRegisterTeacher
            // 
            this.BDSRegisterTeacher.DataMember = "GIAOVIEN_DANGKY";
            this.BDSRegisterTeacher.DataSource = this.DSRegisterTeacher;
            // 
            // TARegisterTeacher
            // 
            this.TARegisterTeacher.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.TARegisterTeacher;
            this.tableAdapterManager.UpdateOrder = THITN.DSRegisterTeacherTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnAdd,
            this.btnRemove,
            this.btnModify,
            this.btnUndo,
            this.btnReload,
            this.btnExit,
            this.btnNote});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRemove, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNote, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.ActAsDropDown = true;
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(0, 50);
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Caption = "Xóa";
            this.btnRemove.Id = 2;
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.LargeImage")));
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemove_ItemClick);
            // 
            // btnModify
            // 
            this.btnModify.Caption = "Sửa";
            this.btnModify.Id = 3;
            this.btnModify.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.ImageOptions.Image")));
            this.btnModify.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnModify.ImageOptions.LargeImage")));
            this.btnModify.Name = "btnModify";
            this.btnModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModify_ItemClick);
            // 
            // btnNote
            // 
            this.btnNote.Caption = "Ghi";
            this.btnNote.Id = 7;
            this.btnNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNote.ImageOptions.Image")));
            this.btnNote.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNote.ImageOptions.LargeImage")));
            this.btnNote.Name = "btnNote";
            this.btnNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNote_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 6;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1187, 62);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 655);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1187, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 593);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1187, 62);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 593);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbBrand);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 62);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1187, 103);
            this.panelControl1.TabIndex = 24;
            // 
            // cbbBrand
            // 
            this.cbbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBrand.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBrand.FormattingEnabled = true;
            this.cbbBrand.Location = new System.Drawing.Point(164, 39);
            this.cbbBrand.Margin = new System.Windows.Forms.Padding(8);
            this.cbbBrand.Name = "cbbBrand";
            this.cbbBrand.Size = new System.Drawing.Size(233, 28);
            this.cbbBrand.TabIndex = 1;
            this.cbbBrand.SelectedIndexChanged += new System.EventHandler(this.cbbBrand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở";
            // 
            // GCRegisterTeacher
            // 
            this.GCRegisterTeacher.DataSource = this.BDSRegisterTeacher;
            this.GCRegisterTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCRegisterTeacher.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.GCRegisterTeacher.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCRegisterTeacher.Location = new System.Drawing.Point(0, 165);
            this.GCRegisterTeacher.MainView = this.gridView1;
            this.GCRegisterTeacher.Margin = new System.Windows.Forms.Padding(5);
            this.GCRegisterTeacher.Name = "GCRegisterTeacher";
            this.GCRegisterTeacher.Size = new System.Drawing.Size(1187, 335);
            this.GCRegisterTeacher.TabIndex = 25;
            this.GCRegisterTeacher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.GCRegisterTeacher;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 39;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 146;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 39;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 146;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 39;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            this.colMALOP.Width = 146;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 39;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            this.colTRINHDO.Width = 146;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 39;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            this.colNGAYTHI.Width = 146;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 39;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            this.colLAN.Width = 146;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 39;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            this.colSOCAUTHI.Width = 146;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 39;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            this.colTHOIGIAN.Width = 146;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTHOIGIAN);
            this.groupBox1.Controls.Add(sOCAUTHILabel);
            this.groupBox1.Controls.Add(this.tbSOCAUTHI);
            this.groupBox1.Controls.Add(this.cbbLAN);
            this.groupBox1.Controls.Add(this.deNGAYTHI);
            this.groupBox1.Controls.Add(this.cbbTRINHDO);
            this.groupBox1.Controls.Add(this.tbMALOP);
            this.groupBox1.Controls.Add(this.tbMAMH);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.tbMAGV);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 155);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // tbTHOIGIAN
            // 
            this.tbTHOIGIAN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSRegisterTeacher, "THOIGIAN", true));
            this.tbTHOIGIAN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTHOIGIAN.Location = new System.Drawing.Point(597, 168);
            this.tbTHOIGIAN.Name = "tbTHOIGIAN";
            this.tbTHOIGIAN.Size = new System.Drawing.Size(152, 30);
            this.tbTHOIGIAN.TabIndex = 17;
            // 
            // tbSOCAUTHI
            // 
            this.tbSOCAUTHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSRegisterTeacher, "SOCAUTHI", true));
            this.tbSOCAUTHI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSOCAUTHI.Location = new System.Drawing.Point(597, 93);
            this.tbSOCAUTHI.Name = "tbSOCAUTHI";
            this.tbSOCAUTHI.Size = new System.Drawing.Size(152, 30);
            this.tbSOCAUTHI.TabIndex = 16;
            // 
            // cbbLAN
            // 
            this.cbbLAN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSRegisterTeacher, "LAN", true));
            this.cbbLAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLAN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLAN.FormattingEnabled = true;
            this.cbbLAN.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbLAN.Location = new System.Drawing.Point(975, 95);
            this.cbbLAN.Name = "cbbLAN";
            this.cbbLAN.Size = new System.Drawing.Size(165, 30);
            this.cbbLAN.TabIndex = 15;
            // 
            // deNGAYTHI
            // 
            this.deNGAYTHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BDSRegisterTeacher, "NGAYTHI", true));
            this.deNGAYTHI.EditValue = null;
            this.deNGAYTHI.Location = new System.Drawing.Point(597, 28);
            this.deNGAYTHI.Name = "deNGAYTHI";
            this.deNGAYTHI.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNGAYTHI.Properties.Appearance.Options.UseFont = true;
            this.deNGAYTHI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYTHI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYTHI.Size = new System.Drawing.Size(152, 28);
            this.deNGAYTHI.TabIndex = 14;
            // 
            // cbbTRINHDO
            // 
            this.cbbTRINHDO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSRegisterTeacher, "TRINHDO", true));
            this.cbbTRINHDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTRINHDO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTRINHDO.FormattingEnabled = true;
            this.cbbTRINHDO.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbbTRINHDO.Location = new System.Drawing.Point(212, 166);
            this.cbbTRINHDO.Name = "cbbTRINHDO";
            this.cbbTRINHDO.Size = new System.Drawing.Size(165, 30);
            this.cbbTRINHDO.TabIndex = 12;
            // 
            // tbMALOP
            // 
            this.tbMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSRegisterTeacher, "MALOP", true));
            this.tbMALOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMALOP.Location = new System.Drawing.Point(212, 95);
            this.tbMALOP.Name = "tbMALOP";
            this.tbMALOP.Size = new System.Drawing.Size(165, 30);
            this.tbMALOP.TabIndex = 11;
            // 
            // tbMAMH
            // 
            this.tbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSRegisterTeacher, "MAMH", true));
            this.tbMAMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMAMH.Location = new System.Drawing.Point(975, 28);
            this.tbMAMH.Name = "tbMAMH";
            this.tbMAMH.Size = new System.Drawing.Size(165, 30);
            this.tbMAMH.TabIndex = 10;
            // 
            // tbMAGV
            // 
            this.tbMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSRegisterTeacher, "MAGV", true));
            this.tbMAGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMAGV.Location = new System.Drawing.Point(212, 28);
            this.tbMAGV.Name = "tbMAGV";
            this.tbMAGV.Size = new System.Drawing.Size(165, 30);
            this.tbMAGV.TabIndex = 2;
            // 
            // FormRegisterTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GCRegisterTeacher);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormRegisterTeacher";
            this.Text = "FormRegisterTeacher";
            this.Load += new System.EventHandler(this.FormRegisterTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSRegisterTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSRegisterTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCRegisterTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYTHI.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource BDSRegisterTeacher;
        private DSRegisterTeacher DSRegisterTeacher;
        private DSRegisterTeacherTableAdapters.GIAOVIEN_DANGKYTableAdapter TARegisterTeacher;
        private DSRegisterTeacherTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnRemove;
        private DevExpress.XtraBars.BarButtonItem btnModify;
        private DevExpress.XtraBars.BarButtonItem btnNote;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTHOIGIAN;
        private System.Windows.Forms.TextBox tbSOCAUTHI;
        private System.Windows.Forms.ComboBox cbbLAN;
        private DevExpress.XtraEditors.DateEdit deNGAYTHI;
        private System.Windows.Forms.ComboBox cbbTRINHDO;
        private System.Windows.Forms.TextBox tbMALOP;
        private System.Windows.Forms.TextBox tbMAMH;
        private System.Windows.Forms.TextBox tbMAGV;
        private DevExpress.XtraGrid.GridControl GCRegisterTeacher;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Label label1;
    }
}