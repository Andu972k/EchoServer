using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
    class Server
    {








        #region Methods

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 7);
            server.Start();

            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();
                DoClient(socket);
            }

            
        }

        public void DoClient(TcpClient socket)
        {
            
            Stream ns = socket.GetStream();
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                string line = sr.ReadLine();
                sw.WriteLine(line);
                sw.Flush();

            }

        }

        #endregion

    }
}
