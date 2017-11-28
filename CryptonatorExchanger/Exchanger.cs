using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptonatorExchanger
{
    class Exchanger
    {
        List<coin> coins;
        sqlLiteDB db;

        internal List<coin> Coins { get => coins; set => coins = value; }
        //main logic class
        public Exchanger()
        {
            db = new sqlLiteDB();
            Coins = db.getCoin();
        }

        public double getAmount(string coinName)
        {
            foreach (coin item in Coins)
            {
                if(item.CoinName == coinName)
                {
                    return Convert.ToDouble(item.CointAmount);
                }
            }
            return 0;
        }        
    }
}
