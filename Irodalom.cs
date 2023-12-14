using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class Irodalom
    {
        static object cursorLock = new object();
        public static int value { get; set; } = 0;
        public static void IrodalomGame()
        {
            Random random = new Random();

            int[] evszamok = { 1823, 1837, 0411, 1848, 1590, 31 };
            string[] esemenyek = { "Himnusz kiadása", "Szózat", "Magyar költészet napja (HHNN)", "Nemzeti dal", "Első magyar nyelvű Biblia", "Hány versszakos a walesi bárdok", };
            Console.Write("\n\n  ====================================================================================================================\n  ");
            Console.WriteLine("  Megérkeztél az irodalom órára!");
            Console.Write("  ====================================================================================================================\n\n  ");

            Console.Write("1. Telefonozol az órán --> ");

            Console.BackgroundColor = ConsoleColor.Green;

            Console.Write("| | | | |");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%");

            Console.Write("\t-->\t");

            Console.BackgroundColor = ConsoleColor.Red;

            Console.Write("| | |");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("%");


            Console.WriteLine("\n2. Mintadiák leszel (vagy nem)");

            Console.Write("Szóval? ");
            string valasztas = Console.ReadLine();



            if (valasztas == "1")
            {
                Program.Telefon -= 20;
                Console.WriteLine("\nEgy kis TikTok");
                Thread.Sleep(2000);

                for (int i = 0; i < 10; i++)
                {
                    if (value == 0)
                    {
                        valasz();


                        Console.Clear();
                        Console.WriteLine($"Na ennyi volt a TikTok erre az órára");

                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Erre sem vagy képes...");
                        break;
                    }

                }


            }

            else if (valasztas == "2")
            {
                Program.Telefon += 20;
                for (int i = 0; i < evszamok.Length; i++)
                {
                    int index = random.Next(evszamok.Length);
                    int helyesEvszam = evszamok[index];
                    string helyesEsemeny = esemenyek[index];

                    Console.WriteLine($"Mikor volt a(z) {helyesEsemeny}?");

                    Console.Write("Válasz: ");
                    int felhasznaloValasz;

                    int probalkozasok = 0;

                    while (probalkozasok < 3)
                    {
                        while (!int.TryParse(Console.ReadLine(), out felhasznaloValasz))
                        {
                            Console.WriteLine("Hibás input. Kérlek adj meg egy évszámot!");
                            Console.Write("Válasz: ");
                        }

                        if (felhasznaloValasz == helyesEvszam)
                        {
                            Console.WriteLine("Ügyes kismackó vagy!");
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
                            else if (probalkozasok == 3)
                            {
                                Console.WriteLine($"Hármat sorozatban? Gratulálok... Véget ért az óra. A helyes válasz: {helyesEvszam}");
                                Program.Kedve -= 30;
                                Console.WriteLine($"Jelenlegi kedved: {Program.Kedve} ");
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("Véget ért az óra");
                                Console.ReadLine();
                                return;

                            }
                            else if (probalkozasok == 1)
                            {
                                Console.WriteLine("Szedd már össze magad Atika!");
                                Console.Write("Próbáld újra: ");
                            }

                            else if (probalkozasok == 2)
                            {
                                Console.WriteLine("Édes Istenem...");
                                Console.WriteLine("Próbáld újra: ");
                            }
                        }
                    }
                }
            }

            Console.ReadLine();
        }

        static void valasz()
        {
            Console.Clear();

            ConsoleKey ch = 0;
            bool isCanceled = false;
            Thread thread = new Thread(() =>
            {


                do
                {

                    if (Console.KeyAvailable)
                    {

                        ch = Console.ReadKey(true).Key;
                    }


                }

                while ((ch != ConsoleKey.DownArrow) && !isCanceled);
                {

                }


            });
            thread.Start();

            Random rnd = new Random();

            double counter = 10;
            double counter2 = rnd.Next(1, 4);
            double counter3 = 0;


            if (counter2 == 1)
            {
                counter3 = 1;
                Console.WriteLine("Vírusos videót dobott be a TikTok. 1 másodperced lesz hogy elpörgesd különben gatya.");
                Thread.Sleep(5000);
            }


            if (counter2 == 2)
            {
                counter3 = 4;
                Console.WriteLine("Elég unalmas ez a szutyok... Pörgess tovább!");
            }


            if (counter2 == 3)
            {
                counter3 = 10;
                Console.WriteLine("Na végre valami izgalmas...");
            }


            DateTime start = DateTime.Now;
            while (thread.IsAlive && counter > 0)
            {
                double msecs = (DateTime.Now - start).TotalMilliseconds;
                counter = counter3 - msecs / 1000;
                lock (cursorLock)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"\n\n{counter:f2}  ");
                    Console.CursorVisible = true;
                }
            }

            if (ch == 0)
            {

                value = 1;
            }


            isCanceled = true;



        }
    }
}
