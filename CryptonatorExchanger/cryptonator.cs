using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptonatorExchanger
{
   
        public class Market
        {
            public string market { get; set; }
            public string price { get; set; }
            public string volume { get; set; }
        }

        public class Ticker
        {
            public string @base { get; set; }
            public string target { get; set; }
            public string price { get; set; }
            public string volume { get; set; }
            public string change { get; set; }
            public List<Market> markets { get; set; }
        }

        public class cryptonator
        {
            public Ticker ticker { get; set; }
            public int timestamp { get; set; }
            public bool success { get; set; }
            public string error { get; set; }
        }
    
}
