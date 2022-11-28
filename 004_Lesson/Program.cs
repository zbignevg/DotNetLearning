using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Text;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace _004_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Given two integers n and m (n <= m), write a method that returns sum of all integers and average from range [n, m].
            SumAndAverage(11, 66);
            SumAndAverage(-10, 0);
            Console.WriteLine();


            //2. Given a string, write a method that returns substring from between two double hash signs (#).
            ExtractString("##abc##def");
            ExtractString("12####78");
            ExtractString("gar##d#en");
            ExtractString("++##--##++");
            Console.WriteLine();


            //3. Letters balance
            LettersBalance("fgvgvf");
            LettersBalance("lampsmpser");
            Console.WriteLine();

            //4. Write a method that takes non-empty string of bits as an argument and returns number as integer.
            BitsToNumber("1");
            BitsToNumber("100010");
            Console.WriteLine();


            //5. Given a string of two letters, where first one occurs before the second in the alphabet, write a method that returns full sequence of letters starting from first and ending at the second one.
            FullSequenceOfLetters("ds");
            FullSequenceOfLetters("or");
            Console.WriteLine();

            //6.Given a non - negative number, write a method that returns its digital root. From Wikipedia -digital root is a value obtained by an iterative process of summing digits, on each iteration using the result from the previous iteration to compute a digit sum.The process continues until a single-digit number is reached.
            DigitalRoot(83);
            DigitalRoot(40002938);

            //7. Given a string in which two words are separated by a char, write a method that replaces these two words.
            ReplaceWords("abc_xyz", '_');
            ReplaceWords("trolling.master", '.');

            //8.Given a non - empty string, write a method that returns it in compressed format.
            CompressString("kkkktttrrrrrrrrrr");
            CompressString("p555ppp7www");

            //9. Given a string, write a method that returns new string in which every odd letter of the word is uppercase.String may consist of one or more words.
            MakeUppercase("modem");
            MakeUppercase("BookWorm");
            MakeUppercase("Aliquam dolor nisl?");

            //10. Is palindrome(recursion) Given a string, write a method that checks if it is a palindrome.String length may be >= 0.
            Console.WriteLine();
            IsPalindromeRecursion("xx");
            IsPalindromeRecursion("pendrive");
        }
        static void SumAndAverage(int num1, int num2)
        {
            float sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}, Average: {(float)(sum / (num2 - num1 + 1))}");
        }

        static void ExtractString(string str)
        {
            int hashTagsBefore = 0;
            int hashTagsAfter = 0;
            string extract = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '#')
                {
                    if (extract.Length > 0)
                        hashTagsAfter++;
                    else
                        hashTagsBefore++;
                }
                else if (hashTagsBefore == 2 && hashTagsAfter == 0)
                {
                    extract += str[i];
                }
            }

            if (hashTagsBefore == 2 && hashTagsAfter == 2)
                Console.WriteLine($"{extract}");
            else
                Console.WriteLine($"empty string");
        }

        static void LettersBalance(string str)
        {
            string leftPart = str.Substring(0, str.Length / 2);
            string rightpart = str.Substring(str.Length / 2);
            bool response = true;

            for (int i = 0; i < leftPart.Length; i++)
            {
                if (!rightpart.Contains(leftPart[i]))
                {
                    response = false;
                }
            }

            Console.WriteLine($"{response}");
        }
        static void BitsToNumber(string str)
        {
            int number = Convert.ToInt32(str);

            Console.WriteLine($"{number}");
        }

        static void FullSequenceOfLetters(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string sequence = "";
            bool firstFound = false;
            bool lastFound = false;


            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == str[0])
                    firstFound = true;
                else if (alphabet[i] == str[1])
                    lastFound = true;

                if (firstFound)
                    sequence += alphabet[i];

                if (lastFound)
                    break;
            }

            Console.WriteLine($"{sequence}");
        }

        static void DigitalRoot(int num)
        {
            int digitalRoot = 0;
            int origin = num;

            do
            {
                int num2 = num;
                while (num2 > 0)
                {
                    int remainder = num2 % 10;
                    if (remainder > 0)
                    {
                        digitalRoot += remainder;
                    }
                    num2 = num2 / 10;
                }

                num = digitalRoot;
                digitalRoot = 0;
            }
            while (num.ToString().Length > 1);

            Console.WriteLine();
            Console.WriteLine($"Digital root of {origin} is : {num}");
        }

        static void ReplaceWords(string str, char separator)
        {
            string[] arr = str.Split(separator);

            Console.WriteLine();
            Console.WriteLine($"{arr[1]}{separator.ToString()}{arr[0]}");
        }

        static void CompressString(string str)
        {
            char? lastChar = null;
            int charsCounter = 0;
            string compressed = "";

            for (int i = 0; i < str.Length; i++)
            {
                char? prevChar = lastChar;
                bool charSwitched = false;

                if (!Char.Equals(lastChar, str[i]))
                {
                    if (!Char.Equals(lastChar, null))
                    {
                        charSwitched = true;
                    }
                    lastChar = str[i];
                }
                else
                    charSwitched = false;

                charsCounter++;

                if (charSwitched || i + 1 == str.Length)
                {
                    charsCounter = i + 1 == str.Length ? charsCounter : charsCounter - 1;
                    compressed += $"{prevChar}{charsCounter}";
                    charsCounter = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"-------{compressed}");
        }

        static void MakeUppercase(string str)
        {
            bool odd = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.Equals(str[i], ' '))
                {
                    odd = false;
                }
                Console.Write($"{(odd ? str[i].ToString().ToUpper() : str[i])}");
                odd = !odd;
            }

            Console.WriteLine();
        }

        static void IsPalindromeRecursion(string str)
        {
            bool isPalindrome = true;
            int halfLength = str.Length / 2;
            for (int i = 0; i < str.Length; i++)
            {
                if (i <= halfLength)
                {
                    if (!Char.Equals(str[i], str[str.Length - 1 - i]))
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{isPalindrome}");
        }
    }
}