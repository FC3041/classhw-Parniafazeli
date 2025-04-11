namespace part4;

class Program
{
    public static bool is_divisible(int a, int b){
        if(a%b==0){
            return true;
        }
        else{
            return false;
        }
    }
    public static bool is_prime(int n){
        if(n==1){
            return false;
        }
        else if (n==2){
        return true;
        }
        else if(n>2){
            for(int i=2; i<n; i++){
                if(is_divisible(n, i)){
                    return false;
                }
            }
            return true;
        
        }
        else if(n<1){
            return false;
        }
        return false;
    }
    static void Main(string[] args)
    {
        for(int i=1;i<100;i++){
            if(is_prime(i)){
                Console.WriteLine(i);
            }
        }
    }
}
