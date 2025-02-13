namespace part3;
using System;
class Program
{
    public static void print_cone(int basesize){
        int k=(basesize/2)+1;
        for(int i=0; i<k;i++){
            Console.Write(" ");
        }
        Console.Write("^");
        Console.WriteLine();
        for(int j=1;j<k;j++){
            for(int z=0;z<(k-j);z++){
                Console.Write(" ");
            }
            for(int g=0;g<j;g++){
                Console.Write("/");
            }
            Console.Write("|");
            for(int q=0;q<j;q++){
                Console.Write("\\");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        print_cone(1);
        print_cone(3);
        print_cone(5);
        print_cone(7);
        print_cone(9);
    }
}
