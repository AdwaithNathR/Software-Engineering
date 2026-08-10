using SE_ProtoType;
using System.Diagnostics;

// Selects user preffered Communication Channel 

namespace Communication
{
    public class CommunicationFactory
    {
        public ICommunication CreateCommunicator(int choice)
        {

            if (choice == 1)
                return new TcpManager();

            else if (choice == 2)
                return new HttpManager();

            else if (choice == 3)
                return new EncodedTcpManager();

            else
                return new TcpManager(); // Defaulty return TcpManager object to avoid Exception
        }
    }
}
