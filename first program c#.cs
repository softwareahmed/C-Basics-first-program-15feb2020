﻿using System;
public class firstprogram
{
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }

    public static void Main()
    {
       
  
        Console.Write("Enter first  number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nThe sum of the two numbers is : {0} \n", Sum(n1, n2));
    }
}