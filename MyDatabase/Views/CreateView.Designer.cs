namespace MyDatabase.Views
{
    partial class CreateView
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
            label1 = new Label();
            buttonCreateStudent = new Button();
            buttonCreateFaculty = new Button();
            buttonCreateAdmin = new Button();
            buttonCreateProgram = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F);
            label1.Location = new Point(132, 96);
            label1.Name = "label1";
            label1.Size = new Size(513, 86);
            label1.TabIndex = 0;
            label1.Text = "Choose an Entity";
            // 
            // buttonCreateStudent
            // 
            buttonCreateStudent.Font = new Font("Segoe UI", 18F);
            buttonCreateStudent.Location = new Point(215, 229);
            buttonCreateStudent.Name = "buttonCreateStudent";
            buttonCreateStudent.Size = new Size(118, 45);
            buttonCreateStudent.TabIndex = 2;
            buttonCreateStudent.Text = "Student";
            buttonCreateStudent.UseVisualStyleBackColor = true;
            // 
            // buttonCreateFaculty
            // 
            buttonCreateFaculty.Font = new Font("Segoe UI", 18F);
            buttonCreateFaculty.Location = new Point(441, 229);
            buttonCreateFaculty.Name = "buttonCreateFaculty";
            buttonCreateFaculty.Size = new Size(118, 45);
            buttonCreateFaculty.TabIndex = 3;
            buttonCreateFaculty.Text = "Faculty";
            buttonCreateFaculty.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAdmin
            // 
            buttonCreateAdmin.Font = new Font("Segoe UI", 18F);
            buttonCreateAdmin.Location = new Point(215, 306);
            buttonCreateAdmin.Name = "buttonCreateAdmin";
            buttonCreateAdmin.Size = new Size(118, 45);
            buttonCreateAdmin.TabIndex = 4;
            buttonCreateAdmin.Text = "Admin";
            buttonCreateAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonCreateProgram
            // 
            buttonCreateProgram.Font = new Font("Segoe UI", 18F);
            buttonCreateProgram.Location = new Point(441, 306);
            buttonCreateProgram.Name = "buttonCreateProgram";
            buttonCreateProgram.Size = new Size(118, 45);
            buttonCreateProgram.TabIndex = 5;
            buttonCreateProgram.Text = "Program";
            buttonCreateProgram.UseVisualStyleBackColor = true;
            // 
            // CreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreateProgram);
            Controls.Add(buttonCreateAdmin);
            Controls.Add(buttonCreateFaculty);
            Controls.Add(buttonCreateStudent);
            Controls.Add(label1);
            Name = "CreateView";
            Text = "CreateView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCreateStudent;
        private Button buttonCreateFaculty;
        private Button buttonCreateAdmin;
        private Button buttonCreateProgram;
    }
}