﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number (1-7):");
            int number = Convert.ToInt32(Console.ReadLine());                
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                    Console.WriteLine("Wrong number please input 1-7");
                    break;
                }            
            }            
        }    
}
