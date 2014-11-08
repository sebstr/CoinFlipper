using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(new CoinFlipper.CoinFlipper().Flip());
            Console.ReadKey();
        }
    }
}
