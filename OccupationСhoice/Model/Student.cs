using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OccupationСhoice
{
    public partial class Student
    {
        private int id_student;
        private string family;
        private string name;
        private string patronymic;
        private DateTime dob;
        private DateTime realeaseDate;

        public Student(int inID, string inFamily, string inName, DateTime indob)
        {
            this.id_student = inID;
            this.family = inFamily;
            this.name = inName;
            this.dob = indob;
        }
        public Student(int inID, string inFamily, string inName, string inPatronymic, DateTime indob)
        {
            this.id_student = inID;
            this.family = inFamily;
            this.name = inName;
            this.patronymic = inPatronymic;
            this.dob = indob;
        }
        public Student(int inID, string inFamily, string inName, DateTime indob, DateTime inRealeaseDate)
        {
            this.id_student = inID;
            this.family = inFamily;
            this.name = inName;
            this.dob = indob;
            this.realeaseDate = inRealeaseDate;
        }
        public Student(int inID, string inFamily, string inName, string inPatronymic, DateTime indob, DateTime inRealeaseDate)
        {
            this.id_student = inID;
            this.family = inFamily;
            this.name = inName;
            this.patronymic = inPatronymic;
            this.dob = indob;
            this.realeaseDate = inRealeaseDate;
        }
        

        public int ID
        {
            get { return this.id_student; }
            set { this.id_student = value; }
        }

        public string Family
        {
            get { return this.family; }
            set { this.family = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Patronymic
        {
            get { return this.patronymic; }
            set { this.patronymic = value; }
        }

        public DateTime DOB
        {
            get { return this.dob; }
            set { this.dob = value; }
        }

        public DateTime RealeaseDate
        {
            get { return this.realeaseDate; }
            set { this.realeaseDate = value; }
        }
    }
}
