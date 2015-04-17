using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OccupationСhoice.View.Student;
using OccupationСhoice.View.Skill;
using OccupationСhoice.View.Subject;
using OccupationСhoice.View.Vacancy;
using OccupationСhoice.View.User;
using OccupationСhoice.Model;
using OccupationСhoice.View;

namespace OccupationСhoice
{
    public partial class MainForm : Form
    {
        private MainControl control;
        private FuzzyRelations fuzzyRelation;

        public MainForm()
        {
            InitializeComponent();
            this.control = new MainControl();
        }

        private void b_Students_Click(object sender, EventArgs e)
        {
            WindowStudentDB stWindow = new WindowStudentDB(control);
            stWindow.Show();
        }

        private void b_Skills_Click(object sender, EventArgs e)
        {
            WindowSkillDB skWindow = new WindowSkillDB(control);
            skWindow.Show();
        }

        private void b_Subjects_Click(object sender, EventArgs e)
        {
            WindowSubjectBD subWindow = new WindowSubjectBD(control);
            subWindow.Show();
        }

        private void b_Vacancies_Click(object sender, EventArgs e)
        {
            WindowVacancyBD vacWindow = new WindowVacancyBD(control);
            vacWindow.Show();
        }

        private void b_Entrance_Click(object sender, EventArgs e)
        {
            string login = tB_Login.Text;
            string password = tB_Password.Text;
            if (this.control.GetUser(login, password))
            {
                b_Skills.Enabled = true;
                b_Students.Enabled = true;
                b_Subjects.Enabled = true;
                b_Vacancies.Enabled = true;
                l_Entrance.Text = "Добро пожаловать в программу!";
                b_Algorithm.Enabled = true;
                b_Algorithm.Visible = true;
            }
        }

        private void b_Registry_Click(object sender, EventArgs e)
        {
            WindowAddUser addWindow = new WindowAddUser(this.control);
            addWindow.ShowDialog();
        }

        private void b_Algorithm_Click(object sender, EventArgs e)
        {
            this.fuzzyRelation = new FuzzyRelations(this.control);
            Matrix[,] Result = this.fuzzyRelation.Algorithm();

            ResultForm rForm = new ResultForm(this.control, Result);
            rForm.Show();
        }
    }
}
