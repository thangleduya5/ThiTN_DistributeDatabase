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
    public partial class FormStudent : Form
    {
        int posStudent = 0;
        int posClass = 0;
        String maSV = "";
        Boolean modify = false;
        public FormStudent()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSClass.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSStudent);

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            DSStudent.EnforceConstraints = false;

            this.TAClass.Connection.ConnectionString = Program.connstr;
            this.TAClass.Fill(this.DSStudent.LOP);

            this.TAStudent.Connection.ConnectionString = Program.connstr;
            this.TAStudent.Fill(this.DSStudent.SINHVIEN);

            this.TATranscript.Connection.ConnectionString = Program.connstr;
            this.TATranscript.Fill(this.DSStudent.BANGDIEM);

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
            posStudent = BDSStudent.Position;
            posClass = BDSStudent.Position;
            BDSStudent.AddNew();
            groupBox1.Enabled = true;

            btnAdd.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = btnRemove.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCStudent.Enabled = false;
            GCClass.Enabled = false;
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maSV = ((DataRowView)BDSStudent[BDSStudent.Position])["MASV"].ToString();
            String maLOP = ((DataRowView)BDSClass[BDSClass.Position])["MALOP"].ToString();

            if (BDSTranscript.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã thi", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này ?? ", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    BDSStudent.RemoveCurrent();
                    this.TAStudent.Connection.ConnectionString = Program.connstr;
                    this.TAStudent.Update(this.DSStudent.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên .Bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.TAClass.Fill(this.DSStudent.LOP);
                    BDSClass.Position = BDSClass.Find("MALOP", maLOP);
                    this.TAStudent.Fill(this.DSStudent.SINHVIEN);
                    BDSStudent.Position = BDSStudent.Find("MASV", maSV);
                    return;
                }
            }
            if (BDSStudent.Count == 0) btnRemove.Enabled = false;
        }

        private void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            posStudent = BDSStudent.Position;
            posClass = BDSStudent.Position;
            modify = true;
            maSV= ((DataRowView)BDSStudent[posStudent])["MASV"].ToString();
            groupBox1.Enabled = true;

            btnAdd.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = btnRemove.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCStudent.Enabled = false;
            GCClass.Enabled = false;
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbMASV.Text.Trim() == "")
            {
                MessageBox.Show("Mã không được trống", "", MessageBoxButtons.OK);
                tbMASV.Focus();
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

            if (deNGAYSINH.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được trống", "", MessageBoxButtons.OK);
                deNGAYSINH.Focus();
                return;
            }

            if (DateTime.Compare(deNGAYSINH.DateTime, DateTime.Now) >= 0)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại", "", MessageBoxButtons.OK);
                deNGAYSINH.Focus();
                return;
            }

            if (!(modify && maSV.Equals(tbMASV.Text)))
            {
                if (SqlFunction.StudentExist(tbMASV.Text))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    tbMASV.Focus();
                    return;
                }
            }
            if (!modify)
            {
                tbMATKHAU.Text = deNGAYSINH.DateTime.Day + "" + deNGAYSINH.DateTime.Month + "" + deNGAYSINH.DateTime.Year + "";
            }
            try
            {
                BDSStudent.EndEdit();
                this.TAStudent.Connection.ConnectionString = Program.connstr;
                this.TAStudent.Update(this.DSStudent.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GCClass.Enabled = true;
            GCStudent.Enabled = true;
            modify = false;
            btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BDSStudent.CancelEdit();
            modify = false;
            if (btnAdd.Enabled == false)
            {
                BDSClass.Position = posClass;
                BDSStudent.Position = posStudent;
            }
            GCClass.Enabled = true;
            GCStudent.Enabled = true;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TAClass.Fill(this.DSStudent.LOP);
                this.TAStudent.Fill(this.DSStudent.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload" + ex.Message, "", MessageBoxButtons.OK);
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
                this.TAClass.Connection.ConnectionString = Program.connstr;
                this.TAClass.Fill(this.DSStudent.LOP);

                this.TAStudent.Connection.ConnectionString = Program.connstr;
                this.TAStudent.Fill(this.DSStudent.SINHVIEN);

                this.TATranscript.Connection.ConnectionString = Program.connstr;
                this.TATranscript.Fill(this.DSStudent.BANGDIEM);

            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
