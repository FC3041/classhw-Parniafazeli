namespace part8;
using System;
class Program
{
    static void Main(string[] args){
        float num;
        int count=0;
        float sum=0;
        float min = float.MaxValue;
        float max = float.MinValue;
        Console.WriteLine("Enter numbers (enter -1 to stop):");

        while(true){
            num=Convert.ToSingle(Console.ReadLine());

            if(num==-1){
                break;
            }
            count++;
            sum+=num;
            if(num<min){
                min=num;
            }
            if(num>max){
                max=num;
            }
        }
        if (count==0){
            Console.WriteLine("No Number");
        }
        else{
           Console.WriteLine("numbers of enteries:" +count);
           Console.WriteLine("average:" +sum/count);
           Console.WriteLine("max:" +max);
           Console.WriteLine("min:" +min);
        }
    }

}
    
        