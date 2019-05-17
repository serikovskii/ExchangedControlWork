using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeControlWork.WPF.DTO
{
    public class Money
    {
        [JsonProperty("edinica_izmerenia")]
        public string NameRate { get; set; }

        [JsonProperty("sootnowenie")]
        public string Ratio { get; set; }

        [JsonProperty("name_rus")]
        public string NameExechengedRate { get; set; }

        [JsonProperty("kurs")]
        public string Kurs { get; set; }

        [JsonProperty("kod")]
        public string Kod { get; set; }
    }
}
