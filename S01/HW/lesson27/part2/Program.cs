namespace part2;

class Program
{
    public static ulong factorial(int n){
        ulong result=1;
        for(int i=1;i<n+1;i++){
            result*=(ulong)i;
        }
        return result;
    }
    
}
