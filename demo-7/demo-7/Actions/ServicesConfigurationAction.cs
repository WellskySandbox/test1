using Atlas.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace demo_7.Actions
{
    /// <summary>
    /// Action for configuring dependency injection
    /// </summary>
    /// <remarks>
    /// For IConfigureServicesAction:
    /// * ConfigureServices() performs DI registrations
    /// </remarks>
    internal class ServicesConfigurationAction : IConfigureServicesAction
    {
        //private readonly SomeOptions _someOptions;

        /// <inheritdoc />
        public ServicesConfigurationAction
        (
        //IOptions<SomeOptions> someOptions
        )
        {
            // configuration settings from ConfigurationKey attributes
            //_someOptions = someOptions.Value;
        }

        /// <inheritdoc />
        /// <summary>
        /// Perform all DI registrations.
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //services.AddSingleton<ISomething, Something>();
        }
    }
}
