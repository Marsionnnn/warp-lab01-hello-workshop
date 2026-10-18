Console.WriteLine("Wybierz kierunek: ");
string kierunek = Console.ReadLine()!;
switch (kierunek)
{
    case "północ":
        Console.WriteLine("Wyruszasz w strone gór");
        break;
    case "południe":
        Console.WriteLine("Wyruszasz w strone pustyni");
        break;
    case "wschód    ":
        Console.WriteLine("Wyruszasz w strone lasu");
        break;
    case "zachód":
        Console.WriteLine("Wyruszasz w strone morza");
        break;
    default:
        Console.WriteLine("Nieznany kierunek");
        break;
}
