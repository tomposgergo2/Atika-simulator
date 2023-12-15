using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{
    internal class Tesi
    {
        public static void TesiGame() 
        {
            Console.Write("\n\n  ====================================================================================================================\n  ");
            Console.WriteLine("  Üdv a tesi órán!");
            Console.Write("  ====================================================================================================================\n\n  ");
            Console.WriteLine("  Ha nem tesizel lemegy a kedved, viszont tölteni tudod a telefonod!");
            Console.Write("  Atika, tesizel? (igen/nem): ");
            string valasztas = Console.ReadLine().ToLower();

            if (valasztas == "nem")
            {
                Console.WriteLine("  Atika nem tesizik. Véget ért az óra.");
                Program.Kedve -= 10;
                Program.Telefon -= 35;
                Console.WriteLine($"  Jelenlegi kedved: {Program.Kedve}");
                Console.WriteLine($"  Akkumulátor szint: {Program.Telefon}");
                Console.WriteLine("  ------------------------------");
                Console.WriteLine("  Véget ért az óra.");
            }
            else if (valasztas == "igen")
            {
                Console.Write("  Kit akarsz oldalba térdeleni? (Dávid, Csizi, Zalán): ");
                string nevValasztas = Console.ReadLine();

                switch (nevValasztas.ToLower())
                {
                    case "dávid":
                        Console.WriteLine("  Oldalba térdelted a Dávidot.");
                        Program.Kedve += 30;
                        Program.Telefon += 30;
                        Console.WriteLine($"  Jelenlegi kedved: {Program.Kedve}");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("  Véget ért az óra.");
                        break;
                    case "csizi":
                        Console.WriteLine("  Oldalba térdelted a Csizit.");
                        Program.Kedve += 30;
                        Program.Telefon += 30;

                        Console.WriteLine($"  Jelenlegi kedved: {Program.Kedve}");
                        Console.WriteLine("  ------------------------------");
                        Console.WriteLine("  Véget ért az óra.");
                        break;
                    case "zalán":
                        Console.WriteLine("  Oldalba térdelted a Márkot.");
                        Program.Kedve += 30;
                        Program.Telefon += 30;

                        Console.WriteLine($"  Jelenlegi kedved: {Program.Kedve}");
                        Console.WriteLine("  ------------------------------");
                        Console.WriteLine("  Véget ért az óra.");
                        break;
                    default:
                        Console.WriteLine("  Érvénytelen választás.");
                        Program.Kedve -= 10;
                        Console.WriteLine($"  Jelenlegi kedved: {Program.Kedve}");
                        Console.WriteLine("  ------------------------------");
                        Console.WriteLine("  Véget ért az óra.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("  Érvénytelen választás.");
                Program.Kedve -= 10;
                Console.WriteLine($"  Jelenlegi kedved: {Program.Kedve}");
                Console.WriteLine("  ------------------------------");
                Console.WriteLine("  Véget ért az óra.");
            }

            Console.ReadLine();
        }
    }
}
