using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class Matek
    {
        public static void MatekGame() 
        {
            Random random = new Random();
            int[] megoldas = { 36, 25, 174, 200, 63, 64, 301, 1280 };
            string[] szamolasok = { "6 * 6", "5 * 5", "125 + 49", "144 + 56", "7 * 9", "8 * 8", "256 + 45", "1025 + 255" };
            Console.Write("\n\n  ====================================================================================================================\n  ");
            Console.WriteLine("  Üdv matek órán!");
            Console.Write("  ====================================================================================================================\n\n  ");

            // Telefonozás választás
            Console.Write("Atika, telefonozol? (igen/nem): ");
            string telefonValasz = Console.ReadLine().ToLower();

            if (telefonValasz == "igen")
            {
                Program.Telefon -= 20; 
                Console.Write("Hány TikTok videót nézel meg? (5, 10, 15): ");
                int tiktokSzam = int.Parse(Console.ReadLine());

                switch (tiktokSzam)
                {
                    case 5:
                        Program.Telefon -= 10;
                        Program.Kedve += 5;
                        break;
                    case 10:
                        Program.Telefon -= 15;
                        Program.Kedve += 10;
                        break;
                    case 15:
                        Program.Telefon -= 20;
                        Program.Kedve += 15;
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás. Az óra véget ért.");
                        Console.ReadLine();
                        return;
                }
                Console.WriteLine($"Jelenlegi kedv: {Program.Kedve}");
                Console.WriteLine($"Akkumulátor szinted: {Program.Telefon}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Véget ért az óra");
                return;
            }
            else
            {
                Program.Telefon += 20;
                Console.WriteLine("Attila figyelj és csináld meg a feladatot!");
                Program.Telefon += 25;
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
                            Program.Kedve += 20;
                            Console.WriteLine($"Jelenlegi kedved: {Program.Kedve} ");
                            Console.WriteLine("------------------------------");
                            return;
                        }
                        else
                        {
                            probalkozasok++;

                            if (Program.Kedve <= 0)
                            {
                                Console.WriteLine("Vége a játéknak, mert a kedved 0 alá ment.");
                                Console.ReadLine();
                                return;
                            }
                            else if (probalkozasok == 2)
                            {
                                Console.WriteLine($"Sajnálom, két rossz válasz után nincs több lehetőséged. A helyes válasz: {helyesMegoldas}");
                                Program.Kedve -= 30;
                                Console.WriteLine($"Jelenlegi kedved: {Program.Kedve} ");
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
}
