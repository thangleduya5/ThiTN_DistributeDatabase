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
    public partial class FormTeacher : Form
    {
        int posTeacher = 0;
        int posDepartment = 0;
        String maGV = "";
        Boolean modify = false;
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSTeacher.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSTeacher);

        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            DSTeacher.EnforceConstraints = false;

            this.TADepartment.Connection.ConnectionString = Program.connstr;
            this.TADepartment.Fill(this.DSTeacher.KHOA);

            this.TATeacher.Connection.ConnectionString = Program.connstr;
            this.TATeacher.Fill(this.DSTeacher.GIAOVIEN);

            this.TARegisterTeacher.Connection.ConnectionString = Program.connstr;
            this.TARegisterTeacher.Fill(this.DSTeacher.GIAOVIEN_DANGKY);

            this.TATopic.Connection.ConnectionString = Program.connstr;
            this.TATopic.Fill(this.DSTeacher.BODE);

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
            posTeacher = BDSTeacher.Position;
            posDepartment = BDSDepartment.Position;
            BDSTeacher.AddNew();
            groupBox1.Enabled = true;

            btnAdd.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = btnRemove.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCTeacher.Enabled = false;
            GCDepartment.Enabled = false;
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = ((DataRowView)BDSTeacher[BDSTeacher.Position])["MAGV"].ToString();
            String maKHOA = ((DataRowView)BDSDepartment[BDSDepartment.Position])["MAKH"].ToString();

            if (BDSRegisterTeacher.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên này vì đã đăng kí thi", "", MessageBoxButtons.OK);
                return;
            }

            if (BDSTopic.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên này vì đã nhập đề thi", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa giáo viên này ?? ", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    BDSTeacher.RemoveCurrent();
                    this.TATeacher.Connection.ConnectionString = Program.connstr;
                    this.TATeacher.Update(this.DSTeacher.GIAOVIEN);
                    SqlFunction.RemoveLogin(maGV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên .Bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.TADepartment.Fill(this.DSTeacher.KHOA);
                    BDSDepartment.Position = BDSDepartment.Find("MAKH", maKHOA);
                    this.TATeacher.Fill(this.DSTeacher.GIAOVIEN);
                    BDSTeacher.Position = BDSTeacher.Find("MAGV", maGV);
                    return;
                }
            }
            if (BDSTeacher.Count == 0) btnRemove.Enabled = false;
        }

        private void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            posTeacher = BDSTeacher.Position;
            posDepartment = BDSDepartment.Position;
            modify = true;
            maGV= ((DataRowView)BDSTeacher[posTeacher])["MAGV"].ToString();
            groupBox1.Enabled = true;

            btnAdd.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = btnRemove.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCDepartment.Enabled = false;
            GCTeacher.Enabled = false;
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã không được trống", "", MessageBoxButtons.OK);
                tbMAGV.Focus();
                return;
            }

            if (tbHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được trống", "", MessageBoxButtons.OK);
                tbHO.Focus();
                return;
            }

            if (tbTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được trống", "", MessageBoxButtons.OK);
                tbTEN.Focus();
                return;
            }

            if (tbDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống", "", MessageBoxButtons.OK);
                tbDIACHI.Focus();
                return;
            }

            if (!(modify && maGV.Equals(tbMAGV.Text)))
            {
                if (SqlFunction.TeacherExist(tbMAGV.Text))
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    tbMAGV.Focus();
                    return;
                }
            }
 


            try
            {
                BDSTeacher.EndEdit();
                this.TATeacher.Connection.ConnectionString = Program.connstr;
                this.TATeacher.Update(this.DSTeacher.GIAOVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giáo viên" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GCDepartment.Enabled = true;
            GCTeacher.Enabled = true;
            modify = false;
            btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            modify = false;
            BDSTeacher.CancelEdit();
            if (btnAdd.Enabled == false)
            {
                BDSDepartment.Position = posDepartment;
                BDSTeacher.Position = posTeacher;
            }
            GCDepartment.Enabled = true;
            GCTeacher.Enabled = true;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TADepartment.Fill(this.DSTeacher.KHOA);
                this.TATeacher.Fill(this.DSTeacher.GIAOVIEN);
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
                this.TADepartment.Connection.ConnectionString = Program.connstr;
                this.TADepartment.Fill(this.DSTeacher.KHOA);

                this.TATeacher.Connection.ConnectionString = Program.connstr;
                this.TATeacher.Fill(this.DSTeacher.GIAOVIEN);

                this.TARegisterTeacher.Connection.ConnectionString = Program.connstr;
                this.TARegisterTeacher.Fill(this.DSTeacher.GIAOVIEN_DANGKY);

                this.TATopic.Connection.ConnectionString = Program.connstr;
                this.TATopic.Fill(this.DSTeacher.BODE);
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
