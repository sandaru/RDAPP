using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RDPCOMAPILib;
using AxRDPCOMAPILib;
using System.Runtime.InteropServices;

namespace RDAPP
{
    class Server
    {
        //Create new RDP Session
        public static RDPSession currentSession = null;//Gloable session
        public static void CreateSession()
        {
            currentSession = new RDPSession();
            //return currentSession;
        }

        //Open the session
        public static void Connect(RDPSession session)
        {
            session.OnAttendeeConnected += Incoming;
            session.Open();
        }

        //Close the session
        public static void Disconnect(RDPSession session)
        {
            session.Close();
            session = null;
        }

        //Get Connection String
        public static String getconnectionString
            (RDPSession session,string authString,
            string group,string password,int clientLimit)
        {
            IRDPSRAPIInvitation invitation = 
                session.Invitations.CreateInvitation
                (authString, group,password, clientLimit);
            return invitation.ConnectionString;
        }

        //Manage atendees 
        private static void Incoming(object Guest)
        {
            IRDPSRAPIAttendee MyGuest = (IRDPSRAPIAttendee)Guest;
            MyGuest.ControlLevel = CTRL_LEVEL.CTRL_LEVEL_INTERACTIVE;
        }

    }
}
