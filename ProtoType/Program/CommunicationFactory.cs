using SE_ProtoType;

// Selects user preffered Communication Channel 

namespace Communication
{
    public class CommunicationFactory
    {
        public ICommunication GetPersistenceManager()
        {
            int choice = GetCommunicationChoice();

            if (choice == 1)
                return new TcpManager();

            else if (choice == 2)
                return new HttpManager();

            else if (choice == 3)
                return new EncodedTcpManager();

            else
                return new TcpManager();
        }

        int GetCommunicationChoice()
        {
            Console.WriteLine("Choose Communication to use (Default TCP)" +
                  "1.Tcp" +
                  "2.Http" +
                  "3.EncodedTcp");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
