using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomeGenerator = new Random();
        int magicNum = randomeGenerator.Next(1,101);
        int guessNum = 1000;
        Console.WriteLine("The magic number is between 1 and 100");
        int numGuesses = 0;
        
        while(guessNum != magicNum){  

            numGuesses = numGuesses + 1;
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNum = int.Parse(guess);

            if(guessNum > magicNum){
                Console.WriteLine("Lower");
            }

            else if(guessNum < magicNum){
                Console.WriteLine("Higher");
            }

            else{
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {numGuesses} guesses!");
            }
        }
    }
}