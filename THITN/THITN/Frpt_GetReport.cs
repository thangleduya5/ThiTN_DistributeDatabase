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
    public partial class Frpt_GetReport : Form
    {
        public Frpt_GetReport()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (deTu.Text.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu không được trống", "", MessageBoxButtons.OK);
                deTu.Focus();
                return;
            }
            if (deDen.Text.Trim() == "")
            {
                MessageBox.Show("Ngày kết thúc không được trống", "", MessageBoxButtons.OK);
                deDen.Focus();
                return;
            }
            if (DateTime.Compare(deDen.DateTime, deTu.DateTime) < 0)
            {
                MessageBox.Show("Ngày kết thức phải lớn hơn hoặc bằng ngày hiện tại", "", MessageBoxButtons.OK);
                deDen.Focus();
                return;
            }
            Xrpt_GetReport rpt = new Xrpt_GetReport(cbbCoso.SelectedItem.ToString(), deTu.DateTime, deDen.DateTime);
            rpt.lbTieuDe.Text = "DANH SÁCH ĐĂNG KÍ THI TRẮC NGHIỆM CƠ SỞ " + cbbCoso.SelectedItem.ToString() + " TỪ NGÀY " + deTu.DateTime + " ĐẾN NGÀY "+ deDen.DateTime;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void Frpt_GetReport_Load(object sender, EventArgs e)
        {
            cbbCoso.SelectedIndex = 0;
        }
    }
}
