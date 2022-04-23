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
    public partial class FormGetExamResult : Form
    {
        String maMH;
        public FormGetExamResult()
        {
            InitializeComponent();
        }

        private void frpt_GetExamResult_Load(object sender, EventArgs e)
        {
            this.mONHOC1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOC1TableAdapter.Fill(this.dSSubject.MONHOC1);
            cbbBrand.DataSource = Program.bds_dspm;
            cbbBrand.DisplayMember = "TENCN";
            cbbBrand.ValueMember = "TENSERVER";
            cbbBrand.SelectedIndex = Program.mChinhanh;
            cmbLan.SelectedIndex = 0;

            if (Program.mGroup == "TRUONG")
            {
                cbbBrand.Enabled = true;
              
            }
            else
            {
              
                cbbBrand.Enabled = false;
            }

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
                this.mONHOC1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOC1TableAdapter.Fill(this.dSSubject.MONHOC1);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strLenh = "exec SP_GetInfoExamResult  '" + txtMaHS.Text + "'," + "'" + cmbMonHoc.SelectedValue.ToString() + "'," +int.Parse(cmbLan.Text) ;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (!Program.myReader.Read())
            {
                MessageBox.Show("Không tìm thấy kết quả thi, vui lòng kiểm tra lại mã SV", "", MessageBoxButtons.OK);
                txtMaHS.Focus();
                return;
            }
            Console.WriteLine("Lan thi: "+cmbLan.Text);
            Xtrp_GetExamResult rpt = new Xtrp_GetExamResult(txtMaHS.Text, cmbMonHoc.SelectedValue.ToString(), int.Parse(cmbLan.Text));   
            
            rpt.lblLanthi.Text = cmbLan.Text;
            rpt.lblMonthi.Text = cmbMonHoc.Text;
            rpt.lblHoten.Text = Program.myReader.GetString(0);
            rpt.lblLop.Text = Program.myReader.GetString(1);
            rpt.lblNgaythi.Text = Program.myReader.GetDateTime(2).ToShortDateString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
      

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOC1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSubject);

        }

    }
}
