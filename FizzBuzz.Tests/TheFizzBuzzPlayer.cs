using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class TheFizzBuzzPlayer
    {
        ILogger logger;
        FizzBuzzPlayer loggingPlayer;

        [SetUp]
        public void setup()
        {
            logger = A.Fake<ILogger>();
            loggingPlayer = new FizzBuzzPlayer(logger);
        }        

        [TestCase(1, ExpectedResult = "1", TestName = "FizzBuzz: Given 1 returns 1 as a string")]
        [TestCase(3, ExpectedResult = "Fizz", TestName = "FizzBuzz: Given 3 returns Fizz as a string")]
        [TestCase(5, ExpectedResult = "Buzz", TestName = "FizzBuzz: Given 5 returns Buzz as a string")]
        [TestCase(15, ExpectedResult = "FizzBuzz", TestName = "FizzBuzz: Given 15 returns FizzBuzz as a string")]
        [TestCase(9, ExpectedResult = "Fizz", TestName = "FizzBuzz: Given 9 returns Fizz as a string")]
        [TestCase(90, ExpectedResult = "FizzBuzz", TestName = "FizzBuzz: Given 90 returns FizzBuzz as a string")]
        public string test(int input)
        {
            return loggingPlayer.play(input);
        }

        [Test]
        public void logsEachPlay()
        {
            loggingPlayer.play(1);
            A.CallTo(() => logger.Log("The FizzBuzz of 1 is 1")).MustHaveHappened();
        }        
    }
}
