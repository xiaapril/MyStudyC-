using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

 public class DateClient
{
     //the need member feilds
     private TcpClient tcpc;
     private string name;
     private int port = 4554;
     private bool readData = false;

     public DateClient(string name)
     {
         //a label
        tryagain:

         this.name = name;
         try
         {
             //connect to the "localhost" at the give port
             //if you have some other servername then you can use that
             //instead of "localhost"
             tcpc = new TcpClient("localhost", port);
             //get a Network stream from the server
             NetworkStream nts = tcpc.GetStream();
             //if the stream is writiable then write to the server
             if (nts.CanWrite)
             {
                 string sender = "Hi Server I am" + name;
                 Byte[] sends = System.Text.Encoding.ASCII.GetBytes(sender.ToCharArray());
                 nts.Write(sends, 0, sends.Length);
                 //flush to stream
                 nts.Flush();
             }

             //make a loop to wait untill some data is read from the stream
             while (!readData && nts.CanRead)
             {
                 if (nts.DataAvailable)
                 {
                     byte[] rcd = new byte[128];
                     int i = nts.Read(rcd, 0, 128);

                     string ree = System.Text.Encoding.ASCII.GetString(rcd);
                     char[] unwanted = { ' ', ' ', ' ' };

                     Console.WriteLine(ree.TrimEnd(unwanted));
                     readData = true;
                 }
             }
         }
         catch(Exception e)
         {
             Console.WriteLine("Could not Connect to server because " + e.ToString());
             Console.Write("Do you want to try Again ? [y/n]:");
             char check = Console.ReadLine().ToCharArray()[0];
             if (check == 'y' || check == 'Y')
                 goto tryagain;
         }

     }

     public static void Main(string[] args)
     {
         //check to see if the client has entered his name
         if (args.Length <= 0)
         {
             Console.WriteLine("Usage:DataClient <yourname>");
             Console.WriteLine("Would You like to enter your name now [y/n]?");
             char check = Console.ReadLine().ToCharArray()[0];
             if (check == 'y' || check == 'Y')
             {
                 Console.WriteLine("Please enter you name:");
                 string newname = Console.ReadLine();
                 DateClient dc = new DateClient(newname);
                 Console.WriteLine("Disconnected!!");
                 Console.ReadLine();
             }
         }
         else
         {
             DateClient dc = new DateClient(args[0]);
             Console.WriteLine("Disconnected!!");
             Console.ReadLine();


         }

     }
}

