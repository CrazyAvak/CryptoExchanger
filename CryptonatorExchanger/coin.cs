using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptonatorExchanger
{
    class coin
    {
        //a coin class where the different coins are saved
        private string coinName;
        private string coinShort;
        private bool coinActive;
        private decimal cointAmount;
        private string soldPrice;
        private string boughtPrice;

        public string CoinName { get => coinName; set => coinName = value; }
        public string CoinShort { get => coinShort; set => coinShort = value; }
        public bool CoinActive { get => coinActive; set => coinActive = value; }
        public decimal CointAmount { get => cointAmount; set => cointAmount = value; }
        public string SoldPrice { get => soldPrice; set => soldPrice = value; }
        public string BoughtPrice { get => boughtPrice; set => boughtPrice = value; }
    }
}
