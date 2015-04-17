namespace OccupationСhoice.View.Student
{
    partial class WindowAddStudent
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
            this.l_Head = new System.Windows.Forms.Label();
            this.l_StFamily = new System.Windows.Forms.Label();
            this.l_StName = new System.Windows.Forms.Label();
            this.l_StPatronymic = new System.Windows.Forms.Label();
            this.l_StDOB = new System.Windows.Forms.Label();
            this.l_StRealeaseDate = new System.Windows.Forms.Label();
            this.tB_StFamily = new System.Windows.Forms.TextBox();
            this.tB_StName = new System.Windows.Forms.TextBox();
            this.tB_StPatronymic = new System.Windows.Forms.TextBox();
            this.dateTimeP_DOB = new System.Windows.Forms.DateTimePicker();
            this.dateTimeP_RDate = new System.Windows.Forms.DateTimePicker();
            this.chB_Marks = new System.Windows.Forms.CheckBox();
            this.b_AddStudent = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.dataGV_Marks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Marks)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Head
            // 
            this.l_Head.AutoSize = true;
            this.l_Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Head.Location = new System.Drawing.Point(101, 9);
            this.l_Head.Name = "l_Head";
            this.l_Head.Size = new System.Drawing.Size(216, 16);
            this.l_Head.TabIndex = 0;
            this.l_Head.Text = "Укажите данные о студенте";
            this.l_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_StFamily
            // 
            this.l_StFamily.AutoSize = true;
            this.l_StFamily.Location = new System.Drawing.Point(13, 47);
            this.l_StFamily.Name = "l_StFamily";
            this.l_StFamily.Size = new System.Drawing.Size(56, 13);
            this.l_StFamily.TabIndex = 1;
            this.l_StFamily.Text = "Фамилия";
            // 
            // l_StName
            // 
            this.l_StName.AutoSize = true;
            this.l_StName.Location = new System.Drawing.Point(13, 85);
            this.l_StName.Name = "l_StName";
            this.l_StName.Size = new System.Drawing.Size(29, 13);
            this.l_StName.TabIndex = 2;
            this.l_StName.Text = "Имя";
            // 
            // l_StPatronymic
            // 
            this.l_StPatronymic.AutoSize = true;
            this.l_StPatronymic.Location = new System.Drawing.Point(13, 126);
            this.l_StPatronymic.Name = "l_StPatronymic";
            this.l_StPatronymic.Size = new System.Drawing.Size(54, 13);
            this.l_StPatronymic.TabIndex = 3;
            this.l_StPatronymic.Text = "Отчество";
            // 
            // l_StDOB
            // 
            this.l_StDOB.AutoSize = true;
            this.l_StDOB.Location = new System.Drawing.Point(13, 181);
            this.l_StDOB.Name = "l_StDOB";
            this.l_StDOB.Size = new System.Drawing.Size(86, 13);
            this.l_StDOB.TabIndex = 4;
            this.l_StDOB.Text = "Дата рождения";
            // 
            // l_StRealeaseDate
            // 
            this.l_StRealeaseDate.AutoSize = true;
            this.l_StRealeaseDate.Location = new System.Drawing.Point(232, 181);
            this.l_StRealeaseDate.Name = "l_StRealeaseDate";
            this.l_StRealeaseDate.Size = new System.Drawing.Size(79, 13);
            this.l_StRealeaseDate.TabIndex = 5;
            this.l_StRealeaseDate.Text = "Дата выпуска";
            // 
            // tB_StFamily
            // 
            this.tB_StFamily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_StFamily.Location = new System.Drawing.Point(128, 44);
            this.tB_StFamily.Name = "tB_StFamily";
            this.tB_StFamily.Size = new System.Drawing.Size(186, 20);
            this.tB_StFamily.TabIndex = 6;
            // 
            // tB_StName
            // 
            this.tB_StName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_StName.Location = new System.Drawing.Point(128, 82);
            this.tB_StName.Name = "tB_StName";
            this.tB_StName.Size = new System.Drawing.Size(186, 20);
            this.tB_StName.TabIndex = 7;
            // 
            // tB_StPatronymic
            // 
            this.tB_StPatronymic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_StPatronymic.Location = new System.Drawing.Point(128, 123);
            this.tB_StPatronymic.Name = "tB_StPatronymic";
            this.tB_StPatronymic.Size = new System.Drawing.Size(186, 20);
            this.tB_StPatronymic.TabIndex = 8;
            // 
            // dateTimeP_DOB
            // 
            this.dateTimeP_DOB.Location = new System.Drawing.Point(16, 210);
            this.dateTimeP_DOB.Name = "dateTimeP_DOB";
            this.dateTimeP_DOB.Size = new System.Drawing.Size(162, 20);
            this.dateTimeP_DOB.TabIndex = 9;
            // 
            // dateTimeP_RDate
            // 
            this.dateTimeP_RDate.Location = new System.Drawing.Point(235, 210);
            this.dateTimeP_RDate.Name = "dateTimeP_RDate";
            this.dateTimeP_RDate.Size = new System.Drawing.Size(162, 20);
            this.dateTimeP_RDate.TabIndex = 10;
            // 
            // chB_Marks
            // 
            this.chB_Marks.AutoSize = true;
            this.chB_Marks.Location = new System.Drawing.Point(16, 288);
            this.chB_Marks.Name = "chB_Marks";
            this.chB_Marks.Size = new System.Drawing.Size(108, 17);
            this.chB_Marks.TabIndex = 11;
            this.chB_Marks.Text = "Указать оценки";
            this.chB_Marks.UseVisualStyleBackColor = true;
            this.chB_Marks.CheckedChanged += new System.EventHandler(this.chB_Marks_CheckedChanged);
            // 
            // b_AddStudent
            // 
            this.b_AddStudent.Location = new System.Drawing.Point(189, 248);
            this.b_AddStudent.Name = "b_AddStudent";
            this.b_AddStudent.Size = new System.Drawing.Size(98, 34);
            this.b_AddStudent.TabIndex = 12;
            this.b_AddStudent.Text = "OK";
            this.b_AddStudent.UseVisualStyleBackColor = true;
            this.b_AddStudent.Click += new System.EventHandler(this.b_AddStudent_Click);
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(293, 248);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(98, 34);
            this.b_Close.TabIndex = 13;
            this.b_Close.Text = "Отмена";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // dataGV_Marks
            // 
            this.dataGV_Marks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV_Marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Marks.Location = new System.Drawing.Point(16, 311);
            this.dataGV_Marks.Name = "dataGV_Marks";
            this.dataGV_Marks.Size = new System.Drawing.Size(388, 80);
            this.dataGV_Marks.TabIndex = 14;
            this.dataGV_Marks.Visible = false;
            // 
            // WindowAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 403);
            this.Controls.Add(this.dataGV_Marks);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_AddStudent);
            this.Controls.Add(this.chB_Marks);
            this.Controls.Add(this.dateTimeP_RDate);
            this.Controls.Add(this.dateTimeP_DOB);
            this.Controls.Add(this.tB_StPatronymic);
            this.Controls.Add(this.tB_StName);
            this.Controls.Add(this.tB_StFamily);
            this.Controls.Add(this.l_StRealeaseDate);
            this.Controls.Add(this.l_StDOB);
            this.Controls.Add(this.l_StPatronymic);
            this.Controls.Add(this.l_StName);
            this.Controls.Add(this.l_StFamily);
            this.Controls.Add(this.l_Head);
            this.Name = "WindowAddStudent";
            this.Text = "WindowAddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Head;
        private System.Windows.Forms.Label l_StFamily;
        private System.Windows.Forms.Label l_StName;
        private System.Windows.Forms.Label l_StPatronymic;
        private System.Windows.Forms.Label l_StDOB;
        private System.Windows.Forms.Label l_StRealeaseDate;
        private System.Windows.Forms.TextBox tB_StFamily;
        private System.Windows.Forms.TextBox tB_StName;
        private System.Windows.Forms.TextBox tB_StPatronymic;
        private System.Windows.Forms.DateTimePicker dateTimeP_DOB;
        private System.Windows.Forms.DateTimePicker dateTimeP_RDate;
        private System.Windows.Forms.CheckBox chB_Marks;
        private System.Windows.Forms.Button b_AddStudent;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.DataGridView dataGV_Marks;
    }
}