using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame{
    class GuessingGameLogic{
        static void Main(string[] args){

            Random randomNumberGenerator = new Random();
            int numberToGuess = randomNumberGenerator.Next(0, 100);
            Console.WriteLine(numberToGuess);

            bool gameWon = false;

            do
            {
                Console.WriteLine("Please guess a number between 0 and 100");
                string playerGuess = Console.ReadLine();
                //Convert User input to int (using Parse)
                int guessedNumber = int.Parse(playerGuess);

                //Basic error checking, test if guessedNumber is between 0/100
                if (guessedNumber < 0 || guessedNumber > 100){
                    Console.WriteLine("Number is not between 0 and 100. Try again!");
                }
                else if (guessedNumber > numberToGuess){
                    Console.WriteLine("Too high, Guess again!");
                }
                else if (guessedNumber < numberToGuess){
                    Console.WriteLine("Too low, Guess again!");
                }
                else if (guessedNumber == numberToGuess){
                    gameWon = true;
                    Console.WriteLine("Good guess! You win!");
                }
            } while (gameWon == false);
        }
    }
}
