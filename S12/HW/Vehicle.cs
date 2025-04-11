public interface IVehicle
{
    double speed();
    int Capacity();
    double efficiency();
}

public class Car: IVehicle
{
    public double x1;
    public double x2;
    public double t1;
    public double t2;
    public int numberofseats;
    public double sookht_masrafi;


    public Car(double t,double tt, double x, double xx,int seats,int sookht){
        x1=x;
        x2=xx;
        t1=t;
        t2=tt;
        sookht_masrafi=sookht;
        numberofseats=seats;
        
    }
    public double speed(){
        return (x2-x1)/(t2-t1);
    }
    public int Capacity(){
        return numberofseats;
    }
    public double efficiency(){
        return sookht_masrafi/(x2-x1);
    }
}
public class Motor: IVehicle
{
    double masafat;
    double modatzaman;
    double tavan_vorodi;
    double tavan_khoroji;

    public Motor(double x, double zaman, double tavaninput, double tavanoutput){
        masafat=x;
        modatzaman=zaman;
        tavan_vorodi=tavaninput;
        tavan_khoroji=tavanoutput;
    }
    public double speed(){
        return masafat/modatzaman;
    }
    public int Capacity(){
        return 2;

    }
    public double efficiency(){
        return tavan_khoroji/tavan_vorodi;
    }
}

public class Bus: IVehicle
{
    public double masafat;
    public double time;
    double kar;

    public Bus(double x, double zaman, double kar1){
        masafat=x;
        time=zaman;
        kar=kar1;
    }

    public double speed(){
        return masafat/time;
    }
    public int Capacity(){
        return 42;
    }
    public double efficiency(){
        return kar/time;
    }

}