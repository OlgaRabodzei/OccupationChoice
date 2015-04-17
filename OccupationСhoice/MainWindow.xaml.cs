using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OccupationСhoice.View;
using OccupationСhoice.View.Skill;
using OccupationСhoice.View.Subject;
using OccupationСhoice.View.Vacancy;

namespace OccupationСhoice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainControl control;

        public MainWindow()
        {
            InitializeComponent();
            this.control = new MainControl();
        }

        private void b_Students_Click(object sender, RoutedEventArgs e)
        {
            WindowStudentDB stWindow = new WindowStudentDB(control);
            stWindow.Show();
        }

        private void b_Skills_Click(object sender, RoutedEventArgs e)
        {
            WindowSkillDB skWindow = new WindowSkillDB(control);
            skWindow.Show();
        }

        private void b_Subjects_Click(object sender, RoutedEventArgs e)
        {
            WindowSubjectBD subWindow = new WindowSubjectBD(control);
            subWindow.Show();
        }

        private void b_Vacancies_Click(object sender, RoutedEventArgs e)
        {
            WindowVacancyBD vacWindow = new WindowVacancyBD(control);
            vacWindow.Show();
        }
    }
}
