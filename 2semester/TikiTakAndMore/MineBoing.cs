using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Minesweeper
{

    public static void Main(string[] args)
    {
        int menuChoice;          //user input menu option
        bool enterMenu = true;   //for the menu loop
        List<Game> gameHistory = new List<Game>();

        do
        {
            Console.WriteLine("Welcome to Minesweeper!\n\n1. Play\n2. Display Stats\n3. Exit\n\nEnter menu choice: ");
            menuChoice = MenuInput();

            if (menuChoice == 1)
            {
                Player player = new Player();

                Grid grid = new Grid(setDifficulty());
                grid.fillGrid();
                grid.printGrid();
                player.stopwatch.Start(); // The stopwatch starts exactly after the board is printed for the first time.
                int turns = 0;

                while (grid.win == 0)
                {
                    turns++;
                    Console.ResetColor();

                    //User input for coordinates and opening/flagging
                    Console.WriteLine("Enter X coordinates: ");
                    player.setXCords(Console.ReadLine());

                    Console.WriteLine("Enter Y coordinates: ");
                    player.setYCords(Console.ReadLine());

                    Console.WriteLine("Open the tile or put a flag? (Enter to open | Anything else to flag | Open a flag to remove it)");
                    player.setOpenOrFlag(Console.ReadLine());

                    //Sends the user's input to the TakeTurn method to handle the turn of the player and prints the changes.
                    grid.TakeTurn(player.xCords, player.yCords, String.IsNullOrEmpty(player.openOrFlag), player);
                    grid.printGrid();
                }
                //Prints the time taken to complete the game.
                TimeSpan elapsed = player.stopwatch.Elapsed;
                /* retrieves the elapsed time measured by a Stopwatch object named player
                 * and assigns it to a TimeSpan variable called elapsed. The Stopwatch.Elapsed
                 * property returns the amount of time that has passed since the Stopwatch started.*/

                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds);
                /* creates a formatted string representation of the elapsed time. It uses the
                 * string.Format method to create the string, with placeholders ({0}, {1}, {2})
                 * representing the hours, minutes, and seconds components of the elapsed TimeSpan.*/

                Console.WriteLine($"Elapsed Time: {elapsedTime}\n\n");
                //Prints the corresponding prompt depending on the ending of the game – either lose or win.


                if (grid.win == 1)
                {
                    Console.WriteLine("Game Over!");
                    grid.PrintAllBombs();
                    gameHistory.Add(new Game(false, turns, elapsedTime));
                }
                else if (grid.win == 2)
                {
                    Console.WriteLine("Congratulations, you won!");
                    gameHistory.Add(new Game(true, turns, elapsedTime));

                } // After a game the user can start a new one rigth away.
                if (PlayNewGame(grid, player))
                    continue;
                else break;


            }
            else if (menuChoice == 2)
            {
                displayStats(gameHistory);
            }
            else
            {
                enterMenu = false;
                Console.WriteLine("\nGoodbye!");
            }

        } while (enterMenu);
    }



    /*
        This method prompts the user for input and validates the input to ensure it is an integer between 1 and 3.
        Returns:
        - An integer representing the chosen menu option.
     */
    public static int MenuInput()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int menuChoice)) // Preventing the game to break.
            {
                if (menuChoice >= 1 && menuChoice <= 3)
                {
                    return menuChoice;
                }
                else
                {
                    Console.Write("Please, enter an integer between 1 and 3!");
                }
            }
            else
            {
                Console.Write("Enter an integer. Don't try to break the game it won't work.");
            }
        }
    }

    public static bool PlayNewGame(Grid grid, Player player) //New game after finsihing previous one
    {
        Console.WriteLine("Do you want to play again? Press Y if you want to play again and press N if you wish to exit.");
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.Y)
        {
            player.stopwatch.Restart();
            grid.fillGrid();
            return true;
        }
        else if (keyInfo.Key == ConsoleKey.N)
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid input. Press N to continue\n or Y if you wish to continue");
            return PlayNewGame(grid, player);
        }
    }

    /*
        The setDifficulty() method prompts the user to choose a difficulty level.
        It continuously loops until a valid input is received.
        The method displays a menu with options for beginner, intermediate, and expert difficulties.
        The user is asked to enter their desired difficulty by providing a corresponding integer.
        The method handles input validation and prevents the game from breaking by checking if the user's input
        is a valid integer within the range of 1 to 3 (inclusive).
        If the user enters an invalid input (not an integer or not within the valid range),
        appropriate error messages are displayed in red color with white text highlighting.
        Returns:
        - The selected difficulty level as an integer.
    */
    public static int setDifficulty()
    {
        while (true)
        {

            Console.Write("\n1 - Beginner\n2 - Intermediate\n3 - Expert\nPlease choose your desired difficulty: ");
            if (int.TryParse(Console.ReadLine(), out int result)) // Preventing the game to break.
            {
                if (result >= 1 && result <= 3)
                {
                    return result;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White; // Nice little highlighting going on here.
                    Console.Write("Please, enter an integer between 1 and 3!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White; // Nice little highlighting going on here.
                Console.Write("Enter an integer. Don't try to break the game it won't work.");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
    /*
        This method takes a List of Game objects as a parameter.
        The purpose of the method is to display statistics of the games played.
        The method iterates over the gameHistory List and prints the game number, result (win or loss),
        number of turns taken, and time taken for each game.
        It also calculates and displays the win rate based on the number of games won.
        If the gameHistory List is empty, it displays a message indicating that no games have been played.
        Parameters:
        - gameHistory: A List of Game objects representing the history of played games.
        Returns: This method does not return any value (void).
    */
    private static void displayStats(List<Game> gameHistory)
    {
        int x = 1;
        int won = 0;
        Console.WriteLine(); // Formatting!
        if (gameHistory.Count > 0)
        {
            foreach (var game in gameHistory)
            {
                string result = String.Empty;

                if (game.won)
                {
                    result = "Win";
                    won++;
                }
                else
                    result = "Loss";

                Console.WriteLine($"{x}. {result}. You took {game.turns} turns in {game.time}  ");
                x++;
            }
            string winrate = String.Format("{0:P2}.", (double)won / (x - 1));
            Console.WriteLine();
            Console.WriteLine($"You have a winrate of {winrate}");
        }
        else Console.WriteLine("You have not played any games. \n");

        Console.WriteLine(); // Formatting again!!
    }
}
/*
    This class represents a Player in a game. It encapsulates the attributes and behaviors of a player.
 */

public class Player
{
    public string xCords { get; private set; } //     xCords: A string representing the x-coordinate of the player's position.
    public string yCords { get; private set; } //     yCords: A string representing the y-coordinate of the player's position.
    public string openOrFlag { get; private set; } //     openOrFlag: A string representing whether the player has chosen to open or flag a position.
    public Stopwatch stopwatch = new Stopwatch(); //     stopwatch: A Stopwatch object used to measure the elapsed time for the player. It is public, allowing external code to access and utilize the stopwatch.

    public Player()
    {

    }
    //    setXCords(string xCords): A method used to set the x-coordinate of the player's position.
    public void setXCords(string xCords)
    {
        this.xCords = xCords;
    }
    //     setYCords(string yCords): A method used to set the y-coordinate of the player's position.
    public void setYCords(string yCords)
    {
        this.yCords = yCords;
    }
    //     setOpenOrFlag(string openOrFlag): A method used to set whether the player has chosen to open or flag a position.
    public void setOpenOrFlag(string openOrFlag)
    {
        this.openOrFlag = openOrFlag;
    }
}
public class Grid
{
    public int rows { get; private set; }
    public int cols { get; private set; }
    public int freeTiles { get; private set; } = 0;
    Dictionary<int, int[]> difficulties = new Dictionary<int, int[]>() {
                {1, new int[] {8,8,10} },
                {2, new int[]  {16,16,40} },
                {3, new int[] {16,30,99}} }; // We use dictionaries to store information about the difficulty. We could have used a jagged array or a 3d array but dictionaries are cooler.

    private int bombCount = 0;
    public int win = 0; // 0 - in game; 1 - exploded; 2 - win
    public Tile[,] board;
    private int flags = 0;

    public Grid(int difficulty)
    {
        rows = difficulties[difficulty][0];
        cols = difficulties[difficulty][1];
        bombCount = difficulties[difficulty][2];
        board = new Tile[rows, cols];
        freeTiles = rows * cols; // We use this in our win condition. We just check if all tiles are occupied. If the player hasn't stepped on a mine
        // and has filled all tiles, then he has won.
        flags = bombCount;
    }
    public void fillGrid()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                board[i, j] = new Tile(); // Filling the grid with tile objects
            }
        }
        placeBombs();
    }
    public void placeBombs()
    {
        while (bombCount > 0)
        {
            var rand = new Random();
            int num1 = rand.Next(rows);
            int num2 = rand.Next(cols);
            if (board[num1, num2].isBomb == false)
            {
                board[num1, num2].makeBomb();
                bombCount--;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                board[i, j].assignCount(i, j, board);
            }
        }
    }
    public void TakeTurn(string xInput, string yInput, bool open, Player player)
    {
        if (int.TryParse(xInput, out int x) && int.TryParse(yInput, out int y))
        {
            if (x >= 0 && x < cols && y >= 0 && y < rows)
            {
                if (board[y, x].info() == '■')
                {

                    if (open)
                    {
                        board[y, x].Reveal();


                        if (board[y, x].info() == '*')
                        {
                            win = 1;
                            player.stopwatch.Stop();

                        }
                        else if (board[y, x].info() == '0')
                        {

                            board[y, x].revealed = false;
                            OpenAdjacentTiles(y, x);
                        }
                        else if (Char.IsDigit(board[y, x].info()))
                            freeTiles--;
                    }
                    else
                    {
                        flags--;
                        freeTiles--;
                        board[y, x].flag();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White; // Nice little highlighting going on here.
                        Console.Write($"    You have {flags} flags remaining.   ");
                        Console.ResetColor();
                    }
                }
                // The following else if statement removes the flag from an already flagged tile and reveals it. It correspondingly increases
                // the counter of the flags. From here everything goes as the a normal revealed tile. If it is a bomb, the game ends.
                // If not, it displays the number of adjacent bombs.
                else if (board[y, x].info() == '$')
                {
                    board[y, x].Reveal();
                    flags++;

                    if (board[y, x].info() == '*')
                    {
                        win = 1;
                        player.stopwatch.Stop();

                    }
                    else if (board[y, x].info() == '0')
                    {

                        board[y, x].revealed = false;
                        OpenAdjacentTiles(y, x);
                    }

                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White; // Nice little highlighting going on here.
                    Console.Write($"    You have {flags} flags remaining.   ");
                    Console.ResetColor();

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White; // Nice little highlighting going on here.
                    Console.Write("This tile has already been revealed.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White; // Nice little highlighting going on here.
                Console.Write(" Invalid coordinates");
                Console.ResetColor();
            }
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White; // Nice little highlighting going on here.
            Console.Write("Coordinates should be numbers. STOP TRYING TO BREAK THE GAME!!!");
            Console.ResetColor();
        }
        if (freeTiles == 0)
        {
            win = 2;
        }

    }

    public void PrintAllBombs()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[j, i].isBomb)
                {
                    board[j, i].Reveal();
                }
            }
        }
        printGrid();
    }

    //The recursive method OpenAdjacentTiles makes sure if you open a tile with 0 bombs near it it starts searching blank tiles untill it finds a tile with a number. The base case is if a tile is opeend, out of the bounds, or numbered stop the recursion,
    //otherwise call the method again wiath all of the 8 cells around the selected cell.
    public void OpenAdjacentTiles(int row, int col)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols || board[row, col].revealed || board[row, col].info() == '$')
        {
            return;
        }
        board[row, col].Reveal();
        freeTiles--;

        if (board[row, col].info() == '0')
        {
            OpenAdjacentTiles(row - 1, col - 1);
            OpenAdjacentTiles(row - 1, col);
            OpenAdjacentTiles(row - 1, col + 1);
            OpenAdjacentTiles(row, col - 1);
            OpenAdjacentTiles(row, col + 1);
            OpenAdjacentTiles(row + 1, col - 1);
            OpenAdjacentTiles(row + 1, col);
            OpenAdjacentTiles(row + 1, col + 1);
        }
        else if (Char.IsDigit(board[row, col].info()))
        {
            return;
        }
    }
    public void printGrid()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("   " + new string('-', cols * 4 + 1));

        for (int i = 0; i < rows; i++)
        {
            Console.ResetColor();

            if (i < 10)
                Console.Write($" {i} ");
            else Console.Write($"{i} ");

            for (int j = 0; j < cols; j++)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("|");

                if (board[i, j].info() == '$')
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (board[i, j].info() == '*')
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (char.IsDigit(board[i, j].info()))
                {
                    int num = (int)board[i, j].info() - 48; // not the nicest looking conversion but it works, sinc we know these are all 1 digit numbers
                    switch (num)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        default:
                            break;
                    }

                }

                if (board[i, j].info() != '0')
                    Console.Write($" {board[i, j].info()} ");
                else Console.Write($"   ");

            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            Console.WriteLine();

            Console.WriteLine("   " + new string('-', cols * 4 + 1));
        }
        Console.ResetColor();
        for (int i = 0; i < cols; i++)
        {
            if (i == 0)
                Console.Write("    ");
            if (i < 10)
                Console.Write($" {i}  ");
            else Console.Write($" {i} ");
        }
        Console.WriteLine();

    }
}
public class Tile
{
    public bool revealed = false;
    public bool isFlag = false;
    public bool isBomb = false;
    public int bombAmm = 0;
    public char[] symbol = { '■', '*', '$' };

    public char info()
    {
        if (!revealed)
        {
            return isFlag ? symbol[2] : symbol[0];
        }
        else
        {
            return isBomb ? symbol[1] : (char)(48 + bombAmm);
        }
    }

    internal void makeBomb()
    {
        isBomb = true;
    }

    public void flag()
    {
        isFlag = true;
    }
    public void Reveal()
    {
        revealed = true;
    }

    public void assignCount(int y, int x, Tile[,] a)
    {
        Neighbour(y, x, a, -1, -1);
        Neighbour(y, x, a, -1, 0);
        Neighbour(y, x, a, -1, 1);
        Neighbour(y, x, a, 0, -1);
        Neighbour(y, x, a, 0, 1);
        Neighbour(y, x, a, 1, -1);
        Neighbour(y, x, a, 1, 0);
        Neighbour(y, x, a, 1, 1);
    }
    private void Neighbour(int y, int x, Tile[,] a, int yChange, int xChange)
    {
        try
        {
            bool bomb = a[y + yChange, x + xChange].isBomb;
            if (bomb && !isBomb)
            {
                this.bombAmm++;
            }
        }
        catch (Exception e)
        {

        }
    }
}
public class Game
{
    public bool won { get; private set; }
    public int turns { get; private set; }
    public string time { get; private set; }

    public Game(bool won, int turns, string time)
    {
        this.won = won;
        this.turns = turns;
        this.time = time;

    }
}
