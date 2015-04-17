using System;
using System.Windows.Forms;

namespace OccupationСhoice.View.Subject
{
    public partial class WindowAddSubject : Form
    {
        private MainControl control;
        private int ID_sub = -1;

        public WindowAddSubject(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        public WindowAddSubject(MainControl inControl, int id_sub)
        {
            InitializeComponent();
            this.control = inControl;
            this.ID_sub = id_sub;
            string SubName; string strHours;
            this.control.CSubject.GetSubject(id_sub, out SubName, out strHours);

            this.tB_SubName.Text = SubName;
            this.tB_hours.Text = strHours;
        }

        private void b_AddSubject_Click(object sender, EventArgs e)
        {
            string SubName = tB_SubName.Text;
            string strHours = tB_hours.Text;
            if (this.ID_sub == -1)//Добавление предмета
                this.control.CSubject.AddSubject(SubName, strHours, out this.ID_sub);
            else//Измененние данных о предмете
                this.control.CSubject.UpdateSubject(this.ID_sub, SubName, strHours);

            if (chB_devKoef.Checked)
            {
                for (int i = 0; i < this.dataGV_devKoef.RowCount - 1; i++)
                {
                    //Добавление коэффициента
                    string skill = this.dataGV_devKoef.Rows[i].Cells[0].Value.ToString();
                    float devKoef;
                    if (float.TryParse(this.dataGV_devKoef.Rows[i].Cells[1].Value.ToString(), out devKoef))
                        this.control.CSubject.AddDevKoef(this.ID_sub, skill, devKoef);
                }
            }
            this.Close();
        }

        private void b_Close_Click(object sender, EventArgs e)
        { this.Close(); }

        private void chB_devKoef_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_devKoef.Checked)
            {
                this.dataGV_devKoef.Visible = true;
                this.dataGV_devKoef.DataSource = this.control.CSubject.GetDevKoef(this.ID_sub);
            }
            else this.dataGV_devKoef.Visible = false;
        }
    }
}
