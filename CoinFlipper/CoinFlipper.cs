using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipper
{
    public class CoinFlipper
    {
		protected Random random;

		public CoinFlipper() {
			this.random = new Random(DateTime.Now.Millisecond);
		}

        public CoinFlipResult Flip() {
			return (CoinFlipResult)(this.random.Next () % 2);
        }
    }
}
