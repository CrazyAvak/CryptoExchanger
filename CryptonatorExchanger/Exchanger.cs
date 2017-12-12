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
            //gives back an avarage value of a coin in dollars;
            string convertCoin = "";
            
            coin aCoin = findCoin(coin);
            cryptonator crypt = api.request(aCoin.CoinShort, "usd");
            
            decimal price = Convert.ToDecimal(crypt.ticker.price.Replace(".", ",")) * aCoin.CointAmount;
            crypt.ticker.price = price.ToString();
            return crypt.ticker.price;           
        }
        private coin findCoin(string coin)
        {
            //searches a coin object in the coinList 
            foreach (coin item in coins)
            {
                if (item.CoinName == coin)
                {
                    return item;
                }                
            }
            return null;
        }
        public string sell(string coin1)
        {
            coin coins1 = findCoin(coin1);
            coin coins2 = findCoin("US Dollar");

            cryptonator crypt = api.request(coins1.CoinShort, coins2.CoinShort);
         
                bool first = true;
                decimal sellPrice = 0;
                string market  = "";
                foreach (Market item in crypt.ticker.markets)
                {
                    decimal price = Convert.ToDecimal(item.price.Replace(".", ","));
                    if (first)
                    {
                        sellPrice = price;
                        market = item.market;
                        first = false;
                    }
                    if(price > sellPrice)
                    {
                        sellPrice = price;
                        market = item.market;
                        
                    }                               
                }
            coins2.CointAmount = coins2.CointAmount + coins1.CointAmount * sellPrice;
            coins1.CointAmount = 0;
            return "sold at a price of: " + sellPrice.ToString() + "at the market: " + market;
        }

        public string buy(string coin1)
        {
            coin coins1 = findCoin(coin1);
            coin coins2 = findCoin("US Dollar");

            cryptonator crypt = api.request(coins1.CoinShort, coins2.CoinShort);
            bool first = true;
            decimal buyPrice = 0;
            string market = "";
            foreach (Market item in crypt.ticker.markets)
            {
                decimal price = Convert.ToDecimal(item.price.Replace(".", ","));
                if (first)
                {
                    buyPrice = price;
                    market = item.market;
                    first = false;
                }
                if(price < buyPrice)
                {
                    buyPrice = price;
                    market = item.market;
                }
            }
            coins1.CointAmount = coins1.CointAmount + coins2.CointAmount / buyPrice;
            coins2.CointAmount = 0;
            return "Bought at a price of:" + buyPrice.ToString() + "at the market:" + market;
        }
    }
}
