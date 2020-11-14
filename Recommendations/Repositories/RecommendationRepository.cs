using Recommendations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Storage;

namespace Recommendations.Repositories
{
    public class RecommendationRepository : IRecommendationRepository
    {
        private readonly string url;

        private readonly string Baseurl;

        public RecommendationRepository() { }

        public RecommendationRepository(IConfiguration configuration) : base()
        {
            url = configuration.GetSection("URL_Settings:url").Value;

            Baseurl = configuration.GetSection("URL_Settings:Baseurl").Value;
        }

        public async Task<List<Data>> GetRecommendations()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{Baseurl}");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            List<Data> requiredData = new List<Data>();
            requiredData.Clear();
            
            HttpResponseMessage response =client.GetAsync($"{url}").Result;
            response.EnsureSuccessStatusCode();

            string stringResponse = await response.Content.ReadAsStringAsync();

            var player2 = JsonConvert.DeserializeObject<List<Data>>(stringResponse);

            /*foreach (var item in player2.Datas)
            {
                requiredData.Add(new Data
                {
                    FavouriteId = item.FavouriteId,
                    Count=item.Count,
                    PId = item.PId,
                    Name = item.Name,
                    UserId=item.UserId,
                    FullName = item.FullName
                }) ;
            }*/
            return player2;



        }


    }
}
