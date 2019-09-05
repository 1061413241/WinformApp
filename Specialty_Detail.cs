using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Specialty_Detail : Form
    {
        public Specialty_Detail()
        {
            InitializeComponent();
        }

        private void Specialty_Detail_Load(object sender, EventArgs e)
        {
            string sql = "select * from Specialty";
            this.dataGridView1.DataSource = SqlHelper.ExecuteReader(sql);
        }
    }
}
