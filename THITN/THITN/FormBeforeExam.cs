using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class FormBeforeExam : Form
    {
        InfoExam infoExam;
        public FormBeforeExam()
        {
            InitializeComponent();
        }


        private void FormBeforeExam_Load(object sender, EventArgs e)
        {
            this.DSSubject.EnforceConstraints = false;

            this.TASubject.Connection.ConnectionString = Program.connstr;
            this.TASubject.Fill(this.DSSubject.MONHOC);
            cbbMONHOC.ValueMember = "MAMH";
            cbbMONHOC.DisplayMember = "TENMH";
            cbbMONHOC.SelectedIndex = 0;
            cbbLAN.SelectedIndex = 0;
            if (Program.mGroup == "SINHVIEN")
            {
                setInfoStudent();
            }
        }
        private void setInfoStudent()
        {
            lbMALOP.Text = Program.maLop;
            lbTENLOP.Text = Program.tenLop;
            lbMASV.Text = Program.studentID;
            lbHOTEN.Text = Program.mHoten;
            groupBox1.Visible = true;
            labelMALOP.Visible = false;
            tbMALOP.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (deNGAYTHI.Text.Trim() == "")
            {
                MessageBox.Show("Ngày thi không được trống", "", MessageBoxButtons.OK);
                deNGAYTHI.Focus();
                return;
            }

            if (DateTime.Compare(deNGAYTHI.DateTime, DateTime.Now) < 0)
            {
                MessageBox.Show("Ngày thi phải là hiện tại hoặc tương lai", "", MessageBoxButtons.OK);
                deNGAYTHI.Focus();
                return;
            }

            String MAMH = cbbMONHOC.SelectedValue.ToString();
            DateTime NGAYTHI = deNGAYTHI.DateTime;
            Int32 LAN = Int32.Parse(cbbLAN.Text);
            String maLop = Program.mGroup == "SINHVIEN" ? Program.maLop : tbMALOP.Text;
            infoExam = SqlFunction.GetInfoExam(maLop, MAMH, NGAYTHI, LAN);



            if (infoExam != null)
            {
                lbTRINHDO.Text = infoExam.trinhDo;
                lbSOCAUTHI.Text = infoExam.soCauThi.ToString();
                lbTHOIGIAN.Text = infoExam.thoiGian.ToString();
                groupBox2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Môn học này không được đăng ký thi. Vui lòng thông báo đến giáo viên để biết thêm chi tiết"
                    , "Không tìm thấy bài thi."
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

                return;
            }
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSSubject.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSSubject);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (SqlFunction.ExamStudentExist(Program.studentID, cbbMONHOC.SelectedValue.ToString(), Int16.Parse(cbbLAN.Text))) 
            {
                MessageBox.Show("Bạn đã thi rồi, không được thi lại");
                return;
            }
            List<QuestionExam> k= SqlFunction.GetQuestionForTestExam(infoExam.maMH, infoExam.trinhDo, infoExam.soCauThi);
            for(int i=0;i<k.Count;i++)
            {
                Console.WriteLine(k[i].cauHoi);
            }
            infoExam.questionExams = k;
            Program.infoExam = infoExam;
            FormExam formExam = new FormExam();
            formExam.ShowDialog();
            this.Close();
        }

    }
}
