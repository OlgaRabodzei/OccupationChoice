using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OccupationСhoice
{
    public partial class Subject
    {
        private int id_subject;
        private string name;
        private int hours;

        public Subject(int inID, string inName)
        { this.id_subject = inID; this.name = inName; }

        public Subject(int inID, string inName, int inHours)
        {
            this.id_subject = inID;
            this.name = inName;
            this.hours = inHours;
        }

        public int ID
        {
            get { return this.id_subject; }
            set { this.id_subject = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Hours
        {
            get { return this.hours; }
            set { if (value > 0) this.hours = value; }
        }
    }
}
