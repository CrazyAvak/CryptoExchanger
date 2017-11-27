using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptonatorExchanger
{
    class coin
    {
        private string coinName;
        private string coinShort;
        private bool coinActive;
        private double cointAmount;

        public string CoinName { get => coinName; set => coinName = value; }
        public string CoinShort { get => coinShort; set => coinShort = value; }
        public bool CoinActive { get => coinActive; set => coinActive = value; }
        public double CointAmount { get => cointAmount; set => cointAmount = value; }
    }
}
