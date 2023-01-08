using RequestSimulator.Application.Dtos;

namespace RequestSimulator.Application.Business.Generator
{
    public interface IRequestGenerator
    {
        public UserRequestDto GenerateApplicationRequest(int requestId, int edgeserverId, int dtId, string edgeservername);
    }
}