//Victor Ivanov 11/6

using System;

public class TupleVector_VictorIvanov {
  public static void Main (string[] args){
    Tuple<double,double,double> u = FillVector("first vector");
    Tuple<double,double,double> v = FillVector("second vector");
    Tuple<double,double,double> h = AddVectors(u, v);
    Console.WriteLine(u);
    Console.WriteLine(v);
    Console.WriteLine(h);
  }

  public static Tuple<double,double,double> FillVector(string name) {
    Console.WriteLine("X cordinates for " + name);
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Y cordinates for " + name);
    double y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Z cordinates for " + name);
    double z = Convert.ToDouble(Console.ReadLine());

    return Tuple.Create(x, y, z);
  }

  public static Tuple<double,double,double> AddVectors(Tuple<double,double,double> a, Tuple<double,double,double> b) {
    return Tuple.Create(a.Item1 + b.Item1, a.Item2 + b.Item2, a.Item3 + b.Item3);
  }


}
