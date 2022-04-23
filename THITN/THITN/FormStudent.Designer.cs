
namespace THITN
{
    partial class FormStudent
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label mASVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            System.Windows.Forms.Label label5;
            this.DSStudent = new THITN.DSStudent();
            this.BDSClass = new System.Windows.Forms.BindingSource(this.components);
            this.TAClass = new THITN.DSStudentTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new THITN.DSStudentTableAdapters.TableAdapterManager();
            this.TAStudent = new THITN.DSStudentTableAdapters.SINHVIENTableAdapter();
            this.BDSStudent = new System.Windows.Forms.BindingSource(this.components);
            this.BDSTranscript = new System.Windows.Forms.BindingSource(this.components);
            this.TATranscript = new THITN.DSStudentTableAdapters.BANGDIEMTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
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
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GCClass = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCStudent = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMASV = new System.Windows.Forms.TextBox();
            this.tbHO = new System.Windows.Forms.TextBox();
            this.tbTEN = new System.Windows.Forms.TextBox();
            this.deNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.tbDIACHI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMATKHAU = new System.Windows.Forms.TextBox();
            mAGVLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTranscript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYSINH.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(70, 113);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(88, 23);
            mAGVLabel.TabIndex = 2;
            mAGVLabel.Text = "DIACHI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(746, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 23);
            label2.TabIndex = 3;
            label2.Text = "TEN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(1087, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 23);
            label3.TabIndex = 4;
            label3.Text = "NGAYSINH:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(421, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 23);
            label4.TabIndex = 5;
            label4.Text = "HO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(85, 26);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 23);
            label6.TabIndex = 7;
            label6.Text = "MASV:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(355, 124);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(0, 17);
            mASVLabel.TabIndex = 7;
            // 
            // DSStudent
            // 
            this.DSStudent.DataSetName = "DSStudent";
            this.DSStudent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDSClass
            // 
            this.BDSClass.DataMember = "LOP";
            this.BDSClass.DataSource = this.DSStudent;
            // 
            // TAClass
            // 
            this.TAClass.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.TAClass;
            this.tableAdapterManager.SINHVIENTableAdapter = this.TAStudent;
            this.tableAdapterManager.UpdateOrder = THITN.DSStudentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TAStudent
            // 
            this.TAStudent.ClearBeforeFill = true;
            // 
            // BDSStudent
            // 
            this.BDSStudent.DataMember = "FK_SINHVIEN_LOP";
            this.BDSStudent.DataSource = this.BDSClass;
            // 
            // BDSTranscript
            // 
            this.BDSTranscript.DataMember = "FK_BANGDIEM_SINHVIEN1";
            this.BDSTranscript.DataSource = this.BDSStudent;
            // 
            // TATranscript
            // 
            this.TATranscript.ClearBeforeFill = true;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1496, 62);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 755);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem8,
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
            this.barDockControlTop.Size = new System.Drawing.Size(1496, 62);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 817);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1496, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 755);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1496, 62);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 755);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem1";
            this.barButtonItem8.Id = 0;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbBrand);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 62);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1496, 103);
            this.panelControl1.TabIndex = 34;
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
            // GCClass
            // 
            this.GCClass.DataSource = this.BDSClass;
            this.GCClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.GCClass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCClass.Location = new System.Drawing.Point(0, 165);
            this.GCClass.MainView = this.gridView1;
            this.GCClass.Name = "GCClass";
            this.GCClass.Size = new System.Drawing.Size(539, 468);
            this.GCClass.TabIndex = 35;
            this.GCClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.GCClass;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 94;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 25;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 94;
            // 
            // GCStudent
            // 
            this.GCStudent.DataSource = this.BDSStudent;
            this.GCStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCStudent.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCStudent.Location = new System.Drawing.Point(539, 165);
            this.GCStudent.MainView = this.gridView2;
            this.GCStudent.Name = "GCStudent";
            this.GCStudent.Size = new System.Drawing.Size(957, 468);
            this.GCStudent.TabIndex = 36;
            this.GCStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI});
            this.gridView2.GridControl = this.GCStudent;
            this.gridView2.Name = "gridView2";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // tbMASV
            // 
            this.tbMASV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSStudent, "MASV", true));
            this.tbMASV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMASV.Location = new System.Drawing.Point(164, 23);
            this.tbMASV.Name = "tbMASV";
            this.tbMASV.Size = new System.Drawing.Size(167, 30);
            this.tbMASV.TabIndex = 8;
            // 
            // tbHO
            // 
            this.tbHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSStudent, "HO", true));
            this.tbHO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHO.Location = new System.Drawing.Point(476, 25);
            this.tbHO.Name = "tbHO";
            this.tbHO.Size = new System.Drawing.Size(167, 30);
            this.tbHO.TabIndex = 10;
            // 
            // tbTEN
            // 
            this.tbTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSStudent, "TEN", true));
            this.tbTEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTEN.Location = new System.Drawing.Point(818, 25);
            this.tbTEN.Name = "tbTEN";
            this.tbTEN.Size = new System.Drawing.Size(159, 30);
            this.tbTEN.TabIndex = 12;
            // 
            // deNGAYSINH
            // 
            this.deNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BDSStudent, "NGAYSINH", true));
            this.deNGAYSINH.EditValue = null;
            this.deNGAYSINH.Location = new System.Drawing.Point(1223, 25);
            this.deNGAYSINH.Name = "deNGAYSINH";
            this.deNGAYSINH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNGAYSINH.Properties.Appearance.Options.UseFont = true;
            this.deNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYSINH.Size = new System.Drawing.Size(159, 28);
            this.deNGAYSINH.TabIndex = 13;
            // 
            // tbDIACHI
            // 
            this.tbDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSStudent, "DIACHI", true));
            this.tbDIACHI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDIACHI.Location = new System.Drawing.Point(164, 111);
            this.tbDIACHI.Name = "tbDIACHI";
            this.tbDIACHI.Size = new System.Drawing.Size(762, 30);
            this.tbDIACHI.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.tbMATKHAU);
            this.groupBox1.Controls.Add(this.tbDIACHI);
            this.groupBox1.Controls.Add(this.deNGAYSINH);
            this.groupBox1.Controls.Add(this.tbTEN);
            this.groupBox1.Controls.Add(this.tbHO);
            this.groupBox1.Controls.Add(mASVLabel);
            this.groupBox1.Controls.Add(this.tbMASV);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 633);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1496, 184);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // tbMATKHAU
            // 
            this.tbMATKHAU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSStudent, "MATKHAU", true));
            this.tbMATKHAU.Enabled = false;
            this.tbMATKHAU.Location = new System.Drawing.Point(1223, 109);
            this.tbMATKHAU.Name = "tbMATKHAU";
            this.tbMATKHAU.PasswordChar = '*';
            this.tbMATKHAU.Size = new System.Drawing.Size(159, 22);
            this.tbMATKHAU.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(1087, 109);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 23);
            label5.TabIndex = 16;
            label5.Text = "MATKHAU:";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1496, 837);
            this.Controls.Add(this.GCStudent);
            this.Controls.Add(this.GCClass);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTranscript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYSINH.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource BDSClass;
        private DSStudent DSStudent;
        private DSStudentTableAdapters.LOPTableAdapter TAClass;
        private DSStudentTableAdapters.TableAdapterManager tableAdapterManager;
        private DSStudentTableAdapters.SINHVIENTableAdapter TAStudent;
        private System.Windows.Forms.BindingSource BDSStudent;
        private System.Windows.Forms.BindingSource BDSTranscript;
        private DSStudentTableAdapters.BANGDIEMTableAdapter TATranscript;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
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
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraGrid.GridControl GCStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.GridControl GCClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDIACHI;
        private DevExpress.XtraEditors.DateEdit deNGAYSINH;
        private System.Windows.Forms.TextBox tbTEN;
        private System.Windows.Forms.TextBox tbHO;
        private System.Windows.Forms.TextBox tbMASV;
        private System.Windows.Forms.TextBox tbMATKHAU;
    }
}