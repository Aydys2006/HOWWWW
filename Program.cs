using System.Diagnostics;
using System.Security;

namespace piano
{
    internal class Program
    { 
        public static int mnog = 1;
        static void txt()
        {Console.WriteLine("F2 - 2 октава \nF3 - 3 октава \nF4 - 4 октава \nF5 - 5 октава \nF6 - 6 октава \nF7 - 7 октава \nF8 - 8 октава");}
        static void ocktawa()
        {
            /*mnog = step == 0 ? 1 : for (int i; i <= step; i++) { mnog = mnog * 2};*/
            if (step == 0)
            {mnog = 1;}
            else
            {
                for (int i = 1; i <= step; i++)
                {
                    mnog = mnog * 2;
                }
            }
            bool done = false;
            while (!done)
            {
                int nota = 0;
                int z = 0;
                Console.Clear();
                Console.WriteLine("tab - чтобы вернуться к выбору октав\nНажимайте на следующие буквы, для того чтобы играть на пианино:");
                Console.WriteLine("||w|e|||t|y|u||\n|a|s|d|f|g|h|j|");
                ConsoleKeyInfo a = Console.ReadKey();
                switch (a.Key)
                {
                    case ConsoleKey.A:
                        nota = 65 * mnog;
                        break;
                    case ConsoleKey.W:
                        nota = 69 * mnog;
                        break;
                    case ConsoleKey.S:
                        nota = 73 * mnog;
                        break;
                    case ConsoleKey.E:
                        nota = 77 * mnog;
                        break;
                    case ConsoleKey.D:
                        nota = 82 * mnog;
                        break;
                    case ConsoleKey.F:
                        nota = 87 * mnog;
                        break;
                    case ConsoleKey.T:
                        nota = 92 * mnog;
                        break;
                    case ConsoleKey.G:
                        nota = 98 * mnog;
                        break;
                    case ConsoleKey.Y:
                        nota = 103 * mnog;
                        break;
                    case ConsoleKey.H:
                        nota = 110 * mnog;
                        break;
                    case ConsoleKey.U:
                        nota = 116 * mnog;
                        break;
                    case ConsoleKey.J:
                        nota = 123 * mnog;
                        break;
                    case ConsoleKey.Tab:
                        done = true;
                        z = 1;
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        z = 1;
                        break;
                    default:
                        Console.WriteLine("Не понял на что вы нажали");
                        z = 1;
                        break;
                }
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Такой нет)");
                        Thread.Sleep(100);
                        break;
                    default:
                        zv(nota);
                        break;
                }
            }
            mnog = 1;
            step = 0;
        }
        public static void zv(int nota)
        {
            Console.Beep(nota, 100);
        }
        public static int step = 0;
        static void Main(string[] args)
        {
            int b = 1;
            while (b == 1)
            {
                int z = 0;
                Console.Clear();
                txt();
                Console.Write("Выберите октаву:");
                ConsoleKeyInfo a = Console.ReadKey();
                Console.Clear();
                switch (a.Key)
                {
                    case ConsoleKey.F2:
                        step = 0;
                        break;
                    case ConsoleKey.F3:
                        step = 1;
                        break;
                    case ConsoleKey.F4:
                        step = 2;
                        break;
                    case ConsoleKey.F5:
                        step = 3;
                        break;
                    case ConsoleKey.F6:
                        step = 4;
                        break;
                    case ConsoleKey.F7:
                        step = 5;
                        break;
                    case ConsoleKey.F8:
                        step = 6;
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        z = 1;
                        break;
                }
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Такой нет)");
                        Thread.Sleep(100);
                        break;
                    default:
                        ocktawa();
                        break;
                }
            }
        }
    }
}