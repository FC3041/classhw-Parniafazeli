namespace part5;

class Program
{
    public static void print_month(int n){
    if (n==1)
        {Console.WriteLine("january");}
    if (n==2)
        {Console.WriteLine("february");}
    if (n==3)
        {Console.WriteLine("march");}
    if (n==4)
        {Console.WriteLine("april");}
    if (n==5)
        {Console.WriteLine("may");}
    if (n==6)
        {Console.WriteLine("june");}
    if (n==7)
        {Console.WriteLine("july");}
    if (n==8)
        {Console.WriteLine("august");}
    if (n==9)
        {Console.WriteLine("september");}
    if (n==10)
        {Console.WriteLine("october");}
    if (n==11)
        {Console.WriteLine("november");}
    if (n==12)
        {Console.WriteLine("december");}
    if (n<1 || n>12)
        {Console.WriteLine("there is no month");}

    }
    static void Main(string[] args)
    {
        for (int n=1; n<13; n++){
            Console.Write(n);
            print_month(n);
        }
    }
}
