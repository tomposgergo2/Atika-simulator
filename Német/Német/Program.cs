//Atika simulator német óra, először is van 3 lehetőség, hogy mit mond SZIA, NEM, OKES és lehet választani hogy kinek mondja, KÁLDI, MÁRK, DÁVID ha megtörtént a kedvéhez hozzá adunk 20-at.

using System;

using System;

class Program
{
    static int kedv = 80; // Kezdeti kedv értéke

    static void Main()
    {
        Console.WriteLine("Megérkeztél német órára!");

        KiirLehetosegek();
        Választás();

        Console.WriteLine($"Jelenlegi kedved: {kedv} ");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Véget ért az óra!");
    }

    static void KiirLehetosegek()
    {
        Console.WriteLine("\nMit mondasz Atika?");
        Console.WriteLine("1. Anyád");
        Console.WriteLine("2. Kussolj");
        Console.WriteLine("3. Dögölj meg");
    }

    static void Választás()
    {
        Console.Write("\nVálassz egy lehetőséget (1-3): ");
        int valasztas = Convert.ToInt32(Console.ReadLine());

        switch (valasztas)
        {
            case 1:
                KivalasztEsMond("Anyád");
                break;
            case 2:
                KivalasztEsMond("Kussolj");
                break;
            case 3:
                KivalasztEsMond("Dögölj meg");
                break;
            default:
                Console.WriteLine("Erre sem vagy képes Atika?!");
                break;
        }
    }

    static void KivalasztEsMond(string uzenet)
    {
        Console.Write("Kinek akarod mondani Atika? (KÁLDI, MÁRK, DÁVID): ");
        string szemely = Console.ReadLine().ToUpper();

        switch (szemely)
        {
            case "KÁLDI":
                Console.WriteLine($"\nHallod Káldi?! {uzenet}!");
                kedv += 20;
                break;
            case "MÁRK":
                Console.WriteLine($"\nHallod Márk?! {uzenet}!");
                kedv += 20;
                break;
            case "DÁVID":
                Console.WriteLine($"\nHallod Dávid?! {uzenet}");
                kedv += 20;
                break;
            default:
                Console.WriteLine("\nMég a nevüket se tudod beírni?");
                kedv -= 10;
                break;
        }

    }


}
