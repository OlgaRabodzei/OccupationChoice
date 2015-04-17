using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OccupationСhoice.View.Skill
{
    public partial class WindowAddSkill : Form
    {
        private MainControl control;
        private int ID_skill= -1;

        public WindowAddSkill(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        public WindowAddSkill(MainControl inControl, int id_skill)
        {
            InitializeComponent();
            this.control = inControl;
            this.ID_skill = id_skill;
            string SkName; string Description;
            this.control.CSkill.GetSkill(id_skill, out SkName, out Description);

            this.tB_SkName.Text = SkName;
            this.rTB_Description.Text = Description;
        }

        private void b_AddSkill_Click(object sender, EventArgs e)
        {
            string SkName = tB_SkName.Text;
            string Description = rTB_Description.Text;
            if (this.ID_skill == -1)
                this.control.CSkill.AddSkill(SkName, Description, out this.ID_skill);
            else
                this.control.CSkill.UpdateSkill(ID_skill, SkName, Description);

            this.Close();
        }

        private void b_Close_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
