//Victor Ivanov 11/6

using System;

public class TikiTakiToi_VictorIvanov {
  public static void Main (string[] args){

    // I create all of the necessary classes, including a temp player
    // which is basically the player who is making a term and switches each turn
    Grid Board = new Grid();
    Player p1 = new Player('X');
    Player p2 = new Player('O');
    Player temp = new Player('?');

    //the game loop, won't stop until a win condition or end of turns (draw)
    while(!Board.EndOfGame()) {
      //decide on a player
      temp = !Board.GetTurn() ? p1 : p2;
      //prints the board
      Board.printBoard();
      //makes the turn and updates the board, logic is explained below
      temp.Turn(Board.GetBoard(), !Board.GetTurn() ? p1 : p2);
      // basically counts the amount of turns taken
      Board.EndTurn();

    }
    //outputs who is the winner
    Board.OutputWinner();


  }
}

public class Grid {

private int turnCount = 0;
private bool turn = false;
private char[] board = {'0', '1', '2', '3', '4', '5', '6', '7', '8'};

  public Grid() {

  }

  public char[] GetBoard() {
    return board;
  }

  public bool GetTurn() {
    return turn;
  }

  public void EndTurn() {
    turnCount++;
  }

  public void OutputWinner() {
    string output = (turnCount == 9) ? "It's a Tie!" : (!turn) ?
     "Player 2 wins!" : "Player 1 wins!";
     printBoard();

    Console.WriteLine(output);
  }

  public Boolean EndOfGame(){

  return (horizontalWin() || verticalWin() || diagonalWin() || turnCount == 9);

  }

  // below are the win conditions
  public Boolean horizontalWin(){
    if ( ((this.board[0] == this.board[1]) && (this.board[1] == this.board[2])) ||
         ((this.board[3] == this.board[4]) && (this.board[4] == this.board[5])) ||
         ((this.board[6] == this.board[7]) && (this.board[7] == this.board[8])) )
          return true;
      return false;
  }
  public Boolean verticalWin(){
    if ( ((this.board[0] == this.board[3]) && (this.board[3] == this.board[6])) ||
         ((this.board[1] == this.board[4]) && (this.board[4] == this.board[7])) ||
         ((this.board[2] == this.board[5]) && (this.board[5] == this.board[8])) )
          return true;
      return false;
  }
  public Boolean diagonalWin(){
    if ( ((this.board[0] == this.board[4]) && (this.board[4] == this.board[8])) ||
         ((this.board[2] == this.board[4]) && (this.board[4] == this.board[6])) )
          return true;
      return false;
  }

  public void printBoard(){
    /* print the current state of the game this.board*/
    turn = (turn == false) ? true : false;
    Console.WriteLine();
    Console.WriteLine(" "+this.board[0]+" | "+this.board[1]+" | "+this.board[2]);
    Console.WriteLine("----------");
    Console.WriteLine(" "+this.board[3]+" | "+this.board[4]+" | "+this.board[5]);
    Console.WriteLine("----------");
    Console.WriteLine(" "+this.board[6]+" | "+this.board[7]+" | "+this.board[8]+"\n\n");

  }


}

public class Player {

private  char symbol;
private int location;

public Player(char ch) {
  symbol = ch;
}

public char ReturnSymbol() {
  return this.symbol;
}

  // checks if the move is invalid
  public Boolean InvalidMove(int x, char[] s, Player other){
  if (x < 0 || x > 8)
    return true;
  return (s[x] == symbol || s[x] == other.ReturnSymbol());
  }

  // prompts the player to enter a location, repeats if invalid
  public void Turn(char[] s, Player other) {
    do {
      Console.Write("Player "+symbol+": ");
      location = Convert.ToInt32(Console.ReadLine());
    }while(InvalidMove(location, s, other));

    s[location] = symbol;
  }


}
