
namespace THITN
{
    partial class FormTeacher
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.BDSTeacher = new System.Windows.Forms.BindingSource(this.components);
            this.BDSDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.DSTeacher = new THITN.DSTeacher();
            this.TATeacher = new THITN.DSTeacherTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new THITN.DSTeacherTableAdapters.TableAdapterManager();
            this.TADepartment = new THITN.DSTeacherTableAdapters.KHOATableAdapter();
            this.BDSRegisterTeacher = new System.Windows.Forms.BindingSource(this.components);
            this.TARegisterTeacher = new THITN.DSTeacherTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.BDSTopic = new System.Windows.Forms.BindingSource(this.components);
            this.TATopic = new THITN.DSTeacherTableAdapters.BODETableAdapter();
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
            this.GCDepartment = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCTeacher = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMAGV = new System.Windows.Forms.TextBox();
            this.tbHO = new System.Windows.Forms.TextBox();
            this.tbTEN = new System.Windows.Forms.TextBox();
            this.tbDIACHI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSRegisterTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(78, 123);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 23);
            label4.TabIndex = 6;
            label4.Text = "DIACHI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(887, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 23);
            label2.TabIndex = 7;
            label2.Text = "TEN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(521, 42);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 23);
            label3.TabIndex = 8;
            label3.Text = "HO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(88, 42);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 23);
            label5.TabIndex = 9;
            label5.Text = "MAGV:";
            // 
            // BDSTeacher
            // 
            this.BDSTeacher.DataMember = "FK_GIAOVIEN_KHOA";
            this.BDSTeacher.DataSource = this.BDSDepartment;
            // 
            // BDSDepartment
            // 
            this.BDSDepartment.DataMember = "KHOA";
            this.BDSDepartment.DataSource = this.DSTeacher;
            // 
            // DSTeacher
            // 
            this.DSTeacher.DataSetName = "DSTeacher";
            this.DSTeacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TATeacher
            // 
            this.TATeacher.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.TATeacher;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSTeacherTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TADepartment
            // 
            this.TADepartment.ClearBeforeFill = true;
            // 
            // BDSRegisterTeacher
            // 
            this.BDSRegisterTeacher.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.BDSRegisterTeacher.DataSource = this.BDSTeacher;
            // 
            // TARegisterTeacher
            // 
            this.TARegisterTeacher.ClearBeforeFill = true;
            // 
            // BDSTopic
            // 
            this.BDSTopic.DataMember = "FK_BODE_GIAOVIEN";
            this.BDSTopic.DataSource = this.BDSTeacher;
            // 
            // TATopic
            // 
            this.TATopic.ClearBeforeFill = true;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1225, 62);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 633);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1225, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 571);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1225, 62);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 571);
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
            this.panelControl1.Size = new System.Drawing.Size(1225, 103);
            this.panelControl1.TabIndex = 29;
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
            // GCDepartment
            // 
            this.GCDepartment.DataSource = this.BDSDepartment;
            this.GCDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.GCDepartment.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GCDepartment.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCDepartment.Location = new System.Drawing.Point(0, 165);
            this.GCDepartment.MainView = this.gridView1;
            this.GCDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.GCDepartment.Name = "GCDepartment";
            this.GCDepartment.Size = new System.Drawing.Size(456, 268);
            this.GCDepartment.TabIndex = 30;
            this.GCDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.GCDepartment;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 31;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 117;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 31;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 117;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 31;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 117;
            // 
            // GCTeacher
            // 
            this.GCTeacher.DataSource = this.BDSTeacher;
            this.GCTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCTeacher.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GCTeacher.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCTeacher.Location = new System.Drawing.Point(456, 165);
            this.GCTeacher.MainView = this.gridView2;
            this.GCTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.GCTeacher.Name = "GCTeacher";
            this.GCTeacher.Size = new System.Drawing.Size(769, 268);
            this.GCTeacher.TabIndex = 31;
            this.GCTeacher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI});
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.GCTeacher;
            this.gridView2.Name = "gridView2";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 31;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 117;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 31;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 117;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 31;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 117;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 31;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 117;
            // 
            // tbMAGV
            // 
            this.tbMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTeacher, "MAGV", true));
            this.tbMAGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMAGV.Location = new System.Drawing.Point(185, 35);
            this.tbMAGV.Name = "tbMAGV";
            this.tbMAGV.Size = new System.Drawing.Size(190, 30);
            this.tbMAGV.TabIndex = 10;
            // 
            // tbHO
            // 
            this.tbHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTeacher, "HO", true));
            this.tbHO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHO.Location = new System.Drawing.Point(589, 35);
            this.tbHO.Name = "tbHO";
            this.tbHO.Size = new System.Drawing.Size(190, 30);
            this.tbHO.TabIndex = 11;
            // 
            // tbTEN
            // 
            this.tbTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTeacher, "TEN", true));
            this.tbTEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTEN.Location = new System.Drawing.Point(961, 35);
            this.tbTEN.Name = "tbTEN";
            this.tbTEN.Size = new System.Drawing.Size(197, 30);
            this.tbTEN.TabIndex = 12;
            // 
            // tbDIACHI
            // 
            this.tbDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTeacher, "DIACHI", true));
            this.tbDIACHI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDIACHI.Location = new System.Drawing.Point(185, 123);
            this.tbDIACHI.Name = "tbDIACHI";
            this.tbDIACHI.Size = new System.Drawing.Size(664, 30);
            this.tbDIACHI.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDIACHI);
            this.groupBox1.Controls.Add(this.tbTEN);
            this.groupBox1.Controls.Add(this.tbHO);
            this.groupBox1.Controls.Add(this.tbMAGV);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1225, 200);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1225, 653);
            this.Controls.Add(this.GCTeacher);
            this.Controls.Add(this.GCDepartment);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDSTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSRegisterTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DSTeacher DSTeacher;
        private DSTeacherTableAdapters.GIAOVIENTableAdapter TATeacher;
        private DSTeacherTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource BDSDepartment;
        private DSTeacherTableAdapters.KHOATableAdapter TADepartment;
        private System.Windows.Forms.BindingSource BDSTeacher;
        private System.Windows.Forms.BindingSource BDSRegisterTeacher;
        private DSTeacherTableAdapters.GIAOVIEN_DANGKYTableAdapter TARegisterTeacher;
        private System.Windows.Forms.BindingSource BDSTopic;
        private DSTeacherTableAdapters.BODETableAdapter TATopic;
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
        private DevExpress.XtraGrid.GridControl GCTeacher;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.GridControl GCDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDIACHI;
        private System.Windows.Forms.TextBox tbTEN;
        private System.Windows.Forms.TextBox tbHO;
        private System.Windows.Forms.TextBox tbMAGV;
    }
}