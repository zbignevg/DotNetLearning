using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _008_Extensions
{
    public static class Extensions
    {
        //Task 1: Write an extension method for integers that will return a bool variable indicating whether the number was positive or not.
        public static string IsPositive(this int num)
        {
            string result = "Neither positive or negative";
            if (num > 0)
                result = "Positive";
            else
                result = "Negative";

            return result;
        }

        //Task 2: Write an extension method for integers that will return a bool variable indicating whether the number was even or not.
        public static bool IsEven(this int num)
        {
            return num % 2 == 0 ? true : false;
        }

        //Task 3: Write an extension method for integers that will return a bool type variable indicating whether the number passed through the parameter is greater or not.
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }

        //Task 4: Write an extension method for the string type that will return a bool variable indicating whether the sentence contains spaces or not.
        public static bool HasSpaces(this string str)
        {
            return str.Contains(' ');
        }

        //Task 5: Write an extension method for string type with parameters fullname, yearOfBirth and domain, the method will return the result as e-mail. postal address. For example: "lastname1990@gmail.com"
        public static string GenerateEmail(this string str, string fullName, string yOfB, string domain)
        {
            return $"{fullName}{yOfB}@{domain}";
        }

        //Task 6: Write an extension method FindAndReturnIfEqual for type List<T> that accepts an object of type T as a parameter and returns the same if it exists in the list.

    }
}
