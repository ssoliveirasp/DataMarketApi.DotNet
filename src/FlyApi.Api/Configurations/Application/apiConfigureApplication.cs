namespace FlyApi.Api.Configuration
{
    public static partial class apiConfigureApplication
    {
        public  static void apiFlyConfigureApplication(this IApplicationBuilder application, IHostingEnvironment env, IApiVersionDescriptionProvider provider)
        {  
            application.addFlyConfiguration(env, provider);
            application.UseFlySwaggerUI(env, provider);
            application.addFlyException(env, provider);
            application.addFlyHttps(env, provider);
            application.addFlyMvc(env, provider);
            application.UseFlyHealthChecks(env, provider);
        }

    }
}