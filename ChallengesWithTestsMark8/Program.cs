using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            ChallengesSet02 set = new ChallengesSet02();
            Console.WriteLine(set.CountOfElementsIsEven(new string[2]));
        }
    }
}
