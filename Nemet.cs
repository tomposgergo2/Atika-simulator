using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class Nemet
    {
        public static void NemetGame() 
        {
            // ide írd ami lefusson ............................................................................................................
            static void Main()
            {
                Console.WriteLine("Megérkeztél német órára!");

                KiirLehetosegek();
                Választás();

                Console.WriteLine($"Jelenlegi kedved: {Program.Kedve} ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Véget ért az óra!");
            }

            static void KiirLehetosegek()
            {
                Console.WriteLine("\nMit mondasz Atika?");
                Console.WriteLine("1. Anyád");
                Console.WriteLine("2. Kussolj");
                Console.WriteLine("3. Dögölj meg");
            }

            static void Választás()
            {
                Console.Write("\nVálassz egy lehetőséget (1-3): ");
                int valasztas = Convert.ToInt32(Console.ReadLine());

                switch (valasztas)
                {
                    case 1:
                        KivalasztEsMond("Anyád");
                        break;
                    case 2:
                        KivalasztEsMond("Kussolj");
                        break;
                    case 3:
                        KivalasztEsMond("Dögölj meg");
                        break;
                    default:
                        Console.WriteLine("Erre sem vagy képes Atika?!");
                        break;
                }
            }

            static void KivalasztEsMond(string uzenet)
            {
                Console.Write("Kinek akarod mondani Atika? (KÁLDI, MÁRK, DÁVID): ");
                string szemely = Console.ReadLine().ToUpper();

                switch (szemely)
                {
                    case "KÁLDI":
                        Console.WriteLine($"\nHallod Káldi?! {uzenet}!");
                        Program.Kedve += 20;
                        break;
                    case "MÁRK":
                        Console.WriteLine($"\nHallod Márk?! {uzenet}!");
                        Program.Kedve += 20;
                        break;
                    case "DÁVID":
                        Console.WriteLine($"\nHallod Dávid?! {uzenet}");
                        Program.Kedve += 20;
                        break;
                    default:
                        Console.WriteLine("\nMég a nevüket se tudod beírni?");
                        Program.Kedve -= 10;
                        break;
                }

            }
        }        
    }
}
