namespace part6;
using System;
class Program
{
    public static void quadradic(float a, float b, float c){
        float delta=b*b-4*a*c;
        if (a==0){
            float root=(-c)/b;
            Console.WriteLine(root);
        }
        else{
        if (delta>0){
        double root1= (-b + Math.Sqrt(delta) )/(2*a);
        double root2= (-b - Math.Sqrt(delta) )/(2*a);
        Console.WriteLine(root1);
        Console.WriteLine(root2);
        }
        if(delta==0){
        float root=-b/(2*a);
        Console.WriteLine(root);
        }
        if(delta<0){
            Console.WriteLine("there is no root");
        }
        }
    }

    static void Main(string[] args)
    {
        quadradic(1,4,4);
    }
}
