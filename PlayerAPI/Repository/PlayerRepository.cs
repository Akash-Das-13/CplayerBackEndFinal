
using PlayerAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace PlayerAPI.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly string keyV;
        
        private readonly string Baseurl;

        public PlayerRepository(IConfiguration configuration) : base()
        {
            keyV = configuration.GetSection("URL_Settings:keyV").Value;
            
            Baseurl = configuration.GetSection("URL_Settings:Baseurl").Value;
        }
        

        public async Task<Player> GetPlayerByIdAsync(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{Baseurl}");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        
            HttpResponseMessage response = client.GetAsync($"api/playerStats?apikey={keyV}&pid={id}").Result;
            response.EnsureSuccessStatusCode();

            var stringResponse =await  response.Content.ReadAsStringAsync();
            /*var player2 = JsonConvert.DeserializeObject<List<Player>>(stringResponse);*/

            var player2 = JsonConvert.DeserializeObject<Player>(stringResponse);

            return player2;
        }

        public async Task<List<Data2>> GetPlayerByNameAsync(string name)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{Baseurl}");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            List<Data2> requiredData = new List<Data2>();
            requiredData.Clear();

            HttpResponseMessage response = client.GetAsync($"api/playerFinder?apikey={keyV}&name={name}").Result;
            response.EnsureSuccessStatusCode();

            var stringResponse = await response.Content.ReadAsStringAsync();

            var player2 = JsonConvert.DeserializeObject<PlayerById>(stringResponse);

            foreach (var item in player2.Data)
            {
                requiredData.Add(new Data2
                {
                    PId=item.PId,
                    Name=item.Name,
                    FullName=item.FullName
                });
            }
            return requiredData;
        }
    }
}
