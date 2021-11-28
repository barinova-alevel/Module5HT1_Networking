namespace Module5HT1_Networking.Services
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Module5HT1_Networking.Services.Abstraction;

    public class UserService : IUserService
    {
        public async Task GetUsers()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users?page=2");
            }
        }

        public async Task GetSingleUser()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/2");
            }
        }

        public async Task NotFoundSingleUser()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(@"https://reqres.in/api/users/23");
            }
        }
    }
}
