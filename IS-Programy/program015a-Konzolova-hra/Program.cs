using System;

class Program
{
    static char[,] mapa = null!;
    static int hracX, hracY;
    static int enemyX, enemyY;
    static Random rnd = new Random();

    static void Main()
    {
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            ZobrazMenu();

            ConsoleKey volba = Console.ReadKey(true).Key;

            if (volba == ConsoleKey.D1 || volba == ConsoleKey.NumPad1)
                SpustitHerniRezim();
            else if (volba == ConsoleKey.D2 || volba == ConsoleKey.NumPad2)
                ZobrazOAutorovi();
            else if (volba == ConsoleKey.D3 || volba == ConsoleKey.NumPad3 || volba == ConsoleKey.Escape)
                break;
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

    static void ZobrazOAutorovi()
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
        Console.ReadKey(true);
    }

    static void SpustitHerniRezim()
    {
        while (true)
        {
            InicializujHru();
            bool vyhra = HrajKolo();

            Console.Clear();
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

            ConsoleKey k = Console.ReadKey(true).Key;
            if (k == ConsoleKey.Escape)
                return;
        }
    }

    static void InicializujHru()
    {
        mapa = new char[,]
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

        SpawnEnemy();
    }

    static void SpawnEnemy()
    {
        int x, y;
        do
        {
            x = rnd.Next(1, mapa.GetLength(1) - 1);
            y = rnd.Next(1, mapa.GetLength(0) - 1);
        }
        while (mapa[y, x] != '.');

        enemyX = x;
        enemyY = y;
        mapa[y, x] = 'X';
    }

    static bool HrajKolo()
    {
        while (true)
        {
            Console.SetCursorPosition(0, 0);
            VykresliMapu();
            Console.WriteLine("\nPohyb: W A S D | ESC = Konec");

            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
                return false;

            bool vyhra;
            bool prohra;

            PohybHrace(key, out vyhra, out prohra);
            if (vyhra) return true;
            if (prohra) return false;

            if (PohybEnemy())
                return false;
        }
    }

    static void VykresliMapu()
    {
        for (int y = 0; y < mapa.GetLength(0); y++)
        {
            Console.Write("  ");
            for (int x = 0; x < mapa.GetLength(1); x++)
            {
                if (mapa[y, x] == 'P') Console.ForegroundColor = ConsoleColor.Green;
                else if (mapa[y, x] == 'X') Console.ForegroundColor = ConsoleColor.Red;
                else if (mapa[y, x] == 'E') Console.ForegroundColor = ConsoleColor.Yellow;
                else if (mapa[y, x] == '#') Console.ForegroundColor = ConsoleColor.DarkGray;
                else Console.ForegroundColor = ConsoleColor.White;

                Console.Write(mapa[y, x] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    static void PohybHrace(ConsoleKey key, out bool vyhra, out bool prohra)
    {
        vyhra = false;
        prohra = false;

        int nx = hracX;
        int ny = hracY;

        if (key == ConsoleKey.W) ny--;
        if (key == ConsoleKey.S) ny++;
        if (key == ConsoleKey.A) nx--;
        if (key == ConsoleKey.D) nx++;

        if (mapa[ny, nx] == '#') return;

        if (mapa[ny, nx] == 'E')
        {
            vyhra = true;
            return;
        }

        if (mapa[ny, nx] == 'X')
        {
            prohra = true;
            return;
        }

        mapa[hracY, hracX] = '.';
        hracX = nx;
        hracY = ny;
        mapa[hracY, hracX] = 'P';
    }

    static bool PohybEnemy()
    {
        int smer = rnd.Next(4);
        int nx = enemyX;
        int ny = enemyY;

        if (smer == 0) ny--;
        if (smer == 1) ny++;
        if (smer == 2) nx--;
        if (smer == 3) nx++;

        if (mapa[ny, nx] == '#' || mapa[ny, nx] == 'E')
            return false;

        if (mapa[ny, nx] == 'P')
            return true;

        mapa[enemyY, enemyX] = '.';
        enemyX = nx;
        enemyY = ny;
        mapa[enemyY, enemyX] = 'X';

        return false;
    }
}
