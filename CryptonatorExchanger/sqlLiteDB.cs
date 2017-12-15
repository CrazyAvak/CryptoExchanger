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
                coin.CoindID = reader["coindID"].ToString();
                if (reader["coinActive"].ToString() == "1")
                {
                    coin.CoinActive = true;
                }
                else
                {
                    coin.CoinActive = false;
                }
                Console.WriteLine(reader["coinName"]  + " " + reader["coinAmount"]);
                coin.CointAmount = Convert.ToDecimal(reader["coinAmount"]);
                coins.Add(coin);
            }
            dbConnection.Close();
            return coins;
        }                

        public void updateAmount(coin coin)
        {
            dbConnection.Open();
            //UPDATE COMPANY SET ADDRESS = 'Texas' WHERE ID = 6;
            string sql = "UPDATE coin SET coinAmount = '" + coin.CointAmount + "' WHERE coindID = " + coin.CoindID ;
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            dbConnection.Close();
        }

        public void updateDB(string sql)
        {
            dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            dbConnection.Close();
        }
    }
}
