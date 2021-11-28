namespace Module5HT1_Networking.Services
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Module5HT1_Networking.Services.Abstraction;
    using Newtonsoft.Json;

    public class UserJobService : IUserJobService
    {
        public async Task CreateJobUser()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "leader",
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var httpMessage = new HttpRequestMessage();
                httpMessage.Content = httpContent;
                httpMessage.RequestUri = new Uri(@"https://reqres.in/api/users");
                httpMessage.Method = HttpMethod.Post;

                var result = await httpClient.SendAsync(httpMessage);

                if (result.StatusCode == HttpStatusCode.Created)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject(content);
                }
            }
        }

        public async Task PutUpdateJobUser()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "zion rezident",
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var httpMessage = new HttpRequestMessage();
                httpMessage.Content = httpContent;
                httpMessage.RequestUri = new Uri(@"https://reqres.in/api/users/2");
                httpMessage.Method = HttpMethod.Put;

                var result = await httpClient.SendAsync(httpMessage);

                if (result.StatusCode == HttpStatusCode.Created)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject(content);
                }
            }
        }

        public async Task PatchUpdateJobUser()
        {
            using (var httpClient = new HttpClient())
            {
                var payload = new
                {
                    name = "morpheus",
                    job = "zion rezident",
                };

                var httpContent = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
                var httpMessage = new HttpRequestMessage();
                httpMessage.Content = httpContent;
                httpMessage.RequestUri = new Uri(@"https://reqres.in/api/users/2");
                httpMessage.Method = HttpMethod.Patch;

                var result = await httpClient.SendAsync(httpMessage);

                if (result.StatusCode == HttpStatusCode.Created)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject(content);
                }
            }
        }

        public async Task DeleteJobUser()
        {
            using (var httpClient = new HttpClient())
            {
                var result = httpClient.DeleteAsync(@"https://reqres.in/api/users/2").Result;
            }
        }
    }
}