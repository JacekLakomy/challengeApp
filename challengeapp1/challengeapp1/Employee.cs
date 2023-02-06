using System;
using System.Diagnostics;

namespace challengeapp1
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }
        }

        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(decimal grade)
        {
            {
                this.AddGrade((float)grade);
            }
        }

        public void AddGrade(double grade)
        {
            {
                this.AddGrade((float)grade);
            }
        }

        public void AddGrade(long grade)
        {
            {
                this.AddGrade((float)grade);
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
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics1.Max = Math.Max(statistics1.Max, grade);
                    statistics1.Min = Math.Min(statistics1.Min, grade);
                    statistics1.Average += grade;
                }
            }
            statistics1.Average /= this.grades.Count;
            return statistics1;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            statistics2.Average = 0;

            for (var i = 0; i < grades.Count; i++)
            {
                statistics2.Max = Math.Max(statistics2.Max, grades[i]);
                statistics2.Min = Math.Min(statistics2.Min, grades[i]);
                statistics2.Average += grades[i];
            }
            statistics2.Average /= this.grades.Count;
            return statistics2;

        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            statistics3.Average = 0;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index]);
                statistics3.Average += this.grades[index];
                index++;
            }
            statistics3.Average /= this.grades.Count;
            return statistics3;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;
            statistics4.Average = 0;
            var index = 0;

            do
            {
                statistics4.Max = Math.Max(statistics4.Max, this.grades[index]);
                statistics4.Min = Math.Min(statistics4.Min, this.grades[index]);
                statistics4.Average += this.grades[index];
                index++;
            }
            while (index < this.grades.Count);

            statistics4.Average /= this.grades.Count;
            return statistics4;
        }
    }
}
