namespace OccupationСhoice.View.Subject
{
    partial class WindowSubjectBD
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
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.b_AddSubjectForm = new System.Windows.Forms.Button();
            this.b_ChangeInfo = new System.Windows.Forms.Button();
            this.b_DelSubject = new System.Windows.Forms.Button();
            this.b_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(12, 51);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(468, 245);
            this.dataGV.TabIndex = 3;
            // 
            // b_AddSubjectForm
            // 
            this.b_AddSubjectForm.Location = new System.Drawing.Point(12, 7);
            this.b_AddSubjectForm.Name = "b_AddSubjectForm";
            this.b_AddSubjectForm.Size = new System.Drawing.Size(127, 34);
            this.b_AddSubjectForm.TabIndex = 2;
            this.b_AddSubjectForm.Text = "Добавить дисциплину";
            this.b_AddSubjectForm.UseVisualStyleBackColor = true;
            this.b_AddSubjectForm.Click += new System.EventHandler(this.b_AddSubjectForm_Click);
            // 
            // b_ChangeInfo
            // 
            this.b_ChangeInfo.Location = new System.Drawing.Point(145, 7);
            this.b_ChangeInfo.Name = "b_ChangeInfo";
            this.b_ChangeInfo.Size = new System.Drawing.Size(127, 34);
            this.b_ChangeInfo.TabIndex = 4;
            this.b_ChangeInfo.Text = "Редактировать";
            this.b_ChangeInfo.UseVisualStyleBackColor = true;
            this.b_ChangeInfo.Click += new System.EventHandler(this.b_ChangeInfo_Click);
            // 
            // b_DelSubject
            // 
            this.b_DelSubject.Location = new System.Drawing.Point(278, 7);
            this.b_DelSubject.Name = "b_DelSubject";
            this.b_DelSubject.Size = new System.Drawing.Size(127, 34);
            this.b_DelSubject.TabIndex = 5;
            this.b_DelSubject.Text = "Удалить дисциплину";
            this.b_DelSubject.UseVisualStyleBackColor = true;
            this.b_DelSubject.Click += new System.EventHandler(this.b_DelSubject_Click);
            // 
            // b_Print
            // 
            this.b_Print.Location = new System.Drawing.Point(411, 8);
            this.b_Print.Name = "b_Print";
            this.b_Print.Size = new System.Drawing.Size(69, 33);
            this.b_Print.TabIndex = 6;
            this.b_Print.Text = "Печать";
            this.b_Print.UseVisualStyleBackColor = true;
            this.b_Print.Click += new System.EventHandler(this.b_Print_Click);
            // 
            // WindowSubjectBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 308);
            this.Controls.Add(this.b_Print);
            this.Controls.Add(this.b_DelSubject);
            this.Controls.Add(this.b_ChangeInfo);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.b_AddSubjectForm);
            this.Name = "WindowSubjectBD";
            this.Text = "WindowSubjectBD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button b_AddSubjectForm;
        private System.Windows.Forms.Button b_ChangeInfo;
        private System.Windows.Forms.Button b_DelSubject;
        private System.Windows.Forms.Button b_Print;
    }
}