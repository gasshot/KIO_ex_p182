using System;

namespace KIO_ex_p182_03_02While
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int c = 0;
            int t = 0;

            while (c++ < 5) //0
            {
                while (t++ <= 5-c) //01234
                {
                    Console.Write("*");
                }
                t = 0;
                
                Console.WriteLine();
            }
        }
    }
}
