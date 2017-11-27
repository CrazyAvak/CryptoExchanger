using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CryptonatorExchanger
{
    class jsonDecoder
    {
        //Decodes the json
        public void decodeJson(string json)
        {            
            cryptonator crypt = new cryptonator();
            crypt = JsonConvert.DeserializeObject<cryptonator>(json);
        }
    }
}
