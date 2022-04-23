using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class Xtrp_GetExamResult : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_GetExamResult()
        {
            InitializeComponent();
        }

        public Xtrp_GetExamResult(String maHS, String maMH, int lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maHS;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();



        }
    }
}
