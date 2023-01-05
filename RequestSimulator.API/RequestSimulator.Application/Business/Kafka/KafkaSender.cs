

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application.Business.Kafka
{
    public class KafkaSender : IKafkaSender
    {
        public KafkaSender()
        {

        }
        public void SendToKafka()
        {
            Console.WriteLine("Sended");
        }
    }
}
