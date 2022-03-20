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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e) //删除
        {
            if (textBox5.Text.Equals(String.Empty) && textBox6.Text.Equals(String.Empty) && textBox7.Text.Equals(String.Empty))
            {
                DialogResult dr1 = MessageBox.Show("检索值不能为空!!");
                if (dr1 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox3.Clear();
                    textBox7.Clear();
                }
            }
            if (Regex.IsMatch(textBox6.Text, @"^\d+$") && Regex.IsMatch(textBox5.Text, @"^\d+$") && Regex.IsMatch(textBox7.Text, @"^\d+$"))
            {
                if (textBox6.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                    && textBox5.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                    && textBox7.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
                {
                    DialogResult dr6 = MessageBox.Show("是否要删除？", "警告", MessageBoxButtons.OKCancel);
                    if (dr6 == DialogResult.OK)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
                        conn.Open();
                        string sql = String.Format("delete from Chengji where Cno = N'{0}' and Scalss = N'{1}' and Sno = N'{2}'", textBox7.Text,textBox6.Text,textBox5.Text);
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
                                textBox3.Clear();
                                textBox7.Clear();
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
                                textBox3.Clear();
                                textBox7.Clear();
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
                        textBox3.Clear();
                        textBox7.Clear();
                    }
                }
            }
            else
            {
                DialogResult dr2 = MessageBox.Show("检索值必须为数字组成!!");
                if (dr2 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox3.Clear();
                    textBox7.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //录入
        {
            if (textBox1.Text.Equals(string.Empty) || textBox2.Text.Equals(string.Empty) || textBox3.Text.Equals(string.Empty) || textBox4.Text.Equals(string.Empty))
            {
                DialogResult dr1 = MessageBox.Show("内容不能为空!!");
                if (dr1 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            if (Regex.IsMatch(textBox1.Text, @"^\d+$") && Regex.IsMatch(textBox2.Text, @"^\d+$") && Regex.IsMatch(textBox3.Text, @"^\d+$") && Regex.IsMatch(textBox4.Text, @"^\d+$"))
            {
                if (textBox1.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                        && textBox2.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                        && textBox3.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                        && textBox4.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
                {                    
                    SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
                    conn.Open();
                    string sql = String.Format("insert into Chengji(Scalss,Sno,Cno,Sorce) values(N'{0}',N'{1}',N'{2}',N'{3}')", textBox1.Text, textBox2.Text,textBox3.Text, textBox4.Text);
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = comm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DialogResult dr = MessageBox.Show("录入成绩成功!!");
                        if (dr == DialogResult.OK)
                        {
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                        }
                    }
                    else
                    {
                        DialogResult dr1 = MessageBox.Show("录入成绩失败!!");
                        if (dr1 == DialogResult.OK)
                        {
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
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
                        textBox3.Clear();
                        textBox4.Clear();
                    }
                }
            }
            else
            {
                DialogResult dr2 = MessageBox.Show("数据必须是数字组成!!");
                if (dr2 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //修改
        {
            if (textBox6.Text.Equals(String.Empty) && textBox5.Text.Equals(String.Empty) && textBox7.Text.Equals(String.Empty))
            {
                DialogResult dr1 = MessageBox.Show("检索值不能为空!!");
                if (dr1 == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox3.Clear();
                    textBox7.Clear();
                }
            }
            if (Regex.IsMatch(textBox6.Text, @"^\d+$") && Regex.IsMatch(textBox5.Text, @"^\d+$") && Regex.IsMatch(textBox7.Text, @"^\d+$"))
            {
                if (textBox6.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                    && textBox5.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1
                    && textBox7.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
                    conn.Open();
                    string sql = String.Format("select * from  Chengji  where Sno = N'{0}' and Scalss = N'{1}' and Cno = N'{2}'", textBox5.Text,textBox6.Text,textBox7.Text);
                    SqlCommand comm = new SqlCommand(sql, conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = comm;
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Chengji");
                    dataGridView1.DataSource = ds.Tables[0];
                    string sql1 = String.Format("select count(*) from  Chengji  where Sno = N'{0}' and Scalss = N'{1}' and Cno = N'{2}'", textBox5.Text, textBox6.Text, textBox7.Text);
                    SqlCommand comm1 = new SqlCommand(sql1, conn);
                    int n = (int)comm1.ExecuteScalar();
                    if (n >= 1)
                    {
                        button4.Enabled = true;
                        textBox2.Text = textBox5.Text;
                        textBox2.Enabled = false;
                        textBox1.Text = textBox6.Text;
                        textBox1.Enabled = false;
                        textBox3.Text = textBox7.Text;
                        textBox3.Enabled = false;
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
                            textBox3.Clear();
                            textBox7.Clear();
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
                        textBox3.Clear();
                        textBox7.Clear();
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
                    textBox3.Clear();
                    textBox7.Clear();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) //确认修改
        {
            if (textBox4.Text.Equals(string.Empty))
            {
                DialogResult dr1 = MessageBox.Show("内容不能为空!!");
                if (dr1 == DialogResult.OK)
                {
                    textBox4.Clear();
                }
            }
            if (textBox4.Text.Split(new char[] { ' ', ',', '，', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '\\', '|', '\'', '<', '>', '/', '{', '}', '！', '@', '#', '￥', '%', '…', '&', '*', '（', '）', '—', '+', '{', '}', '：', '“', '”', '《', '》', '？', '/' }, StringSplitOptions.RemoveEmptyEntries).Length == 1)
            {               
                SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
                conn.Open();
                string sql = String.Format("update Chengji set Sorce = N'{0}' where Cno = N'{1}' and Scalss = N'{2}' and Sno = N'{3}'", textBox4.Text, textBox3.Text, textBox1.Text, textBox2.Text);
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    DialogResult dr = MessageBox.Show("修改信息成功!!");
                    if (dr == DialogResult.OK)
                    {
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox6.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox3.Clear();
                        textBox7.Clear();
                        button4.Enabled = false;
                    }
                }
                else
                {
                    DialogResult dr1 = MessageBox.Show("修改信息失败!!");
                    if (dr1 == DialogResult.OK)
                    {
                        textBox4.Clear();
                    }
                }
                conn.Close();
            }
            else
            {
                DialogResult dr3 = MessageBox.Show("存在非法分隔符!!");
                if (dr3 == DialogResult.OK)
                {
                    textBox4.Clear();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) //查询
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
            conn.Open();
            string sql = String.Format("select * from  Chengji where Cno = N'{0}' and Scalss = N'{1}' and Sno = N'{2}'",textBox7.Text, textBox6.Text, textBox5.Text);
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = comm;
            DataSet ds = new DataSet();
            sda.Fill(ds, "Chengji");
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e) //浏览
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = School;user id = sa;pwd=123456");
            conn.Open();
            string sql = String.Format("select Sno,sum(Sorce)  from  Chengji where Scalss = N'{0}' group by Sno",textBox6.Text);
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = comm;
            DataSet ds = new DataSet();
            sda.Fill(ds, "Chengji");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "学号"; 
            dataGridView1.Columns[1].HeaderText = "总成绩";
            conn.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
