using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WindowsFormsApp1
{
    static class SqlHelper
    {
       
            private static readonly string constr = ConfigurationManager.ConnectionStrings["题库"].ConnectionString;
            public static int ExecuteNonQuery(string sql, params SqlParameter[] pms)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(pms);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }

                }
            }
            public static object ExecuteScalar(string sql, params SqlParameter[] pms)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(pms);
                        conn.Open();
                        return cmd.ExecuteScalar();

                    }
                }
            }
            public static DataTable ExecuteReader(string sql, params SqlParameter[] pms)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddRange(pms);
                    DataTable dtb = new DataTable();
                    adapter.Fill(dtb);
                    return dtb;
                }

            }
        }
    }
