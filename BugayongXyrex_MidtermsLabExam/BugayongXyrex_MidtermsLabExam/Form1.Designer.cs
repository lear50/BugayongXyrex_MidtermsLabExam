namespace BugayongXyrex_MidtermsLabExam
{
    partial class Student_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Page));
            StudentPageLabel = new Label();
            StudentIdLabel = new Label();
            StudentNameLabel = new Label();
            SuspendLayout();
            // 
            // StudentPageLabel
            // 
            StudentPageLabel.AutoSize = true;
            StudentPageLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentPageLabel.Location = new Point(347, 57);
            StudentPageLabel.Name = "StudentPageLabel";
            StudentPageLabel.Size = new Size(143, 30);
            StudentPageLabel.TabIndex = 0;
            StudentPageLabel.Text = "Student Page";
            // 
            // StudentIdLabel
            // 
            StudentIdLabel.AutoSize = true;
            StudentIdLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentIdLabel.Location = new Point(110, 129);
            StudentIdLabel.Name = "StudentIdLabel";
            StudentIdLabel.Size = new Size(81, 20);
            StudentIdLabel.TabIndex = 1;
            StudentIdLabel.Text = "Student ID";
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentNameLabel.Location = new Point(365, 129);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(107, 20);
            StudentNameLabel.TabIndex = 2;
            StudentNameLabel.Text = "Student Name";
            // 
            // Student_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentNameLabel);
            Controls.Add(StudentIdLabel);
            Controls.Add(StudentPageLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Page";
            Text = "Student Page";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentPageLabel;
        private Label StudentIdLabel;
        private Label StudentNameLabel;
    }
}
