#include<iostream>
#include<stdlib.h>
#include<string.h>
using namespace std;

class String
{

    public:
    int m_size;
    char* str;

    String(){
        str=new char[1];
        str[0]='\0';
        m_size=0;
    }
    String(char* str1){
        m_size=strlen(str1);
        str=new char[m_size+1];
        strcpy(str,str1);
    }

    int size(){
        int i=0;
        int count=0;
        while(str[i]!='\0'){
            count++;
            i++;
        }

        return count;
    }
    
    void append(const char* str1){
        char* newstr=(char*)malloc(sizeof(char)*(m_size+strlen(str1)));
        int i;
        for(i=0;i<m_size;i++){
            newstr[i]=str[i];
        }
        delete[] str;
        for(i=0;i<strlen(str1);i++){
            newstr[m_size+i]=str1[i];
        }
        newstr[m_size+strlen(str1)]='\0';
        m_size+=strlen(str1);

        cout<<newstr<<endl;
    }
    void append( const String& s){
        char* newstr=(char*)malloc(sizeof(char)*(m_size+s.m_size+1));
        int i;
        for(i=0;i<m_size;i++){
            newstr[i]=str[i];
        }
        for(i=0;i<s.m_size;i++){
            newstr[m_size+i]=s.str[i];
        }
        delete[] str;
        newstr[m_size+s.m_size]='\0';
        m_size+=s.m_size;

        for(int i=0;i<m_size;i++){
            cout<<newstr[i];
        }
    }

    void assign(const char* str2){
        delete[] str;
        str=new char[m_size+1];
        strcpy(str,str2);
        cout<<str<<endl;
    }
    
    char* c_str(){
        return str;
    }
};


int main(){
    
    String s1("parnia");
    String s2("fazeli");
    String s3("ali");
    cout<<s1.c_str()<<endl;
    s1.append("fazeli");
    s1.append(s3);
    cout<<endl;
    s1.assign("pary");
    cout<<s1.size()<<endl;
    
}