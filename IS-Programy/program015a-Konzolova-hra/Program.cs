using System;

class Program 
{
    //definice proměnných pro herní režim 
    static char[,] mapa = null!; // herní mapa
    static int hracX, hracY; // pozice hráče
    static int enemyX, enemyY; // pozice nepřítele
    static Random rnd = new Random(); // generátor náhodných čísel

    static void Main()
    {
        // Skryje blikající kurzor (aby obrazovka neposkakovala)
        Console.CursorVisible = false;

        // Hlavní smyčka menu
        while (true)
        {
            Console.Clear();
            ZobrazMenu();

            ConsoleKeyInfo volba = Console.ReadKey(true);

            if (volba.Key == ConsoleKey.D1 || volba.Key == ConsoleKey.NumPad1)
            {
                SpustitHerniRezim(); 
            }
            else if (volba.Key == ConsoleKey.D2 || volba.Key == ConsoleKey.NumPad2)
            {
                ZobrazOAutorovi();
            }
            else if (volba.Key == ConsoleKey.D3 || volba.Key == ConsoleKey.NumPad3 || volba.Key == ConsoleKey.Escape)
            {
                break; 
            }
        }
    }

    static void ZobrazMenu()
    {
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

    // TADY JE ZMĚNA: Místo tapíra je popis hry
    static void ZobrazOAutorovi()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*****************************************");
        Console.WriteLine("*             O PROJEKTU                *");
        Console.WriteLine("*****************************************");
        Console.WriteLine("");
        Console.WriteLine("  Autor:   Amálie Musilová");
        Console.WriteLine("  Verze:   1.0 (k zápočtovému testu)");
        Console.WriteLine("");
        Console.WriteLine("            --- CÍL HRY ---");
        Console.WriteLine("  Jsi hráč 'P' (zelená). Tvým úkolem");
        Console.WriteLine("  je najít cestu bludištěm k východu");
        Console.WriteLine("  označenému 'E' (žlutá).");
        Console.WriteLine("");
        Console.WriteLine("            --- NEBEZPEČÍ ---");
        Console.WriteLine("  Musíš se vyhýbat nepříteli 'X',");
        Console.WriteLine("  který se náhodně pohybuje.");
        Console.WriteLine("");
        Console.WriteLine("            --- OVLÁDÁNÍ ---");
        Console.WriteLine("  Pohyb: W, A, S, D");
        Console.WriteLine("  Konec: ESC");
        Console.WriteLine("");
        Console.WriteLine("*****************************************");
        Console.ResetColor();
        Console.WriteLine("\nZmáčkni klávesu pro návrat...");
        Console.ReadKey(true);
    }

    static void SpustitHerniRezim() //static void - nevrací nics
    {
        while (true) 
        {
            InicializujHru(); // Nastavení počátečního stavu hry
            bool vyhra = HrajKolo();  // Hlavní herní smyčka - bool označuje výhru nebo prohru

            Console.Clear(); 
            if (vyhra) // Pokud hráč vyhrál
            {
                Console.ForegroundColor = ConsoleColor.Green;   // Nastavení zelené barvy pro výhru
                Console.WriteLine("\n🎉 VÍTĚZSTVÍ! ÚSPĚŠNĚ JSI UTEKL! 🎉");
            }
            else // Pokud hráč prohrál
            {
                Console.ForegroundColor = ConsoleColor.Red;         // Nastavení červené barvy pro prohru
                Console.WriteLine("\n💀 PROHRÁL JSI! NEPŘÍTEL TĚ DOSTAL! 💀"); 
            }
            Console.ResetColor();

            Console.WriteLine("\n[A] Hrát znovu");  // Možnost restartu hry
            Console.WriteLine("[ESC] Menu");    // Návrat do menu

            ConsoleKey volba = Console.ReadKey(true).Key;               // Čtení volby uživatele
            if (volba == ConsoleKey.Escape) {Console.Clear();return;} // Návrat do menu
            Console.Clear();
        }
    }

    static void InicializujHru() // Nastavení počátečního stavu hry
    {
        mapa = new char[,] // Definice mapy bludiště
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

        hracX = 1; hracY = 1; // Počáteční pozice hráče
        enemyX = 13; enemyY = 5;// Počáteční pozice nepřítele
        mapa[enemyY, enemyX] = 'X'; // Umístění nepřítele na mapu
    }

    static bool HrajKolo() // Hlavní herní smyčka
    {
        while (true)
        {
            // Reset kurzoru na začátek (žádné scrollování)
            Console.SetCursorPosition(0, 0);  // Nastavení kurzoru na začátek konzole
            VykresliMapu(); // Vykreslení aktuální mapy

            Console.WriteLine("\nPohyb: W A S D | ESC = Konec"); // Instrukce pro hráče

            ConsoleKey klavesa = Console.ReadKey(true).Key;// Čtení vstupu hráče
            if (klavesa == ConsoleKey.Escape) return false; // Konec hry

            if (PohybHrace(klavesa)) return true; // Kontrola výhry
            
            PohybEnemy();
            if (hracX == enemyX && hracY == enemyY) return false; // Kontrola prohry
        }
    }

    static void VykresliMapu() // Vykreslení mapy na konzoli
    {
        for (int y = 0; y < mapa.GetLength(0); y++) // pro každý řádek
        {
            Console.Write("  "); 
            for (int x = 0; x < mapa.GetLength(1); x++) // pro každý sloupec
            {
                if (mapa[y, x] == 'P') Console.ForegroundColor = ConsoleColor.Green; // Hráč
                else if (mapa[y, x] == 'X') Console.ForegroundColor = ConsoleColor.Red; // Nepřítel
                else if (mapa[y, x] == 'E') Console.ForegroundColor = ConsoleColor.Yellow; // Východ
                else if (mapa[y, x] == '#') Console.ForegroundColor = ConsoleColor.DarkGray; // Zeď
                else Console.ForegroundColor = ConsoleColor.White; // Prázdný prostor   
                
                Console.Write(mapa[y, x] + " "); // Vykreslení znaku s mezerou
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    static bool PohybHrace(ConsoleKey klavesa) // Pohyb hráče podle vstupu
    {
        int novyX = hracX; 
        int novyY = hracY;

        if (klavesa == ConsoleKey.W) novyY--;
        if (klavesa == ConsoleKey.S) novyY++;
        if (klavesa == ConsoleKey.A) novyX--;
        if (klavesa == ConsoleKey.D) novyX++;

        if (novyX >= 0 && novyX < mapa.GetLength(1) && novyY >= 0 && novyY < mapa.GetLength(0)) // Kontrola hranic mapy
        {        //and ^  - takže if nové x jsou menší nebo rovny než šířka mapy a nové y menší nebo rovny než výška mapy
            if (mapa[novyY, novyX] != '#')// Kontrola zdi
            {
                if (mapa[novyY, novyX] == 'E') return true;// Kontrola výhry

                mapa[hracY, hracX] = '.'; // Vymazání staré pozice hráče
                hracX = novyX;
                hracY = novyY;
                mapa[hracY, hracX] = 'P'; // Umístění hráče na novou pozici
            }
        }
        return false; //vrátí se false, pokud hráč nevyhrál
    }

    static void PohybEnemy() // Náhodný pohyb nepřítele
    {
        int smer = rnd.Next(4); // 0 = nahoru, 1 = dolů, 2 = doleva, 3 = doprava
        int novyX = enemyX;
        int novyY = enemyY;

        if (smer == 0) novyY--; // nahoru
        if (smer == 1) novyY++; // dolů
        if (smer == 2) novyX--; // doleva
        if (smer == 3) novyX++; // doprava

        if (novyX >= 0 && novyX < mapa.GetLength(1) && novyY >= 0 && novyY < mapa.GetLength(0)) // Kontrola hranic mapy
        {
            if (mapa[novyY, novyX] != '#' && mapa[novyY, novyX] != 'E') // Kontrola zdi a východu
            {
                mapa[enemyY, enemyX] = '.'; // Vymazání staré pozice nepřítele
                enemyX = novyX;             // Aktualizace pozice nepřítele
                enemyY = novyY;             
                mapa[enemyY, enemyX] = 'X'; // Umístění nepřítele na novou pozici
            }
        }
    }
}