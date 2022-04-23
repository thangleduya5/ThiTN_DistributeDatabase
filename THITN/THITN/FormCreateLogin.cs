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
    public partial class FormCreateLogin : Form
    {
        public FormCreateLogin()
        {
            InitializeComponent();
        }

        private void FormCreateLogin_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "TRUONG")
            {
                cbbQUYEN.Items.Clear();
                cbbQUYEN.Items.Add("TRUONG");
                cbbQUYEN.Enabled = false;
            }
            cbbQUYEN.SelectedIndex = 0;
        }

        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            if (!SqlFunction.TeacherExist(tbMAGV.Text.Trim()))
            {
                MessageBox.Show("Mã giảng viên không tồn tại trong csdl, vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                return;
            }
            int k = SqlFunction.CreateLogin(tbMAGV.Text.Trim(), tbTENDANGNHAP.Text.Trim(), tbMATKHAU.Text.Trim(), cbbQUYEN.Text);
            String x = "";
            switch (k)
            {
                case -1:
                    x = "Lỗi tạo tài khoản, vui lòng kiểm tra lại";
                    break;
                case 0:
                    x = "Tạo tài khoản thành công";
                    tbMAGV.Text = "";
                    tbTENDANGNHAP.Text = "";
                    tbMATKHAU.Text = "";
                    cbbQUYEN.SelectedIndex = 0;
                    break;
                case 1:
                    x = "Tên đăng nhập đã tồn tại, vui lòng nhập tên khác";
                    tbTENDANGNHAP.Focus();
                    break;
                case 2:
                    x = "Mã giảng viên này đã được tạo tài khoản trước đó rồi";
                    tbMAGV.Focus();
                    break;
            }
            MessageBox.Show(x, "", MessageBoxButtons.OK);
        }
    }
}
