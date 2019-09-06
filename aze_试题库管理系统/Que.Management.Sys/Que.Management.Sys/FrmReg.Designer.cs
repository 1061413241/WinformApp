namespace Que.Management.Sys
{
    partial class FrmReg
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
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblMac_addr = new System.Windows.Forms.Label();
            this.lblIp_addr = new System.Windows.Forms.Label();
            this.txtMac_addr = new System.Windows.Forms.TextBox();
            this.txtIp_addr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(49, 66);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(41, 12);
            this.lblPwd.TabIndex = 12;
            this.lblPwd.Text = "密  码";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(49, 33);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 12);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "用户名";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(98, 63);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(122, 21);
            this.txtPwd.TabIndex = 10;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(98, 30);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(122, 21);
            this.txtUser.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 180);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 18);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(94, 180);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(56, 18);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "注 册";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblMac_addr
            // 
            this.lblMac_addr.AutoSize = true;
            this.lblMac_addr.Location = new System.Drawing.Point(49, 138);
            this.lblMac_addr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMac_addr.Name = "lblMac_addr";
            this.lblMac_addr.Size = new System.Drawing.Size(47, 12);
            this.lblMac_addr.TabIndex = 16;
            this.lblMac_addr.Text = "限制MAC";
            // 
            // lblIp_addr
            // 
            this.lblIp_addr.AutoSize = true;
            this.lblIp_addr.Location = new System.Drawing.Point(49, 103);
            this.lblIp_addr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIp_addr.Name = "lblIp_addr";
            this.lblIp_addr.Size = new System.Drawing.Size(41, 12);
            this.lblIp_addr.TabIndex = 15;
            this.lblIp_addr.Text = "限制IP";
            // 
            // txtMac_addr
            // 
            this.txtMac_addr.Location = new System.Drawing.Point(98, 135);
            this.txtMac_addr.Margin = new System.Windows.Forms.Padding(2);
            this.txtMac_addr.Name = "txtMac_addr";
            this.txtMac_addr.Size = new System.Drawing.Size(122, 21);
            this.txtMac_addr.TabIndex = 14;
            // 
            // txtIp_addr
            // 
            this.txtIp_addr.Location = new System.Drawing.Point(98, 100);
            this.txtIp_addr.Margin = new System.Windows.Forms.Padding(2);
            this.txtIp_addr.Name = "txtIp_addr";
            this.txtIp_addr.Size = new System.Drawing.Size(122, 21);
            this.txtIp_addr.TabIndex = 13;
            // 
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblMac_addr);
            this.Controls.Add(this.lblIp_addr);
            this.Controls.Add(this.txtMac_addr);
            this.Controls.Add(this.txtIp_addr);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmReg";
            this.Text = "FrmReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblMac_addr;
        private System.Windows.Forms.Label lblIp_addr;
        private System.Windows.Forms.TextBox txtMac_addr;
        private System.Windows.Forms.TextBox txtIp_addr;
    }
}