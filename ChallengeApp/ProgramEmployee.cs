using ChallengeApp;

Console.WriteLine("Welcome in DBS.We trust your opinion.");
Console.WriteLine("________________________________________");
Console.WriteLine("");

var employee1 = new Employee("Mike", "Tyson");


while (true)

{
    Console.WriteLine("Please enter the value for emploeyee");
    Console.Write("Press q to close. Thank you!! ");
    var employeeInput = Console.ReadLine();
    if (employeeInput == "q")
    {
        break;
    }
    employee1.AddGrade(employeeInput);
}

var statistics = employee1.GetStatistics();
Console.WriteLine($" Employee average : {statistics.Average}");
Console.WriteLine($" Employee Min : {statistics.Min}");
Console.WriteLine($" Employee Max : {statistics.Max}");











