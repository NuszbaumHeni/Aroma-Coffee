using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WindowsFormsLifetime;

namespace Aroma_Coffee
{
    internal static class Program
    {
        static void Main()
        {
            var app = createHost().Build();

            using (var serviceScope = app.Services.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<Persistence>();
                context.Database.EnsureCreated();
            }

            app.Run();
        }

        public static IHostBuilder createHost()
        {
            return Host.CreateDefaultBuilder(Array.Empty<string>()).UseWindowsFormsLifetime<Form2>().ConfigureServices((hostContext, services) =>
            {
                services.AddDbContext<Persistence>(options =>
                {
                    options.UseSqlite("Data Source=asd.db;Cache=Shared");
                });
                services.AddSingleton<Model>();
            });
        }
    }
}