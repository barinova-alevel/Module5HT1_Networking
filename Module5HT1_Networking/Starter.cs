namespace Module5HT1_Networking
{
    using Microsoft.Extensions.DependencyInjection;
    using Module5HT1_Networking.Services;
    using Module5HT1_Networking.Services.Abstraction;

    public class Starter
    {
        private Application _application;

        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
                    .AddTransient<IRegisterService, RegisterService>()
                    .AddTransient<IResourceCustomService, ResourceCustomService>()
                    .AddTransient<IUserJobService, UserJobService>()
                    .AddTransient<IUserService, UserService>()
                    .AddTransient<Application>()
                    .BuildServiceProvider();

            _application = serviceProvider.GetService<Application>();
            _application.Run();
        }
    }
}
