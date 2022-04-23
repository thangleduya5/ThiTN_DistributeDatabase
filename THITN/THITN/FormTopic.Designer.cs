
namespace THITN
{
    partial class FormTopic
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
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label cAUHOILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopic));
            this.DSTopic = new THITN.DSTopic();
            this.BDSTopic = new System.Windows.Forms.BindingSource(this.components);
            this.TATopic = new THITN.DSTopicTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new THITN.DSTopicTableAdapters.TableAdapterManager();
            this.TATest = new THITN.DSTopicTableAdapters.CTBAITHITableAdapter();
            this.BDSTest = new System.Windows.Forms.BindingSource(this.components);
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
            this.GCTopic = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCAUHOI = new System.Windows.Forms.TextBox();
            this.tbMAMH = new System.Windows.Forms.TextBox();
            this.tbMAGV = new System.Windows.Forms.TextBox();
            this.cbbTRINHDO = new System.Windows.Forms.ComboBox();
            this.cbbDAP_AN = new System.Windows.Forms.ComboBox();
            this.tbNOIDUNG = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            dAP_ANLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            cAUHOILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dAP_ANLabel.Location = new System.Drawing.Point(724, 80);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(88, 23);
            dAP_ANLabel.TabIndex = 38;
            dAP_ANLabel.Text = "DAP AN:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dLabel.Location = new System.Drawing.Point(890, 268);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(31, 23);
            dLabel.TabIndex = 36;
            dLabel.Text = "D:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cLabel.Location = new System.Drawing.Point(890, 198);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(31, 23);
            cLabel.TabIndex = 34;
            cLabel.Text = "C:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bLabel.Location = new System.Drawing.Point(92, 264);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(30, 23);
            bLabel.TabIndex = 32;
            bLabel.Text = "B:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aLabel.Location = new System.Drawing.Point(92, 194);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(31, 23);
            aLabel.TabIndex = 30;
            aLabel.Text = "A:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOIDUNGLabel.Location = new System.Drawing.Point(37, 137);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(112, 23);
            nOIDUNGLabel.TabIndex = 28;
            nOIDUNGLabel.Text = "NOIDUNG:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(72, 30);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(77, 23);
            mAGVLabel.TabIndex = 26;
            mAGVLabel.Text = "MAGV:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRINHDOLabel.Location = new System.Drawing.Point(373, 79);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(110, 23);
            tRINHDOLabel.TabIndex = 24;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(401, 32);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(82, 23);
            mAMHLabel.TabIndex = 22;
            mAMHLabel.Text = "MAMH:";
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cAUHOILabel.Location = new System.Drawing.Point(60, 80);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(97, 23);
            cAUHOILabel.TabIndex = 20;
            cAUHOILabel.Text = "CAUHOI:";
            // 
            // DSTopic
            // 
            this.DSTopic.DataSetName = "DSTopic";
            this.DSTopic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDSTopic
            // 
            this.BDSTopic.DataMember = "BODE";
            this.BDSTopic.DataSource = this.DSTopic;
            // 
            // TATopic
            // 
            this.TATopic.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BODETableAdapter = this.TATopic;
            this.tableAdapterManager.CTBAITHITableAdapter = this.TATest;
            this.tableAdapterManager.UpdateOrder = THITN.DSTopicTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TATest
            // 
            this.TATest.ClearBeforeFill = true;
            // 
            // BDSTest
            // 
            this.BDSTest.DataMember = "FK_CTBAITHI_BODE";
            this.BDSTest.DataSource = this.BDSTopic;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1741, 62);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 752);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1741, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 690);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1741, 62);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 690);
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
            this.panelControl1.Size = new System.Drawing.Size(1741, 103);
            this.panelControl1.TabIndex = 22;
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
            // GCTopic
            // 
            this.GCTopic.DataSource = this.BDSTopic;
            this.GCTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCTopic.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCTopic.Location = new System.Drawing.Point(0, 165);
            this.GCTopic.MainView = this.gridView1;
            this.GCTopic.Name = "GCTopic";
            this.GCTopic.Size = new System.Drawing.Size(1741, 245);
            this.GCTopic.TabIndex = 23;
            this.GCTopic.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView1.GridControl = this.GCTopic;
            this.gridView1.Name = "gridView1";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 25;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 94;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 25;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 94;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            this.colNOIDUNG.Width = 94;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 25;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            this.colA.Width = 94;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 25;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            this.colB.Width = 94;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 25;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            this.colC.Width = 94;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 25;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            this.colD.Width = 94;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 25;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            this.colDAP_AN.Width = 94;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            this.colMAGV.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCAUHOI);
            this.groupBox1.Controls.Add(this.tbMAMH);
            this.groupBox1.Controls.Add(this.tbMAGV);
            this.groupBox1.Controls.Add(this.cbbTRINHDO);
            this.groupBox1.Controls.Add(this.cbbDAP_AN);
            this.groupBox1.Controls.Add(this.tbNOIDUNG);
            this.groupBox1.Controls.Add(this.tbD);
            this.groupBox1.Controls.Add(this.tbC);
            this.groupBox1.Controls.Add(this.tbB);
            this.groupBox1.Controls.Add(this.tbA);
            this.groupBox1.Controls.Add(dAP_ANLabel);
            this.groupBox1.Controls.Add(dLabel);
            this.groupBox1.Controls.Add(cLabel);
            this.groupBox1.Controls.Add(bLabel);
            this.groupBox1.Controls.Add(aLabel);
            this.groupBox1.Controls.Add(nOIDUNGLabel);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(tRINHDOLabel);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(cAUHOILabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1741, 342);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // tbCAUHOI
            // 
            this.tbCAUHOI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "CAUHOI", true));
            this.tbCAUHOI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCAUHOI.Location = new System.Drawing.Point(163, 80);
            this.tbCAUHOI.Name = "tbCAUHOI";
            this.tbCAUHOI.Size = new System.Drawing.Size(131, 30);
            this.tbCAUHOI.TabIndex = 49;
            // 
            // tbMAMH
            // 
            this.tbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "MAMH", true));
            this.tbMAMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMAMH.Location = new System.Drawing.Point(498, 30);
            this.tbMAMH.Name = "tbMAMH";
            this.tbMAMH.Size = new System.Drawing.Size(170, 30);
            this.tbMAMH.TabIndex = 48;
            // 
            // tbMAGV
            // 
            this.tbMAGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "MAGV", true));
            this.tbMAGV.Enabled = false;
            this.tbMAGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMAGV.Location = new System.Drawing.Point(163, 30);
            this.tbMAGV.Name = "tbMAGV";
            this.tbMAGV.Size = new System.Drawing.Size(131, 30);
            this.tbMAGV.TabIndex = 47;
            // 
            // cbbTRINHDO
            // 
            this.cbbTRINHDO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "TRINHDO", true));
            this.cbbTRINHDO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTRINHDO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTRINHDO.FormattingEnabled = true;
            this.cbbTRINHDO.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbbTRINHDO.Location = new System.Drawing.Point(498, 78);
            this.cbbTRINHDO.Name = "cbbTRINHDO";
            this.cbbTRINHDO.Size = new System.Drawing.Size(170, 30);
            this.cbbTRINHDO.TabIndex = 46;
            // 
            // cbbDAP_AN
            // 
            this.cbbDAP_AN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "DAP_AN", true));
            this.cbbDAP_AN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDAP_AN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDAP_AN.FormattingEnabled = true;
            this.cbbDAP_AN.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbbDAP_AN.Location = new System.Drawing.Point(827, 78);
            this.cbbDAP_AN.Name = "cbbDAP_AN";
            this.cbbDAP_AN.Size = new System.Drawing.Size(121, 30);
            this.cbbDAP_AN.TabIndex = 45;
            // 
            // tbNOIDUNG
            // 
            this.tbNOIDUNG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "NOIDUNG", true));
            this.tbNOIDUNG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNOIDUNG.Location = new System.Drawing.Point(163, 135);
            this.tbNOIDUNG.Name = "tbNOIDUNG";
            this.tbNOIDUNG.Size = new System.Drawing.Size(667, 30);
            this.tbNOIDUNG.TabIndex = 44;
            // 
            // tbD
            // 
            this.tbD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "D", true));
            this.tbD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbD.Location = new System.Drawing.Point(950, 266);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(667, 30);
            this.tbD.TabIndex = 43;
            // 
            // tbC
            // 
            this.tbC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "C", true));
            this.tbC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC.Location = new System.Drawing.Point(950, 192);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(667, 30);
            this.tbC.TabIndex = 42;
            // 
            // tbB
            // 
            this.tbB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "B", true));
            this.tbB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.Location = new System.Drawing.Point(163, 266);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(667, 30);
            this.tbB.TabIndex = 41;
            // 
            // tbA
            // 
            this.tbA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSTopic, "A", true));
            this.tbA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.Location = new System.Drawing.Point(163, 191);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(667, 30);
            this.tbA.TabIndex = 40;
            // 
            // FormTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 772);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GCTopic);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormTopic";
            this.Text = "FormTopic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTopic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource BDSTopic;
        private DSTopic DSTopic;
        private DSTopicTableAdapters.BODETableAdapter TATopic;
        private DSTopicTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTopicTableAdapters.CTBAITHITableAdapter TATest;
        private System.Windows.Forms.BindingSource BDSTest;
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
        private DevExpress.XtraGrid.GridControl GCTopic;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCAUHOI;
        private System.Windows.Forms.TextBox tbMAMH;
        private System.Windows.Forms.TextBox tbMAGV;
        private System.Windows.Forms.ComboBox cbbTRINHDO;
        private System.Windows.Forms.ComboBox cbbDAP_AN;
        private System.Windows.Forms.TextBox tbNOIDUNG;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
    }
}