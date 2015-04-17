using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OccupationСhoice.Model
{
   public class Matrix
    {
        private int rowName;
        private int colName;
        private float koef;

        public Matrix()
        { this.rowName = -1; this.colName = -1; this.koef = -1; }

        public Matrix(int inRowName, int inColName, float inKoef)
        {
            this.rowName = inRowName;
            this.colName = inColName;
            this.koef = inKoef;
        }

        public int RowName
        {
            get { return this.rowName; }
            set { this.rowName = value; }
        }

        public int ColName
        {
            get { return this.colName; }
            set { this.colName = value; }
        }

        public float Koef
        {
            get { return this.koef; }
            set { this.koef = value; }
        }
    }
}
