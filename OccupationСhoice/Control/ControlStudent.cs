using System;
using System.Data;

namespace OccupationСhoice
{
    public partial class ControlStudent
    {
        DataManager manager;

        public ControlStudent(DataManager inManager)
        { this.manager = inManager; }

        public bool AddStudent(string inFamily, string inName, string inPatronymic, DateTime indob, DateTime inRealeaseDate, out int idOfNewStudent)
        {
            bool res = true;
            Student student;
            //Получение нового ID
            string QstrGetID = "Select Max(ID) from Students";
            int id = -2;
            if (!int.TryParse(this.manager.SelectScalarQuery(QstrGetID), out id)) { /*Fail!!!*/ }
            idOfNewStudent = id + 1;
            //Создание нового студента
            if (inPatronymic == "" && inRealeaseDate == null)
                student = new Student(idOfNewStudent, inFamily, inName, indob);
            else
            {
                if (inPatronymic == "" && inRealeaseDate != null)
                    student = new Student(idOfNewStudent, inFamily, inName, indob, inRealeaseDate);
                else
                {
                    if (inPatronymic != "" && inRealeaseDate == null)
                        student = new Student(idOfNewStudent, inFamily, inName, inPatronymic, indob);
                    else
                        student = new Student(idOfNewStudent, inFamily, inName, inPatronymic, indob, inRealeaseDate);
                }
            }
            //Добавление нового студента в таблицу
            string Qstr = String.Format("INSERT INTO Students VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", student.ID,
               student.Family, student.Name, student.Patronymic, student.DOB.ToString("dd/MM/yyyy"), student.RealeaseDate.ToString("dd/MM/yyyy"));
            this.manager.MakeQuery(Qstr);
            return res;
        }

        public bool UpdateStudent(int id_Student, string inFamily, string inName, string inPatronymic, DateTime indob, DateTime inRealeaseDate)
        {
            bool res = true;
            Student student;
            //???!!! Поиск студента в списке, а не создание нового?
            if (inPatronymic == "" && inRealeaseDate == null)
                student = new Student(id_Student, inFamily, inName, indob);
            else
            {
                if (inPatronymic == "" && inRealeaseDate != null)
                    student = new Student(id_Student, inFamily, inName, indob, inRealeaseDate);
                else
                {
                    if (inPatronymic != "" && inRealeaseDate == null)
                        student = new Student(id_Student, inFamily, inName, inPatronymic, indob);
                    else
                        student = new Student(id_Student, inFamily, inName, inPatronymic, indob, inRealeaseDate);
                }
            }
            //Изменение строки таблицы
            string Qstr = String.Format("UPDATE Students SET Family = '{0}', Name = '{1}', Patronymic = '{2}', DOB = '{3}', ReleaseDate = '{4}' WHERE ID = {5}",
               student.Family, student.Name, student.Patronymic, student.DOB.ToString("dd/MM/yyyy"), student.RealeaseDate.ToString("dd/MM/yyyy"),student.ID);
            this.manager.MakeQuery(Qstr);
            return res;
        }

        public bool DelStudent(int inIDStudent)
        {
            bool res = true;
            String Qstr = "DELETE FROM Students WHERE Students.ID = " + inIDStudent;
            this.manager.MakeQuery(Qstr);

            Qstr = "DELETE FROM StudSub WHERE StudSub.id_stud = " + inIDStudent;
            this.manager.MakeQuery(Qstr);

            Qstr = "DELETE FROM StudVac WHERE StudVac.id_stud = " + inIDStudent;
            this.manager.MakeQuery(Qstr);
            return res;
        }

        public void GetStudent(int inIDStudent, out string outFamily, out string outName, out string outPatronymic, out DateTime outDOB, out DateTime outRealeaseDate)
        {
            outFamily = ""; outName = ""; outPatronymic = "";
            outDOB = new DateTime(); outRealeaseDate = new DateTime();

            string Qstr = String.Format("SELECT * FROM Students WHERE ID = {0}", inIDStudent);
            DataTable tableInfo = this.manager.SelectQuery(Qstr);
            if (tableInfo.Rows.Count > 0)
            {
                outFamily = tableInfo.Rows[0][1].ToString();
                outName = tableInfo.Rows[0][2].ToString();
                outPatronymic = tableInfo.Rows[0][3].ToString();
                string str = tableInfo.Rows[0][4].ToString();
                if ( str!= "")
                {
                    string[] S = str.Split('.');
                    outDOB = new DateTime(int.Parse(S[2]), int.Parse(S[1]), int.Parse(S[0]));
                }
                str = tableInfo.Rows[0][5].ToString();
                if (str != "")
                {
                    string[] S = str.Split('.');
                    outRealeaseDate = new DateTime(int.Parse(S[2]), int.Parse(S[1]), int.Parse(S[0]));
                }
            }
        }

        public void AddMark(int ID_Student, string subject, float mark)
        {
            try
            {
                string Qstr = String.Format("INSERT INTO StudSub VALUES ({0}, (Select ID from Subjects WHERE Name = '{1}'), {2})",
                    ID_Student, subject, mark.ToString().Replace(',', '.'));
                if (!this.manager.MakeQuery(Qstr))
                {
                    Qstr = String.Format("UPDATE StudSub SET Mark = {0} WHERE id_stud = {1} AND id_sub = (Select ID from Subjects WHERE Name = '{2}')",
                                   mark.ToString().Replace(',', '.'), ID_Student, subject);
                    this.manager.MakeQuery(Qstr);
                }
            }
            catch { }
        }

        public DataTable GetMarks(int Id_Stud)
        {
            string Qstr = String.Format("SELECT Subjects.Name, StudSub.Mark FROM Subjects LEFT OUTER JOIN StudSub ON Subjects.ID = StudSub.id_sub AND StudSub.id_stud = {0}", Id_Stud);
            return this.manager.SelectQuery(Qstr);
        }

        public int RowsCount()
        {
            int count = 0;
            count = int.Parse(this.manager.SelectScalarQuery("SELECT COUNT(*) FROM Students"));
            return count;
        }

        public DataTable GetTableOfStudents()
        {
            string Qstr = "SELECT ID, Family, Name, Patronymic FROM Students";
            return this.manager.SelectQuery(Qstr);
        }

        public string GetNameByID(int IDStudent)
        {
            string name = "";
            string Qstr = "SELECT Family, Name, Patronymic FROM Students WHERE Students.ID = " + IDStudent;
            DataTable t = this.manager.SelectQuery(Qstr);
            name = String.Format("{0} {1} {2}", t.Rows[0][0], t.Rows[0][1], t.Rows[0][2]);
            return name;
        }
    }
}
