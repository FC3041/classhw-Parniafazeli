namespace part5;

class Program
{
    public static double power(double a, int b){
        double result=1;
        for(int i=1; i<b+1; i++){
            result = result * a;
        }
    return result;
    }
    public static double square_root(double x, double precision){
        if (x<0) return 0;
        double lower_bound=0;
        double upper_bound=x;
        while (upper_bound-lower_bound>precision){
            double mid =(upper_bound+lower_bound)/2;
            if (power(mid,2)<x){
                lower_bound=mid;
            }
            else{
                upper_bound=mid;
            }
        }       
        return (lower_bound+upper_bound)/2;
        }
    static void Main(string[] args)
    {
        Console.WriteLine(square_root(2,0.000001));
    }
}
