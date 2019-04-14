using System;
using System.Linq;
using CoinFlipper;
using CoinFlipper.Models;

namespace CoinFlipDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var coinFlipper = new CoinFlipper.CoinFlipper();
            var coinFlipAnalyzer = new CoinFlipAnalyzer();

            Console.WriteLine(coinFlipper.Flip());

            var flips = coinFlipper.FlipLikeCrazy(5).ToList();
            Console.WriteLine("Flipped like crazy {0} times. Got {1} heads and {2} tails. " +
                              "With a longest streak of {3} flip restuls of the same kind in a row!!!",
                flips.Count(),
                flips.Count(f => f == CoinFlipResult.Head),
                flips.Count(f => f == CoinFlipResult.Tail),
                coinFlipAnalyzer.CountLongestStreak(flips)
            );

            Console.ReadKey();
        }
    }
}
