using send_training_backend.Repository;
using send_training_backend.Services;
using System.Data;
using System.Data.SQLite;

namespace send_training_backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDependacnyInjection();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }

    public static class ServiceCollectionExtensions
    {
        public static void AddDependacnyInjection(this IServiceCollection services)
        {
            var currentDir = Directory.GetCurrentDirectory();
            services.AddSingleton<IDbConnection>(x => new SQLiteConnection($"Data Source={Directory.GetCurrentDirectory()}/sql_database.db"));
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}
