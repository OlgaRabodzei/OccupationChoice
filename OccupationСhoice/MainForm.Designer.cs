namespace OccupationСhoice
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Students = new System.Windows.Forms.Button();
            this.b_Skills = new System.Windows.Forms.Button();
            this.b_Subjects = new System.Windows.Forms.Button();
            this.b_Vacancies = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Entrance = new System.Windows.Forms.Label();
            this.tB_Login = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.b_Entrance = new System.Windows.Forms.Button();
            this.b_Registry = new System.Windows.Forms.Button();
            this.b_Algorithm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Students
            // 
            this.b_Students.Enabled = false;
            this.b_Students.Location = new System.Drawing.Point(13, 13);
            this.b_Students.Name = "b_Students";
            this.b_Students.Size = new System.Drawing.Size(89, 43);
            this.b_Students.TabIndex = 0;
            this.b_Students.Text = "Студенты";
            this.b_Students.UseVisualStyleBackColor = true;
            this.b_Students.Click += new System.EventHandler(this.b_Students_Click);
            // 
            // b_Skills
            // 
            this.b_Skills.Enabled = false;
            this.b_Skills.Location = new System.Drawing.Point(13, 62);
            this.b_Skills.Name = "b_Skills";
            this.b_Skills.Size = new System.Drawing.Size(89, 43);
            this.b_Skills.TabIndex = 1;
            this.b_Skills.Text = "Навыки";
            this.b_Skills.UseVisualStyleBackColor = true;
            this.b_Skills.Click += new System.EventHandler(this.b_Skills_Click);
            // 
            // b_Subjects
            // 
            this.b_Subjects.Enabled = false;
            this.b_Subjects.Location = new System.Drawing.Point(13, 111);
            this.b_Subjects.Name = "b_Subjects";
            this.b_Subjects.Size = new System.Drawing.Size(89, 43);
            this.b_Subjects.TabIndex = 2;
            this.b_Subjects.Text = "Дисциплины";
            this.b_Subjects.UseVisualStyleBackColor = true;
            this.b_Subjects.Click += new System.EventHandler(this.b_Subjects_Click);
            // 
            // b_Vacancies
            // 
            this.b_Vacancies.Enabled = false;
            this.b_Vacancies.Location = new System.Drawing.Point(13, 160);
            this.b_Vacancies.Name = "b_Vacancies";
            this.b_Vacancies.Size = new System.Drawing.Size(89, 43);
            this.b_Vacancies.TabIndex = 3;
            this.b_Vacancies.Text = "Вакансии";
            this.b_Vacancies.UseVisualStyleBackColor = true;
            this.b_Vacancies.Click += new System.EventHandler(this.b_Vacancies_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вход в систему";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль:";
            // 
            // l_Entrance
            // 
            this.l_Entrance.AutoSize = true;
            this.l_Entrance.Location = new System.Drawing.Point(136, 160);
            this.l_Entrance.Name = "l_Entrance";
            this.l_Entrance.Size = new System.Drawing.Size(0, 13);
            this.l_Entrance.TabIndex = 7;
            // 
            // tB_Login
            // 
            this.tB_Login.Location = new System.Drawing.Point(190, 39);
            this.tB_Login.Name = "tB_Login";
            this.tB_Login.Size = new System.Drawing.Size(181, 20);
            this.tB_Login.TabIndex = 8;
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(190, 88);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.Size = new System.Drawing.Size(181, 20);
            this.tB_Password.TabIndex = 9;
            // 
            // b_Entrance
            // 
            this.b_Entrance.Location = new System.Drawing.Point(239, 121);
            this.b_Entrance.Name = "b_Entrance";
            this.b_Entrance.Size = new System.Drawing.Size(75, 23);
            this.b_Entrance.TabIndex = 10;
            this.b_Entrance.Text = "Вход";
            this.b_Entrance.UseVisualStyleBackColor = true;
            this.b_Entrance.Click += new System.EventHandler(this.b_Entrance_Click);
            // 
            // b_Registry
            // 
            this.b_Registry.Location = new System.Drawing.Point(320, 121);
            this.b_Registry.Name = "b_Registry";
            this.b_Registry.Size = new System.Drawing.Size(88, 23);
            this.b_Registry.TabIndex = 11;
            this.b_Registry.Text = "Регистрация";
            this.b_Registry.UseVisualStyleBackColor = true;
            this.b_Registry.Click += new System.EventHandler(this.b_Registry_Click);
            // 
            // b_Algorithm
            // 
            this.b_Algorithm.Location = new System.Drawing.Point(239, 180);
            this.b_Algorithm.Name = "b_Algorithm";
            this.b_Algorithm.Size = new System.Drawing.Size(169, 23);
            this.b_Algorithm.TabIndex = 12;
            this.b_Algorithm.Text = "Запустить алгоритм";
            this.b_Algorithm.UseVisualStyleBackColor = true;
            this.b_Algorithm.Click += new System.EventHandler(this.b_Algorithm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 217);
            this.Controls.Add(this.b_Algorithm);
            this.Controls.Add(this.b_Registry);
            this.Controls.Add(this.b_Entrance);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Login);
            this.Controls.Add(this.l_Entrance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Vacancies);
            this.Controls.Add(this.b_Subjects);
            this.Controls.Add(this.b_Skills);
            this.Controls.Add(this.b_Students);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Students;
        private System.Windows.Forms.Button b_Skills;
        private System.Windows.Forms.Button b_Subjects;
        private System.Windows.Forms.Button b_Vacancies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_Entrance;
        private System.Windows.Forms.TextBox tB_Login;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.Button b_Entrance;
        private System.Windows.Forms.Button b_Registry;
        private System.Windows.Forms.Button b_Algorithm;
    }
}

