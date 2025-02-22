using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace tcpTest
{
    public partial class HostScreen : Form
    {
        public HostScreen()
        {
            InitializeComponent();
        }

        private void llConnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ConnectScreen().Show();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            try
            {
                int port = 5001;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                ServerHelper.Server = new(localAddr, port);

                ServerHelper.Server.Start();

                byte[] buffer = new byte[1024];
                string data;

                Thread t = new(WaitForConnection);
                t.Start();
            }
            catch (SocketException)
            {
                Console.WriteLine("Sever already created on current port.");
            }
        }

        private static byte[] ReadStream(NetworkStream stream)
        {
            List<byte> recieved = new();

            while (stream.DataAvailable)
            {
                byte[] buffer = new byte[1024];

                stream.Read(buffer, 0, buffer.Length);

                recieved.AddRange(buffer);
            }

            recieved.RemoveAll(x => x == 0);

            return recieved.ToArray();
        }

        private static void Write(NetworkStream stream, byte[] data)
        {
            stream.Write(data, 0, data.Length);
        }

        private void HostScreen_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        private void WaitForConnection()
        {
            while (true)
            {
                Console.WriteLine("Waiting...");

                TcpClient client = ServerHelper.Server.AcceptTcpClient();
                Console.WriteLine($"Connected new client - {client.ToString()}");

                NetworkStream stream = client.GetStream();

                Thread clientThread = new(() => HandleClient(stream, client));
                clientThread.Start();
            }
        }

        private void HandleClient(NetworkStream stream, TcpClient client)
        {
            while (ServerHelper.Server != null)
            {
                if (stream.DataAvailable)
                {
                    byte[] received = ReadStream(stream);
                    Player player = JsonSerializer.Deserialize<Player>(received);

                    Console.WriteLine($"Received: {player.ToString()}");

                    Write(stream, Encoding.UTF8.GetBytes("Message recieved."));
                }
            }

            client.Close();s
            Thread.CurrentThread.Join();
        }

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
    }
}
