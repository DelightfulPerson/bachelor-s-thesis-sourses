using System;
using System.Net;
using System.Net.Sockets;

namespace ClientSideForms.Modules
{
    class SocketTcpServer
    {
        readonly IPEndPoint _ipPoint = new (IPAddress.Parse(LocalHost.GetLocalIPAddress()), LocalHost._port);

        // Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        TcpClient _client = new ();
        public void ConnectByTcp()
        {
            try
            {
                _client.Connect(_ipPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                _client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool CheckConnectToServer()
        {
            return _client.Connected;
        }

        public void SendDataToServer(double[] outData)
        {

            // Output Arrays
            
            byte[] bytesArray1 = BitConverter.GetBytes(outData[0]);
            byte[] bytesArray2 = BitConverter.GetBytes(outData[1]);
            byte[] sendByteArray = new byte[bytesArray1.Length + bytesArray2.Length];
            int k = 0;
            foreach (byte i in bytesArray1)
            {
                sendByteArray[k] = i;
                k++;
            }
            foreach (byte i in bytesArray2)
            {
                sendByteArray[k] = i;
                k++;
            }
            k = 0;

            // Send input values to Twin Builder
            NetworkStream stream = _client.GetStream();
            stream.Write(sendByteArray, 0, sendByteArray.Length);
        }
    }
}
