namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加专业ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.新增题目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增选择题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增判断题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增应用题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加专业ToolStripMenuItem,
            this.AddCourse,
            this.新增题目ToolStripMenuItem});
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 添加专业ToolStripMenuItem
            // 
            this.添加专业ToolStripMenuItem.Name = "添加专业ToolStripMenuItem";
            this.添加专业ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.添加专业ToolStripMenuItem.Text = "新增专业";
            this.添加专业ToolStripMenuItem.Click += new System.EventHandler(this.添加专业ToolStripMenuItem_Click);
            // 
            // AddCourse
            // 
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(224, 26);
            this.AddCourse.Text = "新增科目";
            this.AddCourse.Click += new System.EventHandler(this.添加ToolStripMenuItem1_Click);
            // 
            // 新增题目ToolStripMenuItem
            // 
            this.新增题目ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增选择题ToolStripMenuItem,
            this.新增判断题ToolStripMenuItem,
            this.新增应用题ToolStripMenuItem});
            this.新增题目ToolStripMenuItem.Name = "新增题目ToolStripMenuItem";
            this.新增题目ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新增题目ToolStripMenuItem.Text = "新增题目";
            this.新增题目ToolStripMenuItem.Click += new System.EventHandler(this.新增题目ToolStripMenuItem_Click);
            // 
            // 新增选择题ToolStripMenuItem
            // 
            this.新增选择题ToolStripMenuItem.Name = "新增选择题ToolStripMenuItem";
            this.新增选择题ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新增选择题ToolStripMenuItem.Text = "新增选择题";
            this.新增选择题ToolStripMenuItem.Click += new System.EventHandler(this.新增选择题ToolStripMenuItem_Click);
            // 
            // 新增判断题ToolStripMenuItem
            // 
            this.新增判断题ToolStripMenuItem.Name = "新增判断题ToolStripMenuItem";
            this.新增判断题ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新增判断题ToolStripMenuItem.Text = "新增判断题";
            // 
            // 新增应用题ToolStripMenuItem
            // 
            this.新增应用题ToolStripMenuItem.Name = "新增应用题ToolStripMenuItem";
            this.新增应用题ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新增应用题ToolStripMenuItem.Text = "新增应用题";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加专业ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCourse;
        private System.Windows.Forms.ToolStripMenuItem 新增题目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增选择题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增判断题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增应用题ToolStripMenuItem;
    }
}

