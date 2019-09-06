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
    public partial class FrmMenu : DockContent
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void lblQueMan_Click(object sender, EventArgs e)
        {
            FrmQueMan man = new FrmQueMan();//实例化子窗体
            openform(man);
        }

        private void lblQueSearch_Click(object sender, EventArgs e)
        {
            FrmQueSearch search = new FrmQueSearch();
            openform(search);
        }

        private void openform(DockContent frm)
        {
            FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;//获取当前窗体的父窗体
            main.IsMdiContainer = true;//设置父窗体为容器窗体
            frm.MdiParent = main;//设置子窗体的父窗体
            frm.Show(main.dockPanel1);//打开子窗体
        }
    }
}
