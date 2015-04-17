using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OccupationСhoice
{
    public partial class ControlSubject
    {
        DataManager manager;

        public ControlSubject(DataManager inManager)
        { this.manager = inManager; }

        public bool AddSubject(string inName, string inHours, out int idOfNewSubject)
        {
            bool res = true;
            Subject subject;
            //Получение нового ID
            string QstrGetID = "Select Max(ID) from Subjects";
            int id = -2;
            if (!int.TryParse(this.manager.SelectScalarQuery(QstrGetID), out id)) { /*Fail!!!*/ }
            idOfNewSubject = id + 1;
            //Создание нового предмета
            int hours;
            if (int.TryParse(inHours, out hours)) subject = new Subject(idOfNewSubject, inName, hours);
            else subject = new Subject(idOfNewSubject, inName);
            //Добавление в таблицу
            string Qstr = String.Format("INSERT INTO Subjects VALUES ({0}, '{1}', {2})",
               subject.ID, subject.Name, subject.Hours);
            manager.MakeQuery(Qstr);
            return res;
        }

        public void GetSubject(int inIDSubject, out string outName, out string outHours)
        {
            outName = ""; outHours = "";

            string Qstr = String.Format("SELECT * FROM Subjects WHERE Subjects.ID = {0}", inIDSubject);
            DataTable tableInfo = this.manager.SelectQuery(Qstr);
            if (tableInfo.Rows.Count > 0)
            {
                outName = tableInfo.Rows[0][1].ToString();
                outHours = tableInfo.Rows[0][2].ToString();
            }
        }

        public bool DelSubject(int inIDSubject)
        {
            bool res = true;
            string Qstr = "DELETE FROM Subjects WHERE Subjects.ID = " + inIDSubject;
            manager.MakeQuery(Qstr);

            Qstr = "DELETE FROM StudSub WHERE StudSub.id_sub = " + inIDSubject;
            manager.MakeQuery(Qstr);

            Qstr = "DELETE FROM SubSkill WHERE SubSkill.id_sub = " + inIDSubject;
            manager.MakeQuery(Qstr);
            return res;
        }

        public bool UpdateSubject(int id_Subject, string inName, string inHours)
        {
            bool res = true;
            Subject subject;
            //???!!!!
            int hours;
            if (int.TryParse(inHours, out hours)) subject = new Subject(id_Subject, inName, hours);
            else subject = new Subject(id_Subject, inName);
            //Изменение строки таблицы
            string Qstr = String.Format("UPDATE Subjects SET Name = '{0}', Hours = {1} WHERE ID = {2}",
               subject.Name, subject.Hours, subject.ID);
            manager.MakeQuery(Qstr);
            return res;
        }

        //public DataTable GetAtribute(string atributeName)
        //{
        //    string Qstr = String.Format("SELECT {0} FROM Subjects", atributeName);
        //    return manager.SelectQuery(Qstr);
        //}

        public DataTable GetDevKoef(int Id_Sub)
        {
            string Qstr = String.Format("SELECT Skills.Name, SubSkill.devKoef FROM Skills LEFT OUTER JOIN SubSkill ON Skills.ID = SubSkill.id_skill AND SubSkill.id_sub = {0}", Id_Sub);
            return this.manager.SelectQuery(Qstr);
        }

        public void AddDevKoef(int ID_Subject, string skill, float devKoef)
        {
            try
            {
                string Qstr = String.Format("INSERT INTO SubSkill VALUES ({0}, (Select ID from Skills WHERE Name = '{1}'), {2})",
                    ID_Subject, skill, devKoef.ToString().Replace(',','.'));
                if (!this.manager.MakeQuery(Qstr))
                {
                    Qstr = String.Format("UPDATE SubSkill SET devKoef = {0} WHERE id_sub = {1} AND id_skill = (Select ID from Skills WHERE Name = '{2}')",
                                   devKoef.ToString().Replace(',', '.'), ID_Subject, skill);
                    this.manager.MakeQuery(Qstr);
                }
            }
            catch { }
        }

        public int RowsCount()
        {
            int count = 0;
            count = int.Parse(this.manager.SelectScalarQuery("SELECT COUNT(*) FROM Subjects"));
            return count;
        }
    }
}
