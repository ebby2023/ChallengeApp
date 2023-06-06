using ChallengeApp;

Employee employee1 = new Employee("Marian", "Duzy", 15);
Employee employee2 = new Employee("Michal", "Stepien", 18);
Employee employee3 = new Employee("Lukasz", "Swirek", 23);
Employee employee4 = new Employee("Mike", "Sweet", 52);


employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(2);

employee2.AddScore(5);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(9);
employee2.AddScore(9);

employee3.AddScore(3);
employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(3);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{ employee3 , employee2 , employee3};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }


}

Console.WriteLine($"Pracownik z najwieksza liczba punktow to: " +
    $"{employeeWithMaxResult.Name} {employeeWithMaxResult.Surname}" +
    $" lat {employeeWithMaxResult.Age}");



