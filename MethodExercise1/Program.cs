using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {


            //-----------------Exercise 1------------------------------
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName} What car do you drive?");
            var car = Console.ReadLine();

            Console.WriteLine($"{car} are nice cars. What football team do you like?");
            var team = Console.ReadLine();

            Console.WriteLine($"I think {team} will win the Super Bowl this year!");
        }
    }
}
