namespace OccupationСhoice.View.Vacancy
{
    partial class WindowVacancyBD
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
            this.b_AddVacancyForm = new System.Windows.Forms.Button();
            this.b_ChangeInfo = new System.Windows.Forms.Button();
            this.b_DelVacancy = new System.Windows.Forms.Button();
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
            this.dataGV.Location = new System.Drawing.Point(12, 53);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(452, 210);
            this.dataGV.TabIndex = 3;
            // 
            // b_AddVacancyForm
            // 
            this.b_AddVacancyForm.Location = new System.Drawing.Point(12, 9);
            this.b_AddVacancyForm.Name = "b_AddVacancyForm";
            this.b_AddVacancyForm.Size = new System.Drawing.Size(127, 34);
            this.b_AddVacancyForm.TabIndex = 2;
            this.b_AddVacancyForm.Text = "Добавить вакансию";
            this.b_AddVacancyForm.UseVisualStyleBackColor = true;
            this.b_AddVacancyForm.Click += new System.EventHandler(this.b_AddVacancyForm_Click);
            // 
            // b_ChangeInfo
            // 
            this.b_ChangeInfo.Location = new System.Drawing.Point(145, 9);
            this.b_ChangeInfo.Name = "b_ChangeInfo";
            this.b_ChangeInfo.Size = new System.Drawing.Size(127, 34);
            this.b_ChangeInfo.TabIndex = 4;
            this.b_ChangeInfo.Text = "Редактировать";
            this.b_ChangeInfo.UseVisualStyleBackColor = true;
            this.b_ChangeInfo.Click += new System.EventHandler(this.b_ChangeInfo_Click);
            // 
            // b_DelVacancy
            // 
            this.b_DelVacancy.Location = new System.Drawing.Point(278, 9);
            this.b_DelVacancy.Name = "b_DelVacancy";
            this.b_DelVacancy.Size = new System.Drawing.Size(127, 34);
            this.b_DelVacancy.TabIndex = 5;
            this.b_DelVacancy.Text = "Удалить вакансию";
            this.b_DelVacancy.UseVisualStyleBackColor = true;
            this.b_DelVacancy.Click += new System.EventHandler(this.b_DelVacancy_Click);
            // 
            // b_Print
            // 
            this.b_Print.Location = new System.Drawing.Point(411, 10);
            this.b_Print.Name = "b_Print";
            this.b_Print.Size = new System.Drawing.Size(53, 33);
            this.b_Print.TabIndex = 8;
            this.b_Print.Text = "Печать";
            this.b_Print.UseVisualStyleBackColor = true;
            this.b_Print.Click += new System.EventHandler(this.b_Print_Click);
            // 
            // WindowVacancyBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 275);
            this.Controls.Add(this.b_Print);
            this.Controls.Add(this.b_DelVacancy);
            this.Controls.Add(this.b_ChangeInfo);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.b_AddVacancyForm);
            this.Name = "WindowVacancyBD";
            this.Text = "WindowVacancyBD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button b_AddVacancyForm;
        private System.Windows.Forms.Button b_ChangeInfo;
        private System.Windows.Forms.Button b_DelVacancy;
        private System.Windows.Forms.Button b_Print;
    }
}