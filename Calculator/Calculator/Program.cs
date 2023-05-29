using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Top:

            Console.WriteLine("\n\t -----Calculator Using C# -----\n");
            float Num1, Num2;

            Console.WriteLine("\n\t==========*****==========\n");

            Console.WriteLine("\n\t Enter Two Numbers => ");
            Num1 = Convert.ToInt32( Console.ReadLine());
            Num2 = Convert.ToInt32(Console.ReadLine());

            
            UP:
            Console.Clear();
            Console.WriteLine("\t -----*** Calculator Using C# ***-----");
            Console.WriteLine("\t==========*****==========\n");
            Console.WriteLine("\t Enter Your Chioce => ");
            Console.WriteLine("\t 1 => Addition ");
            Console.WriteLine("\t 2 => Sustraction ");
            Console.WriteLine("\t 3 => Multiplication ");
            Console.WriteLine("\t 4 => Division \n");
            Console.WriteLine("\t==========*****==========\n");

            switch (Console.ReadLine())
            {
                case "1" :
                    Console.WriteLine("\t Addition Of "+ Num1 +" And " + Num2 +" = " +(Num1+Num2));
                    break;

                case "2" :
                    Console.WriteLine("\t Substraction Of "+ Num1 +" And " + Num2 +" = " +(Num1-Num2));
                    break;

                case "3" : 
                    Console.WriteLine("\t Multiplication Of "+ Num1 +" And " + Num2 +" = " +(Num1*Num2));
                    break;

                case "4" : 
                    Console.WriteLine("\t Division Of "+ Num1 +" And " + Num2 +" = " +(Num1/Num2));
                    break;

                default:
                    Console.WriteLine("\t Invalid Chioce !!!");
                    goto UP;
            }
            Console.WriteLine("\n\t Enter 1 To Continue !!!" + "\n\t Enter Any Other Key To Stop !!!");

            if ("1" == Console.ReadLine())
            {
                Console.Clear();
                goto Top;
            }
            
        }
    }
}
