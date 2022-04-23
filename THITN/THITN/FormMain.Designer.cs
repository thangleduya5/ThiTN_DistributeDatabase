
namespace THITN
{
    partial class FormMain
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnDepartment = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubjects = new DevExpress.XtraBars.BarButtonItem();
            this.btnExamPaper = new DevExpress.XtraBars.BarButtonItem();
            this.btnExam = new DevExpress.XtraBars.BarButtonItem();
            this.btnExamResult = new DevExpress.XtraBars.BarButtonItem();
            this.btnTranscript = new DevExpress.XtraBars.BarButtonItem();
            this.btnExamRegisList = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnExamRegister = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup15 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageMajor = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup16 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageExport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Ma = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hoten = new System.Windows.Forms.ToolStripStatusLabel();
            this.Coso = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAddAccount,
            this.btnExit,
            this.btnChangePass,
            this.btnLogout,
            this.btnLogin,
            this.btnTeacher,
            this.btnStudent,
            this.btnDepartment,
            this.btnSubjects,
            this.btnExamPaper,
            this.btnExam,
            this.btnExamResult,
            this.btnTranscript,
            this.btnExamRegisList,
            this.barButtonItem1,
            this.btnExamRegister});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(12, 15, 12, 15);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPageManager,
            this.ribbonPageMajor,
            this.ribbonPageExport});
            this.ribbonControl1.Size = new System.Drawing.Size(1166, 208);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Caption = "Thêm tài khoản";
            this.btnAddAccount.Enabled = false;
            this.btnAddAccount.Id = 1;
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddAccount_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát chương trình";
            this.btnExit.Enabled = false;
            this.btnExit.Id = 2;
            this.btnExit.Name = "btnExit";
            this.btnExit.VisibleInSearchMenu = false;
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Đổi mật khẩu";
            this.btnChangePass.Enabled = false;
            this.btnChangePass.Id = 3;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePass_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Enabled = false;
            this.btnLogout.Id = 4;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 5;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Caption = "Giảng viên";
            this.btnTeacher.Id = 6;
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeacher_ItemClick);
            // 
            // btnStudent
            // 
            this.btnStudent.Caption = "Sinh viên";
            this.btnStudent.Id = 7;
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudent_ItemClick);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Caption = "Khoa";
            this.btnDepartment.Id = 8;
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDepartment_ItemClick);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Caption = "Môn học";
            this.btnSubjects.Id = 10;
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubjects_ItemClick);
            // 
            // btnExamPaper
            // 
            this.btnExamPaper.Caption = "Đề thi";
            this.btnExamPaper.Id = 11;
            this.btnExamPaper.Name = "btnExamPaper";
            this.btnExamPaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExamPaper_ItemClick);
            // 
            // btnExam
            // 
            this.btnExam.Caption = "Thi";
            this.btnExam.Id = 13;
            this.btnExam.Name = "btnExam";
            this.btnExam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExam_ItemClick);
            // 
            // btnExamResult
            // 
            this.btnExamResult.Caption = "Kết quả thi";
            this.btnExamResult.Id = 14;
            this.btnExamResult.Name = "btnExamResult";
            this.btnExamResult.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExamResult_ItemClick);
            // 
            // btnTranscript
            // 
            this.btnTranscript.Caption = "Bảng điểm";
            this.btnTranscript.Id = 15;
            this.btnTranscript.Name = "btnTranscript";
            this.btnTranscript.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTranscript_ItemClick);
            // 
            // btnExamRegisList
            // 
            this.btnExamRegisList.Caption = "Danh sách đăng kí thi";
            this.btnExamRegisList.Id = 16;
            this.btnExamRegisList.Name = "btnExamRegisList";
            this.btnExamRegisList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExamRegisList_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnExamRegister
            // 
            this.btnExamRegister.Caption = "Đăng kí thi";
            this.btnExamRegister.Id = 18;
            this.btnExamRegister.Name = "btnExamRegister";
            this.btnExamRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExamRegister_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13,
            this.ribbonPageGroup14,
            this.ribbonPageGroup15});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.btnChangePass);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.btnAddAccount);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            // 
            // ribbonPageGroup15
            // 
            this.ribbonPageGroup15.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup15.Name = "ribbonPageGroup15";
            // 
            // ribbonPageManager
            // 
            this.ribbonPageManager.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPageManager.Appearance.Options.UseFont = true;
            this.ribbonPageManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9});
            this.ribbonPageManager.Name = "ribbonPageManager";
            this.ribbonPageManager.Text = "Quản lí";
            this.ribbonPageManager.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTeacher);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnStudent);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDepartment);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnSubjects);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnExamPaper);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageMajor
            // 
            this.ribbonPageMajor.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPageMajor.Appearance.Options.UseFont = true;
            this.ribbonPageMajor.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup16});
            this.ribbonPageMajor.Name = "ribbonPageMajor";
            this.ribbonPageMajor.Text = "Nghiệp vụ";
            this.ribbonPageMajor.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnExam);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup16
            // 
            this.ribbonPageGroup16.ItemLinks.Add(this.btnExamRegister);
            this.ribbonPageGroup16.Name = "ribbonPageGroup16";
            // 
            // ribbonPageExport
            // 
            this.ribbonPageExport.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPageExport.Appearance.Options.UseFont = true;
            this.ribbonPageExport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11});
            this.ribbonPageExport.Name = "ribbonPageExport";
            this.ribbonPageExport.Text = "Báo cáo";
            this.ribbonPageExport.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnExamResult);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnTranscript);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnExamRegisList);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ma,
            this.Hoten,
            this.Coso});
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1166, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Ma
            // 
            this.Ma.Name = "Ma";
            this.Ma.Size = new System.Drawing.Size(30, 20);
            this.Ma.Text = "Ma";
            // 
            // Hoten
            // 
            this.Hoten.Name = "Hoten";
            this.Hoten.Size = new System.Drawing.Size(50, 20);
            this.Hoten.Text = "Hoten";
            // 
            // Coso
            // 
            this.Coso.Name = "Coso";
            this.Coso.Size = new System.Drawing.Size(42, 20);
            this.Coso.Text = "Coso";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 652);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMajor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup15;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem btnAddAccount;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnTeacher;
        private DevExpress.XtraBars.BarButtonItem btnStudent;
        private DevExpress.XtraBars.BarButtonItem btnDepartment;
        private DevExpress.XtraBars.BarButtonItem btnSubjects;
        private DevExpress.XtraBars.BarButtonItem btnExamPaper;
        private DevExpress.XtraBars.BarButtonItem btnExam;
        private DevExpress.XtraBars.BarButtonItem btnExamResult;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public System.Windows.Forms.ToolStripStatusLabel Ma;
        public System.Windows.Forms.ToolStripStatusLabel Hoten;
        public System.Windows.Forms.ToolStripStatusLabel Coso;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnExamRegister;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup16;
        public DevExpress.XtraBars.BarButtonItem btnTranscript;
        public DevExpress.XtraBars.BarButtonItem btnExamRegisList;
    }
}

