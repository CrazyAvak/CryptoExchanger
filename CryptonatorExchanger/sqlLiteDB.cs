using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptonatorExchanger
{   
    class sqlLiteDB
    {
        SQLiteConnection dbConnection;
         public sqlLiteDB()
        {
            dbConnection = new SQLiteConnection("Data Source=cryptoDB.db;Version=3;");            
        }
        public List<coin> getCoin()
        {
            List<coin> coins = new List<coin>();
            dbConnection.Open();
            string sql = "select * from coin";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                coin coin = new coin();
                coin.CoinName = reader["coinName"].ToString();
                coin.CoinShort = reader["coinShort"].ToString();
                if (reader["coinActive"].ToString() == "1")
                {
                    coin.CoinActive = true;
                }
                else
                {
                    coin.CoinActive = false;
                }
                coin.CointAmount = Convert.ToInt32(reader["coinAmount"]);
                coins.Add(coin);
            }
            dbConnection.Close();
            return coins;
        }
    }
}
