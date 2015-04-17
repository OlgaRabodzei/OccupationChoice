using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OccupationСhoice
{
    public partial class ControlSkill
    {
        DataManager manager;

        public ControlSkill(DataManager inManager)
        { this.manager = inManager; }

        public bool AddSkill(string inName, string inDescription, out int idOfNewSkill)
        {
            bool res = true;
            Skill skill;
             //Получение нового ID
            string QstrGetID = "Select Max(ID) from Skills";
            int id = -2;
            if (!int.TryParse(this.manager.SelectScalarQuery(QstrGetID), out id)) { /*Fail!!!*/ }
            idOfNewSkill = id + 1;
            //Создание нового навыка
            if (inDescription == "") skill = new Skill(idOfNewSkill,inName);
            else skill = new Skill(idOfNewSkill,inName, inDescription);

            string Qstr = String.Format("INSERT INTO Skills VALUES ({0}, '{1}', '{2}')",
               skill.ID, skill.Name, skill.Description);
            manager.MakeQuery(Qstr);
            return res;
        }

        public bool UpdateSkill(int id_skill, string inName, string inDescription)
        {
            bool res = true;
            Skill skill;
            //?!!
            if (inDescription == "") skill = new Skill(id_skill, inName);
            else skill = new Skill(id_skill, inName, inDescription);

           //Изменение строки таблицы
            string Qstr = String.Format("UPDATE Skills SET Name = '{0}', Description = '{1}' WHERE ID = {2}",
              skill.Name, skill.Description, skill.ID);
            manager.MakeQuery(Qstr);
            return res;
        }

        public bool DelSkill(int inIDSkill)
        {
            bool res = true;
            String Qstr = "DELETE FROM Skills WHERE Skills.ID = " + inIDSkill;
            manager.MakeQuery(Qstr);

            Qstr = "DELETE FROM SubSkill WHERE SubSkill.id_skill = " + inIDSkill;
            manager.MakeQuery(Qstr);

            Qstr = "DELETE FROM SkillVac WHERE SkillVac.id_skill = " + inIDSkill;
            manager.MakeQuery(Qstr);

            return res;
        }

        public void GetSkill(int inIDSkill, out string outName, out string outDescription)
        {
            outName = ""; outDescription = "";

            string Qstr = String.Format("SELECT * FROM Skills WHERE ID = {0}", inIDSkill);
            DataTable tableInfo = this.manager.SelectQuery(Qstr);
            if (tableInfo.Rows.Count > 0)
            {
                outName = tableInfo.Rows[0][1].ToString();
                outDescription = tableInfo.Rows[0][2].ToString();
            }
        }

        public int RowsCount()
        {
            int count = 0;
            count = int.Parse(this.manager.SelectScalarQuery("SELECT COUNT(*) FROM Skills"));
            return count;
        }
    }
}
