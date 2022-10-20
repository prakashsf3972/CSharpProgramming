using System;
namespace OperationOverLoading;
class Program{
    public static void Main(string[] args)
    {
       Box obj1=new Box(1.2,3.2,4.2);
       obj1.CalculateVolume();

       Box obj2=new Box(10.1,11.1,12.2);
       obj2.CalculateVolume();

       Box obj3;

     double volume1=obj1.CalculateVolume();
     System.Console.WriteLine("VOLUME :"+volume1);

     double volume2=obj2.CalculateVolume();
     System.Console.WriteLine("VOLUME2 :"+volume2);

    obj3=obj1+obj2;
    double volume3=obj3.CalculateVolume();
    System.Console.WriteLine("Volume3 :"+volume3);



    }
}
