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
            Divider1 = new PictureBox();
            Divider2 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Divider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Divider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // Divider1
            // 
            Divider1.BackColor = Color.Transparent;
            Divider1.BackgroundImage = (Image)resources.GetObject("Divider1.BackgroundImage");
            Divider1.BackgroundImageLayout = ImageLayout.Stretch;
            Divider1.Location = new Point(219, 201);
            Divider1.Name = "Divider1";
            Divider1.Size = new Size(100, 147);
            Divider1.TabIndex = 3;
            Divider1.TabStop = false;
            // 
            // Divider2
            // 
            Divider2.BackColor = Color.Transparent;
            Divider2.BackgroundImage = (Image)resources.GetObject("Divider2.BackgroundImage");
            Divider2.BackgroundImageLayout = ImageLayout.Stretch;
            Divider2.Location = new Point(545, 201);
            Divider2.Name = "Divider2";
            Divider2.Size = new Size(100, 147);
            Divider2.TabIndex = 4;
            Divider2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.Location = new Point(-45, 414);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(938, 158);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(-68, -132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(938, 158);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Student_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(Divider2);
            Controls.Add(Divider1);
            Controls.Add(StudentNameLabel);
            Controls.Add(StudentIdLabel);
            Controls.Add(StudentPageLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Page";
            Text = "Student Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Divider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Divider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentPageLabel;
        private Label StudentIdLabel;
        private Label StudentNameLabel;
        private PictureBox Divider1;
        private PictureBox Divider2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
