using RequestSimulator.Application.Dtos;

namespace RequestSimulator.Application.Business.Utils.Kafka
{
    public interface IKafkaSender
    {
        public Object SendToKafka(UserRequestDto userRequestDto);

    }
}