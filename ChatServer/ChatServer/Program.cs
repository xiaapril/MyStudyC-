using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ChatServer
{
    public class ServerSocket1
    {
        public static void Main()
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");

            try
            {
                bool status = true;
                string servermessage = "";
                string clientmessage = "";
                TcpListener tcpListener = new TcpListener(ipAd, 8100);
                tcpListener.Start();
                Console.WriteLine("Server Started");

                Socket socketForClient = tcpListener.AcceptSocket();
                Console.WriteLine("Client Connected");
                NetworkStream networkStream = new NetworkStream(socketForClient);
                StreamReader streamReader = new StreamReader(networkStream);
                StreamWriter streamWriter = new StreamWriter(networkStream);

                while (status)
                {
                    if (socketForClient.Connected)
                    {
                        servermessage = streamReader.ReadLine();
                        Console.WriteLine("Client:" + servermessage);
                        if (servermessage == "bye")
                        {
                            status = false;
                            streamReader.Close();
                            networkStream.Close();
                            streamWriter.Close();
                            return;
                        }
                        Console.Write("Server:");
                        clientmessage = Console.ReadLine();

                        streamWriter.WriteLine(clientmessage);
                        streamWriter.Flush();
                    }
                    streamReader.Close();
                    networkStream.Close();
                    streamWriter.Close();
                    socketForClient.Close();
                    Console.WriteLine("Exiting...");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString()); 
            }
        }
    }
}
