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
using System.Windows.Shapes;

namespace OccupationСhoice.View.Vacancy
{
    /// <summary>
    /// Логика взаимодействия для WindowAddVacancy.xaml
    /// </summary>
    public partial class WindowAddVacancy : Window
    {
        private MainControl control;

        public WindowAddVacancy(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        private void b_AddVacancy_Click(object sender, RoutedEventArgs e)
        {
            string VacName = tB_VacName.Text;
            string post = tB_Post.Text;
            string Description = new TextRange(rTB_Description.Document.ContentStart, rTB_Description.Document.ContentEnd).Text;
            control.CVacancy.AddVacancy(VacName, post, Description);
        }

        private void b_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
