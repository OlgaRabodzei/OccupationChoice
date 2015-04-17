namespace OccupationСhoice.View.Skill
{
    partial class WindowAddSkill
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
            this.label1 = new System.Windows.Forms.Label();
            this.l_SkName = new System.Windows.Forms.Label();
            this.l_Description = new System.Windows.Forms.Label();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_AddSkill = new System.Windows.Forms.Button();
            this.tB_SkName = new System.Windows.Forms.TextBox();
            this.rTB_Description = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите данные о навыке";
            // 
            // l_SkName
            // 
            this.l_SkName.AutoSize = true;
            this.l_SkName.Location = new System.Drawing.Point(12, 47);
            this.l_SkName.Name = "l_SkName";
            this.l_SkName.Size = new System.Drawing.Size(57, 13);
            this.l_SkName.TabIndex = 1;
            this.l_SkName.Text = "Название";
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Location = new System.Drawing.Point(12, 88);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(57, 13);
            this.l_Description.TabIndex = 2;
            this.l_Description.Text = "Описание";
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(174, 176);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(98, 34);
            this.b_Close.TabIndex = 15;
            this.b_Close.Text = "Отмена";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_AddSkill
            // 
            this.b_AddSkill.Location = new System.Drawing.Point(70, 176);
            this.b_AddSkill.Name = "b_AddSkill";
            this.b_AddSkill.Size = new System.Drawing.Size(98, 34);
            this.b_AddSkill.TabIndex = 14;
            this.b_AddSkill.Text = "OK";
            this.b_AddSkill.UseVisualStyleBackColor = true;
            this.b_AddSkill.Click += new System.EventHandler(this.b_AddSkill_Click);
            // 
            // tB_SkName
            // 
            this.tB_SkName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_SkName.Location = new System.Drawing.Point(80, 44);
            this.tB_SkName.Name = "tB_SkName";
            this.tB_SkName.Size = new System.Drawing.Size(192, 20);
            this.tB_SkName.TabIndex = 16;
            // 
            // rTB_Description
            // 
            this.rTB_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB_Description.Location = new System.Drawing.Point(80, 85);
            this.rTB_Description.Name = "rTB_Description";
            this.rTB_Description.Size = new System.Drawing.Size(192, 79);
            this.rTB_Description.TabIndex = 17;
            this.rTB_Description.Text = "";
            // 
            // WindowAddSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rTB_Description);
            this.Controls.Add(this.tB_SkName);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_AddSkill);
            this.Controls.Add(this.l_Description);
            this.Controls.Add(this.l_SkName);
            this.Controls.Add(this.label1);
            this.Name = "WindowAddSkill";
            this.Text = "WindowAddSkill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_SkName;
        private System.Windows.Forms.Label l_Description;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_AddSkill;
        private System.Windows.Forms.TextBox tB_SkName;
        private System.Windows.Forms.RichTextBox rTB_Description;
    }
}