using Entities;
using System.Collections.Generic;

namespace Business
{
    public interface INetstatService
    {
        string GetPortAndIP();
        List<Port> GetNetStatPorts();
    }
}
