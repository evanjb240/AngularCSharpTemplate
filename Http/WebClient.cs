using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using WebAPIClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace WebAPIClient
{
    public class WebClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<Repository>> ProcessRepositories()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Repository>));
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            
    
            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories = serializer.ReadObject(await streamTask) as List<Repository>;
            

            return repositories;
        }

        public static async Task<Binance> TestGetParams()
        {
            var serializer = new DataContractJsonSerializer(typeof(Binance));

            Binance model = null;
            var client = new HttpClient();

            var task = await client.GetAsync("https://api.coinmarketcap.com/v2/ticker/1/");
            var jsonString = await task.Content.ReadAsStringAsync();
            model = JsonConvert.DeserializeObject<Binance>(jsonString);
            return model;
        }
    }
}
