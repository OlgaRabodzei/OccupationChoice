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

namespace OccupationСhoice.View.Skill
{
    /// <summary>
    /// Логика взаимодействия для WindowSkillDB.xaml
    /// </summary>
    public partial class WindowSkillDB : Window
    {
        MainControl control;

        public WindowSkillDB(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
            this.dataGV.ItemsSource = this.control.GetTable("Skills").DefaultView;
        }

        private void b_AddSkillForm_Click(object sender, RoutedEventArgs e)
        {
            WindowAddSkill addWindow = new WindowAddSkill(this.control);
            addWindow.ShowDialog();
        }
    }
}
