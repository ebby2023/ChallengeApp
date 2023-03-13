using ChallegeApp;
using System.Net.Cache;

Employee employee1= new Employee("Mike","Wedler", 33);
Employee employee2= new Employee("Cris","Strong",43);
Employee employee3= new Employee("Elizabeth","Sun",27);

employee1.AddScore(4);
employee1.AddScore(3);
employee1.AddScore(2);
employee1.AddScore(7);
employee1.AddScore(4);

employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(1);
employee2.AddScore(2);

employee3.AddScore(5);
employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(5);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var Employee in employees)
{
    if (Employee.Result > maxResult)
        employeeWithMaxResult = Employee;
        maxResult = Employee.Result;
}

Console.WriteLine("Pracownik z najwieksza liczba punktow to:" + employeeWithMaxResult.Name +  maxResult  + "punktow");
Console.WriteLine("Wiek" + employeeWithMaxResult.Age + "nazwisko" + employeeWithMaxResult.Surname);

