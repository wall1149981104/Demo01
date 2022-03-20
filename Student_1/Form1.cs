using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //登录
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456") ;
            try
            {
                conn.Open();
                string sql = String.Format("select count(*) from [User] where UserName='{0}' and Password = '{1}'", textBox1.Text, textBox2.Text);
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = (int)comm.ExecuteScalar();
                if (n == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Tag = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误！请重试", "登录失败",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Tag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Tag = false;
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e) //取消
        {
            this.Close();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
