string name = "Ewa";
string gender = "kobieta";
var age = 30;

if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30");
}

else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30.");
}

else if (gender == "mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}

else
{
    Console.WriteLine("NIC");
}