using System.Reflection.Emit;

namespace Atika_simulator
{
    internal class Program
    {
        static object consoleLock = new object();
        static void Main(string[] args)
        {
        
            
            #region Add, Data
            NagyLista.Add(Szomod); 
            NagyLista.Add(Tata);
            NagyLista.Add(TataiVasutallomas);
            NagyLista.Add(GyoriVautallomas);
            NagyLista.Add(Jedlik);
            NagyLista.Add(AEpulet);
            NagyLista.Add(BEpulet);
            NagyLista.Add(ElsoEmelet);
            NagyLista.Add(MasodikEmelet);
            NagyLista.Add(HarmadikEmelet);
            NagyLista.Add(ElsoEmeletB);
            NagyLista.Add(HarmadikEmeletB);
            NagyLista.Add(WC);
            NagyLista.Add(Kondi);
            NagyLista.Add(Kaja);
            NagyLista.Add(TPLC);

            NagyLista.Add(T025);
            NagyLista.Add(T12);
            NagyLista.Add(T14);
            NagyLista.Add(T15);
            NagyLista.Add(T106);
            NagyLista.Add(T108);
            NagyLista.Add(T110);
            NagyLista.Add(T112);
            NagyLista.Add(T202);
            NagyLista.Add(T204);
            NagyLista.Add(T208);
            NagyLista.Add(T212);
            NagyLista.Add(TT4);
            NagyLista.Add(TT6);
            NagyLista.Add(TTesi);
            NagyLista.Add(TB7);
            NagyLista.Add(TB8);

            NagyLista.Add(Bufe);
            NagyLista.Add(MaradjOtthon);
            NagyLista.Add(T022);

            Random random = new Random();
            SzendvicsekSzama = random.Next(2, 5);
            Kedve = random.Next(60, 100);
            Update();
            #endregion

            Bevezeto();
            Szomod();
        }

        #region Adatok
        public static void Update()
        {
            int[] adatok = { Viz, Ehes, Kedve, Telefon};
            for (int i = 0; i < 4; i++)
            {
                
                if (adatok[i] > 100)
                    adatok[i] = 100;
                AtiStatok[i] = adatok[i];
                if (adatok[i] < 0)
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine("Nem vigyáztál az atikádra így kifogyott valamelyik alapvető erőjéből");
                    Thread.Sleep(10000);
                    Environment.Exit(0);
                }

            }
                
        }

        public static List<Action> NagyLista = new List<Action>();

        public static bool Annacska { get; set; } = true;
        public static bool NapElkezdese { get; set; } = true;
        public static int BentToltottOrak { get; set; } = 0;
        public static bool JedlikbenVagy { get; set; } = false;
        public static int Viz { get; set; } = 100;
        public static int Ehes { get; set; } = 100;
        public static int Telefon { get; set; } = 100;
        public static int Kedve { get; set; } = 0;
        public static int SzendvicsekSzama { get; set; } = 0;

        public static int[] AtiStatok { get; set; } = { Viz, Ehes, Kedve, Telefon };

        #endregion

        #region Jedlik Elott

