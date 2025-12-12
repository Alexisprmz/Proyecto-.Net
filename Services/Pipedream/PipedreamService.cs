using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using Distribuidos.Api.Models.Pipedream;
using Newtonsoft.Json;

namespace Distribuidos.Api.Services.Pipedream
{
    public class PipedreamService : IPipedreamService
    {
        public async Task<bool> SendWelcome(WelcomeModel body)
        {
            string Endpoint = "https://eocvm36zjmpxbwx.m.pipedream.net";
            var client = new HttpClient();
            var byteData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { name = body.name, email = body.email }));
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(Endpoint, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }



        public async Task<bool> SendCode(WelcomeModel body)
        {
            string Endpoint = "https://eo4cyzg6yrtiuw2.m.pipedream.net";
            var client = new HttpClient();
            var byteData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { name = body.name, email = body.email }));
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(Endpoint, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }


        public async Task<bool> CheckCode(CheckModel body)
        {
            string Endpoint = "https://eo5k96hxnbdj9b4.m.pipedream.net";
            var client = new HttpClient();
            var byteData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { key = body.key, value = body.Value }));
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(Endpoint, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }

        
    }
}