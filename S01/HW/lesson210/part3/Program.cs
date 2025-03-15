namespace part3;
using System;
class Program
{
    public static double exp2(int x, double precision){
        double sum=1.00;
        double term=1.00;
        int n=0;
        while (term>precision){
            n+=1;
            term*=x/n;
            sum+=term;
        }
        return sum;
    }
    
}