        static void Bevezeto()
        {
            Console.WriteLine("░█████╗░████████╗██╗██╗░░██╗░█████╗░");
            Console.WriteLine("██╔══██╗╚══██╔══╝██║██║░██╔╝██╔══██╗");
            Console.WriteLine("███████║░░░██║░░░██║█████═╝░███████║");
            Console.WriteLine("██╔══██║░░░██║░░░██║██╔═██╗░██╔══██║");
            Console.WriteLine("██║░░██║░░░██║░░░██║██║░╚██╗██║░░██║");
            Console.WriteLine("╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝");
            Console.WriteLine("");
            Console.WriteLine("░██████╗███████╗██╗███╗░░░███╗██╗░░░██╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░");
            Console.WriteLine("██╔════╝╚════██║██║████╗░████║██║░░░██║██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗");
            Console.WriteLine("╚█████╗░░░███╔═╝██║██╔████╔██║██║░░░██║██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝");
            Console.WriteLine("░╚═══██╗██╔══╝░░██║██║╚██╔╝██║██║░░░██║██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗");
            Console.WriteLine("██████╔╝███████╗██║██║░╚═╝░██║╚██████╔╝███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║");
            Console.WriteLine("╚═════╝░╚══════╝╚═╝╚═╝░░░░░╚═╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
            Thread.Sleep(5000);
            Console.Clear();
        }
        static void MaradjOtthon()
        {
            Console.WriteLine("\n\nAtikának rossz volt a közérzete így otthon maradt majd holnap megpróbálja újra");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
        static void Szomod()
        {
            Valasztas(0);
        }
        static void Tata()
        {
            Valasztas(1);
        }

        static void TataiVasutallomas()
        {
            Valasztas(2);
        }
        static void GyoriVautallomas()
        {
            Valasztas(3);
        }

        #endregion

        #region Jedlik

        static void Jedlik()
        {

            Valasztas(4);
        }
        static void AEpulet()
        {
            Valasztas(5);
        }
        static void BEpulet()
        {
                Valasztas(6);
        }
        static void ElsoEmelet()
        {
                Valasztas(7);
        }
        static void MasodikEmelet()
        {
                Valasztas(8);
        }
        static void HarmadikEmelet()
        {
                Valasztas(9);
        }
        static void ElsoEmeletB()
        {
                Valasztas(10);
        }
        static void HarmadikEmeletB()
        {
                Valasztas(11);
        }

        #endregion
        
        #region Termek Első emelet

        static void T12()
        {
            Irodalom.IrodalomGame();
            BentToltottOrak += 1;
            Console.WriteLine("12 terem \n Irodalom van atika unatkozik");
            Thread.Sleep(2000);
        }
        static void T14()
        {
            Fizika.FizikaGame();
            BentToltottOrak += 1;
            Console.WriteLine("14 terem \n Fizika van atika szenved");
            Thread.Sleep(2000);
        }
        static void T15()
        {
            Fizika.FizikaGame();
            BentToltottOrak += 1;
            Console.WriteLine("15 terem \n Fizika van atika szenved");
            Thread.Sleep(2000);
        }
        static void T025()
        {
            Matek.MatekGame();
            BentToltottOrak += 1;
            Console.WriteLine("025 terem \n Matek van Atika a sötétségből a homály felé mozog");
            Thread.Sleep(2000);
        }
        
        static void T022()
        {
            Nyelvtan.NyelvtanGame();
            BentToltottOrak += 1;
            Console.WriteLine("025 terem \n Matek van Atika a sötétségből a homály felé mozog");
            Thread.Sleep(2000);
        }


        #endregion
        
        #region Termek Masodik emelt

        static void T106()
        {
            Tori.ToriGame();
            BentToltottOrak += 1;
            Console.WriteLine("106 terem \n Töri van Atika próbál figyelni");
            Thread.Sleep(2000);
        }
        static void T108()
        {
            Nemet.NemetGame();
            BentToltottOrak += 1;
            Console.WriteLine("108 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }
        static void T110()
        {
            Nemet.NemetGame();
            BentToltottOrak += 1;
            Console.WriteLine("110 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }
        static void T112()
        {
            Console.WriteLine("Részt veszel az órán vagynem ?");
            Thread.Sleep(800);
            Console.WriteLine("Csak vicceltem megy a tiktok");
            Telefon -= 20; 
            BentToltottOrak += 1;
            Console.WriteLine("112 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }

        #endregion
        
        #region Termek Harmadik emelet

        static void T202()
        {
            AdatBazis.AdtaBazisGame();
            BentToltottOrak += 1;
            Console.WriteLine("202 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }
        static void T204()
        {
            Matek.MatekGame();  
            BentToltottOrak += 1;
            Console.WriteLine("204 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }
        static void T208()
        {
            Irodalom.IrodalomGame();
            BentToltottOrak += 1;
            Console.WriteLine("208 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }
        static void T212()
        {
            Tori.ToriGame();
            BentToltottOrak += 1;
            Console.WriteLine("212 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }
        static void TT4()
        {
            SzakmaiAngol.SzakmaiAngolGame();
            BentToltottOrak += 1;
            Console.WriteLine("T4 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }
        static void TT6()
        {
            Nemet.NemetGame();
            BentToltottOrak += 1;
            Console.WriteLine("T6 terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }

        #endregion
        
        #region Termek Első emelet B

        static void TTesi()
        {
            Tesi.TesiGame();
            BentToltottOrak += 1;
            Console.WriteLine("Tesi terem \n Fizika van atika unatkozik");
            Thread.Sleep(2000);
        }

        #endregion
        
        #region Termek Harmadik emelet B

        static void TB7()
        {
            DigitalTechnika.DigitalTechGame();
            BentToltottOrak += 1;
            //Nyomod szücsi
            Console.Clear();
            Console.WriteLine("Nyomod szücsi");
            Thread.Sleep(2000);
        }
        static void TB8()
        {
            
            BentToltottOrak += 1;
            //Hörbi geci
            Console.Clear();
            Console.WriteLine("Hörbi geci");
            Thread.Sleep(2000);
        }

        #endregion
        
        #region Termek Plussz, Kaja, Kondi

        static void Bufe()
        {
            if (Annacska == true)
            {
                string[] BufeKaja = { "Melegszendvics", "Sima Hamburger", "Sajt Burger", "Pizza", "Fánk"};
                string[] BufeKajanevek = { "melegszendvicset", "sima hamburgert", "sajt burgert", "pizzát", "fánkot"};
                int[] BufeKajaAdatok = { 20, 20, 15, 15, 5};
                Console.WriteLine("    _________________________________");
                for (int i = 0; i < BufeKaja.Length; i++)
                {
                        Console.Write($" {i+1}.|\t{BufeKaja[i]}\t");
                        int top = Console.CursorTop;
                        Console.SetCursorPosition(37, top);
                        Console.WriteLine("|");
                        Console.WriteLine($"   |_________________________________|");
                }
                Console.Write("\nAjánlott használni a varázsszavakat: Szeretnék , Légyszíves\n\n Ide írhatod mit szeretnél: ");
                string bejovo = Console.ReadLine().ToLower();
                if (bejovo.Contains("szeretnék") || bejovo.Contains("légyszíves"))
                {
                    for (int i = 0; i < BufeKaja.Length; i++)
                    {
                        if (bejovo.Contains(BufeKajanevek[i]))
                        {
                            Ehes += BufeKajaAdatok[i];
                            Console.WriteLine($"Megkaptad a {BufeKajanevek[i]}");
                            Console.WriteLine("Jó étvágyat");
                            break;
                        }
                        else if (i == BufeKajanevek.Length - 1)
                            Console.WriteLine("Sajnos nincs olyan amit kérsz legközelebb legyél pontosabb és megkapod ");
                    }
                }
                else
                {
                    Console.WriteLine("Bunkó voltál Annával ma már ne számíts kiszolgálásra");
                    Annacska = false;
                }
            }
            else
            {
                Console.WriteLine("Bunkó voltál így ma már nem fogadnak a büfében\n\n Legközelebb figyelj hogyan kérsz ételt!");
            }
            Thread.Sleep(3000);
        }

        static void TPLC()
        {
            PLC.PLCGame();
            BentToltottOrak += 1;
            Console.WriteLine("Plc van");
            Thread.Sleep(2000);
        }

        static void WC()
        {
            Viz = 100;
            Console.WriteLine("WC-zett és feltöltötte a kulacsát");
            Thread.Sleep(2000);
            
        }
        static void Kondi()
        {
            Console.Clear();
            AtikaEroKiiras();
            Console.WriteLine("\n\tKondi van");
            Thread.Sleep(2000);
            Console.Clear();
            KondiGame();
            Console.Clear();
            Console.WriteLine("\n\tGo haza");
            Thread.Sleep(1500);
        }

        static void Kaja()
        {
            AtikaEroKiiras();
            if (SzendvicsekSzama > 0)
            {
                Console.WriteLine($"\tSzendvicsek száma {SzendvicsekSzama}");
                Console.WriteLine("\tBulkingolás van");
                SzendvicsekSzama -= 1;
                Ehes += 15;
            }
            else
            {
                Console.WriteLine("\tA szendvicseid száma: 0");
                Console.WriteLine("\tAtika most nem tud enni");
            }
            Thread.Sleep(2000);
            Console.Clear();
        }

        #endregion
        
        #region Atika Erőkiírás, Óra választás, Kondi

        static void AtikaEroKiiras()
        {
            
            string[] Nevek = { "Víze", "Kajája", "Kedve", "Akkumlátor" };
            ConsoleColor[] szinek = { ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Green };

            Console.Write("\n\n  ====================================================================================================================\n  ");
            for (int i = 0; i < Nevek.Length; i++)
            {
                Console.Write($"{Nevek[i]}: ");
                Console.Write(AtikaEroi(AtiStatok[i], szinek[i]));
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"|  {AtiStatok[i]}%\t");
            }
            Console.WriteLine("\n  ====================================================================================================================\n");
            Update();
        }

        static string AtikaEroi(int ero, ConsoleColor color)
        {
            string visszamegy = "";
            int a = ero / 10;
            Console.ForegroundColor = color;
            Console.BackgroundColor = color;
            for (int i = 0; i < a; i++)
                visszamegy += "-";
            return visszamegy;
        }

        public static string[,,] Orak { get; set; } =
        {
        {/*0 Szomod*/ {"Maradjunk itthon","Tata","Kondi","Kaja","","","","","","", ""} },
        {/*1 Tata*/ {"Vissza haza","Tatai vasutállomás","Kondi","Kaja","","","","","","", ""} },
        {/*2 Tatai vasútállomás*/ {"Tata","Győri vasútállomás","Kaja","","","","","","","", ""} },
        {/*3 Győri Vasútállomás*/ {"Vissza Tatai vasutállomásra","Jedlik", "Kaja","","","","","","","", ""} },
        {/*4 Jedlik*/ {"Go Haza","A-épület","B-épület","Kaja","Büfé","","","","","","" } },
        {/*5 AEpulet*/ {"Jedlik","1.emelt","2.emelet","3.emelet","PLC terem","Kaja","","","","",""} },
        {/*6 BEpulet*/ {"Jedlik","1.emelt","3.emelet","Kaja","","","","","","",""} },
        {/*7 ElsoEmelet*/ {"Jedlik","2.emlet","3.emlet","WC","12.terme (Irodalom)","14.terem (Fizika)","15.terem (Fizika)","025.terem (Matek)","022.terem (Nyelvtan)","Kaja",""} },
        {/*8 MasodikEmelet*/ {"Jedlik","1.emelet","3.emelet","WC","106.terme (Töri)","108.terem (Német)","110.terem (Német)","112.terem (Ofő)","Kaja","",""} },
        {/*9 HarmadikEmelet*/ {"Jedlik","1.emelet","2.emelet","WC","202.terme (Adatbázis)","204.terem (Matek)","208.terem (Irodalom)","212.terem (Töri)","T4.terme  (Szakmai angol)","T6.terme  (Német)","Kaja"} },
        {/*10 ElsEmeletB*/ {"Jedlik","3.emelet","WC","Torna terme (Tesi)","Kaja","","","","","",""} },
        {/*11 HarmadikEmletB*/ {"Jedlik","1.emelet","WC","B7.terme (Digitális technika)","B8.terme (Hálózat)","Kaja","","","","",""} },
        };
        public static int[,,] OrakIndex { get; set; } =
        {
            {/*0 Szomod*/ {34, 1, 13, 14, 00, 00, 00, 00, 00, 00, 00 } },
            {/*1 Tata*/ {0, 2, 13, 14, 00, 00, 00, 00, 00, 00, 00 } },
            {/*2 Tatai vasútállomás*/ { 1, 3, 14, 00, 00, 00, 00, 00, 00, 00, 00 } },
            {/*3 Győri Vasútállomás*/ { 2, 4, 14, 00 ,00 ,00, 00, 00, 00, 00, 00 } },
            {/*4 Jedlik*/ { 3, 5, 6, 14, 33, 00, 00, 00, 00, 00, 00 } },
            {/*5 AEpulet*/ { 4, 7, 8, 9, 15, 14, 00, 00, 00, 00, 00 } },
            {/*6 BEpulet*/ { 4, 10, 11, 14, 00, 00, 00, 00, 00, 00, 00} },
            {/*7 ElsoEmelet*/ { 4, 8, 9, 12, 17, 18, 19, 16, 35, 14, 00 } },
            {/*8 MasodikEmelet*/ { 4, 7, 9, 12, 20, 21, 22, 23, 14, 00, 00  } },
            {/*9 HarmadikEmelet*/ { 4, 7, 8, 12, 24, 25, 26, 27, 28, 29, 14 } },
            {/*10 ElsEmeletB*/ { 4, 11, 12, 30, 14, 00, 00, 00, 00, 00, 00 } },
            {/*11 HarmadikEmletB*/ { 4, 10, 12, 31, 32, 14, 00, 00, 00, 00, 00 } },
        };
        static void Valasztas(int melyikHely)
        {
            Console.CursorVisible = false;
            int[] Hosszok = { 4, 4, 3, 3, 5, 6, 4, 10, 9, 11, 5, 6 , 2};
            Update();
            Console.Clear();
            AtikaEroKiiras();
            Console.WriteLine("    _________________________________");
                                

            for (int j = 0; j < Hosszok[melyikHely]; j++)
            {
                if (j == 0)
                {
                    Console.Write($" {j+1}.|\t");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($"{Orak[melyikHely, 0, j]}\t");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    int top = Console.CursorTop;
                    Console.SetCursorPosition(37, top);
                    Console.WriteLine("|");
                    Console.WriteLine("   |_________________________________|");

                }
                else
                {
                    Console.Write($" {j+1}.|\t{Orak[melyikHely, 0, j]}\t");
                    int top = Console.CursorTop;
                    Console.SetCursorPosition(37, top);
                    Console.WriteLine("|");
                    Console.WriteLine($"   |_________________________________|");
                }

            }
            int b = 0;
            while (true)
            {
                ConsoleKey a;
                a = Console.ReadKey().Key;
                Console.Clear();


                if (a == ConsoleKey.Enter)
                {
                    Random rnd = new Random();
                    if (OrakIndex[melyikHely, 0, b] == 3 && BentToltottOrak > 6)
                    {
                        Viz -= rnd.Next(2, 6);
                        Ehes -= rnd.Next(2, 6);
                        Kedve -= rnd.Next(2, 4);
                        Telefon -= rnd.Next(2, 4);
                        NagyLista[OrakIndex[melyikHely,0,b]].Invoke();
                        Console.Clear();
                        Update();
                    }
                    else if (JedlikbenVagy == true && OrakIndex[melyikHely, 0, b] == 3 && BentToltottOrak < 7 )
                    {
                        Console.WriteLine($"Sajnos Atinak ma még bent kell maradnia {7 - BentToltottOrak} órát utánna mehet csak haza. :(");
                        Thread.Sleep(2500);
                        Console.Clear();
                    }
                    else
                    {
                        if (OrakIndex[melyikHely, 0, b] == 4)
                            JedlikbenVagy = true;
                        Viz -= rnd.Next(2, 6);
                        Ehes -= rnd.Next(2, 6);
                        Kedve -= rnd.Next(2, 4);
                        Telefon -= rnd.Next(2, 4);
                        NagyLista[OrakIndex[melyikHely, 0, b]].Invoke();
                        Console.Clear();
                        Update();
                    }
                }
                if (a == ConsoleKey.DownArrow) b++;
                if (a == ConsoleKey.UpArrow) b--;
                if (b == Hosszok[melyikHely]) b = 0;
                if (b < 0) b = Hosszok[melyikHely]-1;

                AtikaEroKiiras();

                Console.WriteLine("    _________________________________");

                for (int i = 0; i < Hosszok[melyikHely]; i++)
                {
                    if (i == b)
                    {
                        Console.Write($" {i+1}.|\t");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"{Orak[melyikHely, 0, i]}\t");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        int top = Console.CursorTop;
                        Console.SetCursorPosition(37, top);
                        Console.WriteLine("|");
                        Console.WriteLine("   |_________________________________|");
                    }
                    else
                    {
                        Console.Write($" {i+1}.|\t{Orak[melyikHely, 0, i]}\t");
                        int top = Console.CursorTop;
                        Console.SetCursorPosition(37, top);
                        Console.WriteLine("|");
                        Console.WriteLine($"   |_________________________________|");
                    } 
                }
                
            }

        }
        static void KondiGame()
        {
            int suly = kivalasztas();
            int b = suly;
            int c = suly;
            ConsoleKey valami = ConsoleKey.F1;
            int korSzam = 0;
            Random rand = new Random();

            int isCanceled = 0;
            Console.CursorVisible = false;
            Thread thread = new Thread(() =>
            {
                while (isCanceled == 0 && (b != 0 || c != 0))
                {
                    lock (consoleLock)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 2);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < b; i++)
                        {
                            Console.SetCursorPosition(0, 6 + i);
                            Console.Write("-");
                        }
                        for (int i = 0; i < c; i++)
                        {
                            Console.SetCursorPosition(10, 6 + i);
                            Console.Write("-");
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(0, 4);
                        Console.Write($"b = {b} c = {c}");
                    }

                    b += korSzam % 2 == 1 ? rand.Next(0, 2) : 0;
                    c += korSzam % 2 == 1 ? rand.Next(0, 2) : 0;
                    korSzam++;
                    do
                    {
                        if(Console.KeyAvailable)
                            valami = Console.ReadKey(true).Key;
                    }
                    while (isCanceled == 0 && valami != ConsoleKey.D && valami != ConsoleKey.K);
                    if (isCanceled == 0)
                    {
                        if (valami == ConsoleKey.D)
                        {
                            if (b > 0) --b;
                            else b = 0;
                        }
                        else
                        {
                            if (c > 0) --c;
                            else c = 0;
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
                Console.WriteLine("\n\n\tAz időd lejárt Sajnos vesztettél atika így elveszít 20 kedv pontot :(");
                Kedve -= 20;
                Ehes -= 15;
                Viz -= 20;
                Update();
            }
            else
            {
                Console.WriteLine("\n\n\tGratulálunk!! Atikának sikerült ez a sett (+5 Kedv)");
                Kedve += 5;
                Ehes -= 15;
                Viz -= 20;
                Console.WriteLine($"\tEnnyi időd maradt: {maradekido:f2}s");
                Update();
            }
            Thread.Sleep(5000);
        }

        static int kivalasztas()
        {
            AtikaEroKiiras();
            Console.WriteLine("\tHány kg szeretnél nyomni?\t (Ha atika nem tudja kinyomni akkor -20 kedv pontot fog kapni figyelj erre)\n\t\t\t\t\t(Alapvető minuszok: -15 víz és kaja potn )\n");
            Console.Write("  ====================================================================================================================\n  ");
            Console.WriteLine("  _________________________________");
            for (int i = 1; i < 10; i++)
            {
                Console.Write($" {i}.|\t");
                Console.Write($"{(i * 2 + 10) * 2}kg");
                int top = Console.CursorTop;
                Console.SetCursorPosition(37, top);
                Console.WriteLine("|");
                Console.WriteLine($"   |_________________________________|");
            }
            char valasztasod;
            do
            {
                valasztasod = Console.ReadKey(true).KeyChar;
            } 
            while (valasztasod > 57 || valasztasod <= 48);
            Console.Clear();
            Console.WriteLine("\n\n\tA kinyomást a D és K billentyűzettel tudod csinálni. Nyomkodd őket amilyen gyorsan csak tudod!");
            Thread.Sleep(5000);
            return ((valasztasod - 48) * 2) + 10;


        }

        static void PisslantasMiniGame()
        {
            Console.WriteLine($"\n\n\t\t Atika elfelejtett pislantani lérlek segíts neki és nyomj meg egy gombot hogy pislantson.");
            Console.ReadKey();
        }

        //static string AtikaOraszoveg()
        //{
        //    string[,] AtiSzovegek =
        //    {
        //    /*Irodalom*/{"Irodalom óra\n Csokonai munkásságát tanulja","Irodalom óra\n Atika csinálja az ipart (TikTok)" },
        //    /*Fizika*/{"Fizika óra\n ", "Fizika óra\n Nem tud mit tenni, telefonozik" },
        //    /*Matek*/{"Matek óra\n Cuki oldogatja a matekfeladatokat és harcol a műveletekkel", "Matek óra\n Atika becsületesen TikTokozik"  },
        //    /*Német*/{"Német van\n Ich möchte eine Kenyér", "Német van\n Menjen aminek menni kell ..."  },
        //    /*Ofő*/{"Ofő óra\n Egy kis TikTok belefér szerinte ", "Ofő óra\n Beszélget Karolyékakl"  },
        //    /*Töri*/{"Törióra\n Máasodik világháborút tanulgatja", "Törióra\n Atika szenved"  },
        //    /*Szakmai Angol*/{"Szakmai Angol\n ", "Szakmai Angol\n"  },
        //    /*Adatbázis kezelés*/{"", ""  },
        //    /*Tesi*/{"", ""  },
        //    /*Digitális Technika*/{"", ""  },
        //    /*Hálózat*/{"", ""  },
        //    };

        //}

        #endregion
    }
}