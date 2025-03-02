#include<iostream>
#include<stdlib.h>
#include<string.h>
#include<stdbool.h>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }

    void printStr()
    {
        cout << m_PChars << endl;
    }

    int len(){//TODO
        return m_size;
    }

    int len1(){//TODO
        int i=0;
        int count=0;
        while(m_PChars[i]!='\0'){
            count++;
            i++;
        }

        return count;
    }


    char* add(const MyStr& s2){//TODO
        char* newstr=(char*)malloc(sizeof(char)*(m_size+s2.m_size+1));
        int i;
        for(i=0;i<m_size;i++){
            newstr[i]=m_PChars[i];
        }
        for(i=0;i<s2.m_size;i++){
            newstr[m_size+i]=s2.m_PChars[i];
        }

        delete[] m_PChars;
        newstr[m_size+s2.m_size]='\0';
        m_size+=s2.m_size;
        m_PChars=newstr;

        return m_PChars;
    }

    bool checkSubstr(const char* str1){//TODO
        int i, j;
        int str1_len = strlen(str1);
    
        for (i = 0; i <= m_size - str1_len; i++) {
            for (j = 0; j < str1_len; j++) {
                if (m_PChars[i + j] != str1[j]) {
                    break;
                }
            }
            if (j == str1_len) {
                return true; 
            }
        }
        return false; 
    }
};
int main()
{
    MyStr s1("parnia");

    MyStr s2("parnia fazeli", 7, 6);
    s2.printStr();
    

    cout<<s2.checkSubstr("fazel")<<endl; // TODO1
    cout<<s2.len()<<endl; //TODO2
    cout<<s2.add(s1)<<endl; // TODO3 
    
}