using Module5HT1_Networking.Services.Abstraction;
using System.Net.Http;
using System.Threading.Tasks;

namespace Module5HT1_Networking.Services
{
    public class ResourceCustomService : IResourceCustomService
    {
        public async Task GetListResource()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown");
            }
        }

        public async Task GetSingleResource()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/2");
            }
        }

        public async Task NotFoundSingleResource()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/unknown/23");
            }
        }
    }
}
