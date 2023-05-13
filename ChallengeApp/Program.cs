

var name1 = "Monika";
var age = 25;
var plec = "kobieta";

if (name1 == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (plec != "kobieta" && age < 18)
{
    Console.WriteLine("Nepelnoletni mezczyzna");
}
else if (plec == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");

}
else
{
    Console.WriteLine("Nie wiem kim jestes");
}


