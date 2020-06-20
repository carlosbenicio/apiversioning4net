namespace CBJOne.Libraries.ApiVersioning
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

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
