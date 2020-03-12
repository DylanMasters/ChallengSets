using System;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Select(i => (i % 2 == 0 ? i : -i)).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           return new string[] { str1, str2, str3, str4 }.Select(s => s.Length).Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return !(sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }
            double number;
            return double.TryParse(input, out number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            int AvgEvens = 0;
            int count = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    AvgEvens += num;
                    count++;
                }
            }
            double finalAVG = AvgEvens / count;
            return finalAVG;
        }

        public int Factorial(int number)
        {
            int test = number;
            int fact = 1;
            if (test >= 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                return fact;
                
            }
            throw new ArgumentOutOfRangeException();

        }
    }
}