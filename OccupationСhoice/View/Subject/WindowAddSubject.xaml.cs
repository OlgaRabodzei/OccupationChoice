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
    /// Логика взаимодействия для WindowAddSubject.xaml
    /// </summary>
    public partial class WindowAddSubject : Window
    {
        private MainControl control;

        public WindowAddSubject(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        private void b_AddSubject_Click(object sender, RoutedEventArgs e)
        {
            string SubName = tB_SubName.Text;
            string strHours = tB_hours.Text;
            control.CSubject.AddSubject(SubName, strHours);
        }

        private void b_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
