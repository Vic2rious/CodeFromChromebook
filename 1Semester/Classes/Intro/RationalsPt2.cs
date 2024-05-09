//Victor Ivanov 11/6

using System;
public class Rational2_VictorIvanov {
public static void Main (String[] args){
    int j = Convert.ToInt32(Console.ReadLine());
    int k = Convert.ToInt32(Console.ReadLine());
    int l = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());

RationalNumber a = new RationalNumber();
a.setNumerator(j);
a.setDenominator(k);

RationalNumber b = new RationalNumber(l, m);

Console.WriteLine(a.getNumerator() +"/" +a.getDenominator());
Console.WriteLine(b.getFraction());
}
}

class RationalNumber {

private int numerator;
private int denominator;

public RationalNumber (int numerator, int denominator) {
  setNumerator(numerator);
  setDenominator(denominator);
  reduceFraction();
}

/*
Constructs a new rational number to represent the ratio
(numerator/denominator). The denominator should never be zero.
Use the setDenominator method to enforce this and set the
denominator to a 1 if a zero is passed.
*/


public RationalNumber() {
  this.numerator = 0;
  this.denominator = 1;
}

//Constructs a new rational number to represent the ratio (0/1).



public int getDenominator() {
  return this.denominator;
}

/*
Returns this rational number's denominator value.
For example, if the ratio if (3/5), returns 5.
*/

public int getNumerator() {
  return this.numerator;
}

/*
Returns this rational number's denominator value.
For example, if the ratio if (3/5), returns 3.
*/


public void setNumerator (int numerator){
  this.numerator = numerator;
}

//Changes this rational number's numerator value.

public void setDenominator (int denominator) {
  this.denominator = denominator == 0 ? 1 : denominator;
}

public void reduceFraction() {
    for(int i = 2; i < this.denominator; i++) {
        if(this.numerator % i == 0 && this.denominator % i == 0) {
            this.numerator /= i;
            this.denominator /= i;
            i = 1;
        }
    }

    if(this.denominator < 0) {
        this.denominator*=-1;
        this.numerator*=-1;
    }
}

/*
Changes this rational number's denominator value.
If a 0 is passed, instead set it to a 1.
*/


public string getFraction() {
    reduceFraction();
    return this.numerator + "/" + this.denominator;
}
/*
Returns a String representation of this rational number,
such as "3/5".
*/
}
