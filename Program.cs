namespace Pianino
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите какую октаву вы хотите. F1-первая, F2-вторая");
            vvod();
        }
        static void vvod()
        {
            while (true)
            {

                ConsoleKeyInfo a = Console.ReadKey();
                if (a.Key == ConsoleKey.F1)
                {
                    int[] oct1 = new int[] { 260, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                    octava1(oct1);
                }
                if (a.Key == ConsoleKey.F2)
                {
                    int[] oct2 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 923, 987 };
                    octava2(oct2);
                }
                if (a.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void octava1(int[] massive)
        {
            Console.WriteLine("Вы выбрали первую октаву.");
            while (true)
            {
                ConsoleKeyInfo b = Console.ReadKey();
                if (b.Key == ConsoleKey.A)
                {
                    Console.Beep(massive[0], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.O)
                {
                    Console.Beep(massive[1], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.E)
                {
                    Console.Beep(massive[2], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.R)
                {
                    Console.Beep(massive[3], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.T)
                {
                    Console.Beep(massive[4], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.Y)
                {
                    Console.Beep(massive[5], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.U)
                {
                    Console.Beep(massive[6], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.I)
                {
                    Console.Beep(massive[7], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.P)
                {
                    Console.Beep(massive[8], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.S)
                {
                    Console.Beep(massive[9], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.D)
                {
                    Console.Beep(massive[10], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.F)
                {
                    Console.Beep(massive[11], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void octava2(int[] massive)
        {
            Console.WriteLine("Вы выбрали вторую октаву.");
            while (true)
            {
                ConsoleKeyInfo b = Console.ReadKey();
                if (b.Key == ConsoleKey.F)
                {
                    Console.Beep(massive[0], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.G)
                {
                    Console.Beep(massive[1], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.H)
                {
                    Console.Beep(massive[2], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.J)
                {
                    Console.Beep(massive[3], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.K)
                {
                    Console.Beep(massive[4], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.L)
                {
                    Console.Beep(massive[5], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.Z)
                {
                    Console.Beep(massive[6], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.X)
                {
                    Console.Beep(massive[7], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.C)
                {
                    Console.Beep(massive[8], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.V)
                {
                    Console.Beep(massive[9], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.N)
                {
                    Console.Beep(massive[10], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.M)
                {
                    Console.Beep(massive[11], 100);
                    Console.Clear();
                }
                if (b.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}