using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RequestSimulator.Application.Business;
using RequestSimulator.Application.Business.Generator;
using RequestSimulator.Application.Business.Utils.Kafka;
using RequestSimulator.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application
{
    public static class ApplicationServiceRegisteration
    {
        public static IServiceCollection ConfigureApplicationServicces(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddSingleton<IMainSimulator, MainSimulator>();
            services.AddHostedService<MainSimulator>();
            return services
            .AddSingleton<IEnvironmentConfig, EnvironmentConfig>()
            .AddSingleton<IMainSimulator, MainSimulator>()
            .AddSingleton<IKafkaSender, KafkaSender>()
            .AddSingleton<IRequestGenerator, RequestGenerator>();        

        }
    }
}
