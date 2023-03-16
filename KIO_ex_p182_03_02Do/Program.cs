using System;

namespace KIO_ex_p182_03_02Do
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int c = 0;
            int t = 0;
            do
            {
                do
                {
                    Console.Write("*");
                } while (t++ < 4-c); //005/014/
                t = 0;
                Console.WriteLine();

            } while (c++ < 4); //01234
        }
    }
}
