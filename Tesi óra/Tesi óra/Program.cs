using System;

class Program
{
    static void Main(string[] args)
    {
        int akksi = 100;
        int kedv = 100;
        Console.WriteLine("Üdv a tesi órán!");
        Console.WriteLine("Ha nem tesizel lemegy a kedved, viszont tölteni tudod a telefonod!");
        Console.Write("Atika, tesizel? (igen/nem): ");
        string valasztas = Console.ReadLine().ToLower();

        if (valasztas == "nem")
        {
            Console.WriteLine("Atika nem tesizik. Véget ért az óra.");
            kedv -= 10;
            akksi += 35;
            Console.WriteLine($"Jelenlegi kedved: {kedv}");
            Console.WriteLine($"Akkumulátor szint: {akksi}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Véget ért az óra.");
        }
        else if (valasztas == "igen")
        {
            Console.Write("Kit akarsz oldalba térdeleni? (Dávid, Csizi, Zalán): ");
            string nevValasztas = Console.ReadLine();

            switch (nevValasztas.ToLower())
            {
                case "dávid":
                    Console.WriteLine("Oldalba térdelted a Dávidot.");
                    kedv += 30;
                    Console.WriteLine($"Jelenlegi kedved: {kedv}");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Véget ért az óra.");
                    break;
                case "csizi":
                    Console.WriteLine("Oldalba térdelted a Csizit.");
                    kedv += 30;
                    Console.WriteLine($"Jelenlegi kedved: {kedv}");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Véget ért az óra.");
                    break;
                case "zalán":
                    Console.WriteLine("Oldalba térdelted a Márkot.");
                    kedv += 30;
                    Console.WriteLine($"Jelenlegi kedved: {kedv}");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Véget ért az óra.");
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás.");
                    kedv -= 10;
                    Console.WriteLine($"Jelenlegi kedved: {kedv}");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Véget ért az óra.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Érvénytelen választás.");
            kedv -= 10;
            Console.WriteLine($"Jelenlegi kedved: {kedv}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Véget ért az óra.");
        }

        Console.ReadLine();
    }
}
