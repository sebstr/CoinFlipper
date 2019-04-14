using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoinFlipper.Models;

namespace CoinFlipper
{
    public class LongestStreakObfuscatedRecursiveStrategy
    {
        public int Count(IEnumerable<CoinFlipResult> flips)
        {
            return C(flips.ToList(), 0, 0, 0, null);
        }

        public int C(List<CoinFlipResult> f, int i, int c, int l, CoinFlipResult? t)
        {
            return i >= f.Count ? (c > l ? c : l) : C(f, i + 1, f[i] == t ? c + 1 : 1, c > l ? c : l, f[i]);
        }
    }
}
