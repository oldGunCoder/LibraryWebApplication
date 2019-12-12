using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryWebApplication.DataAccessLayer
{
    public class UtilityToolsBorrowOrReturn
    {
        public static int BorrowOrReturn(string studentId, string bookId, string cmdText)
        {
            SqlConnection sqlConnection;
            SqlCommand sqlCommand;

            using (sqlConnection = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    sqlConnection.Open();
                    using (sqlCommand = new SqlCommand(cmdText, sqlConnection))
                    {
                        SqlParameter[] sqlParameter = new SqlParameter[2];
                        sqlParameter[0] = new SqlParameter("@studentId", System.Data.SqlDbType.Int);
                        sqlParameter[1] = new SqlParameter("@bookId", System.Data.SqlDbType.Int);

                        sqlParameter[0].Value = Convert.ToInt32(studentId);
                        sqlParameter[1].Value = Convert.ToInt32(bookId);

                        foreach (SqlParameter parameter in sqlParameter)
                        {
                            sqlCommand.Parameters.Add(parameter);
                        }

                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        return (int)sqlCommand.ExecuteScalar();
                    }
                }
                catch (SqlException sqlException)
                {
                    return sqlException.ErrorCode;
                }
            }

        }

        private static string GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}