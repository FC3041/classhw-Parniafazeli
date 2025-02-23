namespace part4;
using System;
class Program
{
    public static double factorial(int n){
        if(n==0) return 1;
        double  result=1;
        for(int i=1;i<n+1;i++){
            result = result * i;
        }
        return result;
    }
    public static double power(double a, int b){
        double result=1;
        for(int i=1; i<b+1; i++){
            result = result * a;
        }
    return result;
    }
    public static double sin(int x,double precision){

    double radians = x * Math.PI / 180.0;
    double term = radians;
    double sum = term;
    int n = 1;


    while (Math.Abs(term) > precision)
    {
        n += 2;
        term = (power(-1, (n - 1) / 2) * power(radians, n)) / factorial(n);
        sum += term;
    }
    return sum;
}
    static void Main(string[] args)
    {
        Console.WriteLine(sin(90,0.000001));
        Console.WriteLine(sin(45,0.0001));
        Console.WriteLine(sin(0,0.0001));

    }
}
