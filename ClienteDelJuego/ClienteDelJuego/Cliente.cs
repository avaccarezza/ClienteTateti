using System;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace Cliente
{
   public static class Cliente
    {
        static void Main(string[] args)
        {

            TcpClient socket = new TcpClient();
            NetworkStream stream;

            Console.WriteLine("Iniciando cliente");

            // 127.0.0.1 : Localhost
            socket.Connect("127.0.0.1", 8000);
            stream = socket.GetStream();

            // Enviar mensaje
            var msgEnv = "Hola como andas";
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(msgEnv);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();

            // Recibir mensaje
            byte[] bytesFrom = new byte[10025];
            stream.Read(bytesFrom, 0, bytesFrom.Length);
            var msgRec = System.Text.Encoding.ASCII.GetString(bytesFrom);
            System.Console.WriteLine(msgRec);

        }
    }
}
