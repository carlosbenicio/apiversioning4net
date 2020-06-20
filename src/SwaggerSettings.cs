namespace CBJOne.Libraries.ApiVersioning
{
    using Microsoft.OpenApi.Models;

    public class SwaggerSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerSettings"/> class.
        /// </summary>
        public SwaggerSettings()
        {
            Name = "REST API Example";
            Info = new OpenApiInfo
            {
                Title = "REST API Example",
                Description = "REST API Versions",
                //TermsOfService = "Please contact your service provider"
            };
        }

        /// <summary>
        /// Gets or sets document Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets swagger Info.
        /// </summary>
        public OpenApiInfo Info { get; set; }

        /// <summary>
        /// Gets or sets RoutePrefix.
        /// </summary>
        public string RoutePrefix { get; set; }

        /// <summary>
        /// Field to enabled or disabled the Authorization protocol
        /// </summary>
        public bool OAuthEnabled { get; set; }

        /// <summary>
        /// Gets Route Prefix with tailing slash.
        /// </summary>
        public string RoutePrefixWithSlash => string.IsNullOrWhiteSpace(RoutePrefix)
                ? string.Empty
                : RoutePrefix + "/";
       
    }
}
