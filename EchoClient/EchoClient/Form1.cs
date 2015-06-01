using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;

namespace EchoClient
{
	public partial class Form1: Form
	{
        TcpClient myclient;
        private NetworkStream networkStream;
        private StreamReader streamReader;
        private StreamWriter streamWriter;

		public Form1()
		{
			InitializeComponent();

            try
            {
                myclient = new TcpClient("localhost", 1234);
            }
            catch
            {
                Console.WriteLine("Failed to connect to server at {0}:1234", "localhost");
                return;
            }

            //初始化网络流
            networkStream = myclient.GetStream();
            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);
		}

        private void b1_Click(object sender, EventArgs e)
        {
            ta.Text = "";
            if (t1.Text == "")
            {
                MessageBox.Show("Please enter something in the textBox");
                t1.Focus();
                return;
            }
            try
            {
                string s;
                streamWriter.WriteLine(t1.Text);
                Console.WriteLine("Sending Message");
                streamWriter.Flush();
                s = streamReader.ReadLine();
                Console.WriteLine("Reading Message");
                Console.WriteLine(s);
                ta.Text = s;
            }
            catch (Exception ee)
            {
                Console.WriteLine("Exception reading from Server:" + ee.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭所有网络流
            streamReader.Close();
            streamWriter.Close();
            networkStream.Close();
        }

        
       
	}
}
