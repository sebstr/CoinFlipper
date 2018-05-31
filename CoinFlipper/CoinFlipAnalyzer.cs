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
            int count = 0;
            var last = CoinFlipResult.Tail;
            int longest = 0;

            foreach (var flip in flips)
            {
                if (last == flip)
                {
                    ++count;
                    longest = Math.Max(longest, count);
                }
                else
                {
                    count = 1;
                    last = flip;
                }
            }

            longest = Math.Max(longest, count);

            return longest;
        }
    }
}
