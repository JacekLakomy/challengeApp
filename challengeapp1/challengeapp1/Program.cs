using challengeapp1;

var employee = new Employee("Jacek", "Łakomy");
employee.AddGrade("1");
employee.AddGrade("500");
employee.AddGrade(6);
employee.AddGrade('5');
employee.AddGrade(7.50000005m);
employee.AddGrade(8.655656561165651d);
employee.AddGrade(9L);
var statistics = employee.GetStatistics();
Console.WriteLine($"Max: {statistics.Max:N0}");
Console.WriteLine($"Min: {statistics.Min:N0}");
Console.WriteLine($"Average: {statistics.Average:N2}");