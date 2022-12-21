using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _010_LINQ
{
    internal class Task1
    {
        public void Run()
        {
            //Task 1
            //Create a list with numbers.
            List<int> numbers = new List<int>();
            numbers.AddRange(new[] { 11, 15, 25, 4, 8, 9 });

            
            //Create a new list and assign its value to the list returned by the first list's Select. The select method must square each number in the first list.
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            
            //Create a list with positive and negative elements, create a new list from it with LINQ returning only positive numbers.
            List<int> positiveAndNegativenumbers = new List<int>();
            positiveAndNegativenumbers.AddRange(new[] { -2, -15, 10, 16, 1, 45, 18, 99, -115, -116 });

            var positiveNumbers = positiveAndNegativenumbers.Where(x => x > 0);
            Console.WriteLine(string.Join(" ", positiveNumbers));


            //Create a list with positive and negative elements, create a new list from it with LINQ returning only positive numbers not greater than 10.
            var positiveNumbersUnder10 = positiveAndNegativenumbers.Where(x => x > 0 && x < 10);
            Console.WriteLine(string.Join(" ", positiveNumbersUnder10));


            //Create a list of numbers and sort it in ascending order with LINQ.
            var sortedNumbers = numbers.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", sortedNumbers));


            //Create a list of numbers and sort it in descending order with LINQ.
            var sortedDescendingNumbers = numbers.OrderByDescending(x => x);
            Console.WriteLine(string.Join(" ", sortedDescendingNumbers));


            //Find the largest element of a list of numbers using LINQ.
            int maxNum = sortedDescendingNumbers.Max();
            Console.WriteLine(maxNum);


            //Create a class Person with parameters Name and Age, create a list from these objects.
            List<Person> people = new List<Person>();
            people.AddRange(new[] {
                new Person("John", 22),
                new Person("Bob", 24),
                new Person("Rachel", 42),
                new Person("Andrew", 12),
            });


            //Create a new list with LINQ retrieving only people's names, another list from age only.
            var peopleNames = people.Select(x => x.Name);
            Console.WriteLine(string.Join(" ", peopleNames));
            var peopleAges = people.Select(x => x.Age);
            Console.WriteLine(string.Join(" ", peopleAges));


            //Sort the list by age in descending order.
            var peopleSortedDescendingByAge = people.OrderByDescending(x => x.Age).Select(x => x.Name);
            Console.WriteLine(string.Join(" ", peopleSortedDescendingByAge));


            //Create a new list of people whose names start with the letter A.
            var peopleNamesStartsWithA = people.Where(x => x.Name.StartsWith("A")).Select(x => x.Name);
            Console.WriteLine(string.Join(" ", peopleNamesStartsWithA));


            //Create a new list of people over 40 and sort by name.
            var peopleNamesOver40 = people.Where(x => x.Age > 40).Select(x => x.Name);
            Console.WriteLine(string.Join(" ", peopleNamesOver40));
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
