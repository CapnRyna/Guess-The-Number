using System;

namespace GTN
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Enter First Number > ");
            int Mini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number > ");
            int Max = Convert.ToInt32(Console.ReadLine());
            bool playagain = true;
            int min = Mini;
            int max = Max;
            int guess;
            int number;
            int guesses;
            String response;


            while (playagain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = r.Next(min + max);

                while (guess != number)
                { 
                    Console.WriteLine($"\nGuess a number between {min} and {max}");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nYou guessed: {guess}");

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine($"Number was {number}");
                Console.WriteLine($"You Win!");
                Console.WriteLine($"Guesses: {guesses}");
                Console.WriteLine("\nDo you want to play again? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playagain = true;
                }
                else if (response == "N")
                {
                    playagain = false;
                    Console.WriteLine("Thanks for playing! :)");
                    Console.ReadLine();
                }
            }
        }
    }
}
