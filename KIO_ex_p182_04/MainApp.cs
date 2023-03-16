using System;


namespace KIO_ex_p182_04
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요. : ");
            string input = Console.ReadLine();
            int output = int.Parse(input);

            if(output <= 0)
            {
                Console.WriteLine("0보다 같거나 작은 수는 사용하실 수 없습니다.");
                return;
            }

            Console.WriteLine();

            for (int c = 0; c < output; c++)
            {
                for (int t = 0; t < c + 1; t++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
