//Victor Ivanov 11/6

using System;

public class Dice_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Rolls: ");
    int r = Convert.ToInt32(Console.ReadLine());
    int num = 1;

    int[] arr = {0, 0, 0, 0, 0, 0};

    Dice a = new Dice();

    for(int i = 0; i<r; i++){
      a.roll();
      arr[a.getValue()-1]++;
    }

    Console.WriteLine("\nDice Roll\tTimes Rolled");
    foreach(int i in arr){
      Console.WriteLine(num + "\t\t" + i);
      num++;
    }
    Console.WriteLine("Total Rolls: " + r);


  }
}

class Dice {
  private int sides;
  private int value;

  public Dice(){
    this.sides = 6;
    this.value = 1;
  }

  public Dice(int sides){
    this.sides = sides;
    this.value = 1;
  }

  public void setSide(int side){
    this.sides = side;
  }

  public void setValue(int value){
    this.value = value;
  }

  public int getSide(){
    return this.sides;
  }

  public int getValue(){
    return this.value;
  }
  public void roll(){
    Random rnd = new Random();
    this.value = rnd.Next(1,this.sides+1);
  }


}

/*

Write a Dice class to support your main program.

It should contain the following attributes:

sides
value
It should contain two constructors:

Dice()
Dice(sides)
Set your initial value to 1.
The class should contain the following methods

setSide(int side)
setValue(int value)
getSide()
getValue()
roll()
*/
