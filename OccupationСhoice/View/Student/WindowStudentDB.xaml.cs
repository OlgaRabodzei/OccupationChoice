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

namespace OccupationСhoice.View
{
    /// <summary>
    /// Логика взаимодействия для WindowStudentDB.xaml
    /// </summary>
    public partial class WindowStudentDB : Window
    {
        private MainControl control;

        public WindowStudentDB(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
            this.dataGV.ItemsSource = this.control.GetTable("Students").DefaultView;
        }

        private void b_AddStudentForm_Click(object sender, RoutedEventArgs e)
        {
            WindowAddStudent addWindow = new WindowAddStudent(this.control);
            addWindow.ShowDialog();
        }
    }
}
