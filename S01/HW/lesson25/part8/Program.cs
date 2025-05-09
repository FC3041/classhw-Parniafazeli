namespace part8;

class Program
{
    public static int average_of_squares1(int n){
        int sum=0;
        for (int i=1; i<n+1; i++){
            sum+= i*i;
        }
        return sum/n;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(average_of_squares1(4));
    }
}
