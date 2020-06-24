namespace CBJOne.Libraries.ApiVersioning.Configs
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using CBJOne.Libraries.ApiVersioning.Extensions;

    public static class SwaggerConfigurations
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddSwaggerOptions()
                .AddSwaggerGen();

            return services;
        }
    } 
}
