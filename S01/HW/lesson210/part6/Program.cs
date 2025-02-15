namespace part6;

class Program
{
    public static double max(double x, double y){
        double max;
        if(y>=x){
            max=y;
        }
        else{
            max=x;
        }
        return max;
    }
    public static double power(double a, int b){
        double result=1;
        for(int i=1; i<b+1; i++){
            result = result * a;
        }
    return result;
    }
    public static double root(double x,int n, double precision){
        if(x<0 && n%2==0) return 0;
        double lowerbound=0;
        double upperbound=max(1,x);
        while(upperbound-lowerbound>precision){
            double mid=(upperbound+lowerbound)/2;
            if(power(mid,n)<x){
                lowerbound=mid;
            }
            else{
                upperbound=mid;
            }
        }
        return (lowerbound+upperbound)/2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
