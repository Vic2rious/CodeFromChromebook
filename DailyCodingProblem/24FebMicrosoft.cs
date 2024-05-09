/*Good morning! Here's your coding interview problem for today.

This problem was asked by Microsoft.

You are given a list of jobs to be done, where each job is represented by a start time and end time.
Two jobs are compatible if they don't overlap. Find the largest subset of compatible jobs.

For example, given the following jobs (there is no guarantee that jobs will be sorted):

[(0, 6),
(1, 4),
(3, 5),
(3, 8),
(4, 7),
(5, 9),
(6, 10),
(8, 11)]
Return:

[(1, 4),
(4, 7),
(8, 11)]

0 1 2 3 4 5 6 7 8 9 10 11 12
* * * * * * * * * * * * *
  * *
  * * * *
  * * * * * * * * *
    * * *
    * *
      * * * * * * * * * * *
          * * *
*/





//Victor Ivanov 12/1

using System;


public class Mic_VictorIvanov {
  public static void Main (string[] args){

  int[,] info = {{0, 6}, {1, 4}, {3, 5}, {3, 8}, {4, 7}, {5, 9} , {6, 10}, {8, 11}};
  Console.WriteLine("How many shifts: " + search(info));

  }

  public static int search(int[,] array, int end, int shifts) {
   int a = shifts;
    for (int i = 0; i<array.GetLength(0); i++) {
      if(array[i,0] >= end) {

       //Console.WriteLine(array[i,0] + ", " + array[i,1]);
         a = a > search(array, array[i,1], shifts+1) ? a : search(array, array[i,1], shifts+1);
      }

    }

    //Console.WriteLine("    " + shifts);
    return a;
  }

  public static int search(int[,] array) {
    return search(array, 0, 0);

  }
}
