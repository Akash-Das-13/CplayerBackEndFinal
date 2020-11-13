using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recommendations.Models
{

    public class Recommendation
    {
        public IList<Data> Datas { get; set; }

    }


    public class Data
    {
        [JsonProperty(PropertyName = "favouriteId")]
        public int FavouriteId { get; set; }

        [JsonProperty(PropertyName = "pid")]
        public int PId { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

    }

   
}
