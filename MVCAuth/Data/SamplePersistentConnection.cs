using Microsoft.AspNet.SignalR;

namespace MVCAuth.Data
{
    public class SamplePersistentConnection : PersistentConnection
    {
        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
;        }

    }
}
