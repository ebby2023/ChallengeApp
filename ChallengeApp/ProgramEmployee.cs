using ChallengeApp;

var employee1 = new Employee("Michal", "Materla");
employee1.AddGrade("Adam");
employee1.AddGrade("4000");
employee1.AddGrade(35f);
employee1.AddGrade(4);
employee1.AddGrade(2);




//var statistics1 = employee1.GetStatistics();

//Console.WriteLine($"Average: {statistics1.Average:N2}");
//Console.WriteLine($"Max: {statistics1.Max}");
//Console.WriteLine($"Min: {statistics1.Min}");

var statistick2 = employee1.GetStatistickWithLoopForeach();

Console.WriteLine("");

Console.WriteLine("Statisticks with loop foreach");
Console.WriteLine("-----------------");
Console.WriteLine($"Average : {statistick2.Average:N2}");
Console.WriteLine($"Max : {statistick2.Max}");
Console.WriteLine($"Min : {statistick2.Min}");

Console.WriteLine("");

var statistick3 = employee1.GetStatistickWithLoopFor();
Console.WriteLine("Statisticks with loop for");
Console.WriteLine("-----------------");
Console.WriteLine($"Average : {statistick2.Average:N2}");
Console.WriteLine($"Max : {statistick2.Max}");
Console.WriteLine($"Min : {statistick2.Min}");

Console.WriteLine("");

var statistick4 = employee1.GetStatistickWithDoWhile();
Console.WriteLine("Statisticks with do while");
Console.WriteLine("-----------------");
Console.WriteLine($"Average : {statistick2.Average:N2}");
Console.WriteLine($"Max : {statistick2.Max}");
Console.WriteLine($"Min : {statistick2.Min}");

Console.WriteLine("");

var statistick5 = employee1.GetStatistickWithWhile();
Console.WriteLine("Statisticks with while");
Console.WriteLine("-----------------");
Console.WriteLine($"Average : {statistick2.Average:N2}");
Console.WriteLine($"Max : {statistick2.Max}");
Console.WriteLine($"Min : {statistick2.Min}");