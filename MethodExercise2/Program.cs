using System;

namespace MethodsExercise
{

    class Program
    {
        

             static int Sum(int num1, int num2)
            {
                var answer = num1 + num2;
                return answer;
                

            }
             static int Multiply(int num1, int num2)
            {
                var answer = num1 * num2;
                return answer;

            static void Main(string[] args)
            {
                var amountOfCookies = Sum(3, 5);


            }
        }
    }
}
