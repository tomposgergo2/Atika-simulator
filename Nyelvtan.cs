using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class Nyelvtan
    {
        static object cursorLock = new object();
        public static int value { get; set; } = 0;
        public static void NyelvtanGame()
        {
            string[] helyes = { "ly", "j", "ly", "", "j", "ly", "j", "j", "", "j", "j" };
            string[] kiegeszites = { "hü_e", "ka_a", "sú_", "di_ó", "sú_os", "pá_a", "kussol_", "hal_ meg", "kami_on", "sa_t", "se_tosztódás", };
            Console.Write("\n\n  ====================================================================================================================\n  ");
            Console.WriteLine("  Megérkeztél a nyelvtan órára! (Már ha részt veszel az órán....");
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
                Console.Clear();
                Console.WriteLine("Egy kis TikTok");
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
                Console.Clear();
                Console.WriteLine("A feladatod az lesz, hogy kiegészítsd a szavakat 'j'-vel és 'ly'-vel. Ügyi legyél <3\n");
                Thread.Sleep(4000);
                Console.Clear();
                for (int i = 0; i < helyes.Length; i++)
                {
                    string index = helyes[i];
                    string kiegSorszam = kiegeszites[i];
                    string helyesSorszam = helyes[i];

                    Console.WriteLine($"Egészítsd ki a következő szót: {kiegSorszam}");

                    Console.Write("Válasz: ");


                    int probalkozasok = 0;

                    while (probalkozasok < 3)
                    {
                        string felhasznaloValasz = Console.ReadLine();

                        if (felhasznaloValasz == helyesSorszam)
                        {
                            Console.WriteLine("Ügyes kismackó vagy!");
                            Thread.Sleep(1500);
                            Console.Clear();

                            probalkozasok = 3;

                        }
                        else
                        {
                            probalkozasok++;

                            if (Program.Kedve <= 0)
                            {
                                Console.WriteLine("Vége a játéknak, mert a kedved 0 alá ment.");

                            }
                            else if (probalkozasok == 3)
                            {
                                Console.WriteLine($"Hármat sorozatban? Gratulálok... Véget ért az óra. A helyes válasz: {helyesSorszam}");
                                Program.Kedve -= 30;
                                Console.WriteLine($"Jelenlegi kedved: {Program.Kedve} ");
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
                Program.Kedve += 20;
                Console.WriteLine($"Jelenlegi kedved: {Program.Kedve} ");
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
