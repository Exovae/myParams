﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();

        Console.WriteLine("How many random numbers do you want to generate?");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = r.Next(1, 10);
        }

        Console.WriteLine("Random numbers generated:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Total of the numbers array = {Add(numbers)}");
        Console.WriteLine($"Product of the numbers array = {Multiply(numbers)}");
    }

    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}
