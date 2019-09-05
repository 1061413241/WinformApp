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
    public partial class FormAdd_Judge : Form
    {
        public FormAdd_Judge()
        {
            InitializeComponent();
            string sql = "select (Course_Name) from Course";
            cmb_Course.DataSource = SqlHelper.ExecuteReader(sql);
            cmb_Course.DisplayMember = "Course_Name";
            string name = cmb_Course.SelectedItem.ToString();
            Console.WriteLine();
        }


        private void Bt_Add_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (cmb_Answ.SelectedIndex == -1)
            {
               MessageBox.Show("你没有选择答案");
                flag++;
            }
            if (cmb_Level.SelectedIndex == -1)
            {
                MessageBox.Show("你没有选择难度");
                flag++;
            }
            if(flag==0)
            {
                string sql = "select question_Id from Question where question_Name='判断题' and Question_Course = @Question_Course";
                SqlParameter[] pm =
                {
                new SqlParameter("@Question_Course",cmb_Course.SelectedItem.ToString())
                 };
                object row = SqlHelper.ExecuteScalar(sql, pm);
                if (row == null)
                {
                    MessageBox.Show("该课程不存在，请检查或添加该课程！");
                    
                }
                else
                {
                    sql = "insert Judge(Jud_Info ,Jud_Level ,Jud_question ,answer) values(@info ,@level ,@sc_question ,@answer)";
                    SqlParameter[] pms =
                    {
                    new SqlParameter("@info",tbInfo.Text),
                    new SqlParameter("@level",cmb_Level.SelectedItem.ToString()),
                    new SqlParameter("@sc_question",(int)row),
                    new SqlParameter("@answer",cmb_Answ.SelectedIndex)
                    };
                    int r = SqlHelper.ExecuteNonQuery(sql, pms);
                    if (r > 0)
                    {
                        MessageBox.Show("添加成功！");
                    }


                }
            }
        }
    }
}
