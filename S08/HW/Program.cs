using System.IO.Pipes;

namespace HW;


class Program
{

    public static void reverse1(string s, out string s1){// نکلیف 1 تابع برعکس کردن ترتیب کلمات  در جمله
        s1="";
        string[] s2=s.Split(" ");
        
        foreach(string part in s2){
            s1=" "+part+s1;
        }
    }

    public static void reverse2(string s2, out string output1){//  تکلیف 2 تابع برعکس کردن ترتیب کلمه و خود هر کلمه در جمله
        output1="";
        string[] wordarray=s2.Split(" ");
        int len=wordarray.Length;
        int i;
        for (i=0;i<len/2;i++){
            string temp=wordarray[i];
            wordarray[i]=wordarray[len-i-1];
            wordarray[len-i-1]=temp;


            wordarray[i]=reverseword(wordarray[i]);
            wordarray[len-i-1]=reverseword(wordarray[len-i-1]);

            if(len%2==1){
                int vasat=len/2;
                wordarray[vasat]=reverseword(wordarray[vasat]);
            }
        }
        foreach(string part in wordarray){
            output1+=part+" ";
        }
            

    }

    public static string reverseword(string word){
        string rev="";
        foreach(char c in word){
            rev=c+rev;
        }
        return rev;
    }
    static void Main(string[] args)
    {
        string jomle="hava kheili khobe";
        string s1;
        string s2;
        reverse1(jomle, out s1);
        reverse2(jomle,out s2);
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}
