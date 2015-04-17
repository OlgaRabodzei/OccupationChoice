using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OccupationСhoice.View.Student
{
    public partial class WindowAddStudent : Form
    {
        private MainControl control;
        private int ID_stud = -1;

        public WindowAddStudent(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        public WindowAddStudent(MainControl inControl, int id_stud)
        {
            InitializeComponent();
            this.control = inControl;
            this.ID_stud = id_stud;
            string StFamily; string StName; string StPatronymic;
            DateTime dob; DateTime rDate;
            this.control.CStudent.GetStudent(id_stud, out StFamily, out StName, out StPatronymic, out dob, out rDate);

            this.tB_StFamily.Text = StFamily;
            this.tB_StName.Text = StName;
            this.tB_StPatronymic.Text = StPatronymic;
            this.dateTimeP_DOB.Value = dob;
            this.dateTimeP_RDate.Value = rDate;
        }

        private void b_AddStudent_Click(object sender, EventArgs e)
        {
            string StFamily = tB_StFamily.Text;
            string StName = tB_StName.Text;
            string StPatronymic = tB_StPatronymic.Text;
            DateTime dob = dateTimeP_DOB.Value;
            DateTime rDate = dateTimeP_RDate.Value;
            if (this.ID_stud == -1)//Добавление студента
                this.control.CStudent.AddStudent(StFamily, StName, StPatronymic, dob, rDate, out this.ID_stud);
            else //Изменение данных о студенте
                this.control.CStudent.UpdateStudent(this.ID_stud, StFamily, StName, StPatronymic, dob, rDate);

            if (chB_Marks.Checked)
            {
                for (int i = 0; i < this.dataGV_Marks.RowCount - 1; i++)
                {
                    //Добавление оценок
                    string subject = this.dataGV_Marks.Rows[i].Cells[0].Value.ToString();
                    float mark = float.Parse(this.dataGV_Marks.Rows[i].Cells[1].Value.ToString());
                    this.control.CStudent.AddMark(this.ID_stud, subject, mark);
                }
            }
            this.Close();
        }

        private void b_Close_Click(object sender, EventArgs e)
        { this.Close(); }

        private void chB_Marks_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_Marks.Checked)
            {
                this.dataGV_Marks.Visible = true;
                this.dataGV_Marks.DataSource = this.control.CStudent.GetMarks(this.ID_stud);
            }
            else this.dataGV_Marks.Visible = false;
        }
    }
}
