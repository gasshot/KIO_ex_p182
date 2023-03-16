using System;

namespace KIO_ex_p182_03_02While
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int c = 0;
            int t = 0;

            while (c++ < 5) 
            {
                while (t++ <= 5 - c) 
                {
                    Console.Write("*");
                }
                t = 0;
                
                Console.WriteLine();
            }
        }
    }
}
