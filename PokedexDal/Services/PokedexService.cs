using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokedexDal.Services
{
    public class PokedexService
    {

        public T Get<T>(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            using (HttpResponseMessage message = client.GetAsync(client.BaseAddress).Result)
            {
                message.EnsureSuccessStatusCode();
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
