namespace lesson23;
using System;
class Program
{
    public static void head(int w){
        int k=(w/2)+1;
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
    
    
    public static void line(int w){
        Console.Write("+");
        for(int i=0; i<w; i++){
            Console.Write("-");
        }
        Console.Write("+");
        Console.WriteLine();
    }
    public static void body(int h,int w){
        for (int i = 0; i < h; i++) {
        Console.Write("+");
        for (int k = 0; k < w; k++) {
            Console.Write("*"); 
        }
        Console.Write("+"); 
        Console.WriteLine();
    }

    }
    public static void make_rocket(int n,int h,int w){
        head(w);
        line(w);
        for(int i=0;i<n;i++){
            body(h,w);
            line(w);
        }
        head(w);
    }
        
    static void Main(string[] args)
    {
        make_rocket(3,4,5);
        
    }
}
