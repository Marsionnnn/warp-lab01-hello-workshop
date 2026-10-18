Console.WriteLine("Podaj punkty życia");
int life = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Czy bohater ma klucz? (true/false)");
bool key = bool.Parse(Console.ReadLine()!)!;
Console.WriteLine("Czy bohater zna hasło? (true/false)");
bool password = bool.Parse(Console.ReadLine()!)!;
if (life > 0 && (key || password))
{
    Console.WriteLine("Bohater może wejść do lochu");
    if (key)
    {
        Console.WriteLine("Bohater żyje i może użyć klucza do wejścia do lochu");
    }
    else if (password)
    {
        Console.WriteLine("Bohater żyje i może użyć hasła do wejścia do lochu");
    };
}
else if (life <= 0)
{
    Console.WriteLine("Bohater nie żyje. Nie może wejść do lochu");
}
else if (!key && !password)
{
    Console.WriteLine("Bohater nie ma klucza do lochu i nie zna hasła. Nie może wejść do lochu");
}