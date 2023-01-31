using challengeapp1;

Employee employee1 = new Employee("Jacek", "Łakomy");
Employee employee2 = new Employee("Stefan", "Burczymucha");
Employee employee3 = new Employee("Beata", "Garbata");

//ocena1
employee1.AddRating(4);
employee2.AddRating(2);
employee3.AddRating(3);

//ocena2
employee1.AddRating(4);
employee2.AddRating(7);
employee3.AddRating(9);

//ocena3
employee1.AddRating(5);
employee2.AddRating(5);
employee3.AddRating(6);

//ocena4
employee1.AddRating(3);
employee2.AddRating(1);
employee3.AddRating(7);

//ocena5
employee1.AddRating(5);
employee2.AddRating(2);
employee3.AddRating(4);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

var bestResult = employees.Max(Employee => Employee.Result);

Employee personWithBestResult = employees[0];
foreach (Employee employee in employees)
    if (employee.Result > personWithBestResult.Result)
    {
        personWithBestResult = (Employee)employee;
    }

Console.WriteLine("Najwyższa ocena:" + " " + bestResult);
Console.WriteLine(personWithBestResult.Name + " " + personWithBestResult.Surname);