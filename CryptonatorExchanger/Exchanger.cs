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
            
            coin aCoin = findCoin(coin);
            cryptonator crypt = api.request(aCoin.CoinShort, "usd");
            
            decimal price = Convert.ToDecimal(crypt.ticker.price.Replace(".", ",")) * aCoin.CointAmount;
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
        private void exchangeHandler()
        {

        }

        public string buyCoin(string coin1,string coin2)
        {

            cryptonator crypt = api.request(findCoin(coin1).CoinShort, findCoin(coin2).CoinShort);

            bool firstitem = true;
            decimal marketPrice = 0;
            if(crypt.ticker.markets.Count == 0)
            {
                return "No markets accepts this transaction";
            }
            foreach (Market item in crypt.ticker.markets)
            {
                
                if(firstitem)
                {
                    marketPrice = Convert.ToDecimal(item.price.Replace(".", ","));
                    firstitem = false;
                }
                if(Convert.ToDecimal( item.price.Replace(".", ",")) < marketPrice)
                {
                    marketPrice = Convert.ToDecimal(item.price.Replace(".", ","));
                    Console.WriteLine(marketPrice.ToString());
                }
            }
            return "transaction complete " + marketPrice.ToString();

        }
        private void sellCount()
        {

        }
    }
}
