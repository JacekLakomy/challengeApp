using challengeapp1;

var employee = new Employee("Jacek", "Łakomy");
employee.AddGrade(-5);
employee.AddGrade(0);
employee.AddGrade(1);
var statistics = employee.GetStatistics();
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");