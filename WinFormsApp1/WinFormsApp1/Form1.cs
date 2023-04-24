using System.Net;
using System.Net.Sockets;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Dirección IP y número de puerto del dispositivo Casio
            string ipAddress = "172.17.20.227";
            int port = 5000;
            // Crea un socket y se conecta al dispositivo Casio
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), port));

            // Envía el comando para encender el dispositivo
            byte[] buffer = { 0x02, 0x30, 0x30, 0x30, 0x30, 0x31, 0x30, 0x03 };
            socket.Send(buffer);

            // Cierra el socket
            socket.Close();

        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            // Dirección IP y número de puerto del dispositivo Casio
            string ipAddress = "172.17.20.227";
            int port = 23;

            // Crea un socket y se conecta al dispositivo Casio
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), port));

            // Envía el comando para apagar el dispositivo
            byte[] buffer = { 0x02, 0x30, 0x30, 0x30, 0x30, 0x31, 0x31, 0x03 };
            socket.Send(buffer);

            // Cierra el socket
            socket.Close();

        }
    }
}