using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class Xrpt_GetTranscript : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_GetTranscript()
        {
        }
        public Xrpt_GetTranscript(String malop, String mamh, int lan)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = mamh;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = lan;
            this.sqlDataSource1.Fill();

        }



    }
}
