namespace part3;

class Program
{
    public static void factorial(int n){
        if(n==0){
            Console.WriteLine("1");
        }
        ulong result=1;
        for(int i=1; i<n+1; i+=){
            result*=(ulong)i;
        }
        Console.WriteLine(result);
    }
    
}
