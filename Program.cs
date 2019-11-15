using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //planet exercise

            List<string> planetList = new List<string>() { "Mercury", "Mars", "Venus" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwo = new List<string>() { "Neptune", "Planet Nine" };

            planetList.AddRange(lastTwo);
            Console.WriteLine("\nAddRange(planetList)");

            Console.WriteLine("\nInsert(2, \"Earth\")");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanetsList = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");

            //numbers exercise
            Random random = new Random();
            List<int> numbers = new List<int>
            {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"Numbers list contains {i}");
                }
            }

        }
    }
}