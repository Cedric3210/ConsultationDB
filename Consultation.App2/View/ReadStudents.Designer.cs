namespace Consultation.App2.View
{
    partial class ReadStudents
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
            dataGridViewStudents = new DataGridView();
            textboxStudentID = new TextBox();
            buttonShowStudentData = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(343, 52);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(416, 344);
            dataGridViewStudents.TabIndex = 0;
            // 
            // textboxStudentID
            // 
            textboxStudentID.Location = new Point(34, 64);
            textboxStudentID.Name = "textboxStudentID";
            textboxStudentID.Size = new Size(236, 27);
            textboxStudentID.TabIndex = 1;
            textboxStudentID.TextChanged += textboxStudentID_TextChanged;
            // 
            // buttonShowStudentData
            // 
            buttonShowStudentData.Location = new Point(34, 234);
            buttonShowStudentData.Name = "buttonShowStudentData";
            buttonShowStudentData.Size = new Size(218, 36);
            buttonShowStudentData.TabIndex = 2;
            buttonShowStudentData.Text = "Show Student Data";
            buttonShowStudentData.UseVisualStyleBackColor = true;
            buttonShowStudentData.Click += buttonShowStudentData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 31);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // ReadStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonShowStudentData);
            Controls.Add(textboxStudentID);
            Controls.Add(dataGridViewStudents);
            Name = "ReadStudents";
            Text = "ReadStudents";
            Load += ReadStudents_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private TextBox textboxStudentID;
        private Button buttonShowStudentData;
        private Label label1;
    }
}