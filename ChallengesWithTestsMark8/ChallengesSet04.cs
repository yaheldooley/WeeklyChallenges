using System;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;

            if (numbers.Length < 1) return sum;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) sum += numbers[i];
                else sum -= numbers[i];
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new string[] { str1, str2, str3, str4 };
			return strings.OrderBy(i => i.Length).Select(i => i.Length).First();
		}

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var nums = new int[] { number1, number2, number3, number4 };
            return nums.OrderBy(n => n).Select(i => i).First();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
			if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0) return false;

			bool canFormTriangle = false;

            if (sideLength1 + sideLength2 > sideLength3 && 
                sideLength2 + sideLength3 > sideLength1 && 
                sideLength1 + sideLength3 > sideLength2)
            {
				canFormTriangle = true;
			}
            return canFormTriangle;
        }

        public bool IsStringANumber(string input)
        {
            decimal result;
            return decimal.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
			if (numbers == null) return 0;
			if (numbers.Length < 1) return 0;

            var evens = numbers.Where(x => x % 2 == 0);
            if (evens.Count() == 0) return 0;

			return evens.Average();
        }

        public int Factorial(int number)
        {
            int factorial = number;
            if (factorial == 0 || factorial == 1) return 1;

            for (int i = number - 1; i > 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
