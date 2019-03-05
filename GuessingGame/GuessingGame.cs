using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this short program is inspired by Mike Dane's C# tutorial https://www.youtube.com/watch?v=sFe6BrtS-vw&list=PLLAZ4kZ9dFpNIBTYHNDrhfE9C-imUXCmk&index=19
// this modified version will be 2 player, first player will enter a word and can provide hints, second player will try to guess the word that player one entered


namespace GuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            {
                playGame();

            }




            void playGame()
            {
                // variable declaration
                string player1, player2 = "";   // player names
                string secretWord = "this is the secret string";         // to establish the word chosen by player1, initialized so an empty string returned by player 2 will not result in immediate win
                string guess = "";              // to store player2s guess
                int guessCount = 0;             // counter to store amount of guesses used
                string guessMax = "";           // max number of guesses set by player1 as string
                int guessMaxNum = 0;            // max number of guesses set by player 1 converted to int
                bool outOfGuesses = false;
                // bool playAgain = false;
                string playAgainChoice = "y";
                int guessesLeft = 0;





                // Game setup
                Console.Write("Player one, enter your name: ");
                player1 = Console.ReadLine();
                Console.Write("Player two, enter your name: ");
                player2 = Console.ReadLine();
                Console.WriteLine(player2 + ", look away from the screen or cover your eyes!");
                Console.WriteLine();
                Console.Write(player1 + ", enter your secret word now: ");
                secretWord = Console.ReadLine();
                Console.Write("How many guesses will you give player 2: ");
                guessMax = Console.ReadLine();
                guessMaxNum = Convert.ToInt32(guessMax); // will be adding a int32.TryParse here to ensure number entered is an actual number
                guessesLeft = guessMaxNum;
                Console.WriteLine();
                Console.WriteLine("Thank you. When ready instruct " + player2 + " to turn around and face the screen. Press any key to continue. (This will clear the screen!)");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(player2 + ", " + player1 + " has given you " + guessMaxNum + " guesses.");
                Console.Write("Enter your first guess: ");
               guess = Console.ReadLine();
              // --guessesLeft;




               // do
               // {
                    while (outOfGuesses == false)
                    {
                        if (guess == secretWord && guessCount != guessMaxNum)
                        {
                            guessesLeft = (guessMaxNum - guessCount);
                            Console.WriteLine();
                            Console.WriteLine("Congratulations! You win, the secret word was " + secretWord + "! You had " + guessesLeft + " guesses left!");
                            break;
                        } else if (guess != secretWord && guessCount < guessMaxNum)
                        {
                            --guessMaxNum;
                            Console.WriteLine();
                            Console.WriteLine("Sorry, " + guess + " is not the correct answer.");
                            Console.Write("You have " + guessMaxNum + " guesses remaining. Enter another guess: ");
                            guess = Console.ReadLine();
                            
                    } else if (guess != secretWord && guessCount == guessMaxNum)
                        {
                            outOfGuesses = true;
                        Console.WriteLine();
                            Console.WriteLine("Out of guesses, " + player2 + "! You lose, the correct word was " + secretWord + "!");
                        }
                    }
                    Console.Write("Do you want to play again? y/n: ");
                    playAgainChoice = Console.ReadLine();
                    if (playAgainChoice != "y" && playAgainChoice != "n")
                    {
                        Console.WriteLine("Invalid selection. Please choose y or n"); // Ensures selection is a returned value of y or n
                        playAgainChoice = Console.ReadLine();
                    } else if (playAgainChoice != "y" && playAgainChoice == "n") 
                    {
                    // playAgain = false;
                    Console.Clear();
                    Console.WriteLine("Game over. Press any key to exit");
                    Console.ReadKey();

                    } else if (playAgainChoice == "y" && playAgainChoice != "n")
                    {
                    //    playAgain = true;
                        Console.Clear();
                        playGame(); // calls playGame function, restarts with a clear screen
                    }

               // } while (playAgain == false);
               









            }

        }
    }
}
