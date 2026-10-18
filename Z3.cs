Console.WriteLine("Podaj wiek");
int wiek = int.Parse(Console.ReadLine()!)!;
if (wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek");
}
else if (wiek >= 0 && wiek <= 12)
{
    Console.WriteLine("Dziecko");
}
else if (wiek >= 13 && wiek <= 17)
{
    Console.WriteLine("Nastolatek");
}
else if (wiek >= 18 && wiek <= 64)
{
    Console.WriteLine("Dorosły");
}
else if (wiek >= 65)
{
    Console.WriteLine("Senior");
}