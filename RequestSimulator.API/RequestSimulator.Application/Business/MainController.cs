using Microsoft.Extensions.Configuration;
using RequestSimulator.Application.Business.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application.Business
{
    public class MainController : IMainController
    {
        KafkaSender KafkaSender = new KafkaSender(); 
        public MainController()
        {
            StartAsync(new CancellationToken());

            KafkaSender.SendToKafka();
        }


        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Kafka StartAsync is called....");

            return Task.CompletedTask;
        }
        public void RequestGenerator()
        {
            Console.WriteLine("Amir");
        }
    }
}
