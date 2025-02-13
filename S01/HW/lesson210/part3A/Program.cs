namespace part3A;

class Program
{
    public static double abs(double x){
        if(x>=0){
            return x;
        }
        else{
            return -x;
        }
    }
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
    public static bool near(double x, double y){
        double max_abs=max(abs(x),abs(y));
        if (abs(x-y)<(0.001*max_abs)){
            return true;
        }
        else{
            return false;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(near(100,100.0005));
    }
}
