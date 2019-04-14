using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlipper.Models;

namespace CoinFlipper
{
    public class CoinFlipper
    {
		protected Random Random;

		public CoinFlipper() {
			this.Random = new Random(DateTime.Now.Millisecond);
		}

        public CoinFlipResult Flip() {
			return (CoinFlipResult)(this.Random.Next(2));
        }

        public IEnumerable<CoinFlipResult> FlipLikeCrazy(int numberOfFlips)
        {            
            for (int i = 0; i < numberOfFlips; i++)
            {
                yield return Flip();
            }
        }        
    }
}
