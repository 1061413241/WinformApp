using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Que.Mana.SysWebApplication
{
    public class DBconn
    {
        //创建连接数据库的方法
        public SqlConnection OpenConn()
        {
            //创建连接
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = "127.0.0.1";
            scsb.UserID = "sa";
            scsb.Password = "123456";
            scsb.InitialCatalog = "Que_db";

            //判断连接是否打开
            SqlConnection conn = new SqlConnection(scsb.ToString());//参数是连接数据库的字符串
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }
        
        
    }
}