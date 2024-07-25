namespace Classes
{
    partial class Form1
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
            lbxStudent = new ListBox();
            dgrwStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgrwStudents).BeginInit();
            SuspendLayout();
            // 
            // lbxStudent
            // 
            lbxStudent.FormattingEnabled = true;
            lbxStudent.Location = new Point(90, 130);
            lbxStudent.Name = "lbxStudent";
            lbxStudent.Size = new Size(274, 529);
            lbxStudent.TabIndex = 0;
            lbxStudent.SelectedIndexChanged += lbxStudent_SelectedIndexChanged;
            // 
            // dgrwStudents
            // 
            dgrwStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwStudents.Location = new Point(460, 130);
            dgrwStudents.Name = "dgrwStudents";
            dgrwStudents.RowHeadersWidth = 62;
            dgrwStudents.Size = new Size(723, 368);
            dgrwStudents.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 824);
            Controls.Add(dgrwStudents);
            Controls.Add(lbxStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbxStudent;
        private DataGridView dgrwStudents;
    }
}
