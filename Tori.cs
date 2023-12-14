using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class Tori
    {
        public static void ToriGame()
        {
            Random random = new Random();
            int[] evszamok = { 1222, 1526, 1456, 896, 1945, 1939, 1914, 1918 };
            string[] esemenyek = { "Aranybulla", "mohácsi csata", "nándorfehérvári csata", "Honfoglalás", "Második világháború vége", "Második világháború kezdete", "Első világháború kezdete", "Első világháború vége" };

            Console.WriteLine("Üdv a történelem órán!");

            for (int i = 0; i < evszamok.Length; i++)
            {
                int index = random.Next(evszamok.Length);
                int helyesEvszam = evszamok[index];
                string helyesEsemeny = esemenyek[index];

                Console.WriteLine($"Mikor volt a(z) {helyesEsemeny}?");

                Console.Write("Válasz: ");
                int felhasznaloValasz;

                int probalkozasok = 0;

                while (probalkozasok < 2)
                {
                    while (!int.TryParse(Console.ReadLine(), out felhasznaloValasz))
                    {
                        Console.WriteLine("Kérlek adj meg egy rendes évszámot!");
                        Console.Write("Válasz: ");
                    }

                    if (felhasznaloValasz == helyesEvszam)
                    {
                        Console.WriteLine("\nÜgyes vagy, helyes válasz!");
                        Program.Kedve += 20;
                        Console.WriteLine($"Jelenlegi kedved: {Program.Kedve} ");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Véget ért az óra");
                        return;
                    }
                    else
                    {
                        probalkozasok++;
                        if (Program.Kedve <= 0)
                        {
                            Console.WriteLine("Vége a játéknak, mert a kedved 0 alá ment.");
                            return;
                        }
                        else if (probalkozasok == 2)
                        {
                            Console.WriteLine($"Sajnálom, két rossz válasz után nincs több lehetőséged. A helyes válasz: {helyesEvszam}");
                            Program.Kedve -= 20;
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
            Console.ReadLine();
        }
    }
}
