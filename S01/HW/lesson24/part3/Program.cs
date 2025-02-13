namespace part3;

class Program
{
    public static void right_triangle(int n){
        int i;
        for(i=1; i<n+1; i++){
            for(int j=n; j>i; j--){
                Console.Write(" ");
            }
            for(int k=1; k<i+1;k++){
               Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        right_triangle(5);
    }
}
