
using MockGraphQL.DataLayer;

namespace MockGraphQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            SetupServices(builder.Services);

            var app = builder.Build();

            app.MapGraphQL();
            app.UseHttpsRedirection();
            app.Run();
        }

        private static void SetupServices(IServiceCollection services)
        {
            services.AddSingleton<ILearnerRepository, DummyDataAccess>();
            services.AddSingleton<IClassroomRepository, DummyDataAccess>();

            services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<LearnerType>()
                .AddType<ClassroomType>();
        }
    }
}
