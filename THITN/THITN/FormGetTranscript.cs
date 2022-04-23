using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace THITN
{
    public partial class FormGetTranscript : Form
    {
        public FormGetTranscript()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSStudent);

        }

        private void FormGetTranscript_Load(object sender, EventArgs e)
        {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dSSubject.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dSStudent.LOP);

            cbbBrand.DataSource = Program.bds_dspm;
            cbbBrand.DisplayMember = "TENCN";
            cbbBrand.ValueMember = "TENSERVER";
            cbbBrand.SelectedIndex = Program.mChinhanh;
            cbbLanthi.SelectedIndex = 0;
            if (Program.mGroup == "TRUONG")
            {
                cbbBrand.Enabled = true;

            }
            else
            {
                cbbBrand.Enabled = false;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Xrpt_GetTranscript rpt = new Xrpt_GetTranscript(cbbTenlop.SelectedValue.ToString(), cbbTenmh.SelectedValue.ToString(), int.Parse(cbbLanthi.Text));
            rpt.lbTieude.Text = "BẢNG ĐIỂM MÔN " + cbbTenmh.Text.ToUpper() + " CỦA LỚP " + cbbTenlop.Text;
            rpt.xrlbTenlop.Text = cbbTenlop.Text;
            rpt.xrlbMonthi.Text = cbbTenmh.Text;
            rpt.xrlbLanthi.Text = cbbLanthi.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cbbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBrand.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbbBrand.SelectedValue.ToString();
            if (cbbBrand.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.Connect() == 0)
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            else
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dSSubject.MONHOC);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dSStudent.LOP);
            }
        }
    }
}
