namespace OccupationСhoice.View.Skill
{
    partial class WindowSkillDB
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
            this.b_AddSkillForm = new System.Windows.Forms.Button();
            this.b_ChangeInfo = new System.Windows.Forms.Button();
            this.b_DelSkill = new System.Windows.Forms.Button();
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
            this.dataGV.Location = new System.Drawing.Point(12, 52);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(468, 241);
            this.dataGV.TabIndex = 3;
            // 
            // b_AddSkillForm
            // 
            this.b_AddSkillForm.Location = new System.Drawing.Point(12, 8);
            this.b_AddSkillForm.Name = "b_AddSkillForm";
            this.b_AddSkillForm.Size = new System.Drawing.Size(127, 34);
            this.b_AddSkillForm.TabIndex = 2;
            this.b_AddSkillForm.Text = "Добавить навык";
            this.b_AddSkillForm.UseVisualStyleBackColor = true;
            this.b_AddSkillForm.Click += new System.EventHandler(this.b_AddSkillForm_Click);
            // 
            // b_ChangeInfo
            // 
            this.b_ChangeInfo.Location = new System.Drawing.Point(145, 8);
            this.b_ChangeInfo.Name = "b_ChangeInfo";
            this.b_ChangeInfo.Size = new System.Drawing.Size(127, 34);
            this.b_ChangeInfo.TabIndex = 4;
            this.b_ChangeInfo.Text = "Редактировать";
            this.b_ChangeInfo.UseVisualStyleBackColor = true;
            this.b_ChangeInfo.Click += new System.EventHandler(this.b_ChangeInfo_Click);
            // 
            // b_DelSkill
            // 
            this.b_DelSkill.Location = new System.Drawing.Point(278, 8);
            this.b_DelSkill.Name = "b_DelSkill";
            this.b_DelSkill.Size = new System.Drawing.Size(127, 34);
            this.b_DelSkill.TabIndex = 5;
            this.b_DelSkill.Text = "Удалить навык";
            this.b_DelSkill.UseVisualStyleBackColor = true;
            this.b_DelSkill.Click += new System.EventHandler(this.b_DelSkill_Click);
            // 
            // b_Print
            // 
            this.b_Print.Location = new System.Drawing.Point(411, 9);
            this.b_Print.Name = "b_Print";
            this.b_Print.Size = new System.Drawing.Size(69, 33);
            this.b_Print.TabIndex = 7;
            this.b_Print.Text = "Печать";
            this.b_Print.UseVisualStyleBackColor = true;
            this.b_Print.Click += new System.EventHandler(this.b_Print_Click);
            // 
            // WindowSkillDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 305);
            this.Controls.Add(this.b_Print);
            this.Controls.Add(this.b_DelSkill);
            this.Controls.Add(this.b_ChangeInfo);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.b_AddSkillForm);
            this.Name = "WindowSkillDB";
            this.Text = "WindowSkillDB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button b_AddSkillForm;
        private System.Windows.Forms.Button b_ChangeInfo;
        private System.Windows.Forms.Button b_DelSkill;
        private System.Windows.Forms.Button b_Print;
    }
}