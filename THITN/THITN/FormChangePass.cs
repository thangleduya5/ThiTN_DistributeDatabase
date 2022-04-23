using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class FormChangePass : Form
    {
        public FormChangePass()
        {
            InitializeComponent();
        }

        private void btn_ChagePassword_Click(object sender, EventArgs e)
        {
            String oldPass = Program.mGroup == "SINHVIEN" ? Program.studentPass : Program.passwordDN;
            String logName = Program.mGroup == "SINHVIEN" ? Program.studentID : Program.mloginDN;
            if (!tbMKCU.Text.Equals(oldPass))
            {
                MessageBox.Show("Mật khẩu cũ bạn nhập không đúng", "", MessageBoxButtons.OK);
                tbMKCU.Focus();
                return;
            }
            if (tbMKMOI.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "", MessageBoxButtons.OK);
                tbMKMOI.Focus();
                return;
            }
            if (!tbMKMOI.Text.Equals(tbMKMOI1.Text))
            {
                MessageBox.Show("Mật khẩu bạn nhập lại không khớp", "", MessageBoxButtons.OK);
                tbMKMOI1.Focus();
                return;
            }
            if(SqlFunction.ChangePass(logName, tbMKMOI.Text, Program.mGroup) == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công", "", MessageBoxButtons.OK);
                if (Program.mGroup != "SINHVIEN") {
                    Program.passwordDN = tbMKMOI.Text;
                    Program.password = Program.passwordDN;
                    Program.Connect();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
