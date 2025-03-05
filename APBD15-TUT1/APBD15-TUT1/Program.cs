// See https://aka.ms/new-console-template for more information
using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Modification 1");

        Console.WriteLine("Modification 2");

        Console.WriteLine("Modification 3");

        double[] arr = { 1, 2, 3.5, 4, 5 };

        Console.WriteLine("Average: " + GetAverage(arr));
        Console.WriteLine("Max: " + GetMax(arr));
    }
    
    static double GetAverage(double[] array)
    {
        double sum = 0;
        int counter = array.Length;
        foreach(double num in array)
        {
            sum += num;
        }
        return sum/counter;
    }

    static double GetMax(double[] array)
    {
        double res = 0;
        foreach (double num in array)
        {
            if (num > res)
            {
                res = num;
            }
        }
        return res;
    }
}



