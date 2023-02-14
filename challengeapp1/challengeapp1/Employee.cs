using System;
using System.Diagnostics;

namespace challengeapp1
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee()
            : base()
        {
            this.Position = ("NA");
        }
        
        public Employee(string name, string surname)
            : base(name, surname)
        {
            this.Position = ("NA");
        }

        public Employee(string name, string surname, string position, float earnings)
            :base(name, surname)
        {
            this.Position= position;
            this.Earnings= earnings;
        }

        public Employee(string name, string surname, char sex, int age, string position, float earnings)
            : base (name, surname, sex, age)
        {
            this.Position = position;
            this.Earnings = earnings;
        }

        public string Position { get; private set; }
        public float Earnings { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Wprowadź liczbę z przediału <0-100> lub literę od A(a) do E(e)");
            }
        }

        public void AddGrade(string grade)
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
                        throw new Exception("Wprowadź liczbę z przediału <0-100> lub literę od A(a) do E(e)");
                    }
                    break;
            }
        }

        public Statistics GetStatistics()
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
