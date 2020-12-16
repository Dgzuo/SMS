using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random r = new Random();
            int Kard1 = r.Next(2,11);
            int Kard2 = r.Next(2, 11);
            int y = Kard1 + Kard2;
            Console.WriteLine($"У вас {y} очков");

            int Map1 = r.Next(2, 11);
            int Map2 = r.Next(2, 11);
            int B = Map1 + Map2;

            while (true)
            {

                if (y <= 21)
                {
                    Console.Write("Желаите ли взять ещё карту(1'да')(0'нет')");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 0)
                    {
                        if (y > B)
                        {
                            Console.WriteLine("Вы выиграли");
                        }
                    }
                    else if (answer == 1)
                    {
                        int Kard3 = r.Next(2, 11);
                        y += Kard3;
                        Console.WriteLine($"У вас {y} очков");
                    }
                }
                else if (y > 21)
                {
                    Console.WriteLine("Вы проиграли");
                    break;

                }
            }
            Console.ReadLine();

            
            
        }
    }
}
