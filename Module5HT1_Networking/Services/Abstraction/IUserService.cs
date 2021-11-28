namespace Module5HT1_Networking.Services.Abstraction
{
    using System.Threading.Tasks;

    public interface IUserService
    {
        public Task GetUsers();

        public Task GetSingleUser();

        public Task NotFoundSingleUser();
    }
}
