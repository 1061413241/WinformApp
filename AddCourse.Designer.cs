namespace WindowsFormsApp1
{
    partial class AddCourse
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
            this.tbCourseId = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbCourSpec = new System.Windows.Forms.TextBox();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.Course_Id = new System.Windows.Forms.Label();
            this.belongSpec = new System.Windows.Forms.Label();
            this.Course_Name = new System.Windows.Forms.Label();
            this.addCour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCourseId
            // 
            this.tbCourseId.Location = new System.Drawing.Point(94, 50);
            this.tbCourseId.Name = "tbCourseId";
            this.tbCourseId.Size = new System.Drawing.Size(131, 25);
            this.tbCourseId.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbCourSpec
            // 
            this.tbCourSpec.Location = new System.Drawing.Point(94, 188);
            this.tbCourSpec.Name = "tbCourSpec";
            this.tbCourSpec.Size = new System.Drawing.Size(131, 25);
            this.tbCourSpec.TabIndex = 2;
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(94, 118);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(131, 25);
            this.tbCourseName.TabIndex = 3;
            // 
            // Course_Id
            // 
            this.Course_Id.AutoSize = true;
            this.Course_Id.Location = new System.Drawing.Point(12, 60);
            this.Course_Id.Name = "Course_Id";
            this.Course_Id.Size = new System.Drawing.Size(67, 15);
            this.Course_Id.TabIndex = 4;
            this.Course_Id.Text = "课程编号";
            // 
            // belongSpec
            // 
            this.belongSpec.AutoSize = true;
            this.belongSpec.Location = new System.Drawing.Point(12, 198);
            this.belongSpec.Name = "belongSpec";
            this.belongSpec.Size = new System.Drawing.Size(67, 15);
            this.belongSpec.TabIndex = 5;
            this.belongSpec.Text = "所属专业";
            // 
            // Course_Name
            // 
            this.Course_Name.AutoSize = true;
            this.Course_Name.Location = new System.Drawing.Point(12, 128);
            this.Course_Name.Name = "Course_Name";
            this.Course_Name.Size = new System.Drawing.Size(67, 15);
            this.Course_Name.TabIndex = 6;
            this.Course_Name.Text = "课程名称";
            // 
            // addCour
            // 
            this.addCour.Location = new System.Drawing.Point(42, 304);
            this.addCour.Name = "addCour";
            this.addCour.Size = new System.Drawing.Size(112, 43);
            this.addCour.TabIndex = 7;
            this.addCour.Text = "添加";
            this.addCour.UseVisualStyleBackColor = true;
            this.addCour.Click += new System.EventHandler(this.AddCour_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCour);
            this.Controls.Add(this.Course_Name);
            this.Controls.Add(this.belongSpec);
            this.Controls.Add(this.Course_Id);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.tbCourSpec);
            this.Controls.Add(this.tbCourseId);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCourseId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbCourSpec;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label Course_Id;
        private System.Windows.Forms.Label belongSpec;
        private System.Windows.Forms.Label Course_Name;
        private System.Windows.Forms.Button addCour;
    }
}