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
        apiRequest api;

        internal List<coin> Coins { get => coins; set => coins = value; }
        //main logic class
        public Exchanger()
        {
            db = new sqlLiteDB();
            api = new apiRequest();
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

        public string getAverageEuroWorth(string coin)
        {
            //gives back an avarage value of a coin in euros;
            string convertCoin = "";
            decimal amount = 0;           
            cryptonator crypt = api.request(findCoin(coin).CoinShort, "usd");
            
            decimal price = Convert.ToDecimal(crypt.ticker.price.Replace(".", ",")) * amount;
            crypt.ticker.price = price.ToString();
            return crypt.ticker.price;           
        }
        private coin findCoin(string coin)
        {
            foreach (coin item in coins)
            {
                if (item.CoinName == coin)
                {
                    return item;
                }                
            }
            return null;
        }
        private void buyCoin(string coin)
        {

        }
        private void sellCount()
        {

        }
    }
}
