using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class Halozat
    {
        public static int value = 0;
        static object consoleLock = new object();
        public static void HalozatGame()
        {


            for (int i = 0; i < 5; i++)
            {
                KondiGame();
            }
            Console.Clear();
            Console.WriteLine("Vége a csodának. ");

        }
        static int kivalasztas()
        {
            Console.WriteLine("\t\t\t\tOszibáttya mixet tesz, úgyhogy mehet a Basket Random!");
            Console.Write("  ====================================================================================================================\n  ");
            Console.WriteLine("  _________________________________");

            Console.Write($"   |\t'SPACE'\tNa had szóljon!");

                int top = Console.CursorTop;
                Console.SetCursorPosition(37, top);
            Console.WriteLine("|");
            Console.WriteLine($"   |_________________________________|");
            
            char valasztasod;
            do
            {
                valasztasod = Console.ReadKey(true).KeyChar;

            }
            while (valasztasod != 32);
            Console.Clear();
            Console.WriteLine("\t\t\t (Ha a Karcsi nyer akkor -20 kedv pontot fog kapni figyelj erre)\n\t\t\t\t\t\n");
            Console.WriteLine("\n\n\t\tA 'felfele nyíl' billentyűvel tudod csinálni. Nyomkodd őket amilyen gyorsan csak tudod!");
            Thread.Sleep(5000);
            return valasztasod;


        }
       
        static void KondiGame()
        {
            
            int Kedve = 100;
            int Ehes = 100;
            int Viz = 100;
            int suly = value == 0 ? kivalasztas() : value;
            value = suly;
            int b = suly;
            ConsoleKey valami = ConsoleKey.F1;
            int korSzam = 0;
            Random rand = new Random();

            int isCanceled = 0;
            Console.CursorVisible = false;
            Thread thread = new Thread(() =>
            {
                while (isCanceled == 0 && (b != 0))
                {
                    lock (consoleLock)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 2);
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        for (int i = 0; i < b; i++)
                        {
                            Console.SetCursorPosition(0, 6 + i);
                            Console.Write("-");
                        }
 
                    }

                    b += korSzam % 2 == 1 ? rand.Next(0,3) : 0;

                    korSzam++;
                    do
                    {
                        if (Console.KeyAvailable)
                            valami = Console.ReadKey(true).Key;
                    }
                    while (isCanceled == 0  && valami != ConsoleKey.UpArrow);
                    if (isCanceled == 0)
                    {
                        if (valami == ConsoleKey.UpArrow)
                        {
                            if (b > 0) --b;
                            else b = 0;
                        }

                    }
                    valami = ConsoleKey.F1;

                }
                Console.CursorVisible = true;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            });
            Console.Clear();
            thread.Start();

            double maradek = 0;
            Console.CursorVisible = true;
            double counter = 10;
            DateTime start = DateTime.Now;
            while (thread.IsAlive && counter > 0)
            {
                lock (consoleLock)
                {
                    double msecs = (DateTime.Now - start).TotalMilliseconds;
                    counter = 10 - msecs / 1000;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.SetCursorPosition(0, 0);
                    Console.Write($"{counter:f2}  ");
                    maradek = msecs;
                }
            }
            Console.CursorVisible = true;
            isCanceled = 1;

            Thread.Sleep(300);
            Console.Clear();
            double maradekido = 10 - maradek / 1000;
            if (maradekido < 0)
            {
                Console.WriteLine("\n\n\tAz időd lejárt Sajnos vesztettél Atika így elveszítettél 10 kedv pontot :(");
                Kedve -= 10;
                Ehes -= 15;
                Viz -= 20;

            }
            else
            {
                Console.WriteLine("\n\n\tGratulálunk!! Szétkaptad a Károlyt :DD (+10 Kedv)");
                Kedve += 10;
                Ehes -= 15;
                Viz -= 20;
                Console.WriteLine($"\tEnnyivel voltál gyorsabb az öcskösnél: {maradekido:f2}s");

            }
            Thread.Sleep(5000);
            Console.Clear();
            
            
       

        }
    }
}
