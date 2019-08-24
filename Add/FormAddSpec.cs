using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormAddSpecialty : Form
    {
        public FormAddSpecialty()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into Specialty(Specialty_Id,Specialty_Name) values(@id,@name)";
            SqlParameter[] pm =
            {
                new SqlParameter("@id",int.Parse(TBid.Text)),
                new SqlParameter("@name",TBname.Text.Trim())
            };
            int r = SqlHelper.ExecuteNonQuery(sql,pm);
            if (r > 0)
            {
                MessageBox.Show("添加成功！");
                Specialty_Detail form = new Specialty_Detail();
                form.Show();
            }

        }
    }
}
