using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OccupationСhoice.Model;

namespace OccupationСhoice
{
    public partial class MainControl
    {
        DataManager manager;
        ControlStudent cStudent;
        ControlSubject cSubject;
        ControlSkill cSkill;
        ControlVacancy cVacancy;

        public MainControl()
        {
            this.manager = new DataManager("master.dbo");
            this.manager.CreateDataBase();
            this.cStudent = new ControlStudent(manager);
            this.cSubject = new ControlSubject(manager);
            this.cSkill = new ControlSkill(manager);
            this.cVacancy = new ControlVacancy(manager);
        }

        public ControlStudent CStudent
        { get { return this.cStudent; } }

        public ControlSubject CSubject
        { get { return this.cSubject; } }

        public ControlSkill CSkill
        { get { return this.cSkill; } }

        public ControlVacancy CVacancy
        { get { return this.cVacancy; } }


        public DataTable GetTable(string T)
        { return this.manager.SelectQuery("SELECT * FROM " + T); }

        public bool GetUser(string inLogin, string inPassword)
        {
            string Qstr = String.Format("SELECT * FROM Users WHERE login = '{0}' AND password = '{1}'",inLogin,inPassword);
            if (this.manager.SelectQuery(Qstr).Rows.Count > 0) return true;
            else return false;
        }

        public void AddUser(string inLogin, string inPassword, string inType)
        {
            string Qstr = String.Format("INSERT INTO Users VALUES ('{0}', '{1}', '{2}')", inLogin, inPassword, inType);
            this.manager.MakeQuery(Qstr);
        }
       
        public Matrix[,] GetMatrix(string table1, string table2)
        {
            int n = 0; int m = 0;
            Matrix[,] Matrix = new Matrix[n, m];
            string Qstr = "";
            if (table1 == "Students" && table2 == "Subjects")
            {
                n = this.cStudent.RowsCount();
                m = this.cSubject.RowsCount();
                Matrix = new Matrix[n, m];
                Qstr = "SELECT * FROM StudSub ORDER BY StudSub.id_stud, StudSub.id_sub";
            }
            else
                if (table1 == "Subjects" && table2 == "Skills")
                {
                    n = this.cSubject.RowsCount();
                    m = this.cSkill.RowsCount();
                    Matrix = new Matrix[n, m];
                    Qstr = "SELECT * FROM SubSkill ORDER BY SubSkill.id_sub, SubSkill.id_skill";
                }
                else
                    if (table1 == "Skills" && table2 == "Vacancies")
                    {
                        n = this.cSkill.RowsCount();
                        m = this.cVacancy.RowsCount();
                        Matrix = new Matrix[n, m];
                        Qstr = "SELECT * FROM SkillVac ORDER BY SkillVac.id_skill, SkillVac.id_vac";
                    }

            DataTable table = this.manager.SelectQuery(Qstr);
            int idMin = int.Parse(table.Rows[0][0].ToString());//минимальный id
            int row = 0;//индекс строки для заполения матрицы
            int col = 0;//индекс столбца для заполнения матрицы

            for (int i = 0; i < table.Rows.Count; i++)//идем по таблице данных
            {
                if (int.Parse(table.Rows[i][0].ToString()) != idMin)//если id изменился
                {
                    row++; col = 0; //переходим на новую строку матрицы
                    idMin = int.Parse(table.Rows[i][0].ToString()); //запоминаем новый id по которому будем идти
                }
                Matrix[row, col] = new Matrix(idMin, int.Parse(table.Rows[i][1].ToString()), float.Parse(table.Rows[i][2].ToString()));
                col++;
            }
            return Matrix;
        }

    }
}
