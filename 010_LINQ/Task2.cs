using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace _010_LINQ
{
    internal class Task2
    {
        public void Run()
        {
            //Task 2

            //Create a Person class with a name and a list of animals(also a new class, animals only have a name). Create a list with Person objects and animal lists inside.
            List<PersonWithAnimals> people = new List<PersonWithAnimals>();
            List<Animal> animals = new List<Animal>();
            animals.AddRange(new[]{
                new Animal("Lucky", 4),
                new Animal("Fluffy", 6)
            });

            List<Animal> animalsSet2 = new List<Animal>();
            animalsSet2.AddRange(new[]{
                new Animal("Mailo", 2),
                new Animal("Richie", 5),
                new Animal("Andy", 8),
                new Animal("Archie", 1)
            });

            people.AddRange(new[]
            {
                new PersonWithAnimals("Bobby", animals),
                new PersonWithAnimals("Dwayne", animalsSet2)
            });


            //With LINQ Select and SelectMany, create a list containing all the animals in the list.
            var allPetsNames = people.SelectMany(x => x.Animals.Select(y => y.Name));
            Console.WriteLine(string.Join(" ", allPetsNames));


            //Another list that will consist only of animals whose names start with the letter A.
            var allPetsNamesStartsWithA = people.SelectMany(x => x.Animals.Where(y => y.Name.StartsWith("A")).Select(y => y.Name));
            Console.WriteLine(string.Join(" ", allPetsNamesStartsWithA));


            //Add the age int Age to the Pet class, make another list of animals whose names start with the letter A and are over 5 years old.
            var allPetsNamesStartsWithAOver5 = people.SelectMany(x => x.Animals.Where(y => y.Name.StartsWith("A") && y.Age > 5).Select(y => y.Name));
            Console.WriteLine(string.Join(" ", allPetsNamesStartsWithAOver5));


            //Write a method that accepts a single string parameter. Write a LINQ function to return words that are all uppercase letters.

            List<string> uppercaseWords = ToUppercase("return ALL uppercase WORDS FROM tHis SENTENCE");
            Console.WriteLine(string.Join(" ", uppercaseWords));

        }

        public static List<string> ToUppercase(string sentence)
        {
            List<string> words = new List<string>();
            words = (sentence.Split(' ')).ToList();

            List<string> upperWords = words.Where(x => x.ToUpper() = x).Select(x => x);

            return upperWords;
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class PersonWithAnimals
    {
        public PersonWithAnimals(string name, List<Animal> animals)
        {
            this.Name = name;
            this.Animals = animals;
        }
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }
    }
}
