using EasySockets.Controllers;
using EasySockets.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class MainForm : Form
    {
        EasySockets.Models.Client _client = new EasySockets.Models.Client();

        public MainForm()
        {
            InitializeComponent();

            _client.ServerConnected += _client_ServerConnected;
            _client.DataReceived += _client_DataReceived;
            _client.ServerDisconnected += _client_ServerDisconnected;

            ClientController.Connect(_client, IPAddress.Loopback, 100);
        }

        private void _client_ServerConnected()
        {

        }

        private void _client_DataReceived(Socket sock, object[] data)
        {
            var header = (PacketHeader)data[0];

            switch (header)
            {
                case PacketHeader.Handshake:
                    ClientController.Send(_client, new object[] { header, Environment.MachineName, "192.168.1.1" });
                    break;
            }
        }

        private void _client_ServerDisconnected()
        {
            throw new NotImplementedException();
        }
    }
}
