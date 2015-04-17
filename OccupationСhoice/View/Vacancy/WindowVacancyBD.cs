using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OccupationСhoice.View.Vacancy
{
    public partial class WindowVacancyBD : Form
    {
        private MainControl control;
        private BindingSource bSource;

        public WindowVacancyBD(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
            this.bSource = new BindingSource();
            this.bSource.DataSource = this.control.GetTable("Vacancies");
            this.bSource.AllowNew = true;
            this.dataGV.DataSource = this.bSource;
        }

        private void b_AddVacancyForm_Click(object sender, EventArgs e)
        {
            WindowAddVacancy addWindow = new WindowAddVacancy(this.control);
            addWindow.ShowDialog();
            this.bSource.DataSource = this.control.GetTable("Vacancies");
        }

        private void b_ChangeInfo_Click(object sender, EventArgs e)
        {
            if (this.dataGV.SelectedRows.Count > 0)
            {
                int id_vac = int.Parse(this.dataGV.SelectedRows[0].Cells[0].Value.ToString());
                WindowAddVacancy addWindow = new WindowAddVacancy(this.control, id_vac);
                addWindow.ShowDialog();
                this.bSource.DataSource = this.control.GetTable("Vacancies");
            }
        }

        private void b_DelVacancy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGV.SelectedRows.Count; i++)
            {
                int id_vac = int.Parse(this.dataGV.SelectedRows[i].Cells[0].Value.ToString());
                this.control.CVacancy.DelVacancy(id_vac);
                this.bSource.DataSource = this.control.GetTable("Vacancies");
            }
        }

        private void b_Print_Click(object sender, EventArgs e)
        {
            Excel.Application ObjExcel = new Excel.Application();
            Excel.Workbook ObjWorkBook;
            Excel.Worksheet ObjWorkSheet;
            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            //Значения [y - строка,x - столбец]
            ObjWorkSheet.Cells[1, 1] = "Таблица вакансий";
            for (int i = 0; i < dataGV.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGV.ColumnCount; j++)
                {
                    ObjWorkSheet.Cells[i + 2, j + 1] = dataGV.Rows[i].Cells[j].Value.ToString();
                }
            }
            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;
        }
    }
}
