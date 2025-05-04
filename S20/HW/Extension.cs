using System.Text;
public static class EXTstring
{
    
    public static string encoder(this string str){//TODO1
        if (str==null){
            return str;
        }
        StringBuilder encodtext=new StringBuilder();
        foreach( char c in str){
            if(char.IsLetter(c)){
                char x;
                if(char.IsUpper(c)){
                    x='A';
                }
                else{
                    x='a';
                }
                char encodechar=(char)(x + (c - x + 3) % 26);
                encodtext.Append(encodechar);
            }
            else{
                encodtext.Append(c);
            }
        }
        return encodtext.ToString();
    }

    public static string decoder(this string str){//TODO2
        if (str==null){
            return str;
        }
        StringBuilder decodetext=new StringBuilder();
        foreach( char c in str){
            if(char.IsLetter(c)){
                char x;
                if(char.IsUpper(c)){
                    x='A';
                }
                else{
                    x='a';
                }
                char decodechar=(char)(x + (c - x + 23) % 26);
                decodetext.Append(decodechar);
            }
            else{
                decodetext.Append(c);
            }
        }
        return decodetext.ToString();

    }
}