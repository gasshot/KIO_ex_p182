using System;

namespace KIO_ex_p182_03_01Do
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
                }while (t++ < c) ; //0123
                t = 0;
                Console.WriteLine();

            } while (c++ < 4); //0123

        }
    }
}
