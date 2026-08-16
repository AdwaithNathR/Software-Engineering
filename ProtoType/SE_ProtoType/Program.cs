using Communication;
using FileMessaging;
using SE_ProtoType;
using System.ComponentModel;
using System.Diagnostics;

// Program which drives everything

namespace Executive
{
    internal class Program 
    {
        private static FileMessenger _fileMessenger;

        static void Main(string[] args)
        {

            // Using Factory
            CommunicationFactory factory = new CommunicationFactory();

            Console.WriteLine("Choose Communication to use (Default TCP)" +
                            " 1.Tcp" +
                            " 2.Http" +
                            " 3.EncodedTcp");

            if ( !(int.TryParse(Console.ReadLine(), out int choice)) ) // Choice of Communication
            {
                Console.WriteLine("Covertion failed\n");
            }

            ICommunication communication = factory.CreateCommunicator(choice);

            if (choice == 1) // Implemented File listening only for TCP
            {
                _fileMessenger = new FileMessenger(communication);
                _fileMessenger.OnFileMessageReceived += delegate (string message)
                {
                    Console.WriteLine(message);
                };
            }
            communication.Send("Hello", "123");
            communication.Receive("");
            Console.WriteLine("Send Count = " + communication.SendCount + "\n");
            Console.WriteLine("Receive Count = " + communication.ReceiveCount + "\n");
        }
    }
}
