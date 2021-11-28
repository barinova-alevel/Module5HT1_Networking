namespace Module5HT1_Networking.Services
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Module5HT1_Networking.Models;
    using Module5HT1_Networking.Services.Abstraction;
    using Newtonsoft.Json;

    public class RegisterService : IRegisterService
    {
        public async Task RegisterSuccessful()
        {
            using (var httpClient = new HttpClient())
            {
                Register register = new Register
                {
                    Email = "eve.holt@reqres.in",
                    Password = "pistol",
                };
                var httpContent = new StringContent(JsonConvert.SerializeObject(register), Encoding.UTF8, "application/json");
                var httpMessage = new HttpRequestMessage();
                httpMessage.Content = httpContent;
                httpMessage.RequestUri = new Uri(@"https://reqres.in/api/users?page=2");
                httpMessage.Method = HttpMethod.Post;

                var result = await httpClient.SendAsync(httpMessage);

                if (result.StatusCode == HttpStatusCode.Created)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject(content);
                }
            }
        }
    }
}
