namespace part6;
using System;
class Program
{
    public static bool leapyear(int year){
        if (year % 4==0 && year% 100!=0 ){
            return true;
        }
        else if(year%400==0){
            return true;
        }
        else{
            return false;
        }
    }
    public static int days_in_month(int year, int monthnumber){
        if (monthnumber==1 || monthnumber==3 || monthnumber==5 || monthnumber==7 ||monthnumber==8 || monthnumber==10 || monthnumber==12)
        return 31;
        else if (monthnumber==4 || monthnumber==6 || monthnumber==9 || monthnumber==11)
        return 30;
        else if (monthnumber==2){
            if(leapyear(year)){
            return 29;
            }
            return 28;
        }
        return 0;
            
    }
    static void Main(string[] args)
    {
        Console.WriteLine(days_in_month(2004,2));
    }
}
