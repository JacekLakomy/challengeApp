using challengeapp1;

Console.WriteLine(" PROGRAM DO GROMADZENIA OCEN PRACOWNIKÓW");
Console.WriteLine("<======================================================================================>");
Console.WriteLine();

var employee = new Employee("Jacek", "Łakomy");

while (true)
{
    Console.WriteLine("Podaj ocenę dla: Jacek  Łakomy");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Statystyki dla pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"Max: {statistics.Max:N0}");
Console.WriteLine($"Min: {statistics.Min:N0}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average as Letter: {statistics.AverageLetter}");