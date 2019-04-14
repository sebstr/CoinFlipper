using System.Collections.Generic;
using CoinFlipper;
using NUnit.Framework;

namespace Tests
{    

    public class CoinFlipAnalyzerUnitTests
    {
        [Test]
        public void Test_empty_list()
        {
            var flips = new List<CoinFlipResult>() { };
            var n = new CoinFlipAnalyzer().CountLongestStreak(flips);
            Assert.AreEqual(n, 0);
        }

        [Test]
        public void Test_single_item_list()
        {
            var flips = new List<CoinFlipResult>()
            {
                CoinFlipResult.Head
            };
            var n = new CoinFlipAnalyzer().CountLongestStreak(flips);
            Assert.AreEqual(n, 1);
        }

        [Test]
        public void Test_list_with_two_of_different_kind()
        {
            var flips = new List<CoinFlipResult>()
            {
                CoinFlipResult.Head
            };
            var n = new CoinFlipAnalyzer().CountLongestStreak(flips);
            Assert.AreEqual(n, 1);
        }

        [Test]
        public void Test_list_having_longest_streak_in_the_middle()
        {
            var flips = new List<CoinFlipResult>()
            {
                CoinFlipResult.Head,
                CoinFlipResult.Head,
                CoinFlipResult.Head,
                CoinFlipResult.Tail,
                CoinFlipResult.Tail,
                CoinFlipResult.Tail,
                CoinFlipResult.Tail,
                CoinFlipResult.Head,
                CoinFlipResult.Head,
                CoinFlipResult.Head,
                CoinFlipResult.Head,
                CoinFlipResult.Head,
                CoinFlipResult.Tail,
                CoinFlipResult.Head,
                CoinFlipResult.Head,
            };

            var n = new CoinFlipAnalyzer().CountLongestStreak(flips);
            Assert.AreEqual(n, 5);
        }
    }

}