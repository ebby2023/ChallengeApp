using ChallengeApp;

var employee1 = new Employee("Michal", "Materla");
employee1.AddGrade("Adam");
employee1.AddGrade("4000");
employee1.AddGrade(35f);
employee1.AddGrade(4);
employee1.AddGrade(2);




var statistics1 = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics1.Average:N1}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");