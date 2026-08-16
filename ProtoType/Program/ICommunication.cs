
// Common Interface for Communication implemented by
// HttpManager , TcpManager 
using Communication;

namespace SE_ProtoType
{
    public interface ICommunication
    {
        int SendCount { get; }
        int ReceiveCount { get; }
        string FilePath { get; }

        void Send(string message, string address);

        string Receive(string message);

        void AddSubscriber(string id, ICommunicationListener subscriber);

    }
}
