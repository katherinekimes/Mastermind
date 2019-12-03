using System;

namespace Mastermind
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Mastermind!");
            Console.WriteLine();
            Console.WriteLine("Your task is simple: guess the four-digit sequence chosen by me, your Robot Overlord,");
            Console.WriteLine("and you shall be granted your freedom.");
            Console.WriteLine();
            Console.WriteLine("You have 10 attempts.");
            Console.WriteLine("I'll even give you a hint: each of the digits is between 1 and 6");
            Console.WriteLine("For each digit you guess correctly AND have in the correct position, a \"+\" will appear.");
            Console.WriteLine("For each digit you guess correctly but do not have in the correct position, a \"-\" will appear.");
            Console.WriteLine("WARNING: the order of the + and - symbols may not correspond to the order of the digits you entered!");
            Console.WriteLine("Good luck!");
            Console.WriteLine("============================================================================================================");
            Console.WriteLine();

            int guessesLeft = 10;

            AnswerGenerator answerGenerator = new AnswerGenerator();
            string answer = answerGenerator.GenerateAnswer();
            //Console.WriteLine(answer);        // toggle on for testing purposes

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Guesses Left: {guessesLeft}");
                Console.WriteLine("Please enter your guess:");
                string guess = Console.ReadLine();
                guessesLeft--;
                Console.WriteLine($"Your guess was: {guess}");
                AnswerComparer answerComparer = new AnswerComparer();
                answerComparer.CheckForCorrectGuess(answer, guess);
                answerComparer.Compare(answer, guess);
                Console.WriteLine(answerComparer.Result);
                if (answerComparer.CorrectGuess == true)
                {
                    Console.WriteLine("Enjoy your freedom... while you can.");
                    Console.Read();
                    break;
                }
                Console.WriteLine("Try again!");
                Console.WriteLine();
                Console.WriteLine("============================================================================================================");
                Console.WriteLine();
            }
            Console.WriteLine("Ooh, sorry. You have failed to guess the sequence. Back to your pod you go!");
            Console.Read();
        }
    }
}
