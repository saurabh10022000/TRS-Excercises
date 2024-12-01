using System;  // For basic types like DateTime, Console, etc.
using System.Collections.Generic;  // For List<T>, KeyValuePair<TKey, TValue>, etc.
using System.Linq;  // For LINQ methods like Min(), Average(), GroupBy(), etc.

namespace TRSEvaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test each method below by uncommenting the corresponding lines.

            // GetMinValue method
            Console.WriteLine(GetMinimumValue(new int[] { -6, 45, 32, 64, -145, 0, 18, 64 }));
            Console.WriteLine(GetMinimumValue(new int[] { 74, -9, 97, 41, -41, 24, 48, 9, -48, -60, -19 }));

            // Multiply Method
            Console.WriteLine(Multiply(3));    // Odd number, should multiply by 9
            Console.WriteLine(Multiply(-1));   // Odd number, should multiply by 9
            Console.WriteLine(Multiply(2));    // Even number, should multiply by 8
            Console.WriteLine(Multiply(61));   // Odd number, should multiply by 9

            // Average and Round method
            Console.WriteLine(AverageAndRound(new int[] { 14, -2, 5, 8, 32, 98, 68 }));
            Console.WriteLine(AverageAndRound(new int[] { 15, 18, -42, 6, 12, -1 }));

            // Count groups method
            CountGroupings(new string[] { "Chocolate", "Vanilla", "Cherry", "Vanilla", "Cherry" })
                .ForEach(x => Console.WriteLine($"Value: {x.Key} occurred {x.Value} times"));

            // Index Of method
            Console.WriteLine(GetIndexOf(new string[] { "Cat", "Dog", "Bird" }, "Dog"));
            Console.WriteLine(GetIndexOf(new string[] { "Mouse", "Dog", "Bird" }, "Cat"));

            // Get fiscal year methods
            Console.WriteLine(GetFiscalYear(new DateTime(2024, 7, 1)));
            Console.WriteLine(GetFiscalYear(new DateTime(2023, 5, 21)));
        }

        // Method to return the minimum value from an array of integers
        static int GetMinimumValue(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("The array cannot be null or empty.");
            }
            return values.Min();
        }

        // Method to multiply based on whether the number is even or odd
        static int Multiply(int value)
        {
            return value % 2 == 0 ? value * 8 : value * 9;
        }

        // Method to calculate the average and return it rounded down
        static int AverageAndRound(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("The array cannot be null or empty.");
            }
            return (int)Math.Floor(values.Average());
        }

        // Method to count occurrences of each string in an array
        static List<KeyValuePair<string, int>> CountGroupings(string[] values)
        {
            if (values == null)
            {
                throw new ArgumentException("The array cannot be null.");
            }

            return values.GroupBy(x => x.Trim())
                         .ToDictionary(group => group.Key, group => group.Count())
                         .ToList();
        }

        // Method to return the index of a value in an array, or -1 if not found
        static int GetIndexOf(string[] values, string lookupValue)
        {
            if (values == null || lookupValue == null)
            {
                throw new ArgumentException("The array or lookup value cannot be null.");
            }

            return Array.IndexOf(values, lookupValue);
        }

        // Method to return the fiscal year based on the date
        static int GetFiscalYear(DateTime value)
        {
            return value.Month >= 7 ? value.Year + 1 : value.Year;
        }
    }

    // Custom exception class for unimplemented methods
    internal class CustomNotImplementedException : Exception
    {
        public CustomNotImplementedException() : base("This method has not been implemented yet.")
        {
        }
    }
}