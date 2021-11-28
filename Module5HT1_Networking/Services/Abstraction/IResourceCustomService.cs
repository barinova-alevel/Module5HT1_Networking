namespace Module5HT1_Networking.Services.Abstraction
{
    using System.Threading.Tasks;

    public interface IResourceCustomService
    {
        public Task GetListResource();

        public Task GetSingleResource();

        public Task NotFoundSingleResource();
    }
}
