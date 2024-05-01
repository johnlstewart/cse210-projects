// C# Prep 4—Lists
// John Stewart
// CSE 210
// 5/1/24

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type '0' when finished.");

        List<int> numbers = new List<int>();
        int number = -1;

        do
        {
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");

        int min = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num > 0 && num < min)
            {
                min = num;
            }
        }
        Console.WriteLine($"The min is: {min}");

        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}