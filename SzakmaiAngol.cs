using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class SzakmaiAngol
    {
        public static object cursorLock = new object();
        public static int value { get; set; } = 0;
        public static void SzakmaiAngolGame()
        {


            int kedv = 100;
            Random random = new Random();

            string[] angol = { "house", "hat", "name", "dog", "cat", "flower", "ball", "table", "chair", "sky", "fire", "water" };
            string[] magyar = { "ház", "kalap", "név", "kutya", "macska", "virág", "labda", "asztal", "szék", "égbolt", "tűz", "víz" };

            Console.WriteLine("Megérkeztél az angol órára! (Már ha részt veszel az órán....)\n");

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


            Console.WriteLine("\n\n2. Mintadiák leszel (vagy nem)");

            Console.Write("\nSzóval? ");
            string valasztas = Console.ReadLine();

            Console.WriteLine();



            if (valasztas == "1")
            {
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
                Console.Clear();
                Console.WriteLine("A feladatod az lesz, hogy a magyar szavak alá írd le az angol megfelelőjüket! Ügyi legyél <3");
                Thread.Sleep(4000);
                Console.Clear();
                for (int i = 0; i < angol.Length; i++)
                {
                    string index = angol[i];
                    string helyesAngol = angol[i];
                    string helyesMagyar = magyar[i];

                    Console.WriteLine($"Mi az angol megfelelője a {helyesMagyar} szónak?");

                    Console.Write("Válasz: ");


                    int probalkozasok = 0;

                    while (probalkozasok < 3)
                    {
                        string felhasznaloValasz = Console.ReadLine();

                        if (felhasznaloValasz == helyesAngol)
                        {
                            Console.WriteLine("Ügyes kismackó vagy!");
                            Thread.Sleep(1500);
                            Console.Clear();

                            probalkozasok = 3;

                        }
                        else
                        {
                            probalkozasok++;

                            if (kedv <= 0)
                            {
                                Console.WriteLine("Vége a játéknak, mert a kedved 0 alá ment.");

                            }
                            else if (probalkozasok == 3)
                            {
                                Console.WriteLine($"Hármat sorozatban? Gratulálok... Véget ért az óra. A helyes válasz: {helyesAngol}");
                                kedv -= 30;
                                Console.WriteLine($"Jelenlegi kedved: {kedv} ");
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("Véget ért az óra");
                                Console.ReadLine();


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
                kedv += 20;
                Console.WriteLine($"Jelenlegi kedved: {kedv} ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Véget ért az óra");

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
