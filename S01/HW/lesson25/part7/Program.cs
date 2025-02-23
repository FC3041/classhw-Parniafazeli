namespace part7;

class Program
{
    public static int average_of_squares0(int n){
        int sum=0;
        for (int i=0; i< n; i++){
            sum += i * i;
        }
        return sum/n;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(average_of_squares0(5));
    }
}
