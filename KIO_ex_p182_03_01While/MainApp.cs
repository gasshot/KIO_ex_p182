using System;

namespace KIO_ex_p182_03_01While
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int c = 0;
            int t = 0;

            while (c++ < 5) // 01234
            {
                while (t++ <c) // f
                {
                    Console.Write("*");
                }
                t = 0;
                Console.WriteLine();
            }
        }
    }
}
