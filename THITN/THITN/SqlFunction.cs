using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace THITN
{
    static class SqlFunction
    {
        public static bool StudentExist(String maSV)
        {

            return Exist("SP_CheckStudentExist", maSV);
        }

        public static bool DepartmentExist(String maKH)
        {
            return Exist("SP_CheckDepartmentExist", maKH);
        }

        public static bool ClassExist(String maLOP)
        {
            return Exist("SP_CheckClassExist", maLOP);
        }

        public static bool CourseExist(String maMH)
        {
            return Exist("SP_CheckCourseExist", maMH);
        }

        public static bool TeacherExist(String maGV)
        {
            return Exist("SP_CheckTeacherExist", maGV);
        }

        public static bool ExamRegisterExist(String maLOP, String maMH, int lan)
        {
            String code = maLOP + "', '" + maMH + "', '" + lan;
            return Exist("SP_CheckExamRegisterExist", code);
        }

        public static bool QuestionEnough(String maMH, String trinhDO, int soCauThi)
        {
            String code = maMH + "', '" + trinhDO + "', '" + soCauThi;
            return Exist("SP_CheckQuestionEnough", code);
        }

        public static bool ExamStudentExist(String maSV, String maMH, int lan)
        {
            String code = maSV + "', '" + maMH + "', '" + lan;
            return Exist("SP_CheckExamStudentExist", code);
        }

        public static bool ExamExist(String maSV, String maMH, int lan)
        {
            String code = maSV + "', '" + maMH + "', '" + lan;
            return Exist("SP_CheckExamExist", code);
        }

        public static int CreateLogin(String maGV, String tenDN, String matKhau, String quyen)
        {
            String query = "Exec SP_CreateLogin '" + tenDN + "','" + matKhau + "','" + maGV + "','" + quyen + "'";
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(query, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();

                return 0;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                if (ex.Message.Contains("server principal"))
                {
                    return 1;
                }
                else if (ex.Message.Contains("User, group, or role"))
                {
                    return 2;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static int RemoveLogin(String maGV)
        {
            String query = "Exec SP_RemoveLogin '" + maGV + "'";
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(query, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();

                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
            }
        }

        public static int ChangePass(String tenDN, String mk, String role)
        {
            String query = "EXEC SP_ChangePass '" + tenDN + "','"+ mk +"','" + role +"'" ;
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(query, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();

                return 1;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                return 0;
            }
        }

        private static bool Exist(String sp, String code)
        {
            String query = "Exec " + sp + " '" + code + "'";
            SqlDataReader reader = ExecSqlDataReader(query);

            while (reader.Read())
            {
                String result = reader.GetString(0);

                if (result.Equals("1"))
                {
                    reader.Close();
                    reader.Dispose();
                    return true;
                }
            }
            reader.Close(); 
            reader.Dispose(); 
            return false;
        }

        public static InfoExam GetInfoExam(String maLop, String maMH, DateTime ngayThi, Int32 lan)
        {
            
            String query = "Exec SP_InfoExam '" + maMH + "', '" + maLop + "'," + lan + ",'" + ngayThi.ToString("MM/dd/yyyy")+"'";
            Console.WriteLine(ngayThi.ToString("MM/dd/yyyy"));
            SqlDataReader reader = ExecSqlDataReader(query);

            if (reader.Read())
            {
                InfoExam infoExam = new InfoExam();

                infoExam.maLop = maLop;
                infoExam.maMH = maMH;
                infoExam.lan = lan;
                infoExam.ngayThi = ngayThi;
                infoExam.trinhDo = reader.GetString(0);
                infoExam.soCauThi = reader.GetInt16(1);
                infoExam.thoiGian = reader.GetInt16(2);

                return infoExam;
            }
            reader.Close();
            reader.Dispose();
            return null;
        }

        public static List<QuestionExam> GetQuestionForTestExam(String maMH, String trinhDO, int soCauThi)
        {
            
            String query = "Exec SP_GetQuestion '" + maMH + "', '" + trinhDO + "', " + soCauThi;
            Console.WriteLine(query);
            SqlDataReader reader = ExecSqlDataReader(query);

            List<QuestionExam> listExam = new List<QuestionExam>();

            while (reader.Read())
            {
                QuestionExam exam = new QuestionExam
                {
                    cauHoi = reader.GetInt32(0),
                    noiDung = reader.GetString(3),
                    a = reader.GetString(4),
                    b = reader.GetString(5),
                    c = reader.GetString(6),
                    d = reader.GetString(7),
                    trueAnswer = reader.GetString(8),
                    yourAnswer = String.Empty
                };
                listExam.Add(exam);
            }

            reader.Close(); 
            reader.Dispose(); 

            return listExam;
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); 
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
