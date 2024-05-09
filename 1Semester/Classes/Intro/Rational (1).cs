using System;
public class Rational {
public static void Main (String[] args){
RationalNumber a = new RationalNumber();
a.setNumerator(4);
a.setDenominator(5);

RationalNumber b = new RationalNumber(3, 10);

Console.WriteLine(a.getNumerator() +"/" +a.getDeonominator());
Console.WriteLine(b.getFraction());
}
}

class RationalNumber {


}
