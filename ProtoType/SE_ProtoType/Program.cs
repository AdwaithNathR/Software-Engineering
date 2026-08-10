using Communication;
using SE_ProtoType;

// Program which drives everything

namespace Executive
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Using Factory
            CommunicationFactory factory = new CommunicationFactory();
            ICommunication communication = factory.GetPersistenceManager();
            communication.Send("Hello", "123");
            communication.Receive("");
            Console.WriteLine("Send Count = " + communication.SendCount + "\n");
            Console.WriteLine("Receive Count = " + communication.ReceiveCount + "\n");
        }
    }
}
