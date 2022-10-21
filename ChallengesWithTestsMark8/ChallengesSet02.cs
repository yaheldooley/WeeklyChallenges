using System;
using System.Collections.Generic;
using System.Linq;

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
			if (numbers == null || numbers.Count() == 0) return 0;
			return numbers.Min() + numbers.Max();
		}

		public int GetLengthOfShortestString(string str1, string str2)
		{
			if (str1.Length <= str2.Length) return str1.Length;
			return str2.Length;
		}

		public int Sum(int[] numbers)
		{
			if (numbers == null) return 0;

			int sum = 0;
			foreach (int num in numbers) sum += num;
			return sum;
		}

		public int SumEvens(int[] numbers)
		{
			if (numbers == null) return 0;

			int evenSum = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] % 2 == 0) evenSum += numbers[i];
			}
			return evenSum;
		}

		public bool IsSumOdd(List<int> numbers)
		{
			if (numbers == null) return false;

			int sum = 0;
			foreach (int i in numbers) sum += i;
			return sum % 2 != 0;
		}

		public long CountOfPositiveOddsBelowNumber(long number)
		{
			if (number < 0) return 0;
			return number / 2;
		}
	}
}