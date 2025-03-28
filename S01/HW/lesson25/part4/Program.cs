﻿namespace part4;

class Program
{
    public static void factorial(int n) {
        ulong result = 1;
        for (int i = 1; i < n + 1; i++) {
            result *= (ulong)i;
        }
        Console.WriteLine(result);
    }

    static void Main(string[] args) {
        for (int i = 1; i < 21; i++) {
            factorial(i); 
        }
        Console.ReadLine(); 
    }
}