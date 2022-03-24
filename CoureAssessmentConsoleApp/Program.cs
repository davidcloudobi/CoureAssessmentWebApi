using System;
using System.Linq;

namespace CoureAssessmentConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Enter Array Values
           var arr = new int[]{1,2,3,4,5};
            var result = KeepTotalScoreCard(arr);
            Console.WriteLine(result);
        }

        static int KeepTotalScoreCard(int[] array)
        {
            switch (array.Any())
            {
                case false:
                    return 0;
            }
            var totalScore = 0;
            foreach (var currentValue in array)
            {
                var remainder = currentValue % 2;
                switch (currentValue)
                {
                    case 8:
                        totalScore += 5;
                        break;
                }

                totalScore += remainder == 0 ? 1 : 3;
            }

            return totalScore;
        }
    }
}
