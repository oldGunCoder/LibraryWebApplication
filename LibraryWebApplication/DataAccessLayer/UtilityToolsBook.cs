using LibraryWebApplication.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryWebApplication.DataAccessLayer
{
    public class UtilityToolsBook
    {
        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["BookDB"].ConnectionString;
        }

        public static int ExecuteInsertBook(Book book, Author author, BusinessLayer.Type type)
        {
            SqlConnection conn;
            SqlCommand cmd;

            using (conn = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    
                    string sql = "sp_InsertBookInfo";

                    conn.Open();

                    using (cmd = new SqlCommand(sql, conn))
                    {

                        SqlParameter[] param = new SqlParameter[6];
                        param[0] = new SqlParameter("@Title", System.Data.SqlDbType.VarChar, 30);
                        param[1] = new SqlParameter("@PageCount", System.Data.SqlDbType.Int);
                        param[2] = new SqlParameter("@Price", System.Data.SqlDbType.Decimal);
                        param[3] = new SqlParameter("@AuthorFirstName", System.Data.SqlDbType.VarChar, 30);
                        param[4] = new SqlParameter("@AuthorLastName", System.Data.SqlDbType.VarChar, 30);
                        param[5] = new SqlParameter("@TypeName", System.Data.SqlDbType.VarChar, 30);

                        param[0].Value = book.Title;
                        param[1].Value = book.PageCount;
                        param[2].Value = book.Price;
                        param[3].Value = author.FristName;
                        param[4].Value = author.LastName;
                        param[5].Value = type.Name;

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

        //internal static int ExecuteInsertBook(Book book, Author author, BusinessLayer.Type type)
        //{
        //    throw new NotImplementedException();
        //}

        //public static object ExecuteSelect()
        //{
        //    SqlConnection conn;
        //    SqlCommand cmd;

        //    using (conn = new SqlConnection(GetConnectionString()))
        //    {
        //        try
        //        {
        //            string sql = "sp_SelectRegistrationInfo";

        //            conn.Open();

        //            using (cmd = new SqlCommand(sql, conn))
        //            {
        //                SqlDataAdapter da = new SqlDataAdapter(cmd);
        //                DataSet ds = new DataSet();
        //                da.Fill(ds);

        //                cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //                return ds;

        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //}
    }
}