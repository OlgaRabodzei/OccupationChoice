using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OccupationСhoice
{
    public partial class Vacancy
    {
        private int id_vacancy;
        private string name;
        private string post;
        private string description;

        public Vacancy(int inID ,string inName, string inPost)
        { this.id_vacancy = inID; this.name = inName; this.post = inPost; }
        public Vacancy(int inID, string inName, string inPost, string inDescription)
        {
            this.id_vacancy = inID;
            this.name = inName;
            this.post = inPost;
            this.description = inDescription;
        }

        public int ID
        {
            get { return this.id_vacancy; }
            set { this.id_vacancy = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Post
        {
            get { return this.post; }
            set { this.post = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
    }
}
