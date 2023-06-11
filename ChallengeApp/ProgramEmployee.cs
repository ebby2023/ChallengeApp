using ChallengeApp;

var employee1 = new Employee("Michal", "Materla");
employee1.AddGrade(4);
employee1.AddGrade(3);
employee1.AddGrade(6);
employee1.AddGrade(4);
employee1.AddGrade(7);

var statistics1 = employee1.GetStatistics();

Console.WriteLine($"Average1: {statistics1.Average:N1}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");