namespace OccupationСhoice.View.Student
{
    partial class WindowStudentDB
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
            this.b_AddStudentForm = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.b_ChangeInfo = new System.Windows.Forms.Button();
            this.b_DelStudent = new System.Windows.Forms.Button();
            this.b_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // b_AddStudentForm
            // 
            this.b_AddStudentForm.Location = new System.Drawing.Point(12, 12);
            this.b_AddStudentForm.Name = "b_AddStudentForm";
            this.b_AddStudentForm.Size = new System.Drawing.Size(127, 34);
            this.b_AddStudentForm.TabIndex = 0;
            this.b_AddStudentForm.Text = "Добавить студента";
            this.b_AddStudentForm.UseVisualStyleBackColor = true;
            this.b_AddStudentForm.Click += new System.EventHandler(this.b_AddStudentForm_Click);
            // 
            // dataGV
            // 
            this.dataGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(12, 56);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.Size = new System.Drawing.Size(457, 217);
            this.dataGV.TabIndex = 1;
            // 
            // b_ChangeInfo
            // 
            this.b_ChangeInfo.Location = new System.Drawing.Point(145, 12);
            this.b_ChangeInfo.Name = "b_ChangeInfo";
            this.b_ChangeInfo.Size = new System.Drawing.Size(127, 34);
            this.b_ChangeInfo.TabIndex = 2;
            this.b_ChangeInfo.Text = "Редактировать";
            this.b_ChangeInfo.UseVisualStyleBackColor = true;
            this.b_ChangeInfo.Click += new System.EventHandler(this.b_ChangeInfo_Click);
            // 
            // b_DelStudent
            // 
            this.b_DelStudent.Location = new System.Drawing.Point(278, 12);
            this.b_DelStudent.Name = "b_DelStudent";
            this.b_DelStudent.Size = new System.Drawing.Size(127, 34);
            this.b_DelStudent.TabIndex = 3;
            this.b_DelStudent.Text = "Удалить студента";
            this.b_DelStudent.UseVisualStyleBackColor = true;
            this.b_DelStudent.Click += new System.EventHandler(this.b_DelStudent_Click);
            // 
            // b_Print
            // 
            this.b_Print.Location = new System.Drawing.Point(412, 12);
            this.b_Print.Name = "b_Print";
            this.b_Print.Size = new System.Drawing.Size(57, 33);
            this.b_Print.TabIndex = 4;
            this.b_Print.Text = "Печать";
            this.b_Print.UseVisualStyleBackColor = true;
            this.b_Print.Click += new System.EventHandler(this.b_Print_Click);
            // 
            // WindowStudentDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 285);
            this.Controls.Add(this.b_Print);
            this.Controls.Add(this.b_DelStudent);
            this.Controls.Add(this.b_ChangeInfo);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.b_AddStudentForm);
            this.Name = "WindowStudentDB";
            this.Text = "WindowStudentDB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_AddStudentForm;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button b_ChangeInfo;
        private System.Windows.Forms.Button b_DelStudent;
        private System.Windows.Forms.Button b_Print;
    }
}