using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RequestSimulator.Application.Business;
using RequestSimulator.Application.Business.Kafka;
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
            services.AddSingleton<IMainController, MainController>();
            return services
            .AddSingleton<IKafkaSender, KafkaSender>()
            .AddSingleton<IMainController, MainController>();

        }
    }
}
