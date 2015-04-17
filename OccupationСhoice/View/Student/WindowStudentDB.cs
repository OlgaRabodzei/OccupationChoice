using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OccupationСhoice.View.Student
{
    public partial class WindowStudentDB : Form
    {
        private MainControl control;
        private BindingSource bSource;

        public WindowStudentDB(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
            this.bSource = new BindingSource();
            this.bSource.DataSource = this.control.GetTable("Students");
            this.bSource.AllowNew = true;
            this.dataGV.DataSource = this.bSource;
        }

        private void b_AddStudentForm_Click(object sender, EventArgs e)
        {
            WindowAddStudent addWindow = new WindowAddStudent(this.control);
            addWindow.ShowDialog();
            this.bSource.DataSource = this.control.GetTable("Students");
        }

        private void b_ChangeInfo_Click(object sender, EventArgs e)
        {
            if (this.dataGV.SelectedRows.Count > 0)
            {
                int id_stud = int.Parse(this.dataGV.SelectedRows[0].Cells[0].Value.ToString());
                WindowAddStudent addWindow = new WindowAddStudent(this.control, id_stud);
                addWindow.ShowDialog();
                this.bSource.DataSource = this.control.GetTable("Students");
            }
        }

        private void b_DelStudent_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGV.SelectedRows.Count; i++)
            {
                int id_stud = int.Parse(this.dataGV.SelectedRows[i].Cells[0].Value.ToString());
                this.control.CStudent.DelStudent(id_stud);
                this.bSource.DataSource = this.control.GetTable("Students");
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
            ObjWorkSheet.Cells[1, 1] = "Таблица студентов";
            for (int i = 0; i < dataGV.RowCount-1; i++)
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
