using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OccupationСhoice.Model
{
  public partial class FuzzyRelations
    {
        private MainControl control;

        public FuzzyRelations(MainControl inControl)
        {
            this.control = inControl;
            MatrixOfMarks = this.control.GetMatrix("Students", "Subjects");
            MatrixOfDevKoef = this.control.GetMatrix("Subjects", "Skills");
            MatrixOfRequiredKoef = this.control.GetMatrix("Skills", "Vacancies");
        }

        public Matrix[,] MatrixOfMarks { get; set; }
        public Matrix[,] MatrixOfDevKoef { get; set; }
        public Matrix[,] MatrixOfRequiredKoef { get; set; }

        public Matrix[,] Multy(Matrix[,] M1, Matrix[,] M2)
        {
            Matrix[,] Rezult = new Matrix[0, 0];
            if (M1.GetLength(1) == M2.GetLength(0))//Если форма матриц согласована
            {
               Rezult = new Matrix[M1.GetLength(0), M2.GetLength(1)];
                for (int i = 0; i < M1.GetLength(0); i++)
                {
                    for (int j = 0; j < M2.GetLength(1); j++)
                    {
                        List<float> s = new List<float>();
                        for (int k = 0; k < M1.GetLength(1); k++)
                            s.Add(Math.Min(M1[i, k].Koef, M2[k, j].Koef));
                        Rezult[i, j] = new Matrix();
                        Rezult[i, j].Koef = s.Max();
                        //???
                        Rezult[i, j].RowName = M1[i, 0].RowName;
                        Rezult[i, j].ColName = M2[0, j].ColName;
                    }
                }
            }
            return Rezult;
        }

        public Matrix[,] Algorithm()
        {
            Matrix[,] Result = new Matrix[0, 0];
            Result = Multy(this.MatrixOfMarks, this.MatrixOfDevKoef);
            Result = Multy(Result, this.MatrixOfRequiredKoef);
            return Result;
        }
    }
}
