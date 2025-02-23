namespace part6;
using System;
class Program
{
    public static void compute_change(int n){
        int a=(100-n)/25;
        int b=(100-n-(a*25))/10;
        int c=(100-n-((b*10)+(a*25)))/5;
        int d=(100-n-((a*25)+(b*10)+(c*5)));

        Console.WriteLine("{0} quarters",a);
        Console.WriteLine("{0} dime", b);
        Console.WriteLine("{0} nickles", c);
        Console.WriteLine("{0} pennies", d);

    }
    static void Main(string[] args)
    {
        compute_change(8);
    }
}
