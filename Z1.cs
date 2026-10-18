Console.WriteLine("Podaj liczbe");
int liczba = int.Parse(Console.ReadLine()!)!;
if (liczba == 0) 
{
    Console.WriteLine("Liczba jest zerem");
}
else if (liczba % 2 == 0)
{
    Console.WriteLine("Liczba jest parzysta");
}
else
{
    Console.WriteLine("Liczba jest nieparzysta");
};
