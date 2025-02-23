namespace part5;

class Program
{
    public static int power(int x, int y){
        int result =1;
        for (int i=0; i<y; i++){
            result*=x;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(power(2,3));
    }
}
