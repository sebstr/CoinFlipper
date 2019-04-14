using System.Collections.Generic;
using CoinFlipper.Models;
using CoinFlipper.Hardcore.Adapters;

namespace CoinFlipper
{
    public class CoinFlipAnalyzer
    {
        public int CountLongestStreak(IEnumerable<CoinFlipResult> flips)
        {
            return HardcoreAdapter.CountLongestStreak(flips);
        }
    }
}
