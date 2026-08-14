
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

        string Encode(string message) // Encode used here is a simple shift of each element left (cycle).
        {
            int messageSizeExact = message.Length - 1;
            if (messageSizeExact < 0)
                return "";
            char[] charArray = message.ToCharArray();
            charArray[messageSizeExact] = message[0]; 
            for(int i = 0; i< messageSizeExact; i++)
            {
                int j = (i+1) % (messageSizeExact+1);
                charArray[i] = message[j];
            }
            message = new string(charArray);
            return message; 
        }

        string Decode(string message) 
        {
            int messageSizeExact = message.Length - 1;
            if (messageSizeExact < 0)
                return "";
            char[] charArray = message.ToCharArray();
            charArray[0] = message[messageSizeExact];
            for (int i = messageSizeExact; i > 0; i--)
            {
                int j = (i - 1) % (messageSizeExact+1);
                charArray[i] = message[j];
            }
            message = new string(charArray);
            return message; 
        }
    }
}
