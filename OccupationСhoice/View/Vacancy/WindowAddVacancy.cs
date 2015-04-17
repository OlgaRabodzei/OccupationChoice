using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OccupationСhoice.View.Vacancy
{
    public partial class WindowAddVacancy : Form
    {
        private MainControl control;
        private int ID_vac = -1;

        public WindowAddVacancy(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        public WindowAddVacancy(MainControl inControl, int id_vac)
        {
            InitializeComponent();
            this.control = inControl;
            this.ID_vac = id_vac;
            string VacName; string post; string Description;
            this.control.CVacancy.GetVacancy(id_vac, out VacName, out post, out Description);

            this.tB_VacName.Text = VacName;
            this.tB_Post.Text = post;
            this.rTB_Description.Text = Description;
        }

        private void b_AddVacancy_Click(object sender, EventArgs e)
        {
            string VacName = tB_VacName.Text;
            string post = tB_Post.Text;
            string Description = rTB_Description.Text;
            if (this.ID_vac == -1)//Добавление вакансии
                this.control.CVacancy.AddVacancy(VacName, post, Description, out this.ID_vac);
            else//Изменение данных о вакансии
                this.control.CVacancy.UpdateVacancy(this.ID_vac, VacName, post, Description);

            if (chB_requiredKoef.Checked)
            {
                for (int i = 0; i < this.dataGV_requiredKoef.RowCount - 1; i++)
                {
                    //Добавление коэффициента
                    string skill = this.dataGV_requiredKoef.Rows[i].Cells[0].Value.ToString();
                    float requiredKoef;
                    if (float.TryParse(this.dataGV_requiredKoef.Rows[i].Cells[1].Value.ToString(), out requiredKoef))
                        this.control.CVacancy.AddRequiredKoef(this.ID_vac, skill, requiredKoef);
                }
            }
            this.Close();
        }

        private void b_Close_Click(object sender, EventArgs e)
        { this.Close(); }

        private void chB_requiredKoef_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_requiredKoef.Checked)
            {
                this.dataGV_requiredKoef.Visible = true;
                this.dataGV_requiredKoef.DataSource = this.control.CVacancy.GetRequiredKoef(this.ID_vac);
            }
            else this.dataGV_requiredKoef.Visible = false;
        }
    }
}
