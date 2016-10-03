using EasySockets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Models
{
    public sealed class ClientInfo
    {
        public Socket Socket { get; set; }
        public string MachineName { get; set; }
        public string IPAddress { get; set; }

        public ClientInfo(Socket socket, string machineName, string ipAddress)
        {
            Socket = socket;
            MachineName = machineName;
            IPAddress = ipAddress;
        }

        public ListViewItem ToListViewItem()
        {
            return new ListViewItem(new[]
            {
                MachineName,
                IPAddress
            })
            { Tag = this };
        }
    }
}
