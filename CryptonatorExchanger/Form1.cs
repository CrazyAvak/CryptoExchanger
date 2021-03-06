﻿using System;
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
        bool bought = false;
        public Form1()
        {
            InitializeComponent();
            exchanger = new Exchanger();                        
            
            time = new Timer();
            time.Interval = 30000;
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
            if (bought)
            {                
                feedUpdate(exchanger.sell(comboBoxCur1.SelectedItem.ToString()));
                bought = false;
            }
            else
            {
                feedUpdate(exchanger.buy(comboBoxCur1.SelectedItem.ToString()));
                bought = true;
            }
            labelusd.Text = "USD: " + exchanger.getAmount("US Dollar");
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
        private void feedUpdate(string feed)
        {            
            textBoxFeed.Text += System.Environment.NewLine + DateTime.Now.ToString("h:mm:ss tt") + " " + feed;
            textBoxFeed.SelectionStart = textBoxFeed.Text.Length;
            textBoxFeed.ScrollToCaret();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (time.Enabled == true)
            {
                time.Enabled = false;
                labelExchangeActive.BackColor = Color.Red;
                buttonStart.Text = "Start exchange";
                comboBoxCur1.Enabled = true;
                comboBoxCur2.Enabled = true;
            }
            else
            {
                time.Enabled = true;
                labelExchangeActive.BackColor = Color.Green;
                buttonStart.Text = "Stop exchange";
                comboBoxCur1.Enabled = false;
                comboBoxCur2.Enabled = false;
            }
            /*
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
                    comboBoxCur1.Enabled = true;
                    comboBoxCur2.Enabled = true;
                }
            else
            {
                time.Enabled = true;
                labelExchangeActive.BackColor = Color.Green;
                buttonStart.Text = "Stop exchange";
                    comboBoxCur1.Enabled = false;
                    comboBoxCur2.Enabled = false;                    
            }
            }
            */
        }

        private void buttonCleanFeed_Click(object sender, EventArgs e)
        {
            textBoxFeed.Text = "";
        }
    }
}
