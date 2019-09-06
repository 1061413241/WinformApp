using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Que.Management.Sys.UserinfoWebService;
using System.Web.Security;

namespace Que.Management.Sys
{
    public partial class FrmReg : Form
    {
        public FrmReg()
        {
            InitializeComponent();
        }
        //注册按钮
        private void btnReg_Click(object sender, EventArgs e)
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = txtPwd.Text.Trim();
            string ip_addr = txtIp_addr.Text.Trim();
            string mac_addr = txtMac_addr.Text.Trim();

            //密码加密
            user_pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(user_pwd, "md5");

            //实例化web服务的对象
            UserinfoWebServiceSoapClient us = new UserinfoWebServiceSoapClient();
            string message = us.Register(user_id, user_pwd, ip_addr, mac_addr);

            MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

