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
    public partial class FormExam : Form
    {
        private InfoExam infoExam;
        private List<QuestionExam> questions;
        private int currentQuestionIndex;

        private int currentMinute = 0;
        private int currentSecond = 0;

        private Timer timer;
        public FormExam()
        {
            InitializeComponent();
            this.infoExam = Program.infoExam;
            this.questions = Program.infoExam.questionExams;

            Init();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;
            timer.Start();

        }

        private void Init()
        {
            QuestionExam exam = questions[currentQuestionIndex];
            lbCAUHOI.Text = "Câu số " + (currentQuestionIndex + 1) + "/ " + questions.Count;
            lbNOIDUNG.Text = exam.noiDung;
            lbA.Text = exam.a;
            lbB.Text = exam.b;
            lbC.Text = exam.c;
            lbD.Text = exam.d;

            btnTRUOC.Enabled = false;
            btnNOPBAI.Visible = false;

            lbInfo.Text = Program.mHoten + "__" + Program.studentID;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.currentSecond++;
            if (currentSecond == 60)
            {
                currentSecond = 0;
                currentMinute++;
                if (currentMinute >= infoExam.thoiGian)
                {
                    MessageBox.Show("Đã hết thời gian làm bài."
                        , "Hết thời gian!"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);

                    SubmitExam(questions);
                    return;
                }
            }
            this.lbTHOIGIAN.Text = currentMinute + " : " + currentSecond;
        }

        private void bANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSTranscript.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSExam);

        }

        private void FormExam_Load(object sender, EventArgs e)
        {
/*            this.DSExam.EnforceConstraints = false;

            this.TATranscript.Connection.ConnectionString = Program.connstr;
            this.TATranscript.Fill(this.DSExam.BANGDIEM);

            this.TAExamDetail.Connection.ConnectionString = Program.connstr;
            this.TAExamDetail.Fill(this.DSExam.CTBAITHI);*/
        }

        private object[] SetupTranscript(InfoExam info, float mark)
        {
            return new object[]
            {
                1,
                Program.studentID
                ,info.maMH
                ,info.lan
                ,info.ngayThi.ToShortDateString()
                ,mark
            };
        }

        private void SaveTranscript(InfoExam info, float mark)
        {
            DataRowView newRow = (DataRowView)BDSTranscript.AddNew();

            newRow.Row.ItemArray = SetupTranscript(info, mark);
 /*           newRow.Row.SetField(1, Program.studentID);
            newRow.Row.SetField(2, info.maMH);
            newRow.Row.SetField(3, info.lan);
            newRow.Row.SetField(4, info.ngayThi.ToShortDateString());
            newRow.Row.SetField(5, mark);*/
            
            this.BDSTranscript.EndEdit();
            this.BDSTranscript.ResetCurrentItem();
            this.TATranscript.Update(this.DSExam.BANGDIEM);
        }

        private object[] SetupExamDetail(QuestionExam question, int soThuTu)
        {
            return new object[]
            {
                question.cauHoi
                ,soThuTu
                ,question.yourAnswer
            };
        }

        private void SaveExamDetails(InfoExam info)
        {
            DataRowView newRow;
            for (int i = 0; i < info.questionExams.Count; i++)
            {
                newRow = (DataRowView)BDSExamDetail.AddNew();

/*                newRow.Row.ItemArray = SetupExamDetail(info.questionExams[i], i + 1);
*/
                newRow.Row.SetField(1, info.questionExams[i].cauHoi);
                newRow.Row.SetField(2, i+1);
                newRow.Row.SetField(3, info.questionExams[i].yourAnswer);

                this.BDSExamDetail.EndEdit();
                this.BDSExamDetail.ResetCurrentItem();
                this.TAExamDetail.Update(this.DSExam.CTBAITHI);
            }
        }

        private float CalculateMark(List<QuestionExam> questionExams)
        {
            int answerTrue = questionExams.Count(x => x.trueAnswer == x.yourAnswer);

            float mark = (float) (10.0 / questionExams.Count) * answerTrue;

            return (float)Math.Round(mark * 2, MidpointRounding.AwayFromZero) / 2;
        }

        private void ShowQuestionByIndex(int questionIndex)
        {
            QuestionExam exam = questions[questionIndex];
            lbCAUHOI.Text = "Câu số " + (questionIndex + 1) + "/ " + questions.Count;
            lbNOIDUNG.Text = exam.noiDung;
            lbA.Text = exam.a;
            lbB.Text = exam.b;
            lbC.Text = exam.c;
            lbD.Text = exam.d;

            switch (exam.yourAnswer)
            {
                case "A":
                    rbA.Checked = true;
                    break;
                case "B":
                    rbB.Checked = true;
                    break;
                case "C":
                    rbC.Checked = true;
                    break;
                case "D":
                    rbD.Checked = true;
                    break;
                default:
                    rbA.Checked = false;
                    rbB.Checked = false;
                    rbC.Checked = false;
                    rbD.Checked = false;
                    break;
            }
        }

        private void ChangeIndexQuestion()
        {
            if (currentQuestionIndex > 0 && currentQuestionIndex < (questions.Count - 1))
            {
                btnSAU.Enabled = true;
                btnTRUOC.Enabled = true;
                btnNOPBAI.Visible = false;
            }
            else if (currentQuestionIndex == 0)
            {
                btnTRUOC.Enabled = false;
            }
            else if (currentQuestionIndex == (questions.Count - 1))
            {
                btnSAU.Enabled = false;
                btnNOPBAI.Visible = true;
            }
        }

        private void btnTRUOC_Click(object sender, EventArgs e)
        {
            currentQuestionIndex--;
            ChangeIndexQuestion();
            ShowQuestionByIndex(currentQuestionIndex);
        }

        private void btnSAU_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            ChangeIndexQuestion();
            ShowQuestionByIndex(currentQuestionIndex);
        }

        private void rbAnswer_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            questions[currentQuestionIndex].yourAnswer = rb.Tag.ToString();
        }

        private void btnNOPBAI_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn nộp bài không. Vẫn còn thời gian để làm bài?"
                        , "Nộp bài."
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                this.timer.Stop();

                SubmitExam(questions);
            }
            else 
            { 
                return; 
            }
        }

        private void SubmitExam(List<QuestionExam> listExam)
        {
            infoExam.questionExams = listExam;

            float mark = CalculateMark(listExam);

            if (Program.mGroup.Equals("SINHVIEN"))
            {
                SaveTranscript(infoExam, mark);
                SaveExamDetails(infoExam);
            }

            int answerTrue = listExam.Where(x => x.trueAnswer == x.yourAnswer).Count();

            StringBuilder stringBuilder = new StringBuilder("Bạn đã trả lời đúng ");
            stringBuilder.Append(answerTrue + " /" + listExam.Count + " câu.");
            stringBuilder.AppendLine("Bạn được " + mark + " điểm.");

            MessageBox.Show(stringBuilder.ToString(), "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
