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
        //main logic class
        public Exchanger()
        {
            db = new sqlLiteDB();
            Coins = db.getCoin();
        }

        internal List<coin> Coins { get => coins; set => coins = value; }
    }
}
