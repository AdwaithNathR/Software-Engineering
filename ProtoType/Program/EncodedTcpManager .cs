
// Send Encoded messages using TCP

using System.Diagnostics;

namespace SE_ProtoType
{
    public class EncodedTcpManager : TcpManager
    {

        public override void Send(string message, string address)
        {
            string encodedMessage = Encode(message);
            Debug.WriteLine("Sending " + message);
            SendCount++;
        }

        public override string Receive(string message)
        {
            string decodedMessage = Decode(message);
            Debug.WriteLine("Recived " + message);
            ReceiveCount++;
            return decodedMessage;
        }

        string Encode(string message)
        {
            return "EncodedMessage"; // will update soon
        }

        string Decode(string message)
        {
            return "DecodedMessage"; // will update soon
        }
    }
}
