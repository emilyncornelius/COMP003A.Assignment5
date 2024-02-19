/*
 * Author: Emily Cornelius
 * Course: Comp-003A
 * Purpose: Coding Assignment for Methods
 */
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Triangle Section");
            Console.Write("Enter a single character: ");
                string charresponse = Console.ReadLine();
           char character = Convert.ToChar(charresponse);

            Console.Write("Enter a positive whole number: ");
            string numresponse = Console.ReadLine();
            int number = Convert.ToInt32(numresponse);
            IsoscelesTriangleBuilder(character, number);
            PrintSeparator("Favorite Characters Section");
            CharacterInfo("Beyonce", 1981);
            CharacterInfo("Jennifer Aniston", 1969);
            CharacterInfo("Megan Thee Stallion", 1995);
            CharacterInfo("Hayao Miyazaki", 1941);
            CharacterInfo("Morrissey", 1969);
        }
        static void PrintSeparator()
        {
            Console.WriteLine("**************************************************");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="print"></param>
        static void PrintSeparator(string print)
        {
            PrintSeparator();
            Console.WriteLine(print);
            PrintSeparator();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            string output = "";
            for (int i = 0; i < size; i++)
            {
                output = output + inputCharacter;
                Console.WriteLine(output);
            }
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(output.Substring(0, i));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static int AgeCalculator( int year)
        { return DateTime.Now.Year - year - 1; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        static void CharacterInfo(string name, int birthYear)
        {
            Console.WriteLine(name + " turns " + AgeCalculator(birthYear) + " this year!");
        }
        }
    }

