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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCour_Click(object sender, EventArgs e)
        {
            string sql = "insert into Course(Course_Id ,Course_Name ,Course_Specialty) values(@id,@name,@CS)";
            string sql1 = "select count(*) from Course where Course_Name = @Name";
            SqlParameter[] pm =
            {
                new SqlParameter("@id",int.Parse(tbCourseId.Text)),
                new SqlParameter("@name",tbCourseName.Text.Trim()),
                new SqlParameter("@CS",tbCourSpec.Text.Trim())
            };
            SqlParameter[] pm1 =
            {
                new SqlParameter("Name",tbCourseName.Text.Trim())
            };
            int i = (int)SqlHelper.ExecuteScalar(sql1,pm1);
            if (i > 0)
            {
                MessageBox.Show(tbCourseName.Text + "已存在！");
            }
            else
            {
                int r = SqlHelper.ExecuteNonQuery(sql, pm);
                if (r > 0)
                {
                    MessageBox.Show("成功添加！");
                }
            }
        }
    }
}
