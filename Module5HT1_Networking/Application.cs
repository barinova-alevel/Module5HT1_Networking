namespace Module5HT1_Networking
{
    using System.Threading.Tasks;
    using Module5HT1_Networking.Services.Abstraction;

    public class Application
    {
        private readonly IUserService _userService;
        private readonly IUserJobService _userJobService;
        private readonly IResourceCustomService _resourceCustomService;
        private readonly IRegisterService _registerService;

        public Application(IUserService userService,
            IUserJobService userJobService,
            IResourceCustomService resourceCustomService,
            IRegisterService registerService)
        {
            _userService = userService;
            _userJobService = userJobService;
            _resourceCustomService = resourceCustomService;
            _registerService = registerService;
        }

        public void Run()
        {
            _userService.GetSingleUser();
            _userService.GetUsers();
            _userService.NotFoundSingleUser();
            _userJobService.CreateJobUser();
            _userJobService.PutUpdateJobUser();
            _userJobService.PatchUpdateJobUser();
            _userJobService.DeleteJobUser();
            _resourceCustomService.GetSingleResource();
            _resourceCustomService.GetSingleResource();
            _resourceCustomService.NotFoundSingleResource();
            _registerService.RegisterSuccessful();

            var result = Task.WhenAll().GetAwaiter();

            // .GetResult()
        }
    }
}
