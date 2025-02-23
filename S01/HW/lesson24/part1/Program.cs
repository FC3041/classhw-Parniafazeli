namespace part1;
using System;
class Program
{
    public static void left_triangle(int n){
        for (int i=1; i<n+1; i++){
            for(int j =0; j<i;j++){
                Console.Write("*");
            }
        Console.WriteLine();
        }
    }        
    static void Main(string[] args)
    {
        left_triangle(5);
    }

}
