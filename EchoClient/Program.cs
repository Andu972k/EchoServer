using System;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client();

            myClient.Start();

            Console.ReadLine();
        }
    }
}
