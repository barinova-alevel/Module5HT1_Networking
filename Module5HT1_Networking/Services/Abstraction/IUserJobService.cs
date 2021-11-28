namespace Module5HT1_Networking.Services.Abstraction
{
    using System.Threading.Tasks;

    public interface IUserJobService
    {
        public Task CreateJobUser();

        public Task PutUpdateJobUser();

        public Task PatchUpdateJobUser();

        public Task DeleteJobUser();
    }
}