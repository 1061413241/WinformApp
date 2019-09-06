using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Que.Mana.SysWebApplication
{
    /// <summary>
    /// UserinfoWebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class UserinfoWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="user_id">用户名</param>
        /// <param name="user_pwd">密码</param>
        /// <returns></returns>
        [WebMethod]
        public string Login(string user_id,string user_pwd,string ip_addr)
        {
            //拼接T-SQL语句
            string strSQL="SELECT * FROM userinfo WHERE user_id='"+user_id+"'AND user_pwd = '"+user_pwd+"'";
            //执行SQL语句
            DBconn dbconn = new DBconn();//实例化连接数据库的类的对象
            SqlConnection conn = dbconn.OpenConn();//调用对象中的打开数据库的方法
            SqlCommand comm = new SqlCommand(strSQL, conn);//实例化sqlcommand对象
            SqlDataReader dr = comm.ExecuteReader();//执行SQL语句，并接收返回的受影响的行数
            if (dr.Read())//如果能够前进到下一条记录，就说明有数据
            {
                if (dr["ip_addr"].ToString() == ip_addr)
                    return null;
                else
                    return "IP地址受限，不允许在"+ip_addr+"登录";
            }
            return "用户名或密码错误";
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user_id">用户名</param>
        /// <param name="user_pwd">密码</param>
        /// <param name="ip_addr">限制登陆的IP</param>
        /// <param name="mac_addr">限制登陆的MAC地址</param>
        /// <returns></returns>
        [WebMethod]
        public string Register(string user_id, string user_pwd, string ip_addr, string mac_addr)
        {
            //拼接T-SQL语句
            string strSQL = @"INSERT INTO [dbo].[userinfo]
                                       ([user_id]
                                       ,[user_pwd]
                                       ,[ip_addr]
                                       ,[mac_addr])
                                 VALUES
                                       ('" + user_id + @"'
                                       ,'" + user_pwd + @"'
                                       ,'" + ip_addr + @"'
                                       ,'" + mac_addr + "')";
            //执行SQL语句
            DBconn dbconn = new DBconn();//实例化连接数据库的类的对象
            SqlConnection conn = dbconn.OpenConn();//调用对象中的打开数据库的方法
            SqlCommand comm = new SqlCommand(strSQL, conn);//实例化sqlcommand对象
            try
            {
                int row_count = comm.ExecuteNonQuery();//执行SQL语句，并接收返回的受影响的行数
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return "注册成功";
        }
    }
}
