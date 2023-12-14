using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class DigitalTechnika
    {
        static object cursorLock = new object();
        public static int value { get; set; } = 0;
        public static void DigitalTechGame()
        {
            Console.Write("\n\n  ====================================================================================================================\n  ");
            Console.WriteLine("  Megjöttél a szaunába... Unalmas mint a szar szóval had szóljon a TikTok!"); 
            Console.Write("  ====================================================================================================================\n\n  ");

            Thread.Sleep(4000);

            Console.WriteLine("De még előtte a döntés a te kezedben áll:\n");
            Console.WriteLine("1. Had szóljon hangosan");
            Console.WriteLine("2. Silent and sneaky\n");

            string valasztas = Console.ReadLine();

            if (valasztas == "1")
            {
                Console.WriteLine("Szépen békésen (hangosan) tiktokozol, nem fenyeget semmi veszély...");
                for (int i = 0; i < 3; i++)
                {

                    if (value == 0)
                    {
                        valasz1();


                        Console.Clear();
                        Console.WriteLine("Rád szólt Gabesz !!!!\n");
                        Console.WriteLine($"Na vajon elteszed a telefont vagy nem...?\n");


                        Random random = new Random();
                        int valasztas2 = random.Next(1, 3);

                        if (valasztas2 == 1)
                        {
                            Console.WriteLine("Folytattad tovább... Te tudod");
                            Program.Kedve += 20;
                            Program.Telefon -= 60;
                            Console.WriteLine("\nA telód majdnem halott de legalább boldog a kis fejed :')");
                            Console.BackgroundColor = ConsoleColor.Green;

                            Console.Write("| | | | |");

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("%");

                            Console.Write("\t-->\t");

                            Console.BackgroundColor = ConsoleColor.Red;

                            Console.Write("| | |");

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n\t\t-60%");


                        }

                        else if (valasztas2 == 2)
                        {
                            Console.WriteLine("Kész csoda!! Eltetted azt a szutykot...\n");
                            Console.WriteLine("Viszont ez mocsok unalmas lesz...\n");
                            Console.WriteLine("A kedved 20-szal csökkent");
                            Program.Kedve -= 20;
                        }
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Erre sem vagy képes...");
                        break;
                    }

                }

            }

            if (valasztas == "2")
            {
                Console.WriteLine("Egy kis TikTok");
                for (int i = 0; i < 10; i++)
                {
                    if (value == 0)
                    {
                        valasz2();


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



        }

        static void valasz1()
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
            double counter2 = 3;
            double counter3 = 0;



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


        static void valasz2()
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
