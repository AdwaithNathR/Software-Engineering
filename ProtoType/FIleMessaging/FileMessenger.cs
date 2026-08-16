using Communication;
using SE_ProtoType;
using System.Security.Principal;

namespace FileMessaging
{

    public delegate void FileMessageReceived(string message);

    public class FileMessenger : ICommunicationListener
    {
        private readonly ICommunication _communicator;
        public event FileMessageReceived? OnFileMessageReceived;
        public const string Identity = "FileMessenger";

        public FileMessenger(ICommunication communicator)
        {
            _communicator = communicator;
            communicator.AddSubscriber(Identity, this);
        }

        public void OnMessageReceived(string message)
        {
            OnFileMessageReceived?.Invoke(message);
        }
    }

}

