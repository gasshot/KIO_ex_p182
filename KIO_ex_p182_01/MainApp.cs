using System;


namespace KIO_ex_p182_01
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int c = 0; c < 5; c++)
            {
                for (int t = 0; t <= c; t++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
