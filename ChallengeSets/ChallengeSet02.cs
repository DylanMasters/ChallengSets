using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length%2 == 0)
            {
                return true;
            }return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number%2 == 0)
            {
                return true;
            }return false;
        }

        public bool IsNumberOdd(int num)
        {
           if(num%2 == 1)
            {
                return true;
            }return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double min = numbers.Min();
            double max = numbers.Max();
            return min * max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            { 
                sum = numbers.Sum(); 
            }return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            int min = 0;
            int max = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] <= min)
                {
                    min = numbers[i];
                }
                else if(numbers[i] >= max)
                {
                    max = numbers[i];
                }
                sum = min * max;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers.Sum()%2 == 1 && numbers != null)
            {
                return true;
            }return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;
            if(number%2 == 1)
            {
                count++;
            }return count;
        }
    }
}
