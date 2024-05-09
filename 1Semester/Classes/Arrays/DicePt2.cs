//Victor Ivanov 11/6

using System;

public class Dice_VictorIvanov {
  public static void Main (string[] args){

    Console.WriteLine("Rolls: ");
    int r = Convert.ToInt32(Console.ReadLine());
    //int r = 20;
    int num = 1;

    string DR = "Dice Roll".PadRight(14);

    int[] arr_a = {0, 0, 0, 0, 0, 0};
    int[] arr_b = {0, 0, 0, 0, 0, 0};

    Dice a = new Dice();
    Dice b = new Dice();

    for(int i = 0; i<r; i++){
      a.roll();
      b.roll();
      arr_a[a.getValue()-1]++;
      arr_b[b.getValue()-1]++;
    }

    Console.WriteLine("\n" + DR + "Dice 1\t Dice 2");
    // \t works only once idk why (it reads it as 2 or 4 spaces randomly)
    // I had to use .PadRight()

    for(int i = 0; i<arr_a.Length; i++){
      Console.WriteLine(num + "".PadRight(13) + arr_a[i].ToString().PadRight(11)+ arr_b[i]);
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
