/*Good morning! Here's your coding interview problem for today.

This problem was asked by Google.

Given a set of closed intervals, find the smallest set of numbers
that covers all the intervals. If there are multiple smallest sets, return any of them.

For example, given the intervals [0, 3], [2, 6], [3, 4], [6, 9],
one set of numbers that covers all these intervals is {3, 6}.
*/

//Victor Ivanov 11/6

using System;

public class Intervals_VictorIvanov {
  public static void Main (string[] args){

    int[,] a = {{0, 3},
                {2, 6},
                {3, 5},
                {6, 9}};

    int min = a[0,0];
    int max = a[0,1];

      for(int i = 1; i< a.GetLength(0); i++) {

    }

  }
}
