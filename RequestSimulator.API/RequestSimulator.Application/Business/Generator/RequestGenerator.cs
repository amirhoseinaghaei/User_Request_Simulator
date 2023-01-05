using RequestSimulator.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application.Business.Generator
{
    public class RequestGenerator : IRequestGenerator
    {
        public UserRequestDto GenerateApplicationRequest(int requestId, int edgeserverId, int dtId)
        {
            UserRequestDto userRequestDto = new UserRequestDto();
            userRequestDto.EdgeServerId = edgeserverId;
            userRequestDto.DigitalTwinId = dtId;
            userRequestDto.Id = requestId;

            return userRequestDto;
        }
    }
}
