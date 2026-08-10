
// Common Interface for Communication implemented by
// HttpManager , TcpManager 
namespace SE_ProtoType
{
    public interface ICommunication
    {
        int SendCount { get; }
        int ReceiveCount { get; }

        void Send(string message, string address);

        string Receive(string message);
    }
}
