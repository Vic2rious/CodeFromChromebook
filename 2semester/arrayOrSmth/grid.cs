//Victor Ivanov 11/6

using System;

public class Grid_VictorIvanov {
  public static void Main (string[] args){

    Grid jeff = new Grid();
    jeff.example();
    Console.WriteLine(jeff.isEmpty(3,3));
    Console.WriteLine(jeff.getValue(5,6));
    for(int i = 1; i<9; i++) {
      Console.WriteLine(jeff.neighbour(5,6,i) + " " + i);
    }
    jeff.placeValue(3,3,'m');
    Console.WriteLine(jeff.getValue(3,3));
    //jeff.clearGrid();
  }

  public class Grid {

    private int rows;
    private int cols;
    public char[,] grid;

    public Grid() {
      rows = 6;
      cols = 7;
      grid = new char[6,7];
      clearGrid();
    }

    public Grid(int a, int b) {
      rows = a;
      cols = b;
      grid = new char[a,b];
      clearGrid();
    }

    public void clearGrid() {
      for (int i = 0; i<rows; i++) {
        for (int j = 0; j<cols; j++) {
          grid[i,j] = ' ';
        }
      }
    }

    public void example() {
      grid = new char[,]
            {{' ',' ',' ',' ',' ',' ',' '},
             {' ',' ',' ',' ',' ',' ',' '},
             {' ',' ','h','i','t',' ',' '},
             {' ',' ','g',' ','e',' ',' '},
             {' ',' ','r','e','!',' ',' '},
             {' ',' ',' ',' ',' ',' ',' '}};
    }

    public void placeValue(int row, int col, char c) {
      if(grid[row,col] == ' ') {
        grid[row, col] = c;
      } else {
        Console.WriteLine("nein nein nein");
      }
    }

    public void replaceValue(int row, int col, char c) {
        grid[row, col] = c;
    }

    public bool isEmpty(int row, int col) {
      if(grid[row, col] == ' ') {
        return true;
      }
      return false;
    }

    public char getValue(int row, int col) {
        return grid[row, col];
    }

    public bool nbh(int row, int col, int position, char ch) {
      if(row == 0 && (position == 1 || position == 2 || position == 3)) {
        return false;
      }
      if(row == rows-1 && (position == 6 || position == 7 || position == 8)) {
        return false;
      }
      if(col == 0 && (position == 1 || position == 4 || position == 6)) {
        return false;
      }
      if(col == cols-1 && (position == 3 || position == 5 || position == 8)) {
        return false;
      }

      switch (position) {
        case 1:
          if(ch == grid[row-1,col-1]) {
            return true;
          }
          break;
        case 2:
          if(ch == grid[row-1,col]) {
            return true;
          }
          break;
        case 3:
          if(ch == grid[row-1,col+1]) {
            return true;
          }
          break;
        case 4:
          if(ch == grid[row,col-1]) {
            return true;
          }
          break;
        case 5:
          if(ch == grid[row,col+1]) {
            return true;
          }
          break;
        case 6:
          if(ch == grid[row+1,col-1]) {
            return true;
          }
          break;
        case 7:
          if(ch == grid[row+1,col]) {
            return true;
          }
          break;
        case 8:
          if(ch == grid[row+1,col+1]) {
            return true;
          }
          break;
        default:
        return false;
        break;
      }
      return false;
    }

    public bool neighbour(int row, int col, int position) {
      return nbh(row,col,position,' ');

    }

    public bool sameNeighbour(int row, int col, int position) {
      return nbh(row,col,position,grid[row,col]);

    }
  }
}
