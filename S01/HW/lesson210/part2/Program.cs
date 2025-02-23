namespace part2;

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
    public static double power(int a, int b){
        double result=1;
        for(int i=1; i<b+1; i++){
            result = result * a;
        }
    return result;
    }
    public static double exp(int x, double precision){
        double term=x;
        double sum=term;
        int n=1;
        while(term>precision){
            term=power(x,n)/factorial(n);
            sum+=term;
            n++;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(exp(1,0.000001));
        Console.WriteLine(exp(2,0.000001));
    }
}
