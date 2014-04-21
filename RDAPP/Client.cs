using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDPCOMAPILib;
using AxRDPCOMAPILib;

namespace RDAPP
{
    class Client
    {
        public static void Connect(string invitation,AxRDPViewer display,string userName,string password)
        {
            display.Connect(invitation,userName,password);
        }

        public static void disconnect(AxRDPViewer display)
        {
            display.Disconnect();
        }
    }
}
