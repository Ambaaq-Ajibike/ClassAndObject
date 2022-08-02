using System;

namespace CLASSWORK
{
    class Students
    {
        public string Name;
        public int MathScore;
        public int EngScore;
        public int TotalScore;
        public double AverageScore;
        public Students(){}
        public Students(string name, int mathscore, int engScore)
        {
            Name = name;
            MathScore = mathscore;
            EngScore = engScore;
            TotalScore = MathScore + EngScore;
            AverageScore = TotalScore / 2.0; 
        }
    }
}
