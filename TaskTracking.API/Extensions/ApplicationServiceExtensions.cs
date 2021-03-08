
using TT.Core.Data;
using TT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT.Services.Task;
namespace TaskTracking.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {


            //DbContext
            services.AddDbContext<DataContext>(options =>
                     options.UseSqlServer(config.GetConnectionString("TT_DB")));
            services.AddScoped<IDbContext>(provider => provider.GetService<DataContext>());

            //repositories
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            //services
            services.AddScoped<ITaskService, TaskService>();


            return services;
        }
    }
}
