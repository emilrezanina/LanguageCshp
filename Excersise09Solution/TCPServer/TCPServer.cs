using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    public class TCPServer
    {
        public const string DefaultIpAddress = "127.0.0.1";
        public const int DefaultPort = 1200;
        public const int ListenerCount = 2;

        private IMessageProcessor processor;
        private Socket socket;

        public TCPServer(IMessageProcessor processor, string ipAddress, int port)
        {
            this.processor = processor;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            if (!IPAddress.TryParse(ipAddress, out IPAddress ip))
            {
                ip = IPAddress.Parse(DefaultIpAddress);
            }
            processor?.Process($"TCP Server listening on {endPoint.ToString()}");
            socket.Bind(endPoint);
            socket.Listen(ListenerCount);
        }

        public void Listen()
        {
            Socket acceptedSocket = socket.Accept();
            byte[] receiveData = new byte[acceptedSocket.SendBufferSize];
            while (true)
            {
                int bufferSize = acceptedSocket.Receive(receiveData);
                byte[] data = new byte[bufferSize];
                for (int i = 0; i < bufferSize; i++)
                {
                    data[i] = receiveData[i];
                }
                string message = Encoding.Default.GetString(data);
                processor?.Process(message);
                if (message == "exit")
                    break;
            }
        }
    }
}
