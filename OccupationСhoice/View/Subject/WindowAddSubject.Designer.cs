namespace OccupationСhoice.View.Subject
{
    partial class WindowAddSubject
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
            this.l_SubName = new System.Windows.Forms.Label();
            this.l_hours = new System.Windows.Forms.Label();
            this.tB_SubName = new System.Windows.Forms.TextBox();
            this.tB_hours = new System.Windows.Forms.TextBox();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_AddSubject = new System.Windows.Forms.Button();
            this.chB_devKoef = new System.Windows.Forms.CheckBox();
            this.dataGV_devKoef = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_devKoef)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите данные о дисциплине";
            // 
            // l_SubName
            // 
            this.l_SubName.AutoSize = true;
            this.l_SubName.Location = new System.Drawing.Point(12, 53);
            this.l_SubName.Name = "l_SubName";
            this.l_SubName.Size = new System.Drawing.Size(57, 13);
            this.l_SubName.TabIndex = 1;
            this.l_SubName.Text = "Название";
            // 
            // l_hours
            // 
            this.l_hours.AutoSize = true;
            this.l_hours.Location = new System.Drawing.Point(12, 95);
            this.l_hours.Name = "l_hours";
            this.l_hours.Size = new System.Drawing.Size(104, 13);
            this.l_hours.TabIndex = 2;
            this.l_hours.Text = "Колличество часов";
            // 
            // tB_SubName
            // 
            this.tB_SubName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_SubName.Location = new System.Drawing.Point(75, 50);
            this.tB_SubName.Name = "tB_SubName";
            this.tB_SubName.Size = new System.Drawing.Size(178, 20);
            this.tB_SubName.TabIndex = 3;
            // 
            // tB_hours
            // 
            this.tB_hours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_hours.Location = new System.Drawing.Point(122, 92);
            this.tB_hours.Name = "tB_hours";
            this.tB_hours.Size = new System.Drawing.Size(100, 20);
            this.tB_hours.TabIndex = 4;
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(174, 137);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(98, 34);
            this.b_Close.TabIndex = 15;
            this.b_Close.Text = "Отмена";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_AddSubject
            // 
            this.b_AddSubject.Location = new System.Drawing.Point(70, 137);
            this.b_AddSubject.Name = "b_AddSubject";
            this.b_AddSubject.Size = new System.Drawing.Size(98, 34);
            this.b_AddSubject.TabIndex = 14;
            this.b_AddSubject.Text = "OK";
            this.b_AddSubject.UseVisualStyleBackColor = true;
            this.b_AddSubject.Click += new System.EventHandler(this.b_AddSubject_Click);
            // 
            // chB_devKoef
            // 
            this.chB_devKoef.AutoSize = true;
            this.chB_devKoef.Location = new System.Drawing.Point(15, 183);
            this.chB_devKoef.Name = "chB_devKoef";
            this.chB_devKoef.Size = new System.Drawing.Size(246, 17);
            this.chB_devKoef.TabIndex = 16;
            this.chB_devKoef.Text = "Указать коэффициенты развития навыков";
            this.chB_devKoef.UseVisualStyleBackColor = true;
            this.chB_devKoef.CheckedChanged += new System.EventHandler(this.chB_devKoef_CheckedChanged);
            // 
            // dataGV_devKoef
            // 
            this.dataGV_devKoef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV_devKoef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_devKoef.Location = new System.Drawing.Point(12, 206);
            this.dataGV_devKoef.Name = "dataGV_devKoef";
            this.dataGV_devKoef.Size = new System.Drawing.Size(260, 81);
            this.dataGV_devKoef.TabIndex = 17;
            this.dataGV_devKoef.Visible = false;
            // 
            // WindowAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.dataGV_devKoef);
            this.Controls.Add(this.chB_devKoef);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_AddSubject);
            this.Controls.Add(this.tB_hours);
            this.Controls.Add(this.tB_SubName);
            this.Controls.Add(this.l_hours);
            this.Controls.Add(this.l_SubName);
            this.Controls.Add(this.label1);
            this.Name = "WindowAddSubject";
            this.Text = "WindowAddSubject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_devKoef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_SubName;
        private System.Windows.Forms.Label l_hours;
        private System.Windows.Forms.TextBox tB_SubName;
        private System.Windows.Forms.TextBox tB_hours;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_AddSubject;
        private System.Windows.Forms.CheckBox chB_devKoef;
        private System.Windows.Forms.DataGridView dataGV_devKoef;
    }
}