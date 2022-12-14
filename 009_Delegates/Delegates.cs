using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _009_Delegates
{
    internal class Delegates
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void DelegateMethod(string message)
        {
            Debug.WriteLine(message);
        }

        //public delegate int Calculation(int a, int b, string action);
        //public static int Calculate(int a, int b, string action)
        //{
        //    int result = 0;

        //    if (action == "add")
        //        result = a + b;
        //    else if (action == "substract")
        //        result = a - b;
        //    else if (action == "divide")
        //        result = a / b;
        //    else if (action == "multiply")
        //        result = a * b;

        //    return result;
        //}


        //public static void AnotherMethod(string message)
        //{
        //    Debug.WriteLine("This message is " + message);
        //}

        //public static void MethodWithCallback(string prefix, string suffix, Del callback)
        //{
        //    callback(prefix + " another message " + suffix);
        //}

        //public static void Result(int a, int b, string action, Calculation performCalculation)
        //{
        //    Console.WriteLine(performCalculation(a, b, action));
        //}

        public delegate int Operation(int a, int b);
        public static Operation add = (a, b) => a + b;
        public static Operation substract = (a, b) => a - b;
        public static Operation divide = (a, b) => a / b;
        public static Operation multiply = (a, b) => a * b;

        public static void Calculator(int a, int b, Operation op)
        {
            Debug.WriteLine("The result is " + op(a, b));
        }



        public delegate bool Filter(Person person);
        public static Filter isChild = (person) => person.age < 18;
        public static Filter isAdult = (person) => person.age >= 18;
        public static Filter isSenior = (person) => person.age > 65;

        public static Filter isAdultAnonymous = delegate (Person person) {
            return person.age >= 18;
        };

        public static Filter isChildAnonymous = delegate (Person person) {
            return person.age < 18;
        };

        public static Filter isSeniorAnonymous = delegate (Person person) {
            return person.age > 65;
        };

        public static void DisplayPeople(string title, List<Person> people, Filter callback)
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.name} {title} - {callback(person)}");
            }
        }

        public static void Run()
        {
            //Del handler = DelegateMethod;
            //handler("Here is our message");

            //handler = AnotherMethod;
            //handler("Here is our message");

            //Del callbackHandler = DelegateMethod;
            //MethodWithCallback("The prefix", "The suffix", callbackHandler);

            //Calculation calculator = Calculate;
            //Result(5, 9, "add", calculator);


            //Calculator(4, 2, add);
            //Calculator(4, 2, substract);
            //Calculator(4, 2, multiply);
            //Calculator(6, 2, divide);



            //Create a class Person with string name and int age
            //In the main method, create a list of people with different names and ages
            //Create a Filter delegate that will return a bool and take a Person object as a parameter.
            //Create three methods that will return bool values and accept Person as a parameter, one method will check if the person is a child < 18 years old, another will check if an adult >= 18 years old and the third will check if a senior is >= 65 years old.
            //Create a method DisplayPeople, with parameters title, List<Person> and delegate Filter.The essence of the method will be to cycle through persons and run the filter passed through the parameters to check whether a person, e.g. is a child.


            //The method call will look something like this: DisplayPeople("Children:", people, IsChild);

            //Replace the program with anonymous methods for delegates.
            //Replace the program with lambda functions for delegates.


            List<Person> people = new List<Person>();
            people.Add(new Person("John", 48));
            people.Add(new Person("Dwayne", 28));
            people.Add(new Person("Bob", 66));
            people.Add(new Person("Eddie", 18));
            people.Add(new Person("Frank", 22));
            people.Add(new Person("Junior", 17));


            DisplayPeople("is adult", people, isAdultAnonymous);
        }
    }
    public class Person
    {
        public string name;
        public int age { get; set; }
        public Person(string personName, int personAge)
        {
            name = personName;
            age = personAge;
        }
        
    }
}
