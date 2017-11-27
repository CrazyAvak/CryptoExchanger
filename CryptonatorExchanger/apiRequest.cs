using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptonatorExchanger
{
    class apiRequest
    {
        public void request(string cur1, string cur2)
        {
            string html = string.Empty;
            string url = "https://api.cryptonator.com/api/full/" + cur1 + "-" + cur2 + "" ;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            jsonDecoder json = new jsonDecoder();
            json.decodeJson(html);
            Console.WriteLine(html);
        }
    }
}
