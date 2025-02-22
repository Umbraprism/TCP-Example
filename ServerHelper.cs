using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace tcpTest
{
    static class ServerHelper
    {
        public static TcpListener? Server { get; set; }
    }
}
