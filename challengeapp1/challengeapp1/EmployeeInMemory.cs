using System;
using System.Diagnostics;

namespace challengeapp1
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (InvokeGradeAdded != null)
                {
                    InvokeGradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Wprowadź liczbę z przediału <0;100>");
            }

        }

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
                case "A":
                case "a":
                    this.grades.Add(100);
                    break;
                case "B":
                case "b":
                    this.grades.Add(80);
                    break;
                case "C":
                case "c":
                    this.grades.Add(60);
                    break;
                case "D":
                case "d":
                    this.grades.Add(40);
                    break;
                case "E":
                case "e":
                    this.grades.Add(20);
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade(result);
                    }
                    else
                    {
                        throw new Exception("Wprowadź liczbę z przediału <0;100> lub literę od A(a) do E(e)");
                    }
                    break;
            }
        }

        public override void AddGrade(double grade)
        {
            {
                this.AddGrade((float)grade);
            }
        }

        public override void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(char grade)
        {
            this.AddGrade(grade.ToString());
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
