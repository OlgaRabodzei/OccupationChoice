using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OccupationСhoice
{
    public partial class ControlVacancy
    {
        DataManager manager;

        public ControlVacancy(DataManager inManager)
        { this.manager = inManager; }

        public bool AddVacancy(string inName, string inPost, string inDescription, out int idOfNewVacancy)
        {
            bool res = true;
            Vacancy vacancy;
            //Получение нового ID
            string QstrGetID = "Select Max(ID) from Vacancies";
            int id = -2;
            if (!int.TryParse(this.manager.SelectScalarQuery(QstrGetID), out id)) { /*Fail!!!*/ }
            idOfNewVacancy = id + 1;
            //Создание новой вакансии
            if (inDescription == "") vacancy = new Vacancy(idOfNewVacancy, inName, inPost);
            else vacancy = new Vacancy(idOfNewVacancy, inName, inPost, inDescription);
            //Добавление в таблицу
            string Qstr = String.Format("INSERT INTO Vacancies VALUES ({0}, '{1}', '{2}', '{3}')",
               vacancy.ID, vacancy.Name, vacancy.Post, vacancy.Description);
            manager.MakeQuery(Qstr);
            return res;
        }

        public void GetVacancy(int inIDVacancy, out string outName, out string outPost, out string outDescription)
        {
            outName = ""; outPost = ""; outDescription = "";

            string Qstr = String.Format("SELECT * FROM Vacancies WHERE Vacancies.ID = {0}", inIDVacancy);
            DataTable tableInfo = this.manager.SelectQuery(Qstr);
            if (tableInfo.Rows.Count > 0)
            {
                outName = tableInfo.Rows[0][1].ToString();
                outPost = tableInfo.Rows[0][2].ToString();
                outDescription = tableInfo.Rows[0][3].ToString();
            }
        }

        public bool DelVacancy(int inIDVacancy)
        {
            bool res = true;
            String Qstr = "DELETE FROM Vacancies WHERE Vacancies.ID = " + inIDVacancy;
            manager.MakeQuery(Qstr);

            Qstr = "DELETE FROM SkillVac WHERE SkillVac.id_vac = " + inIDVacancy;
            manager.MakeQuery(Qstr);

            Qstr = "DELETE FROM StudVac WHERE StudVac.id_vac = " + inIDVacancy;
            manager.MakeQuery(Qstr);
            return res;
        }

        public bool UpdateVacancy(int id_Vacancy, string inName, string inPost, string inDescription)
        {
            bool res = true;
            Vacancy vacancy;
            //???!!!!
            if (inDescription == "") vacancy = new Vacancy(id_Vacancy, inName, inPost);
            else vacancy = new Vacancy(id_Vacancy, inName, inPost, inDescription);
            //Изменение строки таблицы
            string Qstr = String.Format("UPDATE Vacancies SET Name = '{0}', Post = '{1}', Description = '{2}' WHERE Vacancies.ID = {3}",
               vacancy.Name, vacancy.Post, vacancy.Description, vacancy.ID);
            manager.MakeQuery(Qstr);
            return res;
        }

        public DataTable GetRequiredKoef(int Id_Vac)
        {
            string Qstr = String.Format("SELECT Skills.Name, SkillVac.requiredKoef FROM Skills LEFT OUTER JOIN SkillVac ON Skills.ID = SkillVac.id_skill AND SkillVac.id_vac = {0}", Id_Vac);
            return this.manager.SelectQuery(Qstr);
        }

        public void AddRequiredKoef(int ID_Vacancy, string skill, float requiredKoef)
        {
            try
            {
                string Qstr = String.Format("INSERT INTO SkillVac VALUES ((Select Skills.ID from Skills WHERE Skills.Name = '{0}'), {1} ,{2})",
                    skill, ID_Vacancy, requiredKoef.ToString().Replace(',', '.'));
                if (!this.manager.MakeQuery(Qstr))
                {
                    Qstr = String.Format("UPDATE SkillVac SET requiredKoef = {0} WHERE id_vac = {1} AND id_skill = (Select Skills.ID from Skills WHERE Skills.Name = '{2}')",
                                   requiredKoef.ToString().Replace(',', '.'), ID_Vacancy, skill);
                    this.manager.MakeQuery(Qstr);
                }
            }
            catch { }
        }

        public int RowsCount()
        {
            int count = 0;
            count = int.Parse(this.manager.SelectScalarQuery("SELECT COUNT(*) FROM Vacancies"));
            return count;
        }

        public string GetNameByID(int IDVacancy)
        {
            string name = "";
            string Qstr = "SELECT Name FROM Vacancies WHERE Vacancies.ID = " + IDVacancy;
            name = this.manager.SelectScalarQuery(Qstr);
            return name;
        }

        public DataTable GetTableOfVacancies()
        {
            string Qstr = "SELECT ID, Name FROM Vacancies";
            return this.manager.SelectQuery(Qstr);
        }
    }
}
