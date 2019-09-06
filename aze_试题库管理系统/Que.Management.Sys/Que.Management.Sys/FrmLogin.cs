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
using Microsoft.Win32;
using System.Net;
using System.Net.Sockets;


namespace Que.Management.Sys
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        
        //登录按钮
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Login();
        }
        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmReg frm = new FrmReg();
            frm.ShowDialog();

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Return)//判断用户按下的是否是回车键
            {
                Login();
            }
        }

        private void Login()//登录方法
        {
            string user_id = txtUser.Text.Trim();
            string user_pwd = txtPwd.Text;
            //密码加密
            user_pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(user_pwd, "md5");

            //获取本机IP地址
            string ip_addr=string.Empty;
            string HostName = Dns.GetHostName();//得到主机名
            IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
            for(int i=0;i<IpEntry.AddressList.Length;i++)
            {
                //从IP地址列表中筛选出IPv4类型的IP地址
                //AddressFamily.InterNetwork表示此IP为IPv4
                //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                if(IpEntry.AddressList[i].AddressFamily==System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip_addr = IpEntry.AddressList[i].ToString();
                }
            }

            UserinfoWebServiceSoapClient us = new UserinfoWebServiceSoapClient();
            string message = us.Login(user_id, user_pwd, ip_addr);
            if (string.IsNullOrEmpty(message))
            {
                FrmMain.user_id = user_id;
                //MessageBox.Show("登录成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
