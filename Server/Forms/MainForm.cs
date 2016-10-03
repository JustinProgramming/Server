using EasySockets.Controllers;
using EasySockets.Enumerations;
using EasySockets.Models;
using Server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Forms
{
    public partial class MainForm : Form
    {
        private delegate void AddToListViewCallBack(ClientInfo clientInfo);

        EasySockets.Models.Server _server = new EasySockets.Models.Server();

        public MainForm()
        {
            InitializeComponent();

            _server.ClientAccepted += _server_ClientAccepted;
            _server.DataReceived += _server_DataReceived;
            _server.ClientDisconnected += _server_ClientDisconnected;

            ServerController.Listen(_server, 100);
        }

        private void _server_ClientAccepted(Socket sock)
        {
            ServerController.Send(_server, sock, new object[] { PacketHeader.Handshake });
        }

        private void _server_DataReceived(Socket sock, object[] data)
        {
            var header = (PacketHeader)data[0];

            switch (header)
            {
                case PacketHeader.Handshake:
                    var clientInfo = new ClientInfo(sock, (string)data[1], (string)data[2]);
                    Invoke(new AddToListViewCallBack(AddToListView), clientInfo);
                    break;
            }
        }

        private void _server_ClientDisconnected(Socket sock)
        {
            throw new NotImplementedException();
        }

        private void AddToListView(ClientInfo clientInfo)
        {
            gbConnected.Text = $"Connected [{_server.Clients.Count}]";
            lvClients.Items.Add(clientInfo.ToListViewItem());
        }
    }
}
