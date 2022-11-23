using System.Diagnostics;

namespace _003_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double num = 10d;
            //double num2 = 6d;

            int a = 5;
            int b = 9;

            if ((a+=5) < b++)
                Console.WriteLine();


            float res1 = TheCubeOf(-5.5f);
            
            Console.WriteLine($"First res: {res1}");
            Console.WriteLine($"{CtoF(0)}");
            Console.WriteLine($"{CtoF(100)}");
            Console.WriteLine($"{CtoF(-300)}");

            Console.WriteLine($"{ModuloOperations(8, 5, 2)}");


            Console.WriteLine($"{IsResultTheSame(2+2, 2*2)}");
            Console.WriteLine($"{IsResultTheSame(9/3, 16-1)}");

            Console.WriteLine($"{IfNumberContains3(7201432)}");
            Console.WriteLine($"{IfNumberContains3(87501)}");


            Console.WriteLine($"{IfYearIsLeap(2016)}");
            Console.WriteLine($"{IfYearIsLeap(2018)}");


            Console.WriteLine($"{PositiveNegativeOrZero(5.24f)}");
            Console.WriteLine($"{PositiveNegativeOrZero(0.0f)}");
            Console.WriteLine($"{PositiveNegativeOrZero(-994.53f)}");


            Console.WriteLine($"{DivisibleBy2Or3(15, 30)}");
            Console.WriteLine($"{DivisibleBy2Or3(2, 90)}");
            Console.WriteLine($"{DivisibleBy2Or3(7, 12)}");

            Console.WriteLine($"{DivisibleBy2Or3(2, 90)}");
            Console.WriteLine($"{DivisibleBy2Or3(7, 12)}");

            SwapTwoNumbers(87, 45);
            SwapTwoNumbers(-13, 2);

            Console.WriteLine($"{AbsoluteValue(6832)}");
            Console.WriteLine($"{AbsoluteValue(-392)}");
        }

        static float TheCubeOf(float num)
        {
            return num * num * num;
        }

        static string CtoF(int celsius)
        {
            string res;
            if (celsius < -271.5)
                res = "Temperature below absolute zero!";
            else
            {
                int f = (int)celsius * 9 / 5 + 32;
                res = $"T = {f}F";
            }            

            return res;
        }

        static int ModuloOperations(int first, int second, int third)
        {
            return (first % second) % third;
        }

        static bool IsResultTheSame(float firstOperation, float secondOperation)
        {
            return firstOperation == secondOperation;
        }

        static bool IfNumberContains3(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 3)
                    return true;

                number = number / 10;
            }
            return false;
        }
        static bool IfYearIsLeap(int year)
        {
            return year % 4 == 0;
        }
        static string PositiveNegativeOrZero(float number)
        {
            string res = "zero";

            if (number > 0) res = "positive";
            else if (number < 0) res = "negative";

            return res;
        }

        static int DivisibleBy2Or3(int first, int second)
        {
            return ((first % 2 == 0 || first % 3 == 0) && (second % 2 == 0 || second % 3 == 0)) ? first * second : first + second;
        }

        static void SwapTwoNumbers(int  a, int b)
        {
            Console.WriteLine($"Before: a = {a}, b = {b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After: a = {a}, b = {b}");
        }

        static int AbsoluteValue(int num)
        {
            return num < 0 ? num * -1 : num;
        }
    }
}
