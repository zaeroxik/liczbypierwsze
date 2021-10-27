using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("podaj prosze ilosc liczb pierwszych ktore chcesz wypisac");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------");
            int count;
            int c;
            int i = 2;

            for (count = 1; count <= n; i++)
            {
                for (c = 2; c < i; c++)
                {
                    if (i % c == 0)
                        break;
                }
                if (c == i)
                {
                    
                    Console.WriteLine(i);
                    ++count;
                }
            }

        }

    }
}
