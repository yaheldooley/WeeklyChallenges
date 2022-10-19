using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals == null) return true;

            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
			return number % 2 == 0;
		}

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
		}

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double lowest = double.MaxValue;
            double highest = double.MinValue;

            foreach (double num in numbers)
            {
                if (num < lowest) lowest = num;
                else if (num > highest) highest = num;
            }

            return lowest + highest;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == null || str2 == null) return 0;

            return str1.Length <= str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
			int sum = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
                if (i % 2 != 0) continue;
				sum += numbers[i];
			}
			return sum;
		}

        public bool IsSumOdd(List<int> numbers)
        {
			int sum = 0;
			for (int i = 0; i < numbers.Count; i++)
			{
				sum += numbers[i];
			}
			return sum % 2 != 0;
		}

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 1) return 0;
            return number / 2;

        }
    }
}
