using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 添加专业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSpecialty form = new FormAddSpecialty();
            form.Show();
        }

        private void 添加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCourse form = new AddCourse();
            form.Show();
        }

        private void 新增题目ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新增选择题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd_SC form = new FormAdd_SC();
            form.Show();
        }
    }
}
