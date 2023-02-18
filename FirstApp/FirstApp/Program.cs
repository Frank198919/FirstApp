string name = "Ewa";
var myAge = 33;
char gender = 'f';

if (gender == 'f' && myAge < 30)
{
    Console.WriteLine("Kobieta poznizej 30 lat");
}
else if (name == "Ewa" && myAge == 33 && gender == 'f')
{
    Console.WriteLine("Ewa, 33 lata");
}
else if (myAge < 18 && gender != 'f')
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("Brak danych");
}
