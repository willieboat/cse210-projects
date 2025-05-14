using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess?: ");
            userGuess = int.Parse(Console.ReadLine());

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Your Cuess is Corect!");
            }
        }

    }
}