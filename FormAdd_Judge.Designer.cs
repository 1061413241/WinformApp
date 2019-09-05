namespace WindowsFormsApp1
{
    partial class FormAdd_Judge
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
            this.label1 = new System.Windows.Forms.Label();
            this.题目描述 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.cmb_Answ = new System.Windows.Forms.ComboBox();
            this.cmb_Level = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_Add = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "科目";
            // 
            // 题目描述
            // 
            this.题目描述.AutoSize = true;
            this.题目描述.Location = new System.Drawing.Point(42, 95);
            this.题目描述.Name = "题目描述";
            this.题目描述.Size = new System.Drawing.Size(53, 12);
            this.题目描述.TabIndex = 2;
            this.题目描述.Text = "题目描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "答案";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(101, 95);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(390, 182);
            this.tbInfo.TabIndex = 6;
            // 
            // cmb_Answ
            // 
            this.cmb_Answ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Answ.FormattingEnabled = true;
            this.cmb_Answ.Items.AddRange(new object[] {
            "错误",
            "正确"});
            this.cmb_Answ.Location = new System.Drawing.Point(101, 329);
            this.cmb_Answ.Name = "cmb_Answ";
            this.cmb_Answ.Size = new System.Drawing.Size(121, 20);
            this.cmb_Answ.TabIndex = 7;
            // 
            // cmb_Level
            // 
            this.cmb_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Level.Items.AddRange(new object[] {
            "简单",
            "中等",
            "困难"});
            this.cmb_Level.Location = new System.Drawing.Point(591, 87);
            this.cmb_Level.Name = "cmb_Level";
            this.cmb_Level.Size = new System.Drawing.Size(121, 20);
            this.cmb_Level.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "难度";
            // 
            // Bt_Add
            // 
            this.Bt_Add.Location = new System.Drawing.Point(579, 326);
            this.Bt_Add.Name = "Bt_Add";
            this.Bt_Add.Size = new System.Drawing.Size(119, 42);
            this.Bt_Add.TabIndex = 10;
            this.Bt_Add.Text = "添加";
            this.Bt_Add.UseVisualStyleBackColor = true;
            this.Bt_Add.Click += new System.EventHandler(this.Bt_Add_Click);
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Location = new System.Drawing.Point(101, 26);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(121, 20);
            this.cmb_Course.TabIndex = 11;
            // 
            // FormAdd_Judge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.Bt_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Level);
            this.Controls.Add(this.cmb_Answ);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.题目描述);
            this.Controls.Add(this.label1);
            this.Name = "FormAdd_Judge";
            this.Text = "FormAdd_Judge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 题目描述;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.ComboBox cmb_Answ;
        private System.Windows.Forms.ComboBox cmb_Level;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bt_Add;
        private System.Windows.Forms.ComboBox cmb_Course;
    }
}