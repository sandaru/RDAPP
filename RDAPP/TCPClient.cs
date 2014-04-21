using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDAPP
{
    class TCPClient
    {
        private static Socket _clientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static void runRequest(string request)
        {
                byte[] buffer = Encoding.ASCII.GetBytes(request);
                _clientSocket.Send(buffer);


                byte[] recivedBuffer = new byte[1024];
                int rec = _clientSocket.Receive(recivedBuffer);

                byte[] data = new byte[rec];
                Array.Copy(recivedBuffer, data, rec);
                MessageBox.Show("Recived : " + Encoding.ASCII.GetString(data));
        }

        public static void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }

            MessageBox.Show("Connected to the server");
        }
    }
}
