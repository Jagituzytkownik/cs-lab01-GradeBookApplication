using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace GradeBook.GradeBooks
{
    public class RankedGradeBook :BaseGradeBook
    {

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                System.Console.Write("Ranked grading requires at least 5 students.");
            }
            else
            {

                base.CalculateStatistics();
            }
            
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                System.Console.Write("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);

            }

        }
        public override char GetLetterGrade(double averageGrade)
        {
            
            if (Students.Count < 5)
            { throw new InvalidOperationException(); }
                //rozwiązania tego problemu jest ustalenie, ilu uczniów stanowi 20%,
                //a następnie przejrzenie wszystkich ocen i sprawdzenie, ilu uzyskało 
                //wyniki wyższe niż średnia wejściowa. Każdy N uczniów, dla których N 
                //to 20%, upuszcza ocenę literową. )
                //-Return B if the input grade is between the top 20 and 40 % of the class.
                //- Return C if the input grade is between the top 40 and 60% of the class.
                //- Return D if the input grade is between the top 60 and 80% of the class.
                //- Return F if the grade is below the top 80% of the class.
                if (averageGrade > 80)
                {
                    return 'A';
                }
                else if (averageGrade > 60)
                {
                    return 'B';
                }
                else if (averageGrade > 40)
                {
                    return 'C';
                }
                else if(averageGrade > 20)
                {
                    return 'D';
                }

                
                
            return 'F';
        }
        public RankedGradeBook(string name, bool IsWeight) : base(name,IsWeight)
            {
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
