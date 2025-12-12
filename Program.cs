using System;

namespace numGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain == true)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                response = "";

                while (guess != number)
                {
                    Console.Write("Guess a number between " + min + " and " + max + " : ");

                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again? (y/n): ");
                response = Console.ReadLine();


                if (response == "y")
                {
                    playAgain = true;
                }
                else if (response == "n")
                {
                    playAgain = false;

                }


                Console.ReadKey();
            }
        }
    }
}