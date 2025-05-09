#include <iostream>
#include <math.h>
#define PI 3.14159265358979323846
using namespace std;

class Circle{
    public:
        double r;
        double x;
        double y;
        double print_mohit(){
            return 2*PI*r;
        }
        double calculate_masahat(){
            return PI*r*r;
        }
        double distance_markaz(Circle c1){
            double diff_x=c1.x-x;
            double diff_y=c1.y-y;
            return sqrt((diff_x*diff_x)+(diff_y*diff_y));
        }
        double distance_nogthe_markaz(double x1,double y1){
            double diff_x=x1-x;
            double diff_y=y1-y;
            return sqrt((diff_x*diff_x)+(diff_y*diff_y));
        }

        void check_in_circle(double x2, double y2){
            double dist_noghtmarkaz=(distance_nogthe_markaz(x2,y2));
            if (dist_noghtmarkaz>r){
                cout <<"out of circle"<<endl;
            }
            else if(dist_noghtmarkaz==r){
                cout <<"a point is on the circle"<<endl;
            }
            else{
                cout <<"a point is in the circle"<<endl;
            }
        }


};

int main(){
    Circle c;
    Circle c2;
    c2.x=6;
    c2.y=8;
    c.x=5;
    c.y=4;
    c.r=10;
    double mohit=c.print_mohit();
    cout<<"mohit: "<<mohit<<endl;
    double masahat=c.calculate_masahat();
    cout<<"masahat: "<<masahat<<endl;
    double dist_markaz=c.distance_markaz(c2);
    cout<<"dist_markaz: "<<dist_markaz<<endl;
    double dist_noghte_markaz=c.distance_nogthe_markaz(6,9);
    cout<< "dist_noghte_markaz: "<<dist_noghte_markaz<<endl;
    c.check_in_circle(6,9);
}