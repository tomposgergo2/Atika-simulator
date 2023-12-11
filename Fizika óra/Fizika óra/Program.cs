using System;

class Program
{
    static void Main(string[] args)
    {
        int kedv = 100;
        int mentesito = 1; // Mentesítő számláló

        Random random = new Random();

        string[] valasz = { "t", "t", "1", "w", "r", "a", "t", "n" };
        string[] kepletek = { "v = s / ?", "s = v * ?", "f = ? / T", "f = ? * t", "V(k) = 2 * ? *  π * f", "F = m * ?", "T = 1 / ?", "f = ? / Δt" };

        Console.WriteLine("Üdv a fizika órán!");

        // Mentésítő felhasználása
        Console.Write("Felhasználná a mentesítőt? (Igen: 1 / Nem: 0): ");
        int mentesitoValasztas;

        while (!int.TryParse(Console.ReadLine(), out mentesitoValasztas) || (mentesitoValasztas != 0 && mentesitoValasztas != 1))
        {
            Console.WriteLine("Kérlek válassz 0 vagy 1 közül!");
            Console.Write("Válasz: ");
        }

        if (mentesitoValasztas == 1)
        {
            Console.WriteLine("Mentesítő felhasználva!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Véget ért az óra");
            Console.ReadLine();
            return;
        }

        // Játék folytatása
        for (int i = 0; i < valasz.Length; i++)
        {
            int index = random.Next(valasz.Length);
            string helyesValasz = valasz[index];
            string helyesKepletek = kepletek[index];

            Console.WriteLine($"Olld meg az alábbi képletet {helyesKepletek}!");

            Console.Write("Válasz: ");
            string felhasznaloValasz;

            int probalkozasok = 0;

            while (probalkozasok < 2)
            {
                felhasznaloValasz = Console.ReadLine();

                if (felhasznaloValasz == helyesValasz)
                {
                    Console.WriteLine("\nÜgyes vagy, helyes válasz!");
                    kedv += 20;
                    Console.WriteLine($"Jelenlegi kedved: {kedv} ");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Véget ért az óra");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    probalkozasok++;

                    if (kedv <= 0)
                    {
                        Console.WriteLine("Vége a játéknak, mert a kedved 0 alá ment.");
                        return;
                    }
                    else if (probalkozasok == 2)
                    {
                        Console.WriteLine($"Sajnálom, két rossz válasz után nincs több lehetőséged. A helyes válasz: {helyesValasz}");
                        kedv -= 30;
                        Console.WriteLine($"Jelenlegi kedved: {kedv} ");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Véget ért az óra");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Most már ne add a hülyét, Atika!");
                        Console.Write("Próbáld újra: ");
                    }
                }
            }
        }
        Console.ReadLine();
    }
}
