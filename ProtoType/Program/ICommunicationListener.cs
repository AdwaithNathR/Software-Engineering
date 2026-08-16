
// Interface for message listening 

namespace Communication
{
    public interface ICommunicationListener
    {
        void OnMessageReceived(string message);
    }
}
