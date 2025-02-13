namespace part7;

class Program
{
    public static void pythagorean(int limit){
        for(int a=1; a<limit; a++){
            for(int b=1; b<limit; b++){
                for(int c=1; c<limit; c++){
                    if(a*a==b*b+c*c && b>=c){
                    Console.WriteLine("{0},{1},{2}", a, b, c);
                    }
                }
            }
        }
    }
    static void Main(string[] args)
    {
        pythagorean(100);
    }
}
