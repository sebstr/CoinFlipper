using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipper
{
    public class CoinFlipAnalyzer
    {
        public int CountLongestStreak(IEnumerable<CoinFlipResult> flips)
        {
            var currentStreakType = CoinFlipResult.Head;
            int longestStreakLength = 0;
            int currentStreakLength = 0;
            foreach (var coinFlipResult in flips)
            {
                if (coinFlipResult == currentStreakType)
                {
                    currentStreakLength++;
                }
                else
                {
                    currentStreakLength = 1;
                    currentStreakType = coinFlipResult;
                }

                if (currentStreakLength > longestStreakLength)
                {
                    longestStreakLength = currentStreakLength;
                }
            }
            return longestStreakLength;
        }
    }
}
