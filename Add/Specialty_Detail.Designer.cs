namespace WindowsFormsApp1
{
    partial class Specialty_Detail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Specialty_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Specialty_Id,
            this.Specialty_Name});
            this.dataGridView1.Location = new System.Drawing.Point(2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(798, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Specialty_Id
            // 
            this.Specialty_Id.DataPropertyName = "Specialty_Id";
            this.Specialty_Id.HeaderText = "专业编号";
            this.Specialty_Id.MinimumWidth = 6;
            this.Specialty_Id.Name = "Specialty_Id";
            this.Specialty_Id.ReadOnly = true;
            this.Specialty_Id.Width = 125;
            // 
            // Specialty_Name
            // 
            this.Specialty_Name.DataPropertyName = "Specialty_Name";
            this.Specialty_Name.HeaderText = "专业名称";
            this.Specialty_Name.MinimumWidth = 6;
            this.Specialty_Name.Name = "Specialty_Name";
            this.Specialty_Name.ReadOnly = true;
            this.Specialty_Name.Width = 125;
            // 
            // Specialty_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Specialty_Detail";
            this.Text = "Specialty_Detail";
            this.Load += new System.EventHandler(this.Specialty_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty_Name;
    }
}