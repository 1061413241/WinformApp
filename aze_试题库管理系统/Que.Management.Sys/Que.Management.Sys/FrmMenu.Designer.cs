namespace Que.Management.Sys
{
    partial class FrmMenu
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
            this.lblQueSearch = new System.Windows.Forms.Label();
            this.lblQueMan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQueSearch
            // 
            this.lblQueSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQueSearch.Image = global::Que.Management.Sys.Properties.Resources.Magnifier_放大镜;
            this.lblQueSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQueSearch.Location = new System.Drawing.Point(121, 36);
            this.lblQueSearch.Name = "lblQueSearch";
            this.lblQueSearch.Size = new System.Drawing.Size(60, 55);
            this.lblQueSearch.TabIndex = 1;
            this.lblQueSearch.Text = "试题查询";
            this.lblQueSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblQueSearch.Click += new System.EventHandler(this.lblQueSearch_Click);
            // 
            // lblQueMan
            // 
            this.lblQueMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQueMan.Image = global::Que.Management.Sys.Properties.Resources.试题库管理;
            this.lblQueMan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQueMan.Location = new System.Drawing.Point(34, 36);
            this.lblQueMan.Name = "lblQueMan";
            this.lblQueMan.Size = new System.Drawing.Size(60, 55);
            this.lblQueMan.TabIndex = 0;
            this.lblQueMan.Text = "试题管理";
            this.lblQueMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblQueMan.Click += new System.EventHandler(this.lblQueMan_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 575);
            this.Controls.Add(this.lblQueSearch);
            this.Controls.Add(this.lblQueMan);
            this.Name = "FrmMenu";
            this.Text = "菜单栏";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQueMan;
        private System.Windows.Forms.Label lblQueSearch;
    }
}