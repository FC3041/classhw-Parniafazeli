namespace part2;
using System;
class Program
{
    public static void print_left_triangle(int n){
        for(int i=1; i<n+1; i++){
            for(int j=1; j<i+1; j++){
                if(i%2==0){
                    Console.Write("*");
                } else {
                    Console.Write("%");
                }
            }
        Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        print_left_triangle(4);
    }
}
