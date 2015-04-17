using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OccupationСhoice.Model;

namespace OccupationСhoice.View
{
    public partial class ResultForm : Form
    {
        private Matrix[,] Result;
        private MainControl control;

        public ResultForm(MainControl inControl, Matrix[,] inResult)
        {
            InitializeComponent();
            this.control = inControl;
            this.Result = inResult;
            Initialise();
        }

        private void Initialise()
        {
            DataTable table = new DataTable();
            for (int i = 0; i < Result.GetLength(0); i++)
            {
                table.Rows.Add();
                for (int j = 0; j < Result.GetLength(1); j++)
                {
                    if(i==0) table.Columns.Add();
                    table.Rows[i][j] = this.Result[i, j].Koef;
                }
            }
            this.dataGV_result.DataSource = table.DefaultView;
            for (int i = 0; i < this.dataGV_result.ColumnCount; i++)
                this.dataGV_result.Columns[i].HeaderText = this.control.CVacancy.GetNameByID(this.Result[0, i].ColName);

            CalculateVacanciesRating();
            FillComboBox();
        }

        private void FillComboBox()
        {
            DataTable table = new DataTable();
            table = this.control.CStudent.GetTableOfStudents();
            for (int i = 0; i < table.Rows.Count; i++)
                this.cBox_Student.Items.Add(String.Format("{0} {1} {2} {3}",table.Rows[i][0],table.Rows[i][1],table.Rows[i][2],table.Rows[i][3]));

            table = this.control.CVacancy.GetTableOfVacancies();
            for (int i = 0; i < table.Rows.Count; i++)
                this.cBox_Vacancies.Items.Add(String.Format("{0} {1}", table.Rows[i][0], table.Rows[i][1]));
        }

        private void TableForStudent(int studentID)
        {
            this.dataGV_StudentResult.Rows.Clear();//Очищаем таблицу
            for (int i = 0; i < this.Result.GetLength(0); i++)//Идем по матрице рез-ов
                if (this.Result[i, 0].RowName == studentID)//Находим строку снужным студентом
                {
                    for (int j = 0; j < this.Result.GetLength(1); j++)//Выписываем результаты
                    {
                        string vacName = this.control.CVacancy.GetNameByID(this.Result[i, j].ColName);
                        this.dataGV_StudentResult.Rows.Add(vacName, this.Result[i, j].Koef);
                    }
                    break;
                }
        }

        private void TableForVacancies(int vacancyID)
        {
            this.dataGV_VacancyResult.Rows.Clear();//Очищаем таблицу
            for (int j = 0; j < this.Result.GetLength(1); j++)//Идем по матрице рез-ов
                if (this.Result[0, j].ColName == vacancyID)//Находим столбец снужной вакансией
                {
                    for (int i = 0; i < this.Result.GetLength(0); i++)//Выписываем результаты
                    {
                        string student = this.control.CStudent.GetNameByID(this.Result[i, j].RowName);
                        this.dataGV_VacancyResult.Rows.Add(student, this.Result[i, j].Koef);
                    }
                    break;
                }
        }

        private void CalculateVacanciesRating()
        {
            string[] Names = new string[this.Result.GetLength(1)];
            int[] Counts = new int[this.Result.GetLength(1)];

            for (int i = 0; i < this.Result.GetLength(0); i++)
            {
                Matrix max = new Matrix();
                int maxIndex = -1;
                List<int> maxList = new List<int>();
                for (int j = 0; j < this.Result.GetLength(1); j++)
                {
                    if (this.Result[i, j].Koef > max.Koef)
                    {
                        maxList.Remove(maxIndex);
                        max = this.Result[i, j];
                        maxIndex = j;
                        maxList.Add(j);
                    }
                    else if (this.Result[i, j].Koef == max.Koef)
                    {
                        maxList.Add(j);
                    }
                }
                for (int l = 0; l < maxList.Count; l++)
                {
                    if (Names[maxList[l]] == null)
                    {
                        string name = this.control.CVacancy.GetNameByID(Result[i, maxList[l]].ColName);
                        Names[maxList[l]] = name;
                        Counts[maxList[l]]++;
                    }
                    else
                        Counts[maxList[l]]++;
                }
            }
            chart1.Series.RemoveAt(0);
            chart1.Series.Add("Кол-во студентов");
            chart1.Series["Кол-во студентов"].Points.DataBindXY(Names, Counts);
            chart1.Titles.Add("Распределение студентов по вакансиям");
        }

        private void cBox_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idStudent = this.cBox_Student.SelectedItem.ToString().Split(' ')[0];
            TableForStudent(int.Parse(idStudent));
        }

        private void cBox_Vacancies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idVacancy = this.cBox_Vacancies.SelectedItem.ToString().Split(' ')[0];
            TableForVacancies(int.Parse(idVacancy));
        }
    }
}
