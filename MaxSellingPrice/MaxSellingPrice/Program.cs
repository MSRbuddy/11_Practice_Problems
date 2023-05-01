using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Welcome to Maximum Selling Price Problem!*****");
        Console.WriteLine("------------------------------------------------------");

        Console.WriteLine("\nEnter the values of N and K respectively : ");
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = input[0];
        int k = input[1];
        
        Console.WriteLine("\nSelling price of each fruit in Basket-A : ");
        List<int> aPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        Console.WriteLine("\nSelling price of each fruit in Basket-B : ");
        List<int> bPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        for (int i = 0; i < n; i++)
        {
            if (k == 0)
            {
                break;
            }
            int maxPrice = aPrices.Max();
            if (bPrices[i] > maxPrice)
            {
                int maxIndex = aPrices.IndexOf(maxPrice);
                aPrices[maxIndex] = bPrices[i];
                k--;
            }
        }
        Console.WriteLine("\nAfter Swaping, Maximum Selling Price Of Basket-A is : ");
        Console.WriteLine(aPrices.Max());
    }
}