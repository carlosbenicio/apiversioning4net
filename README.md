# Api Versioning 4net

ApiVersioning4Net is a Swashbuckle extenstions that provides a simple way to versioning and documenting APIs.
  
  #### How to implement
  
  - Add this section to your main application.json configuration file.
  ```
   "SwaggerSettings": {
    "RoutePrefix": "",
    "Info": {
      "Title": "Template API",
      "Description": "Swagger with API version, <a href='/swagger.yaml'>download swagger.yaml</a>",
      "Contact": {
        "Name": "any name",
        "Email": "eyouremail"
      },
      "License": {
        "Name": "Name",
        "Url": "<any-url>"
      }
    }
  }
  ```
- Change this value on launchSettings.json
```
"launchUrl": "http://localhost:<port>/index.html",
```
  - Configures
  ```
  // (...)
    

 _service.Configure<SwaggerSettings>(configuration.GetSection(nameof(SwaggerSettings)));
 _service
        .AddApiVersioning()
        .AddSwagger(configuration)
        .AddApiVersionWithExplorer();
        
         //if you to show documentation
         var xmlPath = Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");
          _service.AddSwaggerGen(p =>
            {
                p.IncludeXmlComments(xmlPath);
            });
        // (...)
  ```
  ```
  // (...)
   app
        .UseSwaggerDocuments();
 // (...)
  ```
  
  - Note: don't forget to generate xml file on build section in project property. e.g.
  ```
  
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DocumentationFile>bin\$(Configuration)\netcoreapp3.1\your.api.xml</DocumentationFile>
  </PropertyGroup>
  ```
  
  - Basic usage
  ```
  [Route("api/v{version:apiVersion}/[controller]")]
  public class AnysController
  {
        [ApiVersion("1.0")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           
        }
  }
  ```

### Dependencies
 .NET Core, version >= 3.0.0

