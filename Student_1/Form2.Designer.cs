namespace Student_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理SToolStripMenuItem,
            this.学生管理MToolStripMenuItem,
            this.课程管理CToolStripMenuItem,
            this.成绩管理AToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理SToolStripMenuItem
            // 
            this.系统管理SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统管理SToolStripMenuItem.Name = "系统管理SToolStripMenuItem";
            this.系统管理SToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.系统管理SToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.登录ToolStripMenuItem.Text = "登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 学生管理MToolStripMenuItem
            // 
            this.学生管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生信息ToolStripMenuItem,
            this.查询学生信息ToolStripMenuItem,
            this.删除学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem});
            this.学生管理MToolStripMenuItem.Name = "学生管理MToolStripMenuItem";
            this.学生管理MToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.学生管理MToolStripMenuItem.Text = "学生管理(&M)";
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.添加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.添加学生信息ToolStripMenuItem_Click);
            // 
            // 查询学生信息ToolStripMenuItem
            // 
            this.查询学生信息ToolStripMenuItem.Name = "查询学生信息ToolStripMenuItem";
            this.查询学生信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询学生信息ToolStripMenuItem.Text = "查询学生信息";
            this.查询学生信息ToolStripMenuItem.Click += new System.EventHandler(this.查询学生信息ToolStripMenuItem_Click);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.删除学生信息ToolStripMenuItem_Click);
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.修改学生信息ToolStripMenuItem.Text = "修改学生信息";
            this.修改学生信息ToolStripMenuItem.Click += new System.EventHandler(this.修改学生信息ToolStripMenuItem_Click);
            // 
            // 课程管理CToolStripMenuItem
            // 
            this.课程管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加课程ToolStripMenuItem,
            this.查询课程ToolStripMenuItem,
            this.修改课程ToolStripMenuItem,
            this.删除课程ToolStripMenuItem});
            this.课程管理CToolStripMenuItem.Name = "课程管理CToolStripMenuItem";
            this.课程管理CToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.课程管理CToolStripMenuItem.Text = "课程管理(&C)";
            // 
            // 添加课程ToolStripMenuItem
            // 
            this.添加课程ToolStripMenuItem.Name = "添加课程ToolStripMenuItem";
            this.添加课程ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加课程ToolStripMenuItem.Text = "添加课程";
            this.添加课程ToolStripMenuItem.Click += new System.EventHandler(this.添加课程ToolStripMenuItem_Click);
            // 
            // 查询课程ToolStripMenuItem
            // 
            this.查询课程ToolStripMenuItem.Name = "查询课程ToolStripMenuItem";
            this.查询课程ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询课程ToolStripMenuItem.Text = "查询课程";
            this.查询课程ToolStripMenuItem.Click += new System.EventHandler(this.查询课程ToolStripMenuItem_Click);
            // 
            // 修改课程ToolStripMenuItem
            // 
            this.修改课程ToolStripMenuItem.Name = "修改课程ToolStripMenuItem";
            this.修改课程ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.修改课程ToolStripMenuItem.Text = "修改课程";
            this.修改课程ToolStripMenuItem.Click += new System.EventHandler(this.修改课程ToolStripMenuItem_Click);
            // 
            // 删除课程ToolStripMenuItem
            // 
            this.删除课程ToolStripMenuItem.Name = "删除课程ToolStripMenuItem";
            this.删除课程ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.删除课程ToolStripMenuItem.Text = "删除课程";
            this.删除课程ToolStripMenuItem.Click += new System.EventHandler(this.删除课程ToolStripMenuItem_Click);
            // 
            // 成绩管理AToolStripMenuItem
            // 
            this.成绩管理AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩录入ToolStripMenuItem});
            this.成绩管理AToolStripMenuItem.Name = "成绩管理AToolStripMenuItem";
            this.成绩管理AToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.成绩管理AToolStripMenuItem.Text = "成绩管理(A)";
            // 
            // 成绩录入ToolStripMenuItem
            // 
            this.成绩录入ToolStripMenuItem.Name = "成绩录入ToolStripMenuItem";
            this.成绩录入ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.成绩录入ToolStripMenuItem.Text = "成绩录入";
            this.成绩录入ToolStripMenuItem.Click += new System.EventHandler(this.成绩录入ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(739, 50);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 47);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "课程查询";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 47);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "学生查询";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 47);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "成绩查询";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 47);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "学生信息修改";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 47);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.ToolTipText = "学生信息删除";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 47);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.ToolTipText = "课程删除";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 345);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "学生信息管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}