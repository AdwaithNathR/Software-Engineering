
// Send Message using TCP

namespace SE_ProtoType
{
    public class TcpManager : ICommunication
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

        public virtual void Send(string message, string address)
        {
            Console.WriteLine("Message sending using TCP...\n");
            SendCount++;
        }

        public virtual string Receive(string message)
        {
            Console.WriteLine("Message Received using TCP...\n");
            ReceiveCount++;
            return message;
        }

    }
}
