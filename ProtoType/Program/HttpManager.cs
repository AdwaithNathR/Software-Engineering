
// Send Message using HttpManager

using Communication;
using System.Diagnostics;

namespace SE_ProtoType
{
    public class HttpManager : ICommunication
    {
        private int sendCount = 0; // No.of times Send() called 
        private int receiveCount = 0; // No.of times Receive() called

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

        string ICommunication.FilePath { get; }

        public virtual void Send(string message, string address)
        {
            Debug.WriteLine("Message sending using Http...\n");
            SendCount++;
        }

        public virtual string Receive(string message)
        {
            Debug.WriteLine("Message Receiving using Http...\n");
            ReceiveCount++;
            return message;
        }

        void  ICommunication.AddSubscriber(string id, ICommunicationListener subscriber)
        {
            Debug.WriteLine("");
        }

    }
}
