using RequestSimulator.Application.Dtos;

namespace RequestSimulator.Application.Business.Utils.Kafka
{
    public interface IKafkaSender
    {
        public void SendToKafka(UserRequestDto? userRequestDto);

    }
}