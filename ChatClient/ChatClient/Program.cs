using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ChatClient
{
    public class ClientSocket
    {
        static void Main(string[] args)
        {
            TcpClient sockerForServer;
            bool status = true;
            try
            {
                sockerForServer = new TcpClient("localhost", 8100);
                Console.WriteLine("Connected to Server");
            }
            catch
            {
                Console.WriteLine("Failed to Connect to server{0}:8100","localhost");
                return;
            }
            NetworkStream networkStream = sockerForServer.GetStream();
            StreamReader streamreader = new StreamReader(networkStream);
            StreamWriter streamwriter = new StreamWriter(networkStream);

            try
            {
                string clientmessage;
                string servermessage;

                while (status)
                {
                    Console.Write("Client:");
                    clientmessage = Console.ReadLine();
                    if((clientmessage=="bye")||(clientmessage=="BYE"))
                    {
                        status=false;
                        streamwriter.WriteLine("bye");
                        streamwriter.Flush();
                    }
                    if ((clientmessage != "bye") || (clientmessage != "BYE"))
                    {
                        streamwriter.WriteLine(clientmessage);
                        streamwriter.Flush();
                        servermessage = streamreader.ReadLine();
                        Console.WriteLine("Server:" + servermessage);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception reading from the server");
            }
            streamreader.Close();
            streamwriter.Close();
            networkStream.Close();
        }
    }
}
