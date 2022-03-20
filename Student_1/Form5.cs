using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            button4.Enabled = false;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e) //录入
        {
            if (textBox1.Text.Equals(string.Empty) || textBox2.Text.Equals(string.Empty) || textBox4.Text.Equals(string.Empty) || textBox5.Text.Equals(string.Empty))
            {
                DialogResult dr1 = MessageBox.Show("内容不能为空!!");
                if (dr1 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox4.Clear();
                    textBox6.Clear();
                    radioButton1.Checked = true;
                }
            }
            if (Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                if (textBox1.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                        && textBox2.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                        && textBox5.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                        && textBox4.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
                {
                    string sex = null;
                    if (radioButton1.Checked == true)
                        sex = radioButton1.Text;
                    else
                        sex = radioButton2.Text;
                    SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
                    conn.Open();
                    string sql = String.Format("insert into Course(Cno,Cname,Csele,Cpeople,Cnum) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", textBox1.Text, textBox2.Text, sex, textBox4.Text, textBox5.Text);
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = comm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DialogResult dr = MessageBox.Show("录入信息成功!!");
                        if (dr == DialogResult.OK)
                        {
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox6.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            radioButton1.Checked = true;
                        }
                    }
                    else
                    {
                        DialogResult dr1 = MessageBox.Show("录入信息失败!!");
                        if (dr1 == DialogResult.OK)
                        {
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox6.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            radioButton1.Checked = true;
                        }
                    }
                    conn.Close();
                }
                else
                {
                    DialogResult dr3 = MessageBox.Show("存在非法分隔符!!");
                    if (dr3 == DialogResult.OK)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox6.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        radioButton1.Checked = true;
                    }
                }
            }
            else
            {
                DialogResult dr2 = MessageBox.Show("课程号必须是数字组成!!");
                if (dr2 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox4.Clear();
                    textBox6.Clear();
                    radioButton1.Checked = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //删除
        {
            if (textBox6.Text.Equals(String.Empty))
            {
                DialogResult dr1 = MessageBox.Show("检索学号不能为空!!");
                if (dr1 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    radioButton1.Checked = true;
                }
            }
            if (Regex.IsMatch(textBox6.Text, @"^\d+$"))
            {
                if (textBox6.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
                {
                    DialogResult dr6 = MessageBox.Show("是否要删除？", "警告", MessageBoxButtons.OKCancel);
                    if (dr6 == DialogResult.OK)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
                        conn.Open();
                        string sql = String.Format("delete from Course where Cno = N'{0}'", textBox6.Text);
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n > 0)
                        {
                            DialogResult dr4 = MessageBox.Show("删除成功!!");
                            if (dr4 == DialogResult.OK)
                            {
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox6.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                radioButton1.Checked = true;
                            }

                        }
                        else
                        {
                            DialogResult dr5 = MessageBox.Show("不存在该学生信息!!");
                            if (dr5 == DialogResult.OK)
                            {
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox6.Clear();
                                textBox4.Clear();
                                textBox5.Clear();
                                radioButton1.Checked = true;
                            }
                        }
                        conn.Close();
                    }
                }
                else
                {
                    DialogResult dr3 = MessageBox.Show("存在非法分隔符!!");
                    if (dr3 == DialogResult.OK)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox6.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        radioButton1.Checked = true;
                    }
                }
            }
            else
            {
                DialogResult dr2 = MessageBox.Show("检索学号必须为数字组成!!");
                if (dr2 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    radioButton1.Checked = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //修改
        {
            if (textBox6.Text.Equals(String.Empty))
            {
                DialogResult dr1 = MessageBox.Show("检索课程号不能为空!!");
                if (dr1 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    radioButton1.Checked = true;
                }
            }
            if (Regex.IsMatch(textBox6.Text, @"^\d+$"))
            {
                if (textBox6.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
                    conn.Open();
                    string sql = String.Format("select * from  Course  where Cno = N'{0}'", textBox6.Text);
                    SqlCommand comm = new SqlCommand(sql, conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = comm;
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Student");
                    dataGridView1.DataSource = ds.Tables[0];
                    string sql1 = String.Format("select count(*) from  Course  where Cno = N'{0}'", textBox6.Text);
                    SqlCommand comm1 = new SqlCommand(sql1, conn);
                    int n = (int)comm1.ExecuteScalar();
                    if (n >= 1)
                    {
                        button4.Enabled = true;
                        textBox1.Text = textBox6.Text;
                        textBox1.Enabled = false;
                    }
                    else
                    {
                        DialogResult dr5 = MessageBox.Show("不存在该课程信息!!");
                        if (dr5 == DialogResult.OK)
                        {
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox6.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            radioButton1.Checked = true;
                        }
                    }
                    conn.Close();
                }
                else
                {
                    DialogResult dr3 = MessageBox.Show("存在非法分隔符!!");
                    if (dr3 == DialogResult.OK)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox6.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        radioButton1.Checked = true;
                    }
                }
            }
            else
            {
                DialogResult dr2 = MessageBox.Show("检索课程号必须为数字组成!!");
                if (dr2 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    radioButton1.Checked = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) //确定修改
        {
            if (textBox2.Text.Equals(string.Empty) || textBox4.Text.Equals(string.Empty) || textBox5.Text.Equals(string.Empty))
            {
                DialogResult dr1 = MessageBox.Show("内容不能为空!!");
                if (dr1 == DialogResult.OK)
                {
                    textBox2.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    radioButton1.Checked = true;
                }
            }
            if (textBox2.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                    && textBox4.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                    && textBox5.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
            {
                string sex = null;
                if (radioButton1.Checked == true)
                    sex = radioButton1.Text;
                else
                    sex = radioButton2.Text;
                SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
                conn.Open();
                string sql = String.Format("update Course set Cno = N'{0}',Cname = N'{1}',Csele = N'{2}',Cpeople = N'{3}',Cnum = N'{4}' where Cno = N'{5}'", textBox1.Text, textBox2.Text, sex, textBox4.Text, textBox5.Text, textBox6.Text);
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    DialogResult dr = MessageBox.Show("修改信息成功!!");
                    if (dr == DialogResult.OK)
                    {
                        textBox1.Enabled = true;
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox6.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        button4.Enabled = false;
                        radioButton1.Checked = true;
                    }
                }
                else
                {
                    DialogResult dr1 = MessageBox.Show("录入信息失败!!");
                    if (dr1 == DialogResult.OK)
                    {
                        textBox2.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        radioButton1.Checked = true;
                    }
                }
                conn.Close();
            }
            else
            {
                DialogResult dr3 = MessageBox.Show("存在非法分隔符!!");
                if (dr3 == DialogResult.OK)
                {
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox4.Clear();
                    radioButton1.Checked = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) //查询
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
            conn.Open();
            string sql = String.Format("select * from  Course where Cno = N'{0}'", textBox6.Text);
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = comm;
            DataSet ds = new DataSet();
            sda.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
