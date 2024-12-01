using System;
using System.Collections.Generic;
using System.Linq;

namespace TRSEvaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Example usage
                Console.WriteLine(GetMinimumValue(new int[] { -6, 45, 32, 64, -145, 0, 18, 64 }));
                Console.WriteLine(GetMinimumValue(new int[] { 74, -9, 97, 41, -41, 24, 48, 9, -48, -60, -19}));
                Console.WriteLine(GetMinimumValue(new int[] { -1, -17, 30, 52, -34,-64 }));

                Console.WriteLine(Multiply(3));
                Console.WriteLine(Multiply(-1));
                Console.WriteLine(Multiply(2));
                Console.WriteLine(Multiply(0));
                Console.WriteLine(Multiply(61));

                Console.WriteLine(AverageAndRound(new int[] { 14, -2, 5, 8, 32, 98, 68 }));
                Console.WriteLine(AverageAndRound(new int[] { 28, -52, 4, 12, 31, 1, -2 }));
                Console.WriteLine(AverageAndRound(new int[] { 15, 18, -42, 6, 12, -1 }));
                Console.WriteLine(AverageAndRound(new int[] { 4, 12, 28, -52, 16, -3 }));

                CountGroupings(new string[] { "Chocolate ", "Vanilla", "Cherry", "Vanilla", "Cherry"}).ForEach(x => Console.WriteLine($"Value: {x.Key} occurred {x.Value} times"));
                CountGroupings(new string[] { "Cherry ", "Vanilla", "Cherry", "Vanilla", "Cherry" }).ForEach(x => Console.WriteLine($"Value: {x.Key} occurred {x.Value} times"));
                CountGroupings(new string[] { "Chocolate ", "Chocolate", "Orange", "Vanilla", "Orange" }).ForEach(x => Console.WriteLine($"Value: {x.Key} occurred {x.Value} times"));
                CountGroupings(new string[] { "Chocolate ", "Vanilla", "Chocolate", "Vanilla", "Vanilla" }).ForEach(x => Console.WriteLine($"Value: {x.Key} occurred {x.Value} times"));

                Console.WriteLine(GetIndexOf(new string[] { "Cat", "Dog", "Bird" }, "Dog"));
                Console.WriteLine(GetIndexOf(new string[] { "Fish", "Hamster", "Snake" }, "Fish"));
                Console.WriteLine(GetIndexOf(new string[] { "Mouse", "Dog", "Bird" }, "Cat"));
                Console.WriteLine(GetIndexOf(new string[] { "Cat", "Hamster", "Cat" }, "Cat"));


                Console.WriteLine(GetFiscalYear(new DateTime(2024, 7, 1)));
                Console.WriteLine(GetFiscalYear(new DateTime(2023, 5, 21)));
                Console.WriteLine(GetFiscalYear(new DateTime(2025, 6, 20)));
                Console.WriteLine(GetFiscalYear(new DateTime(2024, 11, 1)));
                Console.WriteLine(GetFiscalYear(new DateTime(2022, 12, 31)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static int GetMinimumValue(int[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");
            return values.Min();
        }

        static int Multiply(int value)
        {
            return value % 2 == 0 ? value * 8 : value * 9;
        }

        static int AverageAndRound(int[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");
            return (int)Math.Floor(values.Average());
        }

        static List<KeyValuePair<string, int>> CountGroupings(string[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");
            return values.GroupBy(v => v.Trim())
                         .Select(group => new KeyValuePair<string, int>(group.Key, group.Count()))
                         .ToList();
        }

        static int GetIndexOf(string[] values, string lookupValue)
        {
            if (values == null || lookupValue == null)
                throw new ArgumentException("Array and lookup value cannot be null.");
            return Array.IndexOf(values, lookupValue);
        }

        static int GetFiscalYear(DateTime value)
        {
            return value.Month >= 7 ? value.Year + 1 : value.Year;
        }
    }
}