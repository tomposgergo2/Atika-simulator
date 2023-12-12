using System;

class Program
{
    static void Main(string[] args)
    {
        int kedv = 100;
        

        Random random = new Random();

        string[] valasz = { "megye", "letszam", "megye", "megye", "allapot"};
        string[] kod = { "\n\tSelect sum(aerob.letszam) / megye.letszam\n\tfrom aerob inner JOIN\n\t     megye on aerob.mkod = megye.kod\n\twhere ?.nev = 'Pest'\n\tgroup by megye.letszam;", 
                         "\n\tSelect megye.nev, \n\t\tsum(aerob.?) / megye.letszam as arany \n\tfrom aerob inner JOIN \n\t\tmegye on aerob.mkod = megye.kod \n\tgroup by megye.letszam, \n\t\tmegye.nev \n\torder by arany desc \n\tlimit 1;", 
                         "\n\tselect count(*)\n\tfrom ?\n\twhere letszam < (select letszam from megye where nev = 'Heves');",
                         "\n\tSelect sum(aerob.letszam) as letszam\n\tfrom aerob inner JOIN     \n\t\tmegye on aerob.mkod = ?.kod\n\twhere megye.nev = 'Somogy'\n\tand aerob.nem = 0;",
                         "\n\tSelect aerob.letszam\n\tfrom aerob inner join\n\t\tmegye on aerob.mkod = megye.kod inner join\n\t\tallapot on aerob.allkod = ?.kod\n\twhere allapot.nev = 'egészséges'\n\tand megye.nev = 'Zala'\n\tand aerob.nem = 1;"
                       };

        Console.WriteLine("Na Jónapot az adatbázis kezelés órán!");


        // Játék folytatása
        for (int i = 0; i < valasz.Length; i++)
        {
            int index = random.Next(valasz.Length);
            string helyesValasz = valasz[index];
            string helyesKod = kod[index];

            Console.WriteLine($"Írd be a hiányzó szót az SQL kódba\nA kérdőjel helyén hiányzik szó! {helyesKod}!");

            Console.Write("Válasz: ");
            string felhasznaloValasz;

            int probalkozasok = 0;

            while (probalkozasok < 2)
            {
                felhasznaloValasz = Console.ReadLine();

                if (felhasznaloValasz == helyesValasz)
                {
                    Console.WriteLine("\nÜgyes vagy, helyes válasz!");
                    kedv += 20;
                    Console.WriteLine($"Jelenlegi kedved: {kedv} ");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Véget ért az óra");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    probalkozasok++;

                    if (kedv <= 0)
                    {
                        Console.WriteLine("Vége a játéknak, mert a kedved 0 alá ment.");
                        return;
                    }
                    else if (probalkozasok == 2)
                    {
                        Console.WriteLine($"Sajnálom, két rossz válasz után nincs több lehetőséged. A helyes válasz: {helyesValasz}");
                        kedv -= 30;
                        Console.WriteLine($"Jelenlegi kedved: {kedv} ");
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
