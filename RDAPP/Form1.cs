using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDPCOMAPILib;
using AxRDPCOMAPILib;

namespace RDAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Form1 fr = new Form1();
        private void radioClient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioClient.Checked)
            {
                radioServer.Checked = false;
                groupClent.Enabled = true;
                groupServer.Enabled = false;
            }
        }

        private void radioServer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioServer.Checked)
            {
                radioClient.Checked = false;
                groupClent.Enabled = false;
                groupServer.Enabled = true;
            }
        }
        /// <summary>
        /// Handle the RDP session 
        /// 1. Create
        /// 2. Open
        /// 3. Generate connection String
        /// 4. Close
        /// Handling by server.cs
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Server.Connect(Server.currentSession);//Open
            TCPServer.setUpServer();
            lblDisplay.Text = "Server Started. Ready to connect";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rtxtServerString.Text = Server.getconnectionString//Con. String
                (Server.currentSession, "Test", "Group", "", 
                Int32.Parse(numClients.Value.ToString()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Server.Disconnect(Server.currentSession);//Close
            lblDisplay.Text = "Connect to share Desktop";
            rtxtServerString.Text = null;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Client.Connect(txtClientString.Text,this.axRDPViewer,"", "");
            TCPClient.LoopConnect();
            TCPClient.runRequest("get time");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.disconnect(this.axRDPViewer);
            txtClientString.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Server.CreateSession();
        }
        /////////////////////////////////////////////////////////



    }
}
