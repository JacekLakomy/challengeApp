using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Linq;

namespace challengeapp1
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {

                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
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
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(100);
                    }
                    break;
                case "B":
                case "b":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(80);
                    }
                    break;
                case "C":
                case "c":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(60);
                    }
                    break;
                case "D":
                case "d":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(40);
                    }
                    break;
                case "E":
                case "e":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(20);
                    }
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(result);
                        }
                    }
                    else
                    {
                        throw new Exception("Wprowadź liczbę z przediału <0-100> lub literę od A(a) do E(e)");
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
            var gradesFromFile = this.ReadGradesFromFile();
            var statistics = new Statistics();

            foreach (var grade in gradesFromFile)
            {
                statistics.AddStatistics(grade);
            }
            
            return statistics;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        float number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        } 
    }
}
