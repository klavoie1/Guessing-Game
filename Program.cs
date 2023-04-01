using System;

namespace guessinggame;
class guessinggame
{
    static void Main(string[] args)
    {
        int playerGuess = 0;
        int computerNum = 0;

        Random rnd = new Random();

        Console.WriteLine("Let's Play a guessing game!");
        Console.WriteLine("I am thinking of a number between 1 and 20.");
        Console.WriteLine("Enter a guess or type -1 to exit.");


        computerNum = rnd.Next(1, 20);

        while(true)
        {
            Console.WriteLine("What is your guess?");
            playerGuess = int.Parse(Console.ReadLine());
            

            if (playerGuess > computerNum)
            {
                Console.WriteLine("Your guess is to large!");
            }
            else if (playerGuess < computerNum) 
            {
                Console.WriteLine("Your guess is to small!");
            }
            else if (playerGuess == computerNum)
            {
                Console.WriteLine("Congratulations!");
                break;
            }
            else if (playerGuess == -1)
            {
                break;
            }
            else
            {
                Console.WriteLine("That is an incorrect value!");
            }
            
        }
    }
}


