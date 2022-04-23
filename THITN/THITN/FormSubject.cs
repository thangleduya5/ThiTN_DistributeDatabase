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
    public partial class FormSubject : Form
    {
        String macs = "";
        int viTri = 0;
        String maMH = "";
        Boolean modify = false;
        public FormSubject()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSSubject.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSSubject);

        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            DSSubject.EnforceConstraints = false;
            this.TASubject.Connection.ConnectionString = Program.connstr;
            this.TASubject.Fill(this.DSSubject.MONHOC);

            this.TARegisterTeacher.Connection.ConnectionString = Program.connstr;
            this.TARegisterTeacher.Fill(this.DSSubject.GIAOVIEN_DANGKY);

            this.TATopic.Connection.ConnectionString = Program.connstr;
            this.TATopic.Fill(this.DSSubject.BODE);

            this.TATranscript.Connection.ConnectionString = Program.connstr;
            this.TATranscript.Fill(this.DSSubject.BANGDIEM);

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
            viTri = BDSSubject.Position;
            BDSSubject.AddNew();
            groupBox1.Enabled = true;

            btnAdd.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = btnRemove.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCSubject.Enabled = false;
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMH = "";
            if (BDSRegisterTeacher.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có giáo viên đăng ký", "", MessageBoxButtons.OK);
                return;
            }

            if (BDSTopic.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có bộ đề", "", MessageBoxButtons.OK);
                return;
            }
            if (BDSTranscript.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có bảng điểm", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa khoa này ?? ", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maMH = (((DataRowView)BDSSubject[BDSSubject.Position])["MAMH"].ToString());
                    BDSSubject.RemoveCurrent();
                    this.TASubject.Connection.ConnectionString = Program.connstr;
                    this.TASubject.Update(this.DSSubject.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa .Bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.TASubject.Fill(this.DSSubject.MONHOC);
                    BDSSubject.Position = BDSSubject.Find("MAMH", maMH);
                    return;
                }
            }
            if (BDSSubject.Count == 0) btnRemove.Enabled = false;
        }

        private void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = BDSSubject.Position;
            modify = true;
            maMH=(((DataRowView)BDSSubject[viTri])["MAMH"].ToString());
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnModify.Enabled = btnRemove.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCSubject.Enabled = false;
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được thiếu !", "", MessageBoxButtons.OK);
                tbMAMH.Focus();
                return;
            }

            if (tbTENMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu !", "", MessageBoxButtons.OK);
                tbTENMH.Focus();
                return;
            }

            if(!(modify && maMH.Equals(tbMAMH.Text)))
            {
                if (SqlFunction.DepartmentExist(tbMAMH.Text))
                {
                    MessageBox.Show("Mã môn học đã tồn tại, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    tbMAMH.Focus();
                    return;
                }
            }

            try
            {
                BDSSubject.EndEdit();
                BDSSubject.ResetCurrentItem();
                this.TASubject.Connection.ConnectionString = Program.connstr;
                this.TASubject.Update(this.DSSubject.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học !" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GCSubject.Enabled = true;
            modify = false;
            btnAdd.Enabled = btnModify.Enabled = btnRemove.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            modify = false;
            BDSSubject.CancelEdit();
            if (btnAdd.Enabled == false)
                BDSSubject.Position = viTri;
            GCSubject.Enabled = true;
            groupBox1.Enabled = false;
            btnAdd.Enabled = btnModify.Enabled = btnRemove.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TASubject.Fill(this.DSSubject.MONHOC);
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
                this.TASubject.Connection.ConnectionString = Program.connstr;
                this.TASubject.Fill(this.DSSubject.MONHOC);

                this.TARegisterTeacher.Connection.ConnectionString = Program.connstr;
                this.TARegisterTeacher.Fill(this.DSSubject.GIAOVIEN_DANGKY);

                this.TATopic.Connection.ConnectionString = Program.connstr;
                this.TATopic.Fill(this.DSSubject.BODE);

                this.TATranscript.Connection.ConnectionString = Program.connstr;
                this.TATranscript.Fill(this.DSSubject.BANGDIEM);

            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
