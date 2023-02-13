string name = "Ewa";

bool female = false;

var age = 33;


if (female == false && age < 30)
{
    Console.WriteLine("You are woman.You are under 30.");
}

else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("You are Ewa. You are 33.");
}

else if(female == false && age <18)
{
    Console.WriteLine("You are a woman. You are under 18.");
}

else
{
    Console.WriteLine("You are not classified on my list");
}

