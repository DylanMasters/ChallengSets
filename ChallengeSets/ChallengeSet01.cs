using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return num1 == num2;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend; 
        }

        public int Add(int number1, int number2)
        {
            return new int[] { number1, number2 }.Sum();
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return new int[] { number1, number2 }.Min();
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson != "")
            {
                return $"Hello, {nameOfPerson}!";
            }
            return "Hello!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}