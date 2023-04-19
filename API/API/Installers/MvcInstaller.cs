using FluentValidation.AspNetCore;
using MediatR;
using System.Reflection;

namespace API.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers()
            //.AddNewtonsoftJson()
             .AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(typeof(Startup).Assembly));

             services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

             services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
