using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms_CS
{
    internal class Program
    {
        static void Main(string[] args)

        {
           
            demoBinarySearch();

        }

        static void demoLinearSearch() // demo linear search, can be written in main code - looks for a number
        {
            int[] numbers = { 7, 3, 9, 1, 8, 6, 4, 10 };
            bool found = false;
            int index = 0;
            int numToFind;
            Console.Write("Enter number to find: ");
            numToFind = Convert.ToInt32(Console.ReadLine());
            while (!found && index < numbers.Length)
            {
                if (numbers[index] == numToFind)
                {
                    found = true;
                }
            }
            Console.WriteLine(found);
        }
        static void demoLinearSearch2()// demo linear search, can be written in main code - looks for a string
        {
            bool found = false;
            string[] strings = { "This", "is", "an", "array", "of", "strings" };
            string stringToFind;
            Console.Write("Enter a word to find: ");
            stringToFind = Console.ReadLine();
            int index = 0;
            while (!found && index < strings.Length)
            {
                if (stringToFind == strings[index])
                {
                    found = true;
                }
            }
            Console.WriteLine(found);
        }

        //Function which returns index when found or -1 if not
        static int FindPositionLinearSearch(int[] array, int numToFind)
        {
            int index = 0;
            while (index < array.Length)
            {
                if (array[index] == numToFind)
                {
                    return index; // returns if found
                }
                index++;
            }
            return -1;

        }
        //Function which returns true/false if string is in array
        static bool FindIfValuePresent(string value, string[] array)
        {
            int index = 0;
            while (index < array.Length)
            {
                if (array[index] == value)
                {
                    return true;    
                }
            }
            return false;
        }

        static void demoBinarySearch() //Can be written in main code to find a number in a number array
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int numToFind;
            bool found = false;
            Console.Write("Enter a number to find: ");
            numToFind = Convert.ToInt32(Console.ReadLine());
            int start, end, mid;
            start = 0;
            end = array.Length - 1;
            do
            {
                mid = (start + end) / 2;
                if (array[mid] == numToFind)
                {
                    found = true;
                }else if ( numToFind > array[mid])
                {
                  
                    start = mid+1;
                }
                else
                {
                    end = mid - 1;
                }
               }while (start < end && !found);

            Console.WriteLine(found);

        }


    }
}
