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
using System.Data;

namespace OccupationСhoice.View
{
    /// <summary>
    /// Логика взаимодействия для WindowAddStudent.xaml
    /// </summary>
    public partial class WindowAddStudent : Window
    {
        private MainControl control;

        public WindowAddStudent(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        private void b_AddStudent_Click(object sender, RoutedEventArgs e)
        {
            string StFamily = tB_StFamily.Text;
            string StName = tB_StName.Text;
            string StPatronymic= tB_StPatronymic.Text;
            DateTime dob = calendar_DOB.SelectedDate.Value;
            DateTime rDate = calendar_RDate.SelectedDate.Value;

            if (chB_Marks.IsChecked == true)
            {
                for (int i = 0; i < this.dataGrid_Marks.Items.Count; i++)
                {
                    ////object S = this.dataGrid_Marks.Items[i];
                    ////DataTable table = new DataTable();
                    ////table.Columns.Add(new DataColumn("subject"));
                    ////table.Columns.Add( new DataColumn("mark"));
                    ////table.Rows.Add(this.dataGrid_Marks.Items[i]);
                    ////string subject = table.Rows[table.Rows.Count - 1][0].ToString();
                    ////int mark = (int)table.Rows[table.Rows.Count - 1][1];
                    //this.control.CStudent.AddMark(StFamily,dataGrid_Marks.
                }
            }

            this.control.CStudent.AddStudent(StFamily, StName, StPatronymic, dob, rDate);

            this.Close();
        }

        private void b_Close_Click(object sender, RoutedEventArgs e)
        { this.Close(); }

        private void chB_Marks_Checked(object sender, RoutedEventArgs e)
        {
            if (chB_Marks.IsChecked == true)
            {
                this.dataGrid_Marks.Visibility = Visibility.Visible;
                this.dataGrid_Marks.ItemsSource = this.control.CSubject.GetAtribute("Name").DefaultView;
                this.dataGrid_Marks.Columns[0].Header = "Дисциплина";
                this.dataGrid_Marks.Columns[0].IsReadOnly = true;
                DataGridTextColumn markColumn = new DataGridTextColumn();
                markColumn.Header = "Оценка";
                this.dataGrid_Marks.Columns.Add(markColumn);
            }
            else
                this.dataGrid_Marks.Visibility = Visibility.Hidden;
        }
    }
}
