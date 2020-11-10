using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Model
{
    public class PlayerById
    {

        [JsonProperty(PropertyName = "data")]
        public IList<Data2> Data { get; set; }
    }

    public class Data2
    {
        [JsonProperty(PropertyName = "pid")]
        public int PId { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
   

}


 /*{
    "data": [
     {
            "pid": 28081,
            "fullName": "Mahendra Singh Dhoni",
            "name": "MS Dhoni"
     }
    ],
    "ttl": 183,
    "cache3": true,
    "v": "1",
    "provider": {
    "source": "Various",
    "url": "https://cricapi.com/",
    "pubDate": "2020-11-09T18:51:07.179Z"
     },
     "creditsLeft": 250
   }*/

