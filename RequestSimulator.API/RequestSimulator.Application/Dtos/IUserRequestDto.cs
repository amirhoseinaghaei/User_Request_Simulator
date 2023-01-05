using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestSimulator.Application.Dtos
{
    public interface IUserRequestDto
    {
        public int DigitalTwinId { get; set; }
        public int EdgeServerId { get; set; }
        public int EdgeServerName { get; set; }

    }
}
