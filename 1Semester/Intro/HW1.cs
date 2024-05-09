// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HW2_VictorIvanov
{
    public static void Main(string[] args)
    {

        int q = 1;
        // Problem 1
        Console.WriteLine("Question: \"" + q + "\"\n");
        q++;

        Console.WriteLine ("a\ta^2\ta^3");

        for(int i = 1; i <= 4; i++) {
            Console.WriteLine (i + "\t" + Math.Pow(i,2) + "\t" + Math.Pow(i,3));
        }

        //Problem 2
        Console.WriteLine("\nQuestion: \"" + q + "\"\n");
        q++;

        Console.WriteLine ("9.5 x 4.5 - 2.5 x 3");
        Console.WriteLine ("-------------------");
        Console.WriteLine ("     4.5 - 3.5");
        Console.WriteLine ("\n" + (9.5*4.5 - 2.5*3)/(4.5 - 3.5) + "\n");

        //Problem 3
        Console.WriteLine("Question: \"" + q + "\"\n");
        q++;

        int sum = 0;

        for (int i = 1; i<=9; i++) {

            sum +=i;

            Console.Write(i <= 8 ? i + " + " : i + " = " + sum);
        }

        //Problem 4
        Console.WriteLine("\n\nQuestion: \"" + q + "\"");
        q++;

        int PiDegree = 110000;
        double pi;
        int flag;

        /*Why do we use doubles?

        because for example when i = 3.0 the division of 1/i returns 0.3333
        if we devided by only 3 it would return simply 0
        which isn't helpful at all*/


        for (int j = PiDegree; j != PiDegree + 4; j+=2) {

            Console.Write("\n4 x (");

            flag = -1;
            pi = 1.0;
            double i;

            for (i = 3.0; i <= j; i+=2) {

                      pi = flag < 0 ? pi - 1/i : pi + 1/i;

                      //Console.WriteLine("Test Test: " + pi + " asdfasdf " + i);

                      Console.Write(flag < 0 ? i-2 + " - 1/" : i-2 + " + 1/");

                      flag*=-1;
                }

                Console.Write(i-2 + ") = " + pi*4 + "\n");
          }

        //Problem 5
        Console.WriteLine("\nQuestion: \"" + q + "\"\n");
        q++;

        double radius = 5.5;
        pi = 3.14;

        double perimeter = 2*radius*pi;
        double area = Math.Pow(radius,2)*pi;

        Console.WriteLine("A circle with a radius of " + radius
        + " has a perimeter of " + perimeter
        + " and an area of " + area);

        //Problem 6

        double width = 4.5;
        double height = 7.9;

        perimeter = 2*(width + height);
        area = width*height;

        Console.WriteLine("\nA rectangle with a width of " + width
        + " and a height of " + height
        + " has a perimeter of " + perimeter
        + " and an area of " + area);


    }

}
