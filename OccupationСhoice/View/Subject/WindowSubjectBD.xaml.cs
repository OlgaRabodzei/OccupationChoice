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

namespace OccupationСhoice.View.Subject
{
    /// <summary>
    /// Логика взаимодействия для WindowSubjectBD.xaml
    /// </summary>
    public partial class WindowSubjectBD : Window
    {
        private MainControl control;

        public WindowSubjectBD(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
            this.dataGV.ItemsSource = this.control.GetTable("Subjects").DefaultView;
        }

        private void b_AddSubjectForm_Click(object sender, RoutedEventArgs e)
        {
            WindowAddSubject addWindow = new WindowAddSubject(this.control);
            addWindow.ShowDialog();
        }
    }
}
