namespace part7;
using System;
class Program
{
    public static int days_in_month(int monthnumber){
        if (monthnumber==1 || monthnumber==3 || monthnumber==5 || monthnumber==7 ||monthnumber==8 || monthnumber==10 || monthnumber==12)
        return 31;
        else if (monthnumber==4 || monthnumber==6 || monthnumber==9 || monthnumber==11)
        return 30;
        else if (monthnumber==2){
            return 28;
        }
        return 0;
            
    }
    
}
