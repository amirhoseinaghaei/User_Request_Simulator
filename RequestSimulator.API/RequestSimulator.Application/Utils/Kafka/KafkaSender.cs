

using RequestSimulator.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application.Business.Utils.Kafka
{
    public class KafkaSender : IKafkaSender
    {
        public KafkaSender()
        {

        }
        public void SendToKafka(UserRequestDto? userRequestDto)
        {
            System.Diagnostics.Debug.WriteLine("Amir");
        }
    }
}
