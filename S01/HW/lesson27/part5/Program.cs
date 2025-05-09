namespace part5;

class Program
{
    public static int fibonacci(int n){
        if(n==1){
            return 1;
        }
        if (n==2){
            return 1;
        }
        if (n>2){
            return fibonacci(n-1)+fibonacci(n-2);
        }
        return 0;
    }
    static void Main(string[] args)
    {
        for(int i=1;i<21;i++){
            Console.WriteLine(fibonacci(i));
        }
    }
}
