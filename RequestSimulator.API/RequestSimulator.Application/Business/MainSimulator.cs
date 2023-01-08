using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using RequestSimulator.Application.Business.Generator;
using RequestSimulator.Application.Business.Utils.Kafka;
using RequestSimulator.Application.Business.Utils.Kafka;
using RequestSimulator.Application.Dtos;
using RequestSimulator.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application.Business
{
    public class MainSimulator : IMainSimulator , IHostedService
    {
        //public List<UserRequestDto> userRequestDtos = new List<UserRequestDto>();
        //KafkaSender KafkaSender = new KafkaSender(); 
        IRequestGenerator _requestGenerator;
        IKafkaSender _kafkaSender;
        IEnvironmentConfig _configuration;
        public MainSimulator(IKafkaSender kafkaSender , IRequestGenerator requestGenerator, IEnvironmentConfig configuration)
        {
            //StartAsync(new CancellationToken());
            _requestGenerator = requestGenerator;
            _kafkaSender = kafkaSender; 
            _configuration = configuration;

        }


        public Task StartAsync(CancellationToken cancellationToken)
        {

            bool isruning = false;
            Task.Run(() =>
            {   
                isruning = true;
                while (isruning)
                {
                    var generatedRequest = _requestGenerator.GenerateApplicationRequest(
                        _configuration.GetRequestInfo().ApplicationId,
                        _configuration.GetRequestInfo().EdgeServerId,
                        _configuration.GetRequestInfo().DTId,
                        _configuration.GetRequestInfo().EdgeServerName
                        );
                    if (generatedRequest != null)
                        _kafkaSender.SendToKafka(generatedRequest);
                }
            });
            Console.WriteLine("Kafka StartAsync is called....");

            return Task.CompletedTask;
        }


        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
