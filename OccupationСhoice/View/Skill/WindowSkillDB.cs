using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OccupationСhoice.View.Skill
{
    public partial class WindowSkillDB : Form
    {
        private MainControl control;
        private BindingSource bSource;

        public WindowSkillDB(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
            this.dataGV.DataSource = this.control.GetTable("Skills").DefaultView;
        }

        private void b_AddSkillForm_Click(object sender, EventArgs e)
        {
            WindowAddSkill addWindow = new WindowAddSkill(this.control);
            addWindow.ShowDialog();
        }

        private void b_ChangeInfo_Click(object sender, EventArgs e)
        {
            if (this.dataGV.SelectedRows.Count > 0)
            {
                int id_skill = int.Parse(this.dataGV.SelectedRows[0].Cells[0].Value.ToString());
                WindowAddSkill addWindow = new WindowAddSkill(this.control, id_skill);
                addWindow.ShowDialog();
                this.bSource.DataSource = this.control.GetTable("Skills");
            }
        }

        private void b_DelSkill_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataGV.SelectedRows.Count; i++)
            {
                int id_skill = int.Parse(this.dataGV.SelectedRows[i].Cells[0].Value.ToString());
                this.control.CSkill.DelSkill(id_skill);
                this.bSource.DataSource = this.control.GetTable("Skills");
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
            ObjWorkSheet.Cells[1, 1] = "Таблица навыков";
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
