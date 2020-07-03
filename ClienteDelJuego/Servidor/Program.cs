using System;
using System.Threading;
using System.Net.Sockets;
using System.Reflection;
using System.Net;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iniciado servidor");

            TcpListener serverSocket = new TcpListener(8000);
            TcpClient clientSocket = default(TcpClient);

            serverSocket.Start();
            while (true)
            {
                clientSocket = serverSocket.AcceptTcpClient();
                HandlerClient client = new HandlerClient();
                client.startClient(clientSocket);

            }

        }
    }

    public class HandlerClient
    {

        TcpClient clientSocket;

        public void startClient(TcpClient clientSocket)
        {
            this.clientSocket = clientSocket;
            Thread threadClient = new Thread(doChat);
            threadClient.Start();
        }

        private void doChat()
        {

            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;

            Byte[] sendBytes = null;
            string serverResponse = null;

            while (true)
            {

                // Recibi mensaje
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, bytesFrom.Length);
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                System.Console.WriteLine(dataFromClient);

                // Enviar mensaje
                serverResponse = "Recibi mensaje";
                sendBytes = System.Text.Encoding.ASCII.GetBytes(serverResponse);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
                networkStream.Flush();

            }

        }

    }
}
