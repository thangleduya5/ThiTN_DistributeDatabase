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
    public partial class FormTopic : Form
    {
        int viTri = 0;
        Boolean modify = false;
        int cauHOI = 0;
        public FormTopic()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSTopic.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSTopic);

        }

        private void FormTopic_Load(object sender, EventArgs e)
        {
            DSTopic.EnforceConstraints = false;
            this.TATopic.Connection.ConnectionString = Program.connstr;
            this.TATopic.Fill(this.DSTopic.BODE);

            this.TATest.Connection.ConnectionString = Program.connstr;
            this.TATest.Fill(this.DSTopic.CTBAITHI);



            cbbBrand.DataSource = Program.bds_dspm;
            cbbBrand.DisplayMember = "TENCN";
            cbbBrand.ValueMember = "TENSERVER";
            cbbBrand.SelectedIndex = Program.mChinhanh;

            groupBox1.Enabled = false;
            if (Program.mGroup == "TRUONG")
            {
                cbbBrand.Enabled = true;
                btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnNote.Enabled = btnUndo.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = true;
                btnNote.Enabled = btnUndo.Enabled = false;
                cbbBrand.Enabled = false;
            }

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = BDSTopic.Position;
            BDSTopic.AddNew();
            groupBox1.Enabled = true;
            tbMAGV.Text = Program.username;

            btnAdd.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = btnRemove.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCTopic.Enabled = false;
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV =((DataRowView)BDSTopic[BDSTopic.Position])["MAGV"].ToString().Trim();
            if (!maGV.Equals(Program.username))
            {
                MessageBox.Show("Giáo viên chỉ được xóa câu hỏi thi do chính gv soạn", "", MessageBoxButtons.OK);
                return;
            }

            int cauhoi = 0;
            if (BDSTest.Count > 0)
            {
                MessageBox.Show("Không thể xóa đề này vì đã có chi tiết bài thi", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa khoa này ?? ", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cauhoi = int.Parse(((DataRowView)BDSTopic[BDSTopic.Position])["CAUHOI"].ToString());
                    BDSTopic.RemoveCurrent();
                    this.TATopic.Connection.ConnectionString = Program.connstr;
                    this.TATopic.Update(this.DSTopic.BODE);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa .Bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.TATopic.Fill(this.DSTopic.BODE);
                    BDSTopic.Position = BDSTopic.Find("CAUHOI", cauhoi);
                    return;
                }
            }
            if (BDSTopic.Count == 0) btnRemove.Enabled = false;
        }

        private void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = ((DataRowView)BDSTopic[BDSTopic.Position])["MAGV"].ToString().Trim();
            if (!maGV.Equals(Program.username))
            {
                MessageBox.Show("Giáo viên chỉ được hiệu chỉnh câu hỏi thi do chính gv soạn", "", MessageBoxButtons.OK);
                return;
            }
            viTri = BDSTopic.Position;
            cauHOI = Int16.Parse(((DataRowView)BDSTopic[BDSTopic.Position])["CAUHOI"].ToString().Trim());
            modify = true;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnModify.Enabled = btnRemove.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCTopic.Enabled = false;
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không được thiếu !", "", MessageBoxButtons.OK);
                tbMAGV.Focus();
                return;
            }

            if (tbMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không đươc thiếu !", "", MessageBoxButtons.OK);
                tbMAMH.Focus();
                return;
            }
            if (tbCAUHOI.Text.Trim() == "")
            {
                MessageBox.Show("Câu hỏi không được thiếu !", "", MessageBoxButtons.OK);
                tbCAUHOI.Focus();
                return;
            }
            if (tbNOIDUNG.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được thiếu !", "", MessageBoxButtons.OK);
                tbNOIDUNG.Focus();
                return;
            }

            if (tbA.Text.Trim() == "")
            {
                MessageBox.Show("Nội dụng đáp án A không được thiếu !", "", MessageBoxButtons.OK);
                tbA.Focus();
                return;
            }
            if (tbB.Text.Trim() == "")
            {
                MessageBox.Show("Nội dụng đáp án B không được thiếu !", "", MessageBoxButtons.OK);
                tbB.Focus();
                return;
            }

            if (tbC.Text.Trim() == "")
            {
                MessageBox.Show("Nội dụng đáp án C không được thiếu !", "", MessageBoxButtons.OK);
                tbC.Focus();
                return;
            }
            if (tbD.Text.Trim() == "")
            {
                MessageBox.Show("Nội dụng đáp án D không được thiếu !", "", MessageBoxButtons.OK);
                tbD.Focus();
                return;
            }

            if(!(modify && cauHOI == Int16.Parse(tbCAUHOI.Text)))
            {
                if (!SqlFunction.CourseExist(tbMAMH.Text))
                {
                    MessageBox.Show("Mã câu hỏi không tồn tại, vui lòng nhập lại !", "", MessageBoxButtons.OK);
                    tbMAMH.Focus();
                    return;
                }
            }
 


            try
            {
                BDSTopic.EndEdit();
                BDSTopic.ResetCurrentItem();
                this.TATopic.Connection.ConnectionString = Program.connstr;
                this.TATopic.Update(this.DSTopic.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đề thi !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GCTopic.Enabled = true;
            modify = false;
            btnAdd.Enabled = btnModify.Enabled = btnRemove.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BDSTopic.CancelEdit();
            if (btnAdd.Enabled == false)
                BDSTopic.Position = viTri;
            GCTopic.Enabled = true;
            groupBox1.Enabled = false;
            btnAdd.Enabled = btnModify.Enabled = btnRemove.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TATopic.Fill(this.DSTopic.BODE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
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
                this.TATopic.Connection.ConnectionString = Program.connstr;
                this.TATopic.Fill(this.DSTopic.BODE);
                this.TATest.Connection.ConnectionString = Program.connstr;
                this.TATest.Fill(this.DSTopic.CTBAITHI);

            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
