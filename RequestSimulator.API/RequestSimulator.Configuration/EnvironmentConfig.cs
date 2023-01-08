using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using static RequestSimulator.Configuration.EnvironmentConfig;

namespace RequestSimulator.Configuration
{
    public interface IEnvironmentConfig
    {
        UserRequestConfig GetRequestInfo();
    }
    public class EnvironmentConfig : IEnvironmentConfig
    {
        private IConfigurationRoot configuration { get; set; }
        UserRequestConfig? userRequestConfig;

        public EnvironmentConfig()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            configuration = configurationBuilder.Build();
            userRequestConfig = configuration.GetSection("UserRequestConfig").Get<UserRequestConfig>();

            //  influxconfig = configuration.GetSection("InfluxConfig").Get<UserRequestConfig>();

        }

        public class UserRequestConfig
        {
            public int EdgeServerId { get; set; }
            public string EdgeServerName { get; set; }
            public int DTId { get; set; }
            public int ApplicationId { get; set; }


        }
        public UserRequestConfig GetRequestInfo()
        {
            return userRequestConfig;
        }


    }
}
