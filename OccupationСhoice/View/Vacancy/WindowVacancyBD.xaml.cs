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
    /// Логика взаимодействия для WindowVacancyBD.xaml
    /// </summary>
    public partial class WindowVacancyBD : Window
    {
        private MainControl control;

        public WindowVacancyBD(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
            this.dataGV.ItemsSource = this.control.GetTable("Vacancies").DefaultView;
        }

        private void b_AddVacancyForm_Click(object sender, RoutedEventArgs e)
        {
            WindowAddVacancy addWindow = new WindowAddVacancy(this.control);
            addWindow.ShowDialog();
        }
    }
}
