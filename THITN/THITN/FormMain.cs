using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THITN
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public void showMenu()
        {
            btnChangePass.Enabled = btnLogout.Enabled = true;
            ribbonPageMajor.Visible = true;
            btnLogin.Enabled = false;
            if (Program.mGroup == "SINHVIEN")
            {
                btnExamRegister.Enabled = false;
            }
            else
            {
                ribbonPageExport.Visible = ribbonPageManager.Visible = true;
                if (Program.mGroup == "GIANGVIEN")
                {
                    btnTranscript.Enabled = false;
                    btnExamRegisList.Enabled = false;
                }
                else
                {
                    btnAddAccount.Enabled = true;
                    btnExit.Enabled = true;
                }
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLogin));
            if (frm != null) frm.Activate();
            else
            {
                FormLogin formLogin = new FormLogin();
                formLogin.MdiParent = this;
                formLogin.Show();
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn đăng xuất không?"
            , "Confirmation", MessageBoxButtons.YesNo)
            == DialogResult.Yes)
            {
                Program.connstr = Program.servername = Program.username = Program.mlogin = Program.password =
                Program.mloginDN = Program.passwordDN = Program.mGroup = Program.mHoten =
                Program.studentID = Program.studentPass = Program.maLop = Program.tenLop = "";
                Program.infoExam = null;
                btnExamRegister.Enabled = true;
                ribbonPageExport.Visible = ribbonPageManager.Visible = ribbonPageMajor.Visible = false;
                Ma.Text = "";
                Hoten.Text = "";
                Coso.Text = "";
                btnAddAccount.Enabled = btnLogout.Enabled = btnChangePass.Enabled = false;
                btnLogin.Enabled = true;
                Form frm = this.CheckExists(typeof(FormLogin));
                if (frm != null) frm.Activate();
                else
                {
                    FormLogin formLogin = new FormLogin();
                    formLogin.MdiParent = this;
                    formLogin.Show();
                }
            }

        }

        private void btnSubjects_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSubject));
            if (frm != null) frm.Activate();
            else
            {
                FormSubject formSubject = new FormSubject();
                formSubject.MdiParent = this;
                formSubject.Show();
            }
        }

        private void btnExamPaper_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTopic));
            if (frm != null) frm.Activate();
            else
            {
                FormTopic formTopic = new FormTopic();
                formTopic.MdiParent = this;
                formTopic.Show();
            }
        }

        private void btnExamRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormRegisterTeacher));
            if (frm != null) frm.Activate();
            else
            {
                FormRegisterTeacher formRegisterTeacher = new FormRegisterTeacher();
                formRegisterTeacher.MdiParent = this;
                formRegisterTeacher.Show();
            }
        }

        private void btnStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormStudent));
            if (frm != null) frm.Activate();
            else
            {
                FormStudent formStudent = new FormStudent();
                formStudent.MdiParent = this;
                formStudent.Show();
            }
        }

        private void btnTeacher_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTeacher));
            if (frm != null) frm.Activate();
            else
            {
                FormTeacher formTeacher = new FormTeacher();
                formTeacher.MdiParent = this;
                formTeacher.Show();
            }
        }

        private void btnExam_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBeforeExam));
            if (frm != null) frm.Activate();
            else
            {
                FormBeforeExam formBeforeExam = new FormBeforeExam();
                formBeforeExam.MdiParent = this;
                formBeforeExam.Show();
            }
        }

        private void btnAddAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormCreateLogin));
            if (frm != null) frm.Activate();
            else
            {
                FormCreateLogin formCreateLogin = new FormCreateLogin();
                formCreateLogin.MdiParent = this;
                formCreateLogin.Show();
            }
        }

        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChangePass));
            if (frm != null) frm.Activate();
            else
            {
                FormChangePass formChangePass = new FormChangePass();
                formChangePass.MdiParent = this;
                formChangePass.Show();
            }
        }

        private void btnExamResult_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGetExamResult));
            if (frm != null) frm.Activate();
            else
            {
                FormGetExamResult formGetExamResult = new FormGetExamResult();
                formGetExamResult.MdiParent = this;
                formGetExamResult.Show();
            }
        }

        private void btnTranscript_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGetTranscript));
            if (frm != null) frm.Activate();
            else
            {
                FormGetTranscript formGetTranscript = new FormGetTranscript();
                formGetTranscript.MdiParent = this;
                formGetTranscript.Show();
            }
        }

        private void btnDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormFaculty_Class));
            if (frm != null) frm.Activate();
            else
            {
                FormFaculty_Class FormFaculty_Class = new FormFaculty_Class();
                FormFaculty_Class.MdiParent = this;
                FormFaculty_Class.Show();
            }
        }

        private void btnExamRegisList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_GetReport));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_GetReport Frpt_GetReport = new Frpt_GetReport();
                Frpt_GetReport.MdiParent = this;
                Frpt_GetReport.Show();
            }
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
