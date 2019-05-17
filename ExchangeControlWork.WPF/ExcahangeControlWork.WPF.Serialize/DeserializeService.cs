using ExchangeControlWork.WPF.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExcahangeControlWork.WPF.Serialize
{
    public class DeserializeService
    {
        public Money[] GetJson()
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string json = client.DownloadString("http://data.egov.kz/api/v2/valutalar_bagamdary4/v565?pretty");
            var result = JsonConvert.DeserializeObject<Money[]>(json);

            return result;
        }
    }
}
