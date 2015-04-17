using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OccupationСhoice
{
    public partial class Skill
    {
        private int id_skill;
        private string name;
        private string description;

        public Skill(int inID, string inName) { this.id_skill = inID; this.name = inName; }
        public Skill(int inID,string inName, string inDescription)
        {
            this.id_skill = inID;
            this.name = inName;
            this.description = inDescription;
        }

        public int ID
        {
            get { return this.id_skill; }
            set { this.id_skill = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
    }
}
