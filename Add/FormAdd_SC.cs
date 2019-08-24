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
    public partial class FormAdd_SC : Form
    {
        public FormAdd_SC()
        {
            InitializeComponent();
            cmbQstDiff.Items.Remove(3);
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string sql = "select question_Id from Question where question_Name='单项选择题' and Question_Course = @Question_Course";
            SqlParameter[] pm =
            {
                new SqlParameter("@Question_Course",tbCourse.Text.Trim())
            };
            object row = SqlHelper.ExecuteScalar(sql, pm);
            if (row == null)
            {
                MessageBox.Show("该课程不存在，请检查或添加该课程！");
            }
            else
            {
                sql = "insert SingleChoice(SC_Info ,SC_Level ,SC_Question,Opt1,Opt2,Opt3,Opt4,answer) values(@info,@level,@sc_question,@Opt1,@Opt2,@Opt3,@Opt4,@answ)";
                SqlParameter[] pm1 =
                {
                    new SqlParameter("@info",tbQstDcb.Text),
                    new SqlParameter("@level",cmbQstDiff.SelectedItem.ToString()),
                    new SqlParameter("@sc_question",(int)row),
                    new SqlParameter("@Opt1",tbOpt1.Text),
                    new SqlParameter("@Opt2",tbOpt2.Text),
                    new SqlParameter("@Opt3",tbOpt3.Text),
                    new SqlParameter("@Opt4",tbOpt4.Text),
                    new SqlParameter("@answ",Cmb_Answ.SelectedItem.ToString())

                };
                int r = SqlHelper.ExecuteNonQuery(sql, pm1);
                if (r > 0)
                {
                    MessageBox.Show("添加成功！");
                }
            }
        }
    }
}
