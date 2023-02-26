using challengeapp1;

Console.WriteLine(" PROGRAM DO GROMADZENIA OCEN PRACOWNIKÓW");
Console.WriteLine("<======================================================================================>");
Console.WriteLine();
Console.WriteLine("Aby zakończyć pracę programu, wprowadź q lub Q");

var employee = new EmployeeInFile("Jacek", "Łakomy");

employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}
while (true)
{
    Console.WriteLine($"Podaj ocenę dla: {employee.Name} {employee.Surname}");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);     
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }    
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Statystyki dla pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"Max: {statistics.Max:N0}");
Console.WriteLine($"Min: {statistics.Min:N0}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average as Letter: {statistics.AverageLetter}");