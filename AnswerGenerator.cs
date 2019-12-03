using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    public class AnswerGenerator
    {
        public string Answer { get; set; }

        public string GenerateAnswer()
        {
            Random random = new Random();

            int one = random.Next(1, 6);
            int two = random.Next(1, 6);
            int three = random.Next(1, 6);
            int four = random.Next(1, 6);

            Answer = one.ToString() + two.ToString() + three.ToString() + four.ToString();

            return Answer;

        }
    }
}