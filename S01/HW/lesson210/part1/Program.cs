namespace part1;

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
    public static double eulers_constant(double precision){
        double term=1;
        double sum=term;
        int n=1;
    
        while(term>precision){
            term=1/factorial(n);
            sum+=term;
            n++;
        }
        return sum;
        
    }
    static void Main(string[] args)
    {
        Console.WriteLine(eulers_constant(0.001));
    }
}
