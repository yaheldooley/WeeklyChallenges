using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

			int fraction = startNumber / n;
			return n * fraction + n;
		}

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue <= 0) businesses[i].Name = "CLOSED";
            };
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            if (numbers.Length == 1) return true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i > 0 && numbers[i] < numbers[i - 1]) return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers == null || numbers.Length == 0) return sum;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0) sum += numbers[i];        
			}
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";
            string newString = "";
            for (int i = 0; i < words.Length; i++)
            {
                string trimmed = words[i].Trim();
                if (trimmed == "") continue;
                newString += trimmed;
                if (i == words.Length - 1) newString += ".";
                else newString += " ";
            }
            return newString;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> allElements = new List<double>();
            if (elements == null || elements.Count == 0) return allElements.ToArray();

            int totalCandidates = elements.Count / 4;
            for (int i = 0; i < totalCandidates; i++)
            {
                int next = (i + 1) * 4 - 1;
                allElements.Add(elements[next]);
            }
            return allElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0) return false;
            if (nums.Length == 1)
            {
                return false;

			}
            
            for (int i = 0; i < nums.Length; i++)
            {
                int num1 = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    int num2 = nums[j];
                    if (i == j) continue;
                    if (num1 + num2 == targetNumber) return true;

                }
            }
            return false;

        }
    }
}
