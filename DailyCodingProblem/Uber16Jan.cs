//Victor Ivanov 11/6


/*Given an array of integers, return a new array such that each element at index i
of the new array is the product of all the numbers in the original array except the one at i.
For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24].
If our input was [3, 2, 1], the expected output would be [2, 3, 6].

Follow-up: what if you can't use division?*/

using System;

public class Name_VictorIvanov {
  public static void Main (string[] args){

    int[] a = {1, 2, 3, 4, 5};
    int[] b = new int[a.Length];

    int prod = 1;

    for(int j = 0; j<a.Length; j++) {
      for(int i = 0; i< a.Length; i++){
        if(j != i)
        prod*=a[i];
      }
      b[j] = prod;
      prod = 1;
    }


    foreach(var k in b) {
      Console.Write(k + " ");
    }
  }
}
