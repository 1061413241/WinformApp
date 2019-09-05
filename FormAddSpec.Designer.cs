namespace WindowsFormsApp1
{
    partial class FormAddSpecialty
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
            this.TBid = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Specialty_Name = new System.Windows.Forms.Label();
            this.Specialty_ID = new System.Windows.Forms.Label();
            this.TBname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBid
            // 
            this.TBid.Location = new System.Drawing.Point(67, 30);
            this.TBid.Name = "TBid";
            this.TBid.Size = new System.Drawing.Size(184, 25);
            this.TBid.TabIndex = 0;
            this.TBid.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Specialty_Name
            // 
            this.Specialty_Name.AutoSize = true;
            this.Specialty_Name.Location = new System.Drawing.Point(24, 95);
            this.Specialty_Name.Name = "Specialty_Name";
            this.Specialty_Name.Size = new System.Drawing.Size(37, 15);
            this.Specialty_Name.TabIndex = 2;
            this.Specialty_Name.Text = "名称";
            // 
            // Specialty_ID
            // 
            this.Specialty_ID.AutoSize = true;
            this.Specialty_ID.Location = new System.Drawing.Point(24, 40);
            this.Specialty_ID.Name = "Specialty_ID";
            this.Specialty_ID.Size = new System.Drawing.Size(37, 15);
            this.Specialty_ID.TabIndex = 3;
            this.Specialty_ID.Text = "编号";
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(67, 85);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(184, 25);
            this.TBname.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormAddSpecialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.Specialty_ID);
            this.Controls.Add(this.Specialty_Name);
            this.Controls.Add(this.TBid);
            this.Name = "FormAddSpecialty";
            this.Text = "新增专业";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Specialty_Name;
        private System.Windows.Forms.Label Specialty_ID;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Button button1;
    }
}