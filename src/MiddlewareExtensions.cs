namespace CBJOne.Libraries.ApiVersioning
{
    using System;
    using Microsoft.AspNetCore.Builder;

    public static class MiddlewareExtensions
    {
        /// <summary>
        /// Enabling Swagger UI.
        /// Excluding from test environment
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        public static IApplicationBuilder UseSwaggerDocuments(this IApplicationBuilder app)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "TEST")
            {
                return null;
            }

            return app
                .UseSwagger()
                .UseSwaggerUI();
        }
    }
}
