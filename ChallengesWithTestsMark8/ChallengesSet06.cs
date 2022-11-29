using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            try
            {
				if (ignoreCase)
				{
					string lowerCase = word.ToLower();

					foreach (string w in words)
					{
						if (w.ToLower() == lowerCase) return true;
					}

				}
				else
				{
					foreach (string w in words)
					{
						if (w == word) return true;
					}
				}
			}
            catch
            {
				return false;
			}

			return false;
		}

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;

            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }

                if (uIndex == true)
                {
                    index = i;
                }
            }
            return index;
		}

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 1;
            int currentCount = 1;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
				if (numbers[i] == numbers[i + 1])
				{
					currentCount++;
					if (currentCount > maxCount) maxCount = currentCount;

				}
				else currentCount = 1;
			}
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> allDoubles = new List<double>();
            if (elements == null || n == 0) return allDoubles.ToArray();

            int places = elements.Count / n;
            for (int i = 1; i < places + 1; i++)
            {
                int pos = i * n;
                allDoubles.Add(pos);
            }

            return allDoubles.ToArray();
        }
    }
}
