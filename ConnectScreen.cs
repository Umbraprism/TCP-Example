using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace tcpTest
{
    public partial class ConnectScreen : Form
    {
        private TcpClient tcpClient;

        public ConnectScreen()
        {
            InitializeComponent();
        }

        private void ConnectScreen_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        private void llHost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new HostScreen().Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpClient == null)
                {
                    int port = 5001;

                    tcpClient = new();

                    tcpClient.Connect("localhost", port);

                    Thread t = new(() => ReadData(tcpClient.GetStream()));
                    t.Start();

                    Console.WriteLine($"Connected succesfuly to {tcpClient.Client.ToString()}");
                }
                else
                {
                    Console.WriteLine("Already connected.");
                }
            }
            catch (SocketException)
            {
                Console.WriteLine("Failed to connect. Is the server still up?");
                tcpClient = null;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tcpClient != null)
            {
                Write(tcpClient.GetStream(), JsonSerializer.SerializeToUtf8Bytes(new Player(tbUsername.Text, tbPassword.Text, Int32.Parse(tbId.Text))));
            }
            else
            {
                Console.WriteLine("Not connected.");
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

        private void ReadData(NetworkStream stream)
        {
            while (true)
            {
                if (stream.DataAvailable)
                {
                    byte[] data = ReadStream(stream);

                    Console.WriteLine($"Received: {data}");
                }
            }
        }

        [DllImport("kernel32")]
        static extern bool AllocConsole();
    }
}
