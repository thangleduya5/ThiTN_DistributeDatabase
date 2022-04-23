using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class Xrpt_GetReport : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_GetReport()
        {
     
        }
        public Xrpt_GetReport(String macs, DateTime tu, DateTime den)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = macs;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = den;
            this.sqlDataSource1.Fill();
        }

    }
}
