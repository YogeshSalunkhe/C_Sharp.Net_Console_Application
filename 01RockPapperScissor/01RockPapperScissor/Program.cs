using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01RockPapperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserMove, CompMove;

            for (;;)
            {
                Console.Clear();

                Console.WriteLine("\t =============*****==============");
                Console.WriteLine("\t||-- Rock -- Paper -- Scissor --||");
                Console.WriteLine("\t =============*****==============");

                Console.WriteLine("\n\t =============*****==============");
                Console.WriteLine("\n\t 0 => Exit.");
                Console.WriteLine("\t 1 => Rock ");
                Console.WriteLine("\t 2 => Papper ");
                Console.WriteLine("\t 3 => Scissor ");
                Console.WriteLine("\n\t =============*****==============");

                Console.WriteLine("\n\t Enter Your Choice => ");
                UserMove = Convert.ToInt32(Console.ReadLine());

                Random Ran = new Random();
                CompMove = Ran.Next(0,3);

                if (UserMove == 0)
                {
                    goto Stop;
                }
                else if (UserMove == 1 && CompMove == 2)
                {
                    Console.WriteLine("\n\t Humanbeing Is The Winner!!!");
                    Console.ReadKey();
                }
                else if (UserMove == 1 && CompMove == 3)
                {
                    Console.WriteLine("\n\t Humanbeing Is The Winner!!!");
                    Console.ReadKey();
                }
                else if (UserMove == 2 && CompMove == 1)
                {
                    Console.WriteLine("\n\t Computer Is The Winner!!!");
                    Console.ReadKey();
                }
                else if (UserMove == 2 && CompMove == 3)
                {
                    Console.WriteLine("\n\t Computer Is The Winner!!!");
                    Console.ReadKey();
                }
                else if (UserMove == 3 && CompMove == 1)
                {
                    Console.WriteLine("\n\t Computer Is The Winner!!!");
                    Console.ReadKey();
                }
                else if (UserMove == 3 && CompMove == 2)
                {
                    Console.WriteLine("\n\t Humanbeing Is The Winner!!!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n\t Game Is Draw !!!");
                    Console.ReadKey();
                }

            }

            Stop:
            Console.WriteLine("\n\t Thanks For Plying My Game !!!");
            Console.ReadKey();

        }
    }
}
