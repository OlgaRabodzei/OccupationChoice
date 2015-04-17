namespace OccupationСhoice.View.Vacancy
{
    partial class WindowAddVacancy
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
            this.l_VacName = new System.Windows.Forms.Label();
            this.l_Post = new System.Windows.Forms.Label();
            this.l_Description = new System.Windows.Forms.Label();
            this.rTB_Description = new System.Windows.Forms.RichTextBox();
            this.tB_VacName = new System.Windows.Forms.TextBox();
            this.tB_Post = new System.Windows.Forms.TextBox();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_AddVacancy = new System.Windows.Forms.Button();
            this.chB_requiredKoef = new System.Windows.Forms.CheckBox();
            this.dataGV_requiredKoef = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_requiredKoef)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите данные о вакансии";
            // 
            // l_VacName
            // 
            this.l_VacName.AutoSize = true;
            this.l_VacName.Location = new System.Drawing.Point(12, 42);
            this.l_VacName.Name = "l_VacName";
            this.l_VacName.Size = new System.Drawing.Size(57, 13);
            this.l_VacName.TabIndex = 1;
            this.l_VacName.Text = "Название";
            // 
            // l_Post
            // 
            this.l_Post.AutoSize = true;
            this.l_Post.Location = new System.Drawing.Point(12, 82);
            this.l_Post.Name = "l_Post";
            this.l_Post.Size = new System.Drawing.Size(65, 13);
            this.l_Post.TabIndex = 2;
            this.l_Post.Text = "Должность";
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Location = new System.Drawing.Point(12, 126);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(57, 13);
            this.l_Description.TabIndex = 3;
            this.l_Description.Text = "Описание";
            // 
            // rTB_Description
            // 
            this.rTB_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB_Description.Location = new System.Drawing.Point(94, 126);
            this.rTB_Description.Name = "rTB_Description";
            this.rTB_Description.Size = new System.Drawing.Size(207, 84);
            this.rTB_Description.TabIndex = 4;
            this.rTB_Description.Text = "";
            // 
            // tB_VacName
            // 
            this.tB_VacName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_VacName.Location = new System.Drawing.Point(94, 42);
            this.tB_VacName.Name = "tB_VacName";
            this.tB_VacName.Size = new System.Drawing.Size(207, 20);
            this.tB_VacName.TabIndex = 5;
            // 
            // tB_Post
            // 
            this.tB_Post.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Post.Location = new System.Drawing.Point(94, 82);
            this.tB_Post.Name = "tB_Post";
            this.tB_Post.Size = new System.Drawing.Size(207, 20);
            this.tB_Post.TabIndex = 6;
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(211, 228);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(98, 34);
            this.b_Close.TabIndex = 15;
            this.b_Close.Text = "Отмена";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_AddVacancy
            // 
            this.b_AddVacancy.Location = new System.Drawing.Point(107, 228);
            this.b_AddVacancy.Name = "b_AddVacancy";
            this.b_AddVacancy.Size = new System.Drawing.Size(98, 34);
            this.b_AddVacancy.TabIndex = 14;
            this.b_AddVacancy.Text = "OK";
            this.b_AddVacancy.UseVisualStyleBackColor = true;
            this.b_AddVacancy.Click += new System.EventHandler(this.b_AddVacancy_Click);
            // 
            // chB_requiredKoef
            // 
            this.chB_requiredKoef.AutoSize = true;
            this.chB_requiredKoef.Location = new System.Drawing.Point(15, 277);
            this.chB_requiredKoef.Name = "chB_requiredKoef";
            this.chB_requiredKoef.Size = new System.Drawing.Size(305, 17);
            this.chB_requiredKoef.TabIndex = 16;
            this.chB_requiredKoef.Text = "Указать требуемые коэффициенты развития навыков";
            this.chB_requiredKoef.UseVisualStyleBackColor = true;
            this.chB_requiredKoef.CheckedChanged += new System.EventHandler(this.chB_requiredKoef_CheckedChanged);
            // 
            // dataGV_requiredKoef
            // 
            this.dataGV_requiredKoef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV_requiredKoef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_requiredKoef.Location = new System.Drawing.Point(12, 300);
            this.dataGV_requiredKoef.Name = "dataGV_requiredKoef";
            this.dataGV_requiredKoef.Size = new System.Drawing.Size(297, 58);
            this.dataGV_requiredKoef.TabIndex = 17;
            this.dataGV_requiredKoef.Visible = false;
            // 
            // WindowAddVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 370);
            this.Controls.Add(this.dataGV_requiredKoef);
            this.Controls.Add(this.chB_requiredKoef);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_AddVacancy);
            this.Controls.Add(this.tB_Post);
            this.Controls.Add(this.tB_VacName);
            this.Controls.Add(this.rTB_Description);
            this.Controls.Add(this.l_Description);
            this.Controls.Add(this.l_Post);
            this.Controls.Add(this.l_VacName);
            this.Controls.Add(this.label1);
            this.Name = "WindowAddVacancy";
            this.Text = "WindowAddVacancy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_requiredKoef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_VacName;
        private System.Windows.Forms.Label l_Post;
        private System.Windows.Forms.Label l_Description;
        private System.Windows.Forms.RichTextBox rTB_Description;
        private System.Windows.Forms.TextBox tB_VacName;
        private System.Windows.Forms.TextBox tB_Post;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_AddVacancy;
        private System.Windows.Forms.CheckBox chB_requiredKoef;
        private System.Windows.Forms.DataGridView dataGV_requiredKoef;
    }
}