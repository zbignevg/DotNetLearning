using System.Diagnostics;

namespace _005_DataTypes
{
    internal class Program
    {
        class Car
        {
            public int year = 2000;
            public string model = "Mazda";
        }

        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //Car car2 = new Car();

            //car2.year = 2022;
            //Debug.WriteLine($"{car2.year} {car1.year}");

            //ChangeCarProps(car2);
            //Debug.WriteLine($"Model car1 {car1.model} of {car1.year}");
            //Debug.WriteLine($"Model car2 {car2.model} of {car2.year}");

            //string text1 = "OLD";
            //string text2 = text1;

            //text2 = "No way";
            //Debug.WriteLine($"{text1}{text2}");

            //ChangeValue(text1);
            //Debug.WriteLine(text1);

            //string[] names = { "Alice", "Bob", "Claire" };
            //ChangeValue(names[2]);

            //for(int i = 0; i < names.Length; i++)
            //{
            //    Debug.WriteLine(names[i]);
            //}

            task1();
        }

        static void task1()
        {
            int[] numbers = new int[10] { 3, 8, 11, 9, 2, 4, 7, 10, 19, 15 };
            int sum = 0;
            float average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Array values sum = {sum}");
            Console.WriteLine($"Average value of array = {(float)sum / (float)numbers.Length}");

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }

        static void ChangeValue(string value)
        {
            value = "new value";
        }

        static void ChangeCarProps(Car car)
        {
            car.year = 2010;
            car.model = "Fiat";
        }
    }
}