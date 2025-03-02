#include<iostream>
#include<stdlib.h>
using namespace std;


class Vector
{
    public:
    int* m_members;
    int m_size;
    int m_capacity;

    void makevector(){
        if(m_capacity==0){
            m_capacity=1;
        }
        else{
            m_capacity*=2;
        }

        int* newmemory= new int[m_capacity];
        int i;
        for(i=0;i<m_size;i++){
            newmemory[i]=m_members[i];
        }

        delete[] m_members;
        m_members=newmemory;
    }

    Vector(){
        m_size=0;
        m_capacity=1;
        m_members=new int[1];
    }
    Vector(int capacity){
        m_capacity=capacity;
        m_size=0;
        m_members=new int[m_capacity];
    }

    int capacity(){
        return m_capacity;
    }

    int* push_back(int x){
        if(m_size>=m_capacity){
            makevector();
        }
        m_members[m_size]=x;
        m_size++;
        return m_members;
    }
    void clear(){
        delete[] m_members;
        m_capacity = 1; 
        m_members = new int[m_capacity];
        m_size = 0;
        
    }
    int at(int i){
        if(i<m_size){
            return m_members[i];
        }
        return 0;
    }

    int size(){
        return m_size;
    }
    
    int* insert(int i, int x){
        m_size+=1;
        m_capacity*=2;

        int* newmem=new int[m_capacity];
        int j;
        for(j=0;j<i;j++){
            newmem[j]=m_members[j];
        }
        newmem[i]=x;
        for(j=i+1;j<m_size;j++){
            newmem[j]=m_members[j-1];
        }
        delete[] m_members;
        m_members=newmem;

        return m_members;
    }
    int* erase(int i) {
        if (i >= 0 && i < m_size) {
            for (int j = i; j < m_size - 1; j++) {
                m_members[j] = m_members[j + 1];
            }
            m_size--;
        }

        return m_members;
    }
};


int main(){
    Vector v1(5);
    v1.push_back(1);
    v1.push_back(2);
    v1.push_back(3);
    v1.push_back(4);
    v1.push_back(5);

    cout << "Size: " << v1.size() << ", Capacity: " << v1.capacity() << endl;
    for(int i = 0; i < v1.size(); i++){
        cout << v1.at(i) << " ";
    }
    cout << endl;
    v1.erase(3);

    cout << "Size after erase: " << v1.size() << endl;

    for(int i = 0; i < v1.size(); i++){
        cout << v1.at(i) << " ";
    }
    cout << endl;

    return 0;
}