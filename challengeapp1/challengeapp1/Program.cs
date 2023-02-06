using challengeapp1;

var employee = new Employee("Jacek", "Łakomy");
employee.AddGrade("1");
employee.AddGrade("99");
employee.AddGrade(6);
employee.AddGrade('5');
employee.AddGrade(7.50000005m);
employee.AddGrade(8.655656561165651d);
employee.AddGrade(9L);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("statystyki z petli foreach:");
Console.WriteLine($"Max: {statistics1.Max:N0}");
Console.WriteLine($"Min: {statistics1.Min:N0}");
Console.WriteLine($"Average: {statistics1.Average:N2}");

Console.WriteLine("statystyki z pętli for:");
Console.WriteLine($"Max: {statistics2.Max:N0}");
Console.WriteLine($"Min: {statistics2.Min:N0}");
Console.WriteLine($"Average: {statistics2.Average:N2}");

Console.WriteLine("statystyki z pętli while:");
Console.WriteLine($"Max: {statistics3.Max:N0}");
Console.WriteLine($"Min: {statistics3.Min:N0}");
Console.WriteLine($"Average: {statistics3.Average:N2}");

Console.WriteLine("statystyki z pętli do while:");
Console.WriteLine($"Max: {statistics4.Max:N0}");
Console.WriteLine($"Min: {statistics4.Min:N0}");
Console.WriteLine($"Average: {statistics4.Average:N2}");