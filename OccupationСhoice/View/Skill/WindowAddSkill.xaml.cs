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
    /// Логика взаимодействия для WindowAddSkill.xaml
    /// </summary>
    public partial class WindowAddSkill : Window
    {
        private MainControl control;

        public WindowAddSkill(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        private void b_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void b_AddSkill_Click(object sender, RoutedEventArgs e)
        {
            string SkName = tB_SkName.Text;
            string Description = new TextRange(rTB_Description.Document.ContentStart, rTB_Description.Document.ContentEnd).Text;
            control.CSkill.AddSkill(SkName, Description);
        }
    }
}
