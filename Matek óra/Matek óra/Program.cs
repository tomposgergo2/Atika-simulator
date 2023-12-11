using System;

class Program
{
    static void Main(string[] args)
    {
        int kedv = 100;
        int akkumulator = 100;
        Random random = new Random();

        int[] megoldas = { 36, 25, 174, 200, 63, 64, 301, 1280 };
        string[] szamolasok = { "6 * 6", "5 * 5", "125 + 49", "144 + 56", "7 * 9", "8 * 8", "256 + 45", "1025 + 255" };

        Console.WriteLine("Üdv matek órán!");

        // Telefonozás választás
        Console.Write("Atika, telefonozol? (igen/nem): ");
        string telefonValasz = Console.ReadLine().ToLower();

        if (telefonValasz == "igen")
        {
            Console.Write("Hány TikTok videót nézel meg? (5, 10, 15): ");
            int tiktokSzam = int.Parse(Console.ReadLine());

            switch (tiktokSzam)
            {
                case 5:
                    akkumulator -= 10;
                    kedv += 5;
                    break;
                case 10:
                    akkumulator -= 15;
                    kedv += 10;
                    break;
                case 15:
                    akkumulator -= 20;
                    kedv += 15;
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás. Az óra véget ért.");
                    Console.ReadLine();
                    return;
            }
            Console.WriteLine($"Jelenlegi kedv: {kedv}");
            Console.WriteLine($"Akkumulátor szinted: {akkumulator}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Véget ért az óra");
            return;
        }
        else
        {

            Console.WriteLine("Attila figyelj és csináld meg a feladatot!");

            for (int i = 0; i < 2; i++) // Két kérdés
            {
                int index = random.Next(0, megoldas.Length);
                int helyesMegoldas = megoldas[index];
                string helyesSzamolas = szamolasok[index];

                Console.WriteLine($"Mennyi {helyesSzamolas}?");

                Console.Write("Válasz: ");
                int felhasznaloValasz;

                int probalkozasok = 0;

                while (probalkozasok < 2)
                {
                    while (!int.TryParse(Console.ReadLine(), out felhasznaloValasz))
                    {
                        Console.WriteLine("Kérlek adj meg egy rendes számot!");
                        Console.Write("Válasz: ");
                    }

                    if (felhasznaloValasz == helyesMegoldas)
                    {
                        Console.WriteLine("Ügyes vagy, helyes válasz!");
                        kedv += 20;
                        Console.WriteLine($"Jelenlegi kedved: {kedv} ");
                        Console.WriteLine("------------------------------");
                        return;
                    }
                    else
                    {
                        probalkozasok++;

                        if (kedv <= 0)
                        {
                            Console.WriteLine("Vége a játéknak, mert a kedved 0 alá ment.");
                            Console.ReadLine();
                            return;
                        }
                        else if (probalkozasok == 2)
                        {
                            Console.WriteLine($"Sajnálom, két rossz válasz után nincs több lehetőséged. A helyes válasz: {helyesMegoldas}");
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
        }
        Console.WriteLine("Véget ért az óra");
        Console.ReadLine();
    }
}
