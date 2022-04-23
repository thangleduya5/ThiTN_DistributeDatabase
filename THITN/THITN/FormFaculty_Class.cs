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
    public partial class FormFaculty_Class : Form
    {
        private Boolean checkThem = false;
        private Boolean checkSua = false;
        private Boolean checkThemLop = false;
        private Boolean checkXoaLop = false;
        private Boolean checkSuaLop = false;
        
        public static Boolean checkSave = true;
        public FormFaculty_Class()
        {
            InitializeComponent();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                
                bdsLop.AddNew();

                txtMalop.Enabled = txtTenlop.Enabled = true;

                txtMaKH.Enabled = txtTenKH.Enabled = false;
                txtMAKHOA.Enabled = false;
                txtMAKHOA.Text = txtMaKH.Text;

                btnAdd.Enabled = btnRemove.Enabled = btnReload.Enabled = btnModify.Enabled = false;
                txtMalop.Focus();
                btnNote.Enabled = false;
                btnUndo.Enabled = false;
                GCKhoa.Enabled = false;
                btnThemLop.Enabled = btnSuaLop.Enabled = btnXoaLop.Enabled = false;
                txtMaKH.Enabled = txtTenKH.Enabled = false;

                checkThemLop = true;
                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giảng viên" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Không có Lớp nào để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                if (bdsGVDK.Count > 0)
                {
                    MessageBox.Show("Giáo viên này đã tồn tại trong bảng giảng viên đăng ký, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }

                if (bdsSV.Count > 0)
                {
                    MessageBox.Show("Lớp đã có sinh viên, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa lớp không: " + ((DataRowView)this.bdsLop.Current).Row["TENLOP"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //phải chạy lệnh del from where mới chính xác
                        bdsLop.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.TALop.Update(this.dsFaculty_class.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa Lớp " + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void ghiLop()
        {
            try
            {
                bdsLop.EndEdit();

                bdsLop.ResetCurrentItem();

                this.TALop.Update(this.dsFaculty_class.LOP);

                this.TAGVDK.Connection.ConnectionString = Program.connstr;
                this.TAGVDK.Fill(this.dsFaculty_class.GIAOVIEN_DANGKY);

                this.TASV.Connection.ConnectionString = Program.connstr;
                this.TASV.Fill(this.dsFaculty_class.SINHVIEN);

                this.TAGV.Connection.ConnectionString = Program.connstr;
                this.TAGV.Fill(this.dsFaculty_class.GIAOVIEN);

                this.TALop.Connection.ConnectionString = Program.connstr;
                this.TALop.Fill(this.dsFaculty_class.LOP);

               

                this.TAKhoa.Connection.ConnectionString = Program.connstr;
                this.TAKhoa.Fill(this.dsFaculty_class.KHOA);


                txtMalop.Enabled = txtTenlop.Enabled = false;
                checkThemLop = checkSuaLop = checkXoaLop = false;
                /* btnUndo.Enabled = true;
                 btnNote.Enabled = true;*/
                GCKhoa.Enabled = true;
                GCLop.Enabled = true;
                btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled
                 = btnUndo.Enabled = btnReload.Enabled = btnNote.Enabled = true;
               
                btnSuaLop.Enabled = btnThemLop.Enabled = btnXoaLop.Enabled = true;
                checkSave = true;

            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi giảng viên " + ex.Message, "", MessageBoxButtons.OK);
            }
        }


        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Không có Lớp để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
               
               
                txtMalop.Enabled = false;
                txtTenlop.Enabled  = true;
               
                 GCKhoa.Enabled = false;
                btnAdd.Enabled = btnRemove.Enabled = btnModify.Enabled
                    = btnUndo.Enabled = btnReload.Enabled = btnNote.Enabled = false;
               
                btnThemLop.Enabled = btnXoaLop.Enabled = btnSuaLop.Enabled = false;
                checkSave = false;
            }
        }

        private void btnGhiLop_Click(object sender, EventArgs e)
        {
            if (checkThemLop == true)
            {
                try
                {
                    if (txtMalop.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Mã Lớp không được để trống, vui lòng nhập lại ", "", MessageBoxButtons.OK);
                        return;
                    }

                    if (txtTenlop.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Tên lớp không được để trống, vui lòng nhập lại ", "", MessageBoxButtons.OK);
                        return;
                    }


                    if (SqlFunction.ClassExist(txtMalop.Text))
                    {
                        MessageBox.Show("Mã lớp đã tồn tại, vui lòng nhập lại", "", MessageBoxButtons.OK);
                        txtMalop.Focus();
                        return;
                    }
                    else
                    {
                        ghiLop();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Lớp " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            else if (checkSuaLop == true)
            {
                try
                {
                    ghiLop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Lớp " + ex.Message, "", MessageBoxButtons.OK);
                }
            }

            else
            {
                ghiLop();
            }
        }

        private void btnPhucHoiLop_Click(object sender, EventArgs e)
        {
            bdsLop.CancelEdit();
            checkSuaLop = false;
            checkThemLop = false;
            txtMalop.Enabled = false;
            txtTenlop.Enabled = false;


            btnUndo.Enabled = true;
            btnAdd.Enabled = btnRemove.Enabled = btnReload.Enabled = btnNote.Enabled = btnModify.Enabled = true;

            GCKhoa.Enabled = true;
            GCLop.Enabled = true;

            btnSuaLop.Enabled = btnThemLop.Enabled = btnXoaLop.Enabled = true;
        }

        private void btnTaiLaiLop_Click(object sender, EventArgs e)
        {
            this.TALop.Fill(this.dsFaculty_class.LOP);
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsFaculty_class);

        }

        private void FormFaculty_Class_Load(object sender, EventArgs e)
        {
            
            this.ControlBox = false;

            dsFaculty_class.EnforceConstraints = false;
          
            GCKhoa.UseDisabledStatePainter = false;
            GCLop.UseDisabledStatePainter = false;

            try
            {
                cbbBrand.DataSource = Program.bds_dspm;
                cbbBrand.DisplayMember = "TENCN";
                cbbBrand.ValueMember = "TENSERVER";
                cbbBrand.SelectedIndex = Program.mChinhanh;

                cbbBrand.Enabled = false;


            }
            catch (Exception ex) { }

            this.TAKhoa.Connection.ConnectionString = Program.connstr;
            this.TAKhoa.Fill(this.dsFaculty_class.KHOA);

            this.TAGV.Connection.ConnectionString = Program.connstr;
            this.TAGV.Fill(this.dsFaculty_class.GIAOVIEN);

            this.TALop.Connection.ConnectionString = Program.connstr;
            this.TALop.Fill(this.dsFaculty_class.LOP);

            this.TAGVDK.Connection.ConnectionString = Program.connstr;
            this.TAGVDK.Fill(this.dsFaculty_class.GIAOVIEN_DANGKY);

            this.TASV.Connection.ConnectionString = Program.connstr;
            this.TASV.Fill(this.dsFaculty_class.SINHVIEN);







            panelControl2.Enabled = false;
            panelLop.Enabled = false;
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

            txtMaCN.Enabled = false;
            txtMAKHOA.Enabled = false;
            txtMaKH.Enabled = txtTenKH.Enabled = txtMalop.Enabled = txtTenlop.Enabled = false;

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                String macn = ((DataRowView)bdsKhoa[1])["MACS"].ToString();
                bdsKhoa.AddNew();
                txtMaCN.Text = macn;
                panelLop.Enabled = false;
                checkThem = true;
                btnAdd.Enabled = btnRemove.Enabled = btnReload.Enabled = btnModify.Enabled = false;
                txtMaKH.Focus();
                btnNote.Enabled = true;
                GCKhoa.Enabled = false;
                GCLop.Enabled = false;
                ctxMenuLop.Enabled = false;
                txtMaKH.Enabled = txtTenKH.Enabled = true;

                checkSave = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khoa " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKhoa.Count == 0)
            {
                MessageBox.Show("Không có Khoa để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (bdsLop.Count > 0)
                {
                    MessageBox.Show("Khoa đã có lớp, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }

                if (bdsGiaoVien.Count > 0)
                {
                    MessageBox.Show("Khoa đã có giáo viên, không thể xóa", "", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + ((DataRowView)this.bdsKhoa.Current).Row["TENKH"].ToString() + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //phải chạy lệnh del from where mới chính xác
                        bdsKhoa.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.TAKhoa.Update(this.dsFaculty_class.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khoa" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private int ghiKhoa()
        {
            try
            {
                bdsKhoa.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsKhoa.ResetCurrentItem();
                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.TAKhoa.Update(this.dsFaculty_class.KHOA);

                checkThem = false;
                btnAdd.Enabled = btnRemove.Enabled = btnReload.Enabled = btnModify.Enabled = true;
                txtMaKH.Focus();
                btnNote.Enabled = true;
                GCKhoa.Enabled = true;
                GCLop.Enabled = true;
                ctxMenuLop.Enabled = true;
                txtMaKH.Enabled = txtTenKH.Enabled = false;
                checkSave = true;
                panelLop.Enabled = true;
                return 0;
            }
            catch (Exception ex)
            {
                checkSave = false;
                MessageBox.Show("Lỗi ghi khoa" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            }
        }

        private void btnNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkThem == true)
            {
                if (txtMaKH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã khoa không được rỗng", "", MessageBoxButtons.OK);
                    txtMaKH.Focus();
                    return;
                }
                if (txtTenKH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên khoa không được rỗng", "", MessageBoxButtons.OK);
                    txtTenKH.Focus();
                    return;
                }


                if (SqlFunction.DepartmentExist(txtMaKH.Text))
                {
                    MessageBox.Show("Mã khoa đã tồn tại, vui lòng nhập lại", "", MessageBoxButtons.OK);
                    txtMaKH.Focus();
                    return;
                }
                else
                {
                    ghiKhoa();
                    checkThem = false;
                }
            }
            else if (checkSua == true)
            {

                if (txtTenKH.Text.Equals(""))
                {
                    MessageBox.Show("Tên khoa không được rỗng", "", MessageBoxButtons.OK);
                    txtTenKH.Focus();
                    return;
                }

                ghiKhoa();


            }
            else
            {
                ghiKhoa();
            }
        }

        private void btnModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKhoa.Count == 0)
            {
                MessageBox.Show("Không có Khoa để sửa!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                checkSua = true;
                panelLop.Enabled = false;
                btnAdd.Enabled = btnRemove.Enabled = btnReload.Enabled = btnModify.Enabled = false;
                txtMaKH.Focus();
                btnNote.Enabled = true;
                GCKhoa.Enabled = false;
                GCLop.Enabled = false;
                ctxMenuLop.Enabled = false;
                txtTenKH.Enabled = true;
                checkSave = false;
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
                this.TAGVDK.Connection.ConnectionString = Program.connstr;
                this.TAGVDK.Fill(this.dsFaculty_class.GIAOVIEN_DANGKY);

                this.TASV.Connection.ConnectionString = Program.connstr;
                this.TASV.Fill(this.dsFaculty_class.SINHVIEN);

                this.TAGV.Connection.ConnectionString = Program.connstr;
                this.TAGV.Fill(this.dsFaculty_class.GIAOVIEN);

                this.TALop.Connection.ConnectionString = Program.connstr;
                this.TALop.Fill(this.dsFaculty_class.LOP);



                this.TAKhoa.Connection.ConnectionString = Program.connstr;
                this.TAKhoa.Fill(this.dsFaculty_class.KHOA);

            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            btnAdd.Enabled = btnRemove.Enabled = btnReload.Enabled = btnModify.Enabled = true;
            txtMaKH.Focus();
            checkThem = false;
            btnNote.Enabled = true;
            GCKhoa.Enabled = true;
            GCLop.Enabled = true;
            ctxMenuLop.Enabled = true;
            this.TAKhoa.Fill(this.dsFaculty_class.KHOA);
            txtMaKH.Enabled = txtTenKH.Enabled = false;
            panelLop.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.TAGVDK.Connection.ConnectionString = Program.connstr;
            this.TAGVDK.Fill(this.dsFaculty_class.GIAOVIEN_DANGKY);

            this.TASV.Connection.ConnectionString = Program.connstr;
            this.TASV.Fill(this.dsFaculty_class.SINHVIEN);

            this.TAGV.Connection.ConnectionString = Program.connstr;
            this.TAGV.Fill(this.dsFaculty_class.GIAOVIEN);

            this.TALop.Connection.ConnectionString = Program.connstr;
            this.TALop.Fill(this.dsFaculty_class.LOP);



            this.TAKhoa.Connection.ConnectionString = Program.connstr;
            this.TAKhoa.Fill(this.dsFaculty_class.KHOA);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
