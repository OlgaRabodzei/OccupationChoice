namespace OccupationСhoice.View.User
{
    partial class WindowAddUser
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
            this.l_Login = new System.Windows.Forms.Label();
            this.l_Password = new System.Windows.Forms.Label();
            this.cB_Type = new System.Windows.Forms.ComboBox();
            this.l_Type = new System.Windows.Forms.Label();
            this.b_AddUser = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.tB_Login = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите Ваши данные";
            // 
            // l_Login
            // 
            this.l_Login.AutoSize = true;
            this.l_Login.Location = new System.Drawing.Point(12, 58);
            this.l_Login.Name = "l_Login";
            this.l_Login.Size = new System.Drawing.Size(38, 13);
            this.l_Login.TabIndex = 1;
            this.l_Login.Text = "Логин";
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.Location = new System.Drawing.Point(12, 99);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(45, 13);
            this.l_Password.TabIndex = 2;
            this.l_Password.Text = "Пароль";
            // 
            // cB_Type
            // 
            this.cB_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_Type.FormattingEnabled = true;
            this.cB_Type.Items.AddRange(new object[] {
            "студент",
            "преподаватель",
            "администратор"});
            this.cB_Type.Location = new System.Drawing.Point(118, 142);
            this.cB_Type.Name = "cB_Type";
            this.cB_Type.Size = new System.Drawing.Size(154, 21);
            this.cB_Type.TabIndex = 3;
            // 
            // l_Type
            // 
            this.l_Type.AutoSize = true;
            this.l_Type.Location = new System.Drawing.Point(12, 145);
            this.l_Type.Name = "l_Type";
            this.l_Type.Size = new System.Drawing.Size(100, 13);
            this.l_Type.TabIndex = 4;
            this.l_Type.Text = "Тип пользователя";
            // 
            // b_AddUser
            // 
            this.b_AddUser.Location = new System.Drawing.Point(96, 202);
            this.b_AddUser.Name = "b_AddUser";
            this.b_AddUser.Size = new System.Drawing.Size(85, 34);
            this.b_AddUser.TabIndex = 5;
            this.b_AddUser.Text = "Добавить";
            this.b_AddUser.UseVisualStyleBackColor = true;
            this.b_AddUser.Click += new System.EventHandler(this.b_AddUser_Click);
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(187, 202);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(85, 34);
            this.b_Close.TabIndex = 6;
            this.b_Close.Text = "Отмена";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // tB_Login
            // 
            this.tB_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Login.Location = new System.Drawing.Point(96, 55);
            this.tB_Login.Name = "tB_Login";
            this.tB_Login.Size = new System.Drawing.Size(176, 20);
            this.tB_Login.TabIndex = 7;
            // 
            // tB_Password
            // 
            this.tB_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Password.Location = new System.Drawing.Point(96, 96);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.Size = new System.Drawing.Size(176, 20);
            this.tB_Password.TabIndex = 8;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Login);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_AddUser);
            this.Controls.Add(this.l_Type);
            this.Controls.Add(this.cB_Type);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.l_Login);
            this.Controls.Add(this.label1);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_Login;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.ComboBox cB_Type;
        private System.Windows.Forms.Label l_Type;
        private System.Windows.Forms.Button b_AddUser;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.TextBox tB_Login;
        private System.Windows.Forms.TextBox tB_Password;
    }
}