
// Send Message using TCP

using Communication;
using System.Diagnostics;

namespace SE_ProtoType
{

    public class TcpManager : ICommunication
    {
        private int sendCount = 0; // No.of times Send() called 
        private int receiveCount = 0; // No.of times Receive() called
        private readonly FileSystemWatcher _listener;
        private readonly Thread _listenThread;
        private ICommunicationListener communicationListener;


        public string FilePath { get; private set; } //Inherited

        public TcpManager()
        {
            FilePath = @"C:\Project_SE\ProtoType\Sample.txt";
            _listener = new FileSystemWatcher();
            _listener.Path = Path.GetDirectoryName(FilePath);
            _listener.Filter = Path.GetFileName(FilePath);
            _listenThread = new(new ThreadStart(ListenerThreadProc));
            _listenThread.Start();
        }

        public int SendCount
        {
            get
            {
                return sendCount;
            }
            set
            {
                sendCount = value;
            }
        }
        public int ReceiveCount
        {
            get
            {
                return receiveCount;
            }
            set
            {
                receiveCount = value;
            }
        }

        public virtual void Send(string message, string address)
        {
            Debug.WriteLine("Message sending using TCP...\n");
            SendCount++;
        }

        public virtual string Receive(string message)
        {
            Debug.WriteLine("Message Received using TCP...\n");
            ReceiveCount++;
            return message;
        }

        public void AddSubscriber(string id, ICommunicationListener subscriber)
        {
            communicationListener = subscriber;
        }

        private void ListenerThreadProc()
        {
            while (true)
            {
                try 
                {
                    _listener.WaitForChanged(WatcherChangeTypes.Changed);
                    string message = File.ReadAllText(FilePath);
                    communicationListener.OnMessageReceived(message);

                }
                catch (Exception e)
                {
                    Trace.TraceError(e.Message);
                }
            }
        }

    }
}
