using System;

namespace MethodsExercise
{

    class Program
    {
        public static int Sum(int num1, int num2)
            {
                var answer = num1 + num2;
                return answer;
                
            }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
            
        }
        static void Main(string[] args)
        {
            var amountOfCookies = Sum(3, 5);
            var amountOfCakes = Multiply(4, 6);
            Console.WriteLine(amountOfCookies);
            Console.WriteLine(amountOfCakes);
        }
    }
}
