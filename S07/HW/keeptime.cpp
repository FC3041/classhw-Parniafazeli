#include<iostream>
#include<Windows.h>
using namespace std;

class Keeptime{

    double StartTime;
    const char* loopname;
    

    public:
    Keeptime(const char* loop){
        loopname=loop;
        StartTime=GetTickCount64();
    }

    
    ~Keeptime(){
        double Endtime=GetTickCount64();
        double Time=Endtime-StartTime;

        cout<<"Time:"<<Time<<endl;
    }

};

int main(){
    {
        Keeptime time("loop");
        for(int i=0;i<100000000;i++){
            int j=i*i;
        }

    }


}