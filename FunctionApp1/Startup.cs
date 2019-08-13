using FunctionApp1;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(Startup))]
namespace FunctionApp1
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped(typeof(Foo));
            builder.Services.AddTransient(c => GetBar(c));
        }

        private Bar GetBar(IServiceProvider prov)
        {
            var foo = prov.GetService<Foo>();

            return new Bar(foo);
        }
    }
}
