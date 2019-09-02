using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace EchoClient
{
    class Client
    {











        #region Methods

        public void Start()
        {

            //TcpClient socket = new TcpClient("localhost", 7);



            using (TcpClient socket = new TcpClient("localhost", 7))
            using (Stream ns = socket.GetStream())
            using (StreamReader reader = new StreamReader(ns))
            using (StreamWriter writer = new StreamWriter(ns))
            {
                string messageToBeSent = "Hello User, how is your day";

                writer.WriteLine(messageToBeSent);
                writer.Flush();

                string response = reader.ReadLine();
                Console.WriteLine(response);
                string response2 = reader.ReadLine();
                Console.WriteLine(response2);

                

            }
            

        }



        #endregion

    }
}
