using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Project_Doorbell
{
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BUFFER_SIZE = 1024;
        // Receive buffer.
        public byte[] buffer = new byte[BUFFER_SIZE];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }
}
