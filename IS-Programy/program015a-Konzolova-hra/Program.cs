using System;
//Načte knihovnu System – bez ní nejde používat Console, Random atd.

class Program
//Začátek třídy Program – v ní je celý program.
{
    static char[,] mapa = null!; 
    //Dvourozměrné pole znaků – bludiště.
    //null! říká: „teď je to prázdné, ale později to určitě nastavím“.

    static int hracX, hracY;
    static int enemyX, enemyY;
    //Souřadnice hráče a nepřítele v mapě.

    static Random rnd = new Random(); 
    //Generátor náhodných čísel – pro pohyb nepřítele a jeho spawn.

    static void Main() //Hlavní funkce programu – tady to všechno začíná.
    {
        Console.CursorVisible = false;
                //Skryje blikající kurzor – aby hra vypadala líp.

        while (true) 
        {
            Console.Clear();
            ZobrazMenu(); 
                //Nekonečná smyčka menu:
                        // vymaže obrazovku,
                        //   zobrazí menu.


            ConsoleKey volba = Console.ReadKey(true).Key; 
                //Načte stisknutou klávesu, ale nezobrazí ji na obrazovce.

            if (volba == ConsoleKey.D1 || volba == ConsoleKey.NumPad1) 
                SpustitHerniRezim();
                        //Když stiskneš 1 → spustí se hra.

            else if (volba == ConsoleKey.D2 || volba == ConsoleKey.NumPad2)
                ZobrazOAutorovi();
                        //Když 2 → info o hře.

            else if (volba == ConsoleKey.D3 || volba == ConsoleKey.NumPad3 || volba == ConsoleKey.Escape)
                break; 
                        //3 nebo ESC → konec programu.
        }
    }

    static void ZobrazMenu()
    //Funkce, která jen vypisuje menu.
    {   
        //Barevné výpisy:
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("================================");
        Console.WriteLine("     🏰 ÚTĚK Z BLUDIŠTĚ 🏰      ");
        Console.WriteLine("================================");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("    [1] Spustit hru");
        Console.WriteLine("    [2] O hře a autorovi");
        Console.WriteLine("    [3] Konec");
    }

    static void ZobrazOAutorovi()
    //Vypíše informace o hře, autorovi a ovládání.
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*****************************************");
        Console.WriteLine("*             O PROJEKTU                *");
        Console.WriteLine("*****************************************");
        Console.WriteLine();
        Console.WriteLine(" Autor: Amálie Musilová");
        Console.WriteLine();
        Console.WriteLine(" CÍL: dojdi k východu 'E'");
        Console.WriteLine(" NEPŘÍTEL: vyhýbej se 'X'");
        Console.WriteLine();
        Console.WriteLine(" OVLÁDÁNÍ: W A S D");
        Console.WriteLine(" ESC: návrat");
        Console.WriteLine();
        Console.WriteLine("*****************************************");
        Console.ResetColor();
                    //Nastaví barvu textu a pak ji vrátí zpět.

        Console.ReadKey(true);
                   // Čeká, až hráč něco zmáčkne, aby se mohl vrátit do menu.
    
    }

    static void SpustitHerniRezim() //static void → nic nevrací.
    {
        while (true)
        {
            InicializujHru();
            bool vyhra = HrajKolo();
                       // Nekonečný cyklus hraní:
                       //       nastaví novou hru,
                       //       zahraje jedno kolo.


            Console.Clear();

            //Podle výsledku vypíše výhru nebo prohru.
            if (vyhra)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n🎉 VÍTĚZSTVÍ! 🎉");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n💀 PROHRÁL JSI! 💀");
            }
            Console.ResetColor();

            Console.WriteLine("\n[A] Hrát znovu");
            Console.WriteLine("[ESC] Menu");

            ConsoleKey k = Console.ReadKey(true).Key; //Načte klávesu.
            if (k == ConsoleKey.Escape)
                return;
                    //ESC → návrat do menu.
        }
    }

    static void InicializujHru()
    {
        mapa = new char[,] //, --> dvourozměrné pole znaků.
                //Vytvoří pevně dané bludiště:
                // # = zeď
                // . = cesta
                // E = východ

        {
            { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
            { '#','P','.','.','.','#','.','.','.','.','.','.','E','.','#' },
            { '#','#','#','#','.','#','.','#','#','#','#','.','#','.','#' },
            { '#','.','.','.','.','.','.','.','.','.','#','.','#','.','#' },
            { '#','.','#','#','#','#','.','#','#','.','#','.','#','.','#' },
            { '#','.','.','.','.','.','.','.','.','.','.','.','.','.','#' },
            { '#','.','#','#','#','.','#','#','#','.','#','#','#','.','#' },
            { '#','.','.','.','.','.','.','.','.','.','.','.','.','.','#' },
            { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
        };

        hracX = 1;
        hracY = 1;
                //Hráč začíná na souřadnici (1,1).

        SpawnEnemy();
                //Vytvoří nepřítele na náhodném místě.      
                }

    static void SpawnEnemy()
    {
        //Hledá náhodné místo, kde je tečka – tedy volná cesta.
        int x, y; //Souřadnice nepřítele.
        do //Opakuj, dokud nenajdeš volné místo.
        {
            x = rnd.Next(1, mapa.GetLength(1) - 1); //GetLength(1) je šířka pole (počet sloupců).
            y = rnd.Next(1, mapa.GetLength(0) - 1);     //GetLength(0) je výška pole (počet řádků).
        }
        while (mapa[y, x] != '.'); //Pokud tam není tečka, zkus to znovu.


        enemyX = x;     //Nastaví souřadnice nepřítele.
        enemyY = y;     
        mapa[y, x] = 'X';
                    //Na to místo dá nepřítele.
    }

    static bool HrajKolo() //Vrátí true = výhra, false = prohra.
    {
        while (true) 
        {
            Console.SetCursorPosition(0, 0); //Vrátí kurzor na začátek obrazovky.
            VykresliMapu();
                        //Pořád dokola:
                        //   vrátí kurzor nahoru,
                        //      znovu vykreslí mapu.

            Console.WriteLine("\nPohyb: W A S D | ESC = Konec"); //Nápověda pro hráče.

            ConsoleKey key = Console.ReadKey(true).Key; //Načte hráčův pohyb.
            if (key == ConsoleKey.Escape) //ESC 
                return false;
                    //ESC = konec kola (prohra / odchod).

            bool vyhra; //Výsledek pohybu hráče.
            bool prohra; 

            PohybHrace(key, out vyhra, out prohra); //Posune hráče podle klávesy.
            if (vyhra) return true; 
            if (prohra) return false; 
                       // Když dojde k cíli → výhra.
                              // Když narazí na nepřítele → prohra.


            if (PohybEnemy()) //Posune nepřítele náhodně.
                return false; //^Pohne nepřítelem.
                                    // Když narazí na hráče → prohra.
        }
    }

    static void VykresliMapu()
    {
        for (int y = 0; y < mapa.GetLength(0); y++) //Projde všechny řádky.
        {
            Console.Write("  "); 
            for (int x = 0; x < mapa.GetLength(1); x++) //Projde všechny sloupce.
            {
                if (mapa[y, x] == 'P') Console.ForegroundColor = ConsoleColor.Green; //Změní barvu podle toho, co je na dané pozici.
                else if (mapa[y, x] == 'X') Console.ForegroundColor = ConsoleColor.Red; //Nepřítel červeně.
                else if (mapa[y, x] == 'E') Console.ForegroundColor = ConsoleColor.Yellow; //Východ žlutě.
                else if (mapa[y, x] == '#') Console.ForegroundColor = ConsoleColor.DarkGray; //Zdi tmavě šedě.
                else Console.ForegroundColor = ConsoleColor.White; //Cesty bíle.

                Console.Write(mapa[y, x] + " "); //Vypíše znak a mezeru za ním.
                Console.ResetColor(); //Vrátí barvu zpět na výchozí.
            }
            Console.WriteLine();
        }
    }

    static void PohybHrace(ConsoleKey key, out bool vyhra, out bool prohra) //out = vrací více hodnot.
    {
        vyhra = false; 
        prohra = false;

        int nx = hracX; 
        int ny = hracY; //Dočasné nové souřadnice. 

        if (key == ConsoleKey.W) ny--; //Podle klávesy změní směr.
        if (key == ConsoleKey.S) ny++;
        if (key == ConsoleKey.A) nx--;
        if (key == ConsoleKey.D) nx++;

        if (mapa[ny, nx] == '#') return;
                //Do zdi se nesmí. Pokud je tam #, nic se nestane.

        if (mapa[ny, nx] == 'E')
                //Došel do cíle → výhra.
        {
            vyhra = true;
            return;
        }

        if (mapa[ny, nx] == 'X')
                //Narazil do nepřítele → prohra.
        {
            prohra = true;
            return;
        }

        mapa[hracY, hracX] = '.';
        hracX = nx;
        hracY = ny;
        mapa[hracY, hracX] = 'P';
                //Posune hráče:
                    // staré místo = tečka,
                    // nové místo = P.

    }

    static bool PohybEnemy()
    {
        int smer = rnd.Next(4); //Náhodně vybere směr: 0 = nahoru, 1 = dolů, 2 = doleva, 3 = doprava.
        int nx = enemyX; //Dočasné nové souřadnice.
        int ny = enemyY; 

        if (smer == 0) ny--; //Podle směru změní souřadnice.
        if (smer == 1) ny++; 
        if (smer == 2) nx--;
        if (smer == 3) nx++;

        if (mapa[ny, nx] == '#' || mapa[ny, nx] == 'E')
            return false;     //Nepřítel nemůže do zdi ani do cíle.
                

        if (mapa[ny, nx] == 'P')
            return true;      //Narazil na hráče → prohra.

        mapa[enemyY, enemyX] = '.'; //posune nepřítele:
        enemyX = nx; 
        enemyY = ny;
        mapa[enemyY, enemyX] = 'X';

        return false; //Nepřítel se nepohnul na hráče → pokračuj ve hře.
    }
}
