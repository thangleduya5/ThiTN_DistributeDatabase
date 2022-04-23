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
    public partial class FormRegisterTeacher : Form
    {
        int position = 0;
        Boolean modify = false;

        String maMH = "";
        String maLOP = "";
        Int16 lan = 0;
        public FormRegisterTeacher()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDSRegisterTeacher.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSRegisterTeacher);

        }

        private void FormRegisterTeacher_Load(object sender, EventArgs e)
        {
            DSRegisterTeacher.EnforceConstraints = false;

            this.TARegisterTeacher.Connection.ConnectionString = Program.connstr;
            this.TARegisterTeacher.Fill(this.DSRegisterTeacher.GIAOVIEN_DANGKY);

            cbbBrand.DataSource = Program.bds_dspm;
            cbbBrand.DisplayMember = "TENCN";
            cbbBrand.ValueMember = "TENSERVER";
            cbbBrand.SelectedIndex = Program.mChinhanh;

            groupBox1.Enabled = false;
            if (Program.mGroup == "TRUONG")
            {
                cbbBrand.Enabled = true;
                btnAdd.Enabled = btnModify.Enabled = btnRemove.Enabled = btnUndo.Enabled = btnNote.Enabled = false;
            }
            else
            {
                cbbBrand.Enabled = false;
                btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = true;
                btnNote.Enabled = btnUndo.Enabled = false;
            }

            if (BDSRegisterTeacher.Count == 0)
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = BDSRegisterTeacher.Position;
            groupBox1.Enabled = true;
            BDSRegisterTeacher.AddNew();
            cbbLAN.Text = "1";
            cbbTRINHDO.Text = "A";  

            btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCRegisterTeacher.Enabled = false;
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maMH = (((DataRowView)BDSRegisterTeacher[BDSRegisterTeacher.Position])["MAMH"].ToString());
            maLOP = (((DataRowView)BDSRegisterTeacher[BDSRegisterTeacher.Position])["MALOP"].ToString());
            lan = Int16.Parse(((DataRowView)BDSRegisterTeacher[BDSRegisterTeacher.Position])["LAN"].ToString());
            if (SqlFunction.ExamExist(maMH, maLOP, lan))
            {
                MessageBox.Show("Đã được thi rồi, không được xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa không nè ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    BDSRegisterTeacher.RemoveCurrent();
                    this.TARegisterTeacher.Connection.ConnectionString = Program.connstr;
                    this.TARegisterTeacher.Update(this.DSRegisterTeacher.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đăng kí. Xóa lại đi!" + ex.Message, "", MessageBoxButtons.OK);
                    this.TARegisterTeacher.Fill(this.DSRegisterTeacher.GIAOVIEN_DANGKY);
                    return;
                }
                if (BDSRegisterTeacher.Count == 0)
                {
                    btnRemove.Enabled = false;
                }
            }
        }

        private void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = BDSRegisterTeacher.Position;
            maMH = (((DataRowView)BDSRegisterTeacher[position])["MAMH"].ToString());
            maLOP = (((DataRowView)BDSRegisterTeacher[position])["MALOP"].ToString());
            lan = Int16.Parse(((DataRowView)BDSRegisterTeacher[position])["LAN"].ToString());
            if (SqlFunction.ExamExist(maMH, maLOP, lan))
            {
                MessageBox.Show("Đã được thi rồi, không được hiệu chỉnh", "", MessageBoxButtons.OK);
                return;
            }
            modify = true;
            groupBox1.Enabled = true;

            btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnNote.Enabled = btnUndo.Enabled = true;
            GCRegisterTeacher.Enabled = false;
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không được để trống", "", MessageBoxButtons.OK);
                tbMAGV.Focus();
                return;
            }
            if (tbMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "", MessageBoxButtons.OK);
                tbMALOP.Focus();
                return;
            }
            if (tbMAMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn không được để trống", "", MessageBoxButtons.OK);
                tbMAMH.Focus();
                return;
            }
            String soCau = tbSOCAUTHI.Text.Trim();
            String thoigian = tbTHOIGIAN.Text.Trim();
            if (soCau == "")
            {
                MessageBox.Show("Số câu thi không được để trống", "", MessageBoxButtons.OK);
                tbSOCAUTHI.Focus();
                return;
            }
            if (thoigian == "")
            {
                MessageBox.Show("Thời gian không được để trống", "", MessageBoxButtons.OK);
                tbTHOIGIAN.Focus();
                return;
            }

            try
            {
                if (Int32.Parse(soCau) < 10 || Int32.Parse(soCau) > 100)
                {
                    MessageBox.Show("Số câu thi phải >=10 và <=100", "", MessageBoxButtons.OK);
                    tbSOCAUTHI.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số câu thi không đúng địn dạng", "", MessageBoxButtons.OK);
                tbSOCAUTHI.Focus();
                return;
            }

            try
            {
                if (Int32.Parse(thoigian) < 15 || Int32.Parse(thoigian) > 60)
                {
                    MessageBox.Show("Thời gian thi phải >=15 và <=60", "", MessageBoxButtons.OK);
                    tbTHOIGIAN.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thời gian thi không đúng địn dạng", "", MessageBoxButtons.OK);
                tbTHOIGIAN.Focus();
                return;
            }


            if (deNGAYTHI.Text.Trim() == "")
            {
                MessageBox.Show("Ngày thi không được để trống", "", MessageBoxButtons.OK);
                deNGAYTHI.Focus();
                return;
            }

            if (DateTime.Compare(deNGAYTHI.DateTime, DateTime.Now) < 0)
            {
                MessageBox.Show("Ngày thi phải lớn hơn ngày hiện tại", "", MessageBoxButtons.OK);
                deNGAYTHI.Focus();
                return;
            }


            if (!SqlFunction.TeacherExist(tbMAGV.Text))
            {
                MessageBox.Show("Mã giáo viên không tồn tại", "", MessageBoxButtons.OK);
                tbMAGV.Focus();
                return;
            }

            if (!SqlFunction.CourseExist(tbMAMH.Text))
            {
                MessageBox.Show("Mã môn học không tồn tại", "", MessageBoxButtons.OK);
                tbMAMH.Focus();
                return;
            }

            if (!SqlFunction.ClassExist(tbMALOP.Text))
            {
                MessageBox.Show("Mã lớp không tồn tại", "", MessageBoxButtons.OK);
                tbMALOP.Focus();
                return;
            }


            if (!SqlFunction.QuestionEnough(tbMAMH.Text,cbbTRINHDO.Text,Int16.Parse(tbSOCAUTHI.Text)))
            {
                MessageBox.Show("Không đủ đề để đăng kí thi", "", MessageBoxButtons.OK);
                return;
            }
            if(!(modify && maMH.Trim().Equals(tbMAMH.Text.Trim()) && maLOP.Trim().Equals(tbMALOP.Text.Trim()) && lan == Int16.Parse(cbbLAN.Text)))
            {
                if (SqlFunction.ExamRegisterExist(tbMALOP.Text, tbMAMH.Text, Int32.Parse(cbbLAN.Text)))
                {
                    MessageBox.Show("Đã đăng kí rồi, vui lòng xem lại", "", MessageBoxButtons.OK);
                    return;
                }
            }

            try
            {
                BDSRegisterTeacher.EndEdit();
                this.TARegisterTeacher.Connection.ConnectionString = Program.connstr;
                this.TARegisterTeacher.Update(this.DSRegisterTeacher.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khoa" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            GCRegisterTeacher.Enabled = true;
            btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;
            groupBox1.Enabled = false;
            modify = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BDSRegisterTeacher.CancelEdit();
            if (btnAdd.Enabled == false)
            {
                BDSRegisterTeacher.Position = position;
            }
            GCRegisterTeacher.Enabled = true;
            groupBox1.Enabled = true;
            btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnNote.Enabled = btnUndo.Enabled = false;
            modify = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TARegisterTeacher.Fill(this.DSRegisterTeacher.GIAOVIEN_DANGKY);
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
            {
                return;
            }
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
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.TARegisterTeacher.Connection.ConnectionString = Program.connstr;
                this.TARegisterTeacher.Fill(this.DSRegisterTeacher.GIAOVIEN_DANGKY);
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
