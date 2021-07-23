using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GC_Lab27.Models
{
    public class AwwDAL
    {
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.reddit.com/");

            return client;
        }

        public async Task<AwwObject> GetAww()
        {
            var client = GetClient();

            var request = await client.GetAsync("r/aww/.json");
            var json = await request.Content.ReadAsStringAsync();
            var response = await request.Content.ReadAsAsync<AwwObject>();

            return response;
        }
    }
}
