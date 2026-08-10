
// Send Encoded messages using TCP

namespace SE_ProtoType
{
    public class EncodedTcpManager : TcpManager
    {

        public override void Send(string message, string address)
        {
            string encodedMessage = Encode(message);
            Console.WriteLine("Sending Decoded Message");
            SendCount++;
        }

        public override string Receive(string message)
        {
            string decodedMessage = Decode(message);
            Console.WriteLine("Recived Decoded Message");
            ReceiveCount++;
            return decodedMessage;
        }

        string Encode(string message)
        {
            return "EncodedMessage";
        }

        string Decode(string message)
        {
            return "DecodedMessage";
        }
    }
}
