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
            
            time = new Timer();
            time.Interval = 1000;
            time.Tick += Time_Tick;
            
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
            apiRequest request = new apiRequest();
            request.request("btc", "usd");
        }

        private void comboBoxCur2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAmount2.Text = "Coin Amount: " + exchanger.getAmount(comboBoxCur2.SelectedItem.ToString()) ;
            labelValue2.Text = "Coin in usd: " + exchanger.getAverageEuroWorth(comboBoxCur2.SelectedItem.ToString());
        }

        private void comboBoxCur1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAmount1.Text = "Coin Amount: " + exchanger.getAmount(comboBoxCur1.SelectedItem.ToString());
            labelValue1.Text = "Coin in usd: " + exchanger.getAverageEuroWorth(comboBoxCur1.SelectedItem.ToString());
        }
        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(comboBoxCur1.SelectedItem.ToString() == comboBoxCur2.SelectedItem.ToString())
            {
                MessageBox.Show("Can't trade with the same coins");
            }
            else
            {


            if (time.Enabled == true)
            {
                time.Enabled = false;
                labelExchangeActive.BackColor = Color.Red;
                buttonStart.Text = "Start exchange";
            }
            else
            {
                time.Enabled = true;
                labelExchangeActive.BackColor = Color.Green;
                buttonStart.Text = "Stop exchange";
            }
            }
        }
    }
}
