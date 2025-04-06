namespace part7;
using System;
class Program
{
    public static double power(int a, int b){
        double result=1;
        for(int i=1; i<b+1; i++){
            result = result * a;
        }
    return result;
    }
    public static double ln(double x,double precision){
        if(x<0) return 0;
        double lowerbound=0;
        double upperbound=x;
        double mid=0;
        while(upperbound-lowerbound>precision){
            mid=(lowerbound+upperbound)/2;
            double exp_mid= Math.Exp(mid);
            if(exp_mid<x){
                lowerbound=mid;
            }
            else{
                upperbound=mid;
            }
        }
        return (lowerbound+upperbound)/2;

    }
    static void Main(string[] args)
    {
        Console.WriteLine(ln(10,0.0001));
    }
}
