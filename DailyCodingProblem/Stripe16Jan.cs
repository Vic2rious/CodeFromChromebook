//Victor Ivanov 11/6

/*
Given an array of integers, find the first missing positive integer in linear time and constant space.
In other words, find the lowest positive integer that does not exist in the array.
The array can contain duplicates and negative numbers as well.

For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.

You can modify the input array in-place.
*/

using System;

public class Name_VictorIvanov {
  public static void Main (string[] args){

    int[] a = {3, 4, -1, 1};
    //int[] a = {3, 4, 0, -2, 1, 2, 6, -1, 1};
    //int[] a = {3, 1, 2};
    //int[] a = {-1, -2, 0, 1, 2, 3, 4, 5};
    
    int num = 1;

    Array.Sort(a);

    foreach(var i in a) {
      if(i==num) {
        num++;
      }
    }
    Console.WriteLine(num);

  }
}
