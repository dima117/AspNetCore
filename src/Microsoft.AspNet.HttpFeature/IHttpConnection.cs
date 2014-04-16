using System.Net;

namespace Microsoft.AspNet.HttpFeature
{
    public interface IHttpConnection
    {
        IPAddress RemoteIpAddress { get; set; }
        IPAddress LocalIpAddress { get; set; }
        int RemotePort { get; set; }
        int LocalPort { get; set; }
        bool IsLocal { get; set; }
    }
}