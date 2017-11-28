using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptonatorExchanger
{
    public partial class Form1 : Form
    {
        Timer time;
        Exchanger exchanger;
        public Form1()
        {
            InitializeComponent();
            exchanger = new Exchanger();
            apiRequest request = new apiRequest();
            exchanger = new Exchanger();
            request.request("btc", "usd");
            time = new Timer();
            time.Interval = 30000;
            time.Tick += Time_Tick;
            time.Enabled = true;
            sqlLiteDB db = new sqlLiteDB();            
            fillGUI();
           
        }

        private void fillGUI()
        {
            foreach (coin coin in exchanger.Coins)
            {
                if(coin.CoinActive == true)
                {
                    comboBoxCur1.Items.Add(coin.CoinName);
                    comboBoxCur2.Items.Add(coin.CoinName);
                }
            }
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            //every 30 seconds call the exchanger methods for an exchange            
        }
       
    }
}
