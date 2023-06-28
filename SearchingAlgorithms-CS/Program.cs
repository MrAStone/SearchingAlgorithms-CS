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
           
            DemoBinarySearch2();

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

        static void DemoBinarySearch2() //Can be written in main code for finding a string
            // A very common misconception is that strings can't be found using binary search
            // this is not the case, it must be storted in alphabetical order (case matters)
        {
            string[] array = { "apple", "banana", "pear", "pineapple", "plum" };
            string wordToFind;
            bool found = false;
            Console.Write("Enter word to find: ");
            wordToFind = Console.ReadLine();
            int start, end, mid;
            start = 0;
            end = array.Length - 1;
            do
            {
                mid = (start + end) / 2;
                if (array[mid] == wordToFind)
                {
                    found = true;
                }
                else if (string.Compare(wordToFind, array[mid])==1) // in C# string.Compare produces (0 if the same, 1 if first is greater than second, -1 if second greater than first)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            } while (start < end && !found);

            Console.WriteLine(found);
        }
        static int BinarySearchPositionFunction(string[] array, string wordToFind)
        {

            // A very common misconception is that strings can't be found using binary search
            // this is not the case, it must be storted in alphabetical order (case matters)
            {
              
                bool found = false;
                Console.Write("Enter word to find: ");
                wordToFind = Console.ReadLine();
                int start, end, mid;
                start = 0;
                end = array.Length - 1;
                do
                {
                    mid = (start + end) / 2;
                    if (array[mid] == wordToFind)
                    {
                        return mid;
                    }
                    else if (string.Compare(wordToFind, array[mid]) == 1) // in C# string.Compare produces (0 if the same, 1 if first is greater than second, -1 if second greater than first)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                } while (start < end && !found);

                return -1;
            }

        }
        static bool BinarySearchReturnFound(int[] array, int numToFind)
        {
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
                    return found;
                }
                else if (numToFind > array[mid])
                {

                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            } while (start < end && !found);
            return found;
        }

    }
}
