string name = "Ewa";
bool male = true;
bool female = false;

var age = 47;
var age1 = 33;
var age2 = 17;


if (female == false && age < 30)
{
    Console.WriteLine("You are woman.You are under 30.");
}

else if (name == "Ewa" && age1 == 32)
{
    Console.WriteLine("You are Ewa. You are 33.");
}

else if(male == true && age2 <18)
{
    Console.WriteLine("You are a man. You are under 18.");
}

else
{
    Console.WriteLine("You are not classified on my list");
}

