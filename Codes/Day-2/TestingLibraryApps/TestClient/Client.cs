using System;
using TestLibrary;

namespace TestClient
{
    class Client
    {
        static void Main()
        {
            string message = Messenger.SayHello("joydip");
            Console.WriteLine(message);

            Console.WriteLine("press key to terminate...");
            Console.Read();
        }
    }
}
