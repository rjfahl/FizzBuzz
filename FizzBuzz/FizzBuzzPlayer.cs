using System;

namespace FizzBuzz
{
    public class FizzBuzzPlayer
    {
        private ILogger logger;

        public FizzBuzzPlayer(ILogger logger)
        {
            this.logger = logger;
        }

        public string play(int input)
        {
            var word = Word(input);
            var result = word == "" ? input.ToString() : word;
            logger.Log($"The FizzBuzz of {input} is {result}");
            return result;
        }

        private static string Word(int input)
        {
            var result = "";
            if (input % 3 == 0)
                result += "Fizz";
            if (input % 5 == 0)
                result += "Buzz";
            return result;
        }
    }
}