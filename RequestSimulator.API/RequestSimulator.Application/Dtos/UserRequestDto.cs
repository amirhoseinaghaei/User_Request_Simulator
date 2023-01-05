using RequestSimulator.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application.Dtos
{
    public class UserRequestDto : BaseDto
    {
        public int DigitalTwinId { get; set; }
        public int EdgeServerId { get; set; }
        public int EdgeServerName { get; set; }

    }
}
