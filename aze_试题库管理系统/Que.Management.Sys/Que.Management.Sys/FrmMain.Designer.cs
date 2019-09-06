namespace Que.Management.Sys
{
    partial class FrmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemQue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWin = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripMenuItemQueMan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQueSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPaper = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPaperMan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPaperSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQue,
            this.ToolStripMenuItemPaper,
            this.toolStripMenuItemWin});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.toolStripMenuItemWin;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(829, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemQue
            // 
            this.toolStripMenuItemQue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQueMan,
            this.toolStripMenuItemQueSearch});
            this.toolStripMenuItemQue.Name = "toolStripMenuItemQue";
            this.toolStripMenuItemQue.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItemQue.Text = "试题信息";
            // 
            // toolStripMenuItemWin
            // 
            this.toolStripMenuItemWin.Name = "toolStripMenuItemWin";
            this.toolStripMenuItemWin.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItemWin.Text = "窗口列表";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUser});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(829, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabelUser.Text = "用户信息";
            // 
            // dockPanel1
            // 
            this.dockPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 25);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.ShowDocumentIcon = true;
            this.dockPanel1.Size = new System.Drawing.Size(829, 492);
            this.dockPanel1.TabIndex = 4;
            // 
            // toolStripMenuItemQueMan
            // 
            this.toolStripMenuItemQueMan.Image = global::Que.Management.Sys.Properties.Resources.试题库管理;
            this.toolStripMenuItemQueMan.Name = "toolStripMenuItemQueMan";
            this.toolStripMenuItemQueMan.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemQueMan.Text = "试题管理";
            this.toolStripMenuItemQueMan.Click += new System.EventHandler(this.toolStripMenuItemQueMan_Click);
            // 
            // toolStripMenuItemQueSearch
            // 
            this.toolStripMenuItemQueSearch.Image = global::Que.Management.Sys.Properties.Resources.Magnifier_放大镜;
            this.toolStripMenuItemQueSearch.Name = "toolStripMenuItemQueSearch";
            this.toolStripMenuItemQueSearch.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemQueSearch.Text = "试题查询";
            this.toolStripMenuItemQueSearch.Click += new System.EventHandler(this.toolStripMenuItemQueSearch_Click);
            // 
            // ToolStripMenuItemPaper
            // 
            this.ToolStripMenuItemPaper.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPaperMan,
            this.toolStripMenuItemPaperSearch});
            this.ToolStripMenuItemPaper.Name = "ToolStripMenuItemPaper";
            this.ToolStripMenuItemPaper.Size = new System.Drawing.Size(68, 21);
            this.ToolStripMenuItemPaper.Text = "试卷信息";
            // 
            // toolStripMenuItemPaperMan
            // 
            this.toolStripMenuItemPaperMan.Name = "toolStripMenuItemPaperMan";
            this.toolStripMenuItemPaperMan.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemPaperMan.Text = "试卷管理";
            // 
            // toolStripMenuItemPaperSearch
            // 
            this.toolStripMenuItemPaperSearch.Name = "toolStripMenuItemPaperSearch";
            this.toolStripMenuItemPaperSearch.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemPaperSearch.Text = "试卷查询";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 539);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQue;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQueMan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQueSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWin;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPaper;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaperMan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaperSearch;
    }
}