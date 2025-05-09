#include<iostream>
#include<stdlib.h>
using namespace std;


class MyList
{
    public:
        int m_size;
        int* m_Pnums;

    MyList(int size, int *nums)
    :m_size(size)
    {
        m_Pnums = (int*)malloc(sizeof(int)*size);
        int i;
        for(i=0; i<m_size;i++)
        {
            m_Pnums[i] = nums[i];
        }
    }

    void append(int x)
    {
        resize(m_size+1);
        m_Pnums[m_size-1] = x;

        int i;
        for(i=0;i<m_size;i++){
            cout<<m_Pnums[i]<<endl;
        }
    }

    private:
    void resize(int newsize)
    {
        int* newMem = (int*)malloc(sizeof(int)*newsize);
        int i=0;
        for(i=0; i<m_size;i++)
        {
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_size = newsize;
        m_Pnums = newMem;
        //newMem = NULL;
    }

    public:
    void pop(){
        int* newlist=(int*)malloc(sizeof(int)*(m_size-1));
        int i=0;
        for(i=0;i<m_size-1;i++){
            newlist[i]=m_Pnums[i];
        }
        free(m_Pnums);
        m_Pnums=newlist;

        for(i=0;i<m_size-1;i++){
            cout<<newlist[i]<<endl;
        }
    }

    void print(){
        int i;
        for(i=0;i<m_size;i++){
            cout<<m_Pnums[i]<<endl;
        }
    }

    void count(){
        cout<<"tedad:"<<m_size<<endl;
    }
    
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    MyList m(5, nums);
    m.print();
    m.count();
    m.pop();

}