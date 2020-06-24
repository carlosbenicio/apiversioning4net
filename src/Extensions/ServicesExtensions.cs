namespace CBJOne.Libraries.ApiVersioning.Extensions
{
    using CBJOne.Libraries.ApiVersioning.Config;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;
    using Swashbuckle.AspNetCore.Swagger;
    using Swashbuckle.AspNetCore.SwaggerGen;
    using Swashbuckle.AspNetCore.SwaggerUI;

    public static class ServicesExtensions
    {
        /// <summary>
        /// Add AddVersionedApiExplorer and AddApiVersioning middlewares
        /// </summary>
        /// <param name="services"></param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddApiVersionWithExplorer(this IServiceCollection services)
        {
            return services
                .AddVersionedApiExplorer(options =>
                {
                    options.GroupNameFormat = "'v'VVV";
                    options.SubstituteApiVersionInUrl = true;
                })
                .AddApiVersioning(options =>
                {
                    options.AssumeDefaultVersionWhenUnspecified = true;
                    options.ReportApiVersions = true;
                    options.DefaultApiVersion = new ApiVersion(1, 0);
                });
        }

        /// <summary>
        /// Add swagger services
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/>/></param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddSwaggerOptions(this IServiceCollection services)
        {
            return services
                .AddTransient<IConfigureOptions<SwaggerOptions>, ConfigureSwaggerOptions>()
                .AddTransient<IConfigureOptions<SwaggerUIOptions>, ConfigureSwaggerUIOptions>()
                .AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerGenOptions>();
        }
    }
}
