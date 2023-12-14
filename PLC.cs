using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class PLC
    {
        public static void PLCGame()
        {
            int aksiadat = 0;
            int kedvadat = 0;
            Console.Write("\n\n  ====================================================================================================================\n  ");

            Console.WriteLine("  Megérkeztél a PLC órára!");
            Console.Write("  ====================================================================================================================\n\n  ");


            Random random = new Random();
            int asitas = random.Next(1, 11);

            if (asitas == 1 || asitas == 2 || asitas == 3)
            {
                Console.WriteLine("  Flóri: A tiszteletlen paraszt!\n  Nem említettem urak, hogy ezt nem bírom elviselni?\n  Beleásít a pofámba, konkrétan leláttam a gyomráig.");
                Console.WriteLine("  Csizma: Jó nagy paraszt vagy Atika...");
                Console.WriteLine("  Atika: Kussoljmá");
                Console.WriteLine("  *Flórinak tetszik Atika flegmasága*");
                Console.WriteLine("  Flóri: Na jolvan urak mára ennyit terveztem, nem akarok év vége előtt izmozni. A viszont látásra!");
                Console.WriteLine("\n  Nyomj meg valamit hogy továbbmenj");
                Console.ReadKey(true);

            }


            if (asitas == 10)
            {
                Console.WriteLine("  Flóri: A tiszteletlen paraszt!\n  Nem említettem urak, hogy ezt nem bírom elviselni?\n  Beleásít a pofámba, konkrétan leláttam a gyomráig.");
                Console.WriteLine("  Atika: *Pislog*");
                Console.WriteLine("  Atika: *Pislog mégegyet (ritka)");
                Console.WriteLine("  Egész osztály: Odafigyeljen tanárúúúr!!! Atika pislogott, ráadásul kettőt!!");
                Console.WriteLine("\n  Nyomj meg valamit hogy továbbmenj");
                Console.ReadKey(true);
            }

            if (asitas == 4 || asitas == 5 || asitas == 6 || asitas == 7 || asitas == 8 || asitas == 9)
            {

                Console.WriteLine("  Nem nedves a pince, nem boldog...\n");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("  *Atika nagyon fél a tanárúrtól, ezért egész órán behúzza a nyakát és csendben dolgozik egész órán...");

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\n   ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("--> Milyen pólus tartozik a színhez?");

                string valasz1 = Console.ReadLine();

                Console.WriteLine();


                if (valasz1 == "+" || valasz1 == "pozitív" || valasz1 == "pozitiv")
                {
                    Console.WriteLine("  Ügyes vagy kismackó, most pislogj egyet!");
                    Program.Kedve += 20;
                }

                else if (valasz1 == "-" || valasz1 == "negatív" || valasz1 == "negativ")
                {
                    Console.WriteLine("  Majdnem... 50-50 volt, maradj inkább a tiktoknál!");
                    Console.WriteLine("  Na de előtte van mégegy esélyed...");

                    Program.Kedve -= 10;
                    Program.Telefon -= 10;

                    aksiadat += 10;
                    kedvadat += 10;
                }

                else
                {
                    Console.WriteLine("  Jóóbutavagy, maradj inkább a tiktoknál");
                    Console.WriteLine("  Na de előtte van mégegy esélyed...");

                    Program.Kedve -= 10;
                    Program.Telefon -= 10;

                    aksiadat += 10;
                    kedvadat += 10;
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n   ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("--> Milyen pólus tartozik a színhez?");


                Console.BackgroundColor = ConsoleColor.Black;

                string valasz2 = Console.ReadLine();

                Console.WriteLine();

                if (valasz2 == "-" || valasz2 == "negatív" || valasz2 == "negativ")
                {
                    Console.WriteLine("  Ügyes vagy kismackó, most pislogj egyet!");
                    Program.Kedve += 20;
                }

                else if (valasz2 == "+" || valasz2 == "pozitív" || valasz2 == "pozitiv")
                {
                    Console.WriteLine("  Ez sem jött össze... Most már tényleg maradj inkább a tiktoknál!");

                    Program.Kedve -= 10;
                    Program.Telefon -= 10;

                    aksiadat += 10;
                    kedvadat += 10;
                }
                else
                {
                    Console.WriteLine("  Jóóbutavagy, most már tényleg maradj inkább a tiktoknál");

                    Program.Kedve -= 10;
                    Program.Telefon -= 10;

                    aksiadat += 10;
                    kedvadat += 10;
                }

                Console.WriteLine("\n  Az órának vége !\n");

                if (kedvadat == 10)
                {
                    Console.WriteLine($"{kedvadat} kedvpontot veszítettél :(");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("| | |\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (kedvadat == 20)
                {
                    Console.WriteLine($"{kedvadat} kedvpontot veszítettél :(");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("| | | | |");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (aksiadat == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine($"\n{aksiadat}%-ot merült a telefonod :(");
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("| | |");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (aksiadat == 20)
                {
                    Console.WriteLine();
                    Console.WriteLine($"\n{aksiadat}%-ot merült a telefonod :(");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("| | | | |\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;



                }

            }
        }
    
    }
}
