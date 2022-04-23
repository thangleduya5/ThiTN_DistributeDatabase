using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace THITN
{
    public partial class FormLogin : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

        public FormLogin()
        {
            InitializeComponent();
            InitDataForCbbGroup();
        }
        private void InitDataForCbbGroup()
        {
            btnStudent.BackColor = Color.White;
            btnTeacher.BackColor = Color.Aquamarine;
        }

        private void getListBrand(string cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbbGroup.DataSource = Program.bds_dspm;
            cbbGroup.DisplayMember = "TENCN";
            cbbGroup.ValueMember = "TENSERVER";
        }

        private int ConnectDB()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;

            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại tên server của Publisher và tên CSDL.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }


        private void btnTeacher_Click(object sender, EventArgs e)
        {
            btnStudent.BackColor = Color.White;
            btnTeacher.BackColor = Color.Aquamarine;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            btnTeacher.BackColor = Color.White;
            btnStudent.BackColor = Color.Aquamarine;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbLogin.Text.Trim()=="" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if (btnTeacher.BackColor == Color.Aquamarine)
            {
                Program.mlogin = tbLogin.Text;
                Program.password = tbPassword.Text;
                if (Program.Connect() == 0) return;

                Program.mChinhanh = cbbGroup.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                String strLenh = "exec SP_InfoTeacher '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu \nBạn xem lại username, password", "");
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                Program.formMain.Ma.Text = "Mã GV: " + Program.username;
                Program.formMain.Hoten.Text = "Họ tên: " + Program.mHoten;
                Program.formMain.Coso.Text = "Nhóm: " + Program.mGroup;
            }
            else
            {
                Program.mlogin = "student";
                Program.password = "123456";
                Program.studentID = tbLogin.Text;
                Program.studentPass = tbPassword.Text;
                if (Program.Connect() == 0) return;

                Program.mChinhanh = cbbGroup.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                String strLenh = "exec SP_InfoStudent '" + Program.studentID + "'" + "," + "'" + Program.studentPass + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.studentID;
                if (Convert.IsDBNull(Program.myReader.GetString(0)) || Program.myReader.GetValue(1).ToString()=="")
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu \nBạn xem lại username, password", "");
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(4);
                Program.maLop = Program.myReader.GetString(2);
                Program.tenLop = Program.myReader.GetString(3);
                Program.myReader.Close();
                Program.conn.Close();
                Program.formMain.Ma.Text = "Mã SV: " + Program.username;
                Program.formMain.Hoten.Text = "Họ tên: " + Program.mHoten;
                Program.formMain.Coso.Text = "Nhóm: " + Program.mGroup;
            }
            Program.formMain.showMenu();
            this.Close();
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (ConnectDB() == 0) return;
            getListBrand("Select * from Get_Subscribes");
            cbbGroup.SelectedIndex = 0;
            Program.servername = cbbGroup.SelectedValue.ToString();
        }

        private void cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = cbbGroup.SelectedValue.ToString();
        }
    }
}
