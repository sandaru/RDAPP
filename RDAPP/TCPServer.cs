using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using RDPCOMAPILib;
using AxRDPCOMAPILib;
using System.Net;
using System.Windows.Forms;
using System.Threading;

namespace RDAPP
{
    class TCPServer
    {
        //Globle variables
        private static byte[] _buffer = new byte[1024];
        private static List<Socket> _clientSockets = new List<Socket>();
        private static Socket _serverSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
       
        //Initiate the TCP connection
        public static void setUpServer()
        {
            MessageBox.Show("TCP Server Started");
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serverSocket.Listen(1);
            _serverSocket.BeginAccept(new AsyncCallback(acceptCallBack), null);
        }

        //When server accept the request
        private static void acceptCallBack(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            _clientSockets.Add(socket);
            socket.BeginReceive
                (_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(reciveCallBack), socket);
            _serverSocket.BeginAccept(new AsyncCallback(acceptCallBack), null);
        }

        //When request recived from the client
        private static void reciveCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int recived = socket.EndReceive(AR);
            byte[] dataBuff = new byte[recived];
            Array.Copy(_buffer, dataBuff, recived);

            String text = Encoding.ASCII.GetString(dataBuff);
            Console.WriteLine("Text Recived : " + text);
            /* Contrall commands */
            ///////////////////////////////////////////////////////////////////////////////
            string response = string.Empty;
            Triger triger = new Triger();
            Command requestActiveList =
                new ActiveWindowList(triger, Server.currentSession);

            Switch click = new Switch();

            if (text.ToLower() == "")
            {

            }
            else if (text.ToLower() == "get list")
            {
                response = listToString(click.StoreAndExecute(requestActiveList));
            }
            ////////////////////////////////////////////////////////////////////////////////
           
            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend
                (data, 0, data.Length, SocketFlags.None,
                new AsyncCallback(sendCallBack), socket);
            socket.BeginReceive
               (_buffer, 0, _buffer.Length, SocketFlags.None,
               new AsyncCallback(reciveCallBack), socket);
        }

        //When after send the data
        private static void sendCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }
        
        //Method to convert list to string
        private static String listToString(List<string> list)
        {
            String temp = string.Empty;
            foreach (var item in list)
            {
                temp += item.ToString() + ",";
            }
            return temp;
        }
    }
}
