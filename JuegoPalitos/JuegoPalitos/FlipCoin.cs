using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPalitos
{
    internal class FlipCoin
    {


        Random coin = new Random();

        public int Coin;

        public void setCoin() { Coin = coin.Next(1, 3); }

        public int flipCoin() { return Coin; }


    }
}
