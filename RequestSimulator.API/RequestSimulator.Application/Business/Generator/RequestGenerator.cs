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
        Random Random;
        private double arrivalRequestProb ;

        public RequestGenerator()
        {
            Random = new Random();
            arrivalRequestProb = 0.4; 

        }
        public UserRequestDto GenerateApplicationRequest(int requestId, int edgeserverId, int dtId, string edgeservername)
        {
            if (Random.NextDouble() < arrivalRequestProb)
            {
                UserRequestDto userRequestDto = new UserRequestDto();
                userRequestDto.EdgeServerId = edgeserverId;
                userRequestDto.DigitalTwinId = dtId;
                userRequestDto.Id = requestId;
                userRequestDto.EdgeServerName = edgeservername;
                return userRequestDto;

            }
            return null;
        }
    }
}
