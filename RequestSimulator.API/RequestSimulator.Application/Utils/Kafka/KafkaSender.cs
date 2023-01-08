


using AutoMapper;
using Confluent.Kafka;
using Confluent.SchemaRegistry;
using Confluent.SchemaRegistry.Serdes;
using MessagePack;
using RequestSimulator.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application.Business.Utils.Kafka
{
    public class KafkaSender : IKafkaSender
    {
        private readonly ProducerConfig config = new ProducerConfig
         { BootstrapServers = "localhost:9092" };


        private readonly string topic = "App-request";

        private byte[] a; 
    public KafkaSender()
        {

        }

        public Object SendToKafka(UserRequestDto userRequestDto)
        {


            string message = $"EdgeserverId: {userRequestDto.EdgeServerId}, EdgeserverName: {userRequestDto.EdgeServerName}, DTId: {userRequestDto.DigitalTwinId}, ApplicationID: {userRequestDto.Id}";
            var body = MessagePackSerializer.Serialize<string>(message);
            var producer = new ProducerBuilder<Null, byte[]>(config).Build(); 
            try
            {
                return producer.ProduceAsync(topic, new Message<Null, byte[]> { Value = body })
                    .GetAwaiter()
                    .GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Oops, something went wrong: {e}");
            }
            
            return null;
            System.Diagnostics.Debug.WriteLine("Amir");
        }
    }
}
