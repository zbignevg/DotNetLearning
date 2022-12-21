namespace _008_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            int number = 4;
            Console.WriteLine(number.IsPositive());

            //Task 2
            int number2 = 15;
            Console.WriteLine(number2.IsEven());

            //Task 3
            int number3 = 15;
            int compareWith = 10;
            Console.WriteLine($"{number3} is greater than {compareWith}? - {number3.IsGreaterThan(compareWith)}");

            //Task 4
            string str = "ThisStringhasspaces";
            Console.WriteLine("Has spaces - " + str.HasSpaces());

            //Task 5
            string email = "";
            Console.WriteLine("Generated email - " + email.GenerateEmail("lastname", "1990", "gmail.com"));

            List<int> numbers = new List<int>();
        }
    }

    class List<T>
    {
        public T Data { get; set; }
    }
}