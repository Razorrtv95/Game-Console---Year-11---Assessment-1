
// introduction


using System.ComponentModel.Design;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Threading;

static string getuserinput(string exiter)
{
    Console.Write(exiter);
    string input1 = Console.ReadLine()?.Trim().ToLower() ?? "";

    if (input1 == "exit")
    {
        Console.WriteLine("\nExiting the game... Goodbye!");
        Environment.Exit(0); 
    }

    return input1;
}

Console.WriteLine("");
Console.WriteLine("Welcome to the console!\n");
Console.WriteLine("In order to play you must be over the age of 10!\n");
Console.WriteLine("If you'd every like to leave the game, type 'exit' within an input box!\n");
Console.Write("Press any key to continue...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄       ▄▄  ▄▄▄▄▄▄▄▄▄▄▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄  ▄  ▄ ");
Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌     ▐░░▌▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░▌▐░▌▐░▌");
Console.WriteLine("▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░▌░▌   ▐░▐░▌▐░█▀▀▀▀▀▀▀▀▀      ▐░█▀▀▀▀▀▀▀█░▌▐░▌░▌     ▐░▌▐░▌▐░▌▐░▌");
Console.WriteLine("▐░▌          ▐░▌       ▐░▌▐░▌▐░▌ ▐░▌▐░▌▐░▌               ▐░▌       ▐░▌▐░▌▐░▌    ▐░▌▐░▌▐░▌▐░▌");
Console.WriteLine("▐░▌ ▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌▐░▌ ▐░▐░▌ ▐░▌▐░█▄▄▄▄▄▄▄▄▄      ▐░▌       ▐░▌▐░▌ ▐░▌   ▐░▌▐░▌▐░▌▐░▌");
Console.WriteLine("▐░▌▐░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌     ▐░▌       ▐░▌▐░▌  ▐░▌  ▐░▌▐░▌▐░▌▐░▌");
Console.WriteLine("▐░▌ ▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌   ▀   ▐░▌▐░█▀▀▀▀▀▀▀▀▀      ▐░▌       ▐░▌▐░▌   ▐░▌ ▐░▌▐░▌▐░▌▐░▌");
Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌               ▐░▌       ▐░▌▐░▌    ▐░▌▐░▌ ▀  ▀  ▀ ");
Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄▄▄      ▐░█▄▄▄▄▄▄▄█░▌▐░▌     ▐░▐░▌ ▄  ▄  ▄ ");
Console.WriteLine("▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░▌▐░▌▐░▌");
Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀       ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀  ▀  ▀ \n");

Console.ForegroundColor = ConsoleColor.White;

// add error message for name
string name = "";

int outoftime = 10;

while (outoftime > 0)
{

    if (Console.KeyAvailable)
    {
        name = getuserinput(""); 
        break;
    }

    Console.Write($"\rPlease enter your name in {outoftime} seconds... ");
    Thread.Sleep(1000);
    outoftime--;
}

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("");
    Console.WriteLine("\nTime's up. Giving you a default name: Guest.\n");
    name = "Guest";
}

Console.WriteLine($"\nWelcome to the game, {name}!");

int age;
Console.WriteLine("");
ageInput:
Console.Write("What is your age?: ");
try
{
    age = Convert.ToInt32(getuserinput(""));
}
catch
{
    Console.WriteLine("");
    Console.WriteLine("Your age needs to be a number!\n");
    goto ageInput;
}

if (age < 10)
{
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("You can't play the game!\n");
    Console.WriteLine("Goodbye!\n");
    System.Environment.Exit(0);
}
else
{

    Console.Clear();
    Console.WriteLine("You can play the game welcome!\n");
    Console.Write("Press any key to continue... ");
    Console.ReadKey();
    Console.WriteLine("");
    Console.Clear();

gameInput:
    Console.Clear();
    Console.WriteLine("1. Naughts and Crosses");
    Console.WriteLine("2. Rock, Paper, Scissors\n");
    Console.Write("Please select which game you want to play by entering the corresponding number...\n ");

    int hello;

    try
    {
        hello = Convert.ToInt32(getuserinput(""));

    gamefiveInput:

        if (hello == 1)
        {

            // Game  - Naughts and Crosses

            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
            Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌");
            Console.WriteLine(" ▀▀▀▀█░█▀▀▀▀  ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀       ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀       ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ");
            Console.WriteLine("     ▐░▌          ▐░▌     ▐░▌                    ▐░▌     ▐░▌       ▐░▌▐░▌                    ▐░▌     ▐░▌       ▐░▌▐░▌  ");
            Console.WriteLine("     ▐░▌          ▐░▌     ▐░▌                    ▐░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░▌                    ▐░▌     ▐░▌       ▐░▌▐░█▄▄");
            Console.WriteLine("     ▐░▌          ▐░▌     ▐░▌                    ▐░▌     ▐░░░░░░░░░░░▌▐░▌                    ▐░▌     ▐░▌       ▐░▌▐░░░░░░░░░░░▌");
            Console.WriteLine("     ▐░▌          ▐░▌     ▐░▌                    ▐░▌     ▐░█▀▀▀▀▀▀▀█░▌▐░▌                    ▐░▌     ▐░▌       ▐░▌▐░█▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("     ▐░▌          ▐░▌     ▐░▌                    ▐░▌     ▐░▌       ▐░▌▐░▌                    ▐░▌     ▐░▌       ▐░▌▐░▌ ");
            Console.WriteLine("     ▐░▌      ▄▄▄▄█░█▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄           ▐░▌     ▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄▄▄           ▐░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄");
            Console.WriteLine("     ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌          ▐░▌     ▐░▌       ▐░▌▐░░░░░░░░░░░▌          ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌");
            Console.WriteLine("      ▀       ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀            ▀       ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀            ▀       ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ ");
        

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nINSTRUCTIONS: \n");

            Console.WriteLine("You will need a friend for this game!\n");

            Console.WriteLine("You will be playing against them!\n");

            Console.WriteLine("Player 1 is X and Player 2 is O!\n");

            Console.WriteLine("If you'd like to undo your turn, type 'undo' into the input box.\n");

            Console.WriteLine("Shall we begin?\n");

            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool player1turn = true;
            int numTurns = 0;
            Stack<string> undobutton = new Stack<string>();

            while (!CheckVictory() && numTurns != 9)
            {


                printboard();
            gameLoop:

                if (player1turn)
                    Console.WriteLine("Player 1, it's your turn. Enter a number corresponding to the place you'd like to place X.");
                else
                    Console.WriteLine("Player 2, it's your turn. Enter a number corresponding to the place you'd like to place O.");

                string choice1 = getuserinput("");

                
                if (int.TryParse(choice1, out int chosenspot) && chosenspot >= 1 && chosenspot <= 9)
                {

                    int boards = chosenspot - 1;

                    if (board[boards] == "X" || board[boards] == "O")
                    {
                        Console.Clear();
                        printboard();
                        Console.WriteLine("\nSpot already taken! Choose another spot.\n");
                        goto gameLoop;
                    }
                    else
                    {
                        board[boards] = player1turn ? "X" : "O";
                        undobutton.Push(boards.ToString());
                        numTurns++;
                        player1turn = !player1turn;
                        Console.Clear();
                    }
                }

                else if (choice1 == "undo" || choice1 == "Undo")
                {

                    if (undobutton.Count > 0)
                    {
                        int beforemove = Convert.ToInt32(undobutton.Pop());
                        board[beforemove] = (beforemove + 1).ToString();
                        player1turn = !player1turn;
                        numTurns--;
                        Console.Clear();
                    }
                    else
                    {

                        Console.Clear();
                        printboard();
                        Console.WriteLine("\nNo moves to undo!\n");
                        goto gameLoop;

                    }
                }

                else
                {

                    Console.Clear();
                    printboard();
                    Console.WriteLine("\nInvalid input! Please enter a number between 1 and 9.\n");
                    goto gameLoop;
                }


            }

            printboard();


            if (CheckVictory() && player1turn)
                Console.WriteLine("Player 2 wins!");

            else if (CheckVictory() && !player1turn)
                Console.WriteLine("Player 1 wins!");
            else
                Console.WriteLine("It's a draw!");



            gamefourInput: // return to menu for knots and crosses

                Console.WriteLine("\nDo you want to:\n");
                Console.WriteLine("1. Play again. ");
                Console.WriteLine("2. Return to the menu. ");
                Console.WriteLine("3. Exit the game. \n");


                string again = "";
                int notimeleft = 45;

                while (notimeleft > 0)
                {

                    if (Console.KeyAvailable)
                    {
                        again = getuserinput("");
                        break; 
                    }

                    Console.Write($"\rTime left: {notimeleft} seconds... ");
                    Thread.Sleep(1000); 
                    notimeleft--;
                }

                if (string.IsNullOrWhiteSpace(again))
                {
                    Console.WriteLine("\nTime's up! Returning to menu...");
                    Thread.Sleep(1000);
                    goto gameInput;
                }


                if (again == "1")
                {
                    goto gamefiveInput;
                }

                else if (again == "2")
                {
    
                    Console.WriteLine("Goodbye! You will be returned to the menu.");
                    Thread.Sleep(1000);
                    goto gameInput;
                }

                else if (again == "3")
                {

                    Console.WriteLine("Goodbye! You will be exited from the program!");
                    System.Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Please pick one of the three options.");
                    Thread.Sleep(1000);
                    goto gamefourInput;

                }



            bool CheckVictory()
            {

            
                bool row1 = board[0] == board[1] && board[1] == board[2];
                bool row2 = board[3] == board[4] && board[4] == board[5];
                bool row3 = board[6] == board[7] && board[7] == board[8];


                bool col1 = board[0] == board[3] && board[3] == board[6];
                bool col2 = board[1] == board[4] && board[4] == board[7];
                bool col3 = board[2] == board[5] && board[5] == board[8];

 
                bool diag1 = board[0] == board[4] && board[4] == board[8];
                bool diag2 = board[6] == board[4] && board[4] == board[2];

                return row1 || row2 || row3 || col1 || col2 || col3 || diag1 || diag2;

            }


            void printboard()
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("| " + "    ||   " + "  || " + "    |");
                    for (int m = 0; m < 3; m++)
                    {
                        Console.Write("|  " + board[i * 3 + m] + "  |");
                    }
                    Console.WriteLine("\n| " + "    ||   " + "  || " + "    |");
                    Console.WriteLine("---------------------");
                    //Console.WriteLine("| " +"    ||   " + "  || " +"    |" );


                }


            }



        }
        else if (hello == 2)
        {

        // Game 2 - Rock Paper Scissors

        gametwoInput:

            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄    ▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄    ");
            Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌  ");
            Console.WriteLine("▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░▌ ▐░▌      ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌  ");
            Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌▐░▌       ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌       ▐░▌    ");
            Console.WriteLine("▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌          ▐░▌░▌        ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌     ");
            Console.WriteLine("▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌          ▐░░▌         ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌    ");
            Console.WriteLine("▐░█▀▀▀▀█░█▀▀ ▐░▌       ▐░▌▐░▌          ▐░▌░▌        ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀█░█▀▀    ");
            Console.WriteLine("▐░▌     ▐░▌  ▐░▌       ▐░▌▐░▌          ▐░▌▐░▌       ▐░▌          ▐░▌       ▐░▌▐░▌          ▐░▌          ▐░▌     ▐░▌        ");
            Console.WriteLine("▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌      ▐░▌          ▐░▌       ▐░▌▐░▌          ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌      ▐░▌     ");
            Console.WriteLine("▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌     ▐░▌          ▐░▌       ▐░▌▐░▌          ▐░░░░░░░░░░░▌▐░▌       ▐░▌    ");
            Console.WriteLine(" ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀    ▀       ▀            ▀         ▀  ▀            ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀       ");

            Console.WriteLine("");

            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌");
            Console.WriteLine("▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀  ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ");
            Console.WriteLine("▐░▌          ▐░▌               ▐░▌     ▐░▌          ▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌         ");
            Console.WriteLine("▐░▌          ▐░▌               ▐░▌     ▐░▌          ▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌         ");
            Console.WriteLine("▐░▌          ▐░▌               ▐░▌     ▐░▌          ▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌         ");
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀█░▌▐░▌               ▐░▌      ▀▀▀▀▀▀▀▀▀█░▌ ▀▀▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░█▀▀▀▀█░█▀▀  ▀▀▀▀▀▀▀▀▀█░▌");
            Console.WriteLine("          ▐░▌▐░▌               ▐░▌               ▐░▌          ▐░▌▐░▌       ▐░▌▐░▌     ▐░▌            ▐░▌");
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄  ▄▄▄▄█░█▄▄▄▄  ▄▄▄▄▄▄▄▄▄█░▌ ▄▄▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌      ▐░▌  ▄▄▄▄▄▄▄▄▄█░▌");
            Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌");
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀ \n");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Instructions:\n");

            Console.WriteLine("You will be playing against the me, the Computer!\n");

            Console.WriteLine("You will be given 3 options to choose from:\n");

            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors\n");

            Console.WriteLine("If you win, you will be get 1 point.\n");

            Console.WriteLine("If you lose or you draw, no points will be awarded.\n");

            Console.WriteLine("First to 3 points wins!\n");

            Console.WriteLine("Shall we begin?\n");

            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            int myScore = 0;
            int compScore = 0;

            Random random = new Random();

            while (myScore != 3 && compScore != 3)


            {

                Console.Clear();

                Console.WriteLine("\n------------------------------------\n");
                Console.WriteLine("Scores: \n");

                Console.WriteLine("You: " + myScore);
                Console.WriteLine("Computer: " + compScore);


                Console.Write("\nEnter a choice (rock, paper, scissors): ");
                string choice = getuserinput("");

                int computerChoice = random.Next(0, 3);

                if (computerChoice == 0)
                {
                    Console.WriteLine("Computer chooses rock.");

                    switch (choice)

                    {
                        case "rock" or "Rock" or "ROCK":
                            Console.WriteLine("It's a draw this round!");
                            break;
                        case "paper" or "Paper" or "PAPER":
                            Console.WriteLine("You win this round!");
                            myScore = myScore + 1;
                            break;
                        case "scissors" or "Scissors" or "SCISSORS":
                            Console.WriteLine("You lose this round!");
                            compScore = compScore + 1;
                            break;
                        default:
                            Console.WriteLine("Doesn't count. Please try again!");
                            Console.Clear();
                            break;
                    }


                }

                else if (computerChoice == 1)
                {
                    Console.WriteLine("Computer chooses paper.");

                    switch (choice)

                    {
                        case "rock" or "Rock" or "ROCK":
                            Console.WriteLine("You lose this round!");
                            compScore = compScore + 1;
                            break;
                        case "paper" or "Paper" or "PAPER":
                            Console.WriteLine("It's a draw this round!");
                            break;
                        case "scissors" or "Scissors" or "SCISSORS":
                            Console.WriteLine("You win this round!");
                            myScore = myScore + 1;
                            break;
                        default:
                            Console.WriteLine("Doesn't count. Please try again");
                            break;
                    }


                }

                else
                {
                    Console.WriteLine("Computer chooses scissors.");

                    switch (choice)

                    {
                        case "rock" or "Rock" or "ROCK":
                            Console.WriteLine("You win this round!");
                            myScore = myScore + 1;
                            break;
                        case "paper" or "Paper" or "PAPER":
                            Console.WriteLine("You lose this round!");
                            compScore = compScore + 1;
                            break;
                        case "scissors" or "Scissors" or "SCISSORS":
                            Console.WriteLine("It's a draw this round!");
                            break;
                        default:
                            Console.WriteLine("Doesn't count. Please try again");
                            break;
                    }

                }


                // Console.WriteLine("\n------------------------------------\n");
                // Console.WriteLine("Press the enter key to continue to the next round...");
                // getuserinput("");

                Thread.Sleep(2000);

            }

            if (myScore == 3)
            {
                
                Console.Clear();

                Console.WriteLine("You beat the one and only computer!\n");
                Console.WriteLine("\nYou: " + myScore);
                Console.WriteLine("Computer: " + compScore);

                Console.WriteLine("\nYou win!"); // win score 

                goto gamethreeInput;


            }

            else
            {

                Console.Clear();
                
                Console.WriteLine("Better luck next time haha!\n");
                Console.WriteLine("\nYou: " + myScore);
                Console.WriteLine("Computer: " + compScore);

                Console.WriteLine("\nYou lose!");

                goto gamethreeInput;
            }

        gamethreeInput: // return to menu for scissors paper rock

            Console.WriteLine("\nDo you want to:\n");
            Console.WriteLine("1. Play again. ");
            Console.WriteLine("2. Return to the menu. ");
            Console.WriteLine("3. Exit the game. \n");

            string again = "";
            int notimeleft = 45;

            while (notimeleft > 0)
            {

                if (Console.KeyAvailable)
                {
                    again = getuserinput("");
                    break; 
                }

                Console.Write($"\rTime left: {notimeleft} seconds... ");
                Thread.Sleep(1000); 
                notimeleft--;
            }

            if (string.IsNullOrWhiteSpace(again))
            {
                Console.WriteLine("\nTime's up! Returning to menu...");
                Thread.Sleep(1000);
                goto gameInput;
            }

            switch (again)
            {

                case "1":
                    goto gametwoInput;
                case "2":
                    Console.WriteLine("Goodbye! You will be returned to the menu.");
                    Thread.Sleep(2000);
                    goto gameInput;
                case "3":
                    Console.WriteLine("Goodbye! You will be exited from the program!");
                    System.Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("\nPlease pick one of the three options.");
                    Thread.Sleep(1000);
                    goto gamethreeInput;
            }


        }
        else
        {

            Console.WriteLine("Please enter the right number.");
            goto gameInput;
        }

    }
    catch
    {
        Console.WriteLine("");
        Console.WriteLine("It needs to be a number.");
        goto gameInput;

    }


}

//showmenu();





