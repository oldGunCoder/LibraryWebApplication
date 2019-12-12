using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace LibraryWebApplication.BusinessLayer
{
    public class UtilityTools
    {
        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;
        }

        public static int ExecuteInsert(Student student)
        {
            SqlConnection conn;
            SqlCommand cmd;

            using (conn = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    //string sql = "INSERT INTO Registration (Name, Username, Password) VALUES (@Name,@Username,@Password)";
                    string sql = "sp_InsertRegistrationInfo";

                    conn.Open();

                    using (cmd = new SqlCommand(sql, conn))
                    {

                        SqlParameter[] param = new SqlParameter[9];
                        param[0] = new SqlParameter("@FirstName", System.Data.SqlDbType.VarChar, 30);
                        param[1] = new SqlParameter("@LastName", System.Data.SqlDbType.VarChar, 30);
                        param[2] = new SqlParameter("@BirthDate", System.Data.SqlDbType.DateTime);
                        param[3] = new SqlParameter("@Gender", System.Data.SqlDbType.Char, 6);
                        param[4] = new SqlParameter("@Class", System.Data.SqlDbType.VarChar, 30);
                        
                        param[0].Value = student.FirstName;
                        param[1].Value = student.LastName;
                        param[2].Value = student.BirthDate;
                        param[3].Value = student.Gender;
                        param[4].Value = student.Class;
                        

                        foreach (SqlParameter p in param)
                        {
                            cmd.Parameters.Add(p);
                        }

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        return (int)cmd.ExecuteScalar();
                    }
                }
                catch (SqlException ex)
                {
                    return ex.ErrorCode;
                }
            }
        }

        public static object ExecuteSelect()
        {
            SqlConnection conn;
            SqlCommand cmd;

            using (conn = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    string sql = "sp_SelectRegistrationInfo";

                    conn.Open();

                    using (cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        return ds;

                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
}