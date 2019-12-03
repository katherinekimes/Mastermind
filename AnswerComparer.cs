using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    public class AnswerComparer
    {
        public string Result { get; set; }
        public string PositionRight { get; set; }
        public string DigitRight { get; set; }
        public bool CorrectGuess { get; set; }

        public bool CheckForCorrectGuess(string answer, string guess)
        {
            if (guess[0] == answer[0] && guess[1] == answer[1] && guess[2] == answer[2] && guess[3] == answer[3])
            {
                CorrectGuess = true;
                return CorrectGuess;
            }
            else
            {
                CorrectGuess = false;
                return CorrectGuess;
            }
        }

        public string Compare(string answer, string guess)
        {
            if (CorrectGuess == true)
            {
                Result = "Congratulations! You found the correct sequence!";
                return Result;
            }
            else
            {
                if (guess[0] == answer[0])
                {
                    PositionRight += "+ ";
                }
                if (guess[1] == answer[1])
                {
                    PositionRight += "+ ";
                }
                if (guess[2] == answer[2])
                {
                    PositionRight += "+ ";
                }
                if (guess[3] == answer[3])
                {
                    PositionRight += "+ ";
                }

                if (guess[0] != answer[0] && (guess[0] == answer[1] || guess[0] == answer[2] || guess[0] == answer[3]))
                {
                    DigitRight += "- ";
                }
                if (guess[1] != answer[1] && (guess[1] == answer[0] || guess[1] == answer[2] || guess[1] == answer[3]))
                {
                    DigitRight += "- ";
                }
                if (guess[2] != answer[2] && (guess[2] == answer[0] || guess[2] == answer[1] || guess[2] == answer[3]))
                {
                    DigitRight += "- ";
                }
                if (guess[3] != answer[3] && (guess[3] == answer[0] || guess[3] == answer[1] || guess[3] == answer[2]))
                {
                    DigitRight += "- ";
                }

                Result = PositionRight + DigitRight;
                return Result;
            }
        }
    }
}
