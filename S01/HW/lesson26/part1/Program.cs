namespace part1;

class Program
{
    public static void leapyear(int year){
        if (year % 4==0 && year% 100!=0 ){
            Console.WriteLine("true");
        }
        else if(year%400==0){
            Console.WriteLine("true");
        }
        else{
            Console.WriteLine("false");
        }
    }
    static void Main(string[] args)
    {
        leapyear(1792);
        leapyear(1796);
        leapyear(2000);
        leapyear(1800);
        leapyear(1804);
        leapyear(1900);
        leapyear(1904);
        leapyear(2000);
        leapyear(2004);
    }
}
