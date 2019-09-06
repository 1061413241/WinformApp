using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Que.Management.Sys
{
    public partial class FrmMain : DockContent
    {
        public static string user_id;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = user_id;//获取当前用户信息

            FrmMenu menu = new FrmMenu();
            menu.Show(dockPanel1, DockState.DockLeft);
            dockPanel1.DockLeftPortion = 240;
            FrmHome home = new FrmHome();
            home.Show(dockPanel1);
        }

        //试题管理界面
        private void toolStripMenuItemQueMan_Click(object sender, EventArgs e)
        {
            FrmQueMan man = new FrmQueMan();//窗体实例化
            man.Show(dockPanel1);//窗体show()
        }

        //试题查询界面
        private void toolStripMenuItemQueSearch_Click(object sender, EventArgs e)
        {
            FrmQueSearch search = new FrmQueSearch();
            search.Show(dockPanel1);
        }
    }
}
