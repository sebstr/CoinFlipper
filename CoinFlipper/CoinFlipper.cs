using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipper
{
    public class CoinFlipper
    {
        public CoinFlipResult Flip() {
            return (CoinFlipResult)(new Random().Next() % 2);
        }
    }
}
