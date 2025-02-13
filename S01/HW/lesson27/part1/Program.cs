namespace part1;
using System;
class Program
{
    public static void absolute_value(int x){
        if(x>0){
            Console.WriteLine("positive");
        }
        else if(x<0){
            Console.WriteLine("negative");
        }
        else{
            Console.WriteLine("none");
        }
    }
    static void Main(string[] args)
    {
        absolute_value(-100);
        absolute_value(-1);
        absolute_value(0);
        absolute_value(1);
        absolute_value(1000);
    }
}
