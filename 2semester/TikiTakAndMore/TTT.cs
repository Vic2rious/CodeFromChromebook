using System;
public class TTT{
public static void Main (String[] args){

String[] board = {"0", "1", "2", "3", "4", "5", "6", "7", "8"};
String p1 = "O";
String p2 = "X";
int location = -99;
Boolean p1Turn = true;

//Start Game
printBoard(board);

//start game loop
while(!win(board)){
  if(p1Turn){
    do {
      Console.Write("Player "+p1+": ");
      location = Convert.ToInt32(Console.ReadLine());
    }while(validMove(location, board, p1, p2));
    
    board[location] = p1;
    p1Turn = false;
  }
  else {
    do {
      Console.Write("Player "+p2+": ");
      location = Convert.ToInt32(Console.ReadLine());
    }while(validMove(location, board, p1, p2));
    board[location] = p2;
    p1Turn = true;
  }
  printBoard(board);

}//end of game loop
//display win condition
if (p1Turn)
  Console.WriteLine("Player "+p2+" wins");
else
  Console.WriteLine("Player "+p1+" wins");

}
// methods to Write
public static void printBoard(String[] board){
  /* print the current state of the game board*/
  Console.WriteLine(" "+board[0]+" | "+board[1]+" | "+board[2]);
  Console.WriteLine("----------");
  Console.WriteLine(" "+board[3]+" | "+board[4]+" | "+board[5]);
  Console.WriteLine("----------");
  Console.WriteLine(" "+board[6]+" | "+board[7]+" | "+board[8]+"\n\n");

}

public static Boolean validMove(int x, String[] s, String p1, String p2){
if (x < 0 || x > 8)
  return true;
return ( (s[x] == p1) || (s[x] == p2) );
}

public static Boolean win(String[] s){
  /*Check if a win condition is met.
  Uses three helper methods.
  return true if win conditions are met; false otherwise*/
return (horizontalWin(s) || verticalWin(s) || diagonalWin(s) );

}
public static Boolean horizontalWin(String[] s){
  if ( ((s[0] == s[1]) && (s[1] == s[2])) ||
       ((s[3] == s[4]) && (s[4] == s[5])) ||
       ((s[6] == s[7]) && (s[7] == s[8])) )
        return true;
    return false;
}
public static Boolean verticalWin(String[] s){
  if ( ((s[0] == s[3]) && (s[3] == s[6])) ||
       ((s[1] == s[4]) && (s[4] == s[7])) ||
       ((s[2] == s[5]) && (s[5] == s[8])) )
        return true;
    return false;
}
public static Boolean diagonalWin(String[] s){
  if ( ((s[0] == s[4]) && (s[4] == s[8])) ||
       ((s[2] == s[4]) && (s[4] == s[6])) )
        return true;
    return false;
}

}
