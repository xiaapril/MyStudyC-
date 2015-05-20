using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;


public class DateServer
{
    private TcpListener myListener;
    private IPAddress ipAd = IPAddress.Parse("127.0.0.1");
    private int port = 4554;

    public DateServer()
    {
        try
        {
            myListener = new TcpListener(ipAd, port);
            myListener.Start();
            Console.WriteLine("Server Ready - Listining for new Connections ...");
            Thread th=new Thread(new ThreadStart(StartListen));
            th.Start();
        }
        catch(Exception e)
        {
            Console.WriteLine("An Exception Occured while Listing :"+e.ToString());            
        }
    }

    private void StartListen()
    {
        while (true)
        {
            Socket mySocket = myListener.AcceptSocket();
            if (mySocket.Connected)
            {
                Console.WriteLine("Client Connected!!");
                Byte[] receive = new Byte[64];
                int i = mySocket.Receive(receive, receive.Length, 0);
                char[] unwanted = { ' ', ' ', ' ' };
                string rece = System.Text.Encoding.ASCII.GetString(receive);
                Console.WriteLine(rece.TrimEnd(unwanted));

                DateTime now = DateTime.Now;
                String strDateLine = "Server: The Date/Time Now is: " + now.ToShortDateString() + " " + now.ToShortTimeString();

                Byte[] byteDateLine = System.Text.Encoding.ASCII.GetBytes(strDateLine.ToCharArray());
                mySocket.Send(byteDateLine, byteDateLine.Length, 0);
            }


        }
    }


    static void Main(string[] args)
    {
        DateServer dts=new DateServer();
    }
}

