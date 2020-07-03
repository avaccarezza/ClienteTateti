using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteDelJuego.Modelo
{
  public  class ConexionSocketServer
    {
        TcpClient socket = new TcpClient();
        NetworkStream stream;
        Usuario uRival = null;    
         
        public bool conectar()
        {
            try
            {
                Console.WriteLine("Iniciando cliente");
                // 127.0.0.1 : Localhost
                socket.Connect("127.0.0.1", 8000);
                stream = socket.GetStream();
                
                return true;
            }
            catch (SocketException e)
            {
                Console.WriteLine("No se pudo conectar al servidor");
                return false;
            }
        }
        
        public void generarJugada(int pos)
        {

            var data = pos.ToString();
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(data);
            Console.WriteLine(data);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();
        }

        public void PonerEnCola(Usuario u1)
        {            
                    var data = JsonConvert.SerializeObject(u1);
                    var sendBytes = System.Text.Encoding.ASCII.GetBytes(data);
                    byte[] intBytes = BitConverter.GetBytes(sendBytes.Length);
                    stream.Write(intBytes, 0, intBytes.Length);
                    stream.Write(sendBytes, 0, sendBytes.Length);
                    stream.Flush();
        }
        public void salirDeLaCola(Usuario u1)
        {
            var data = JsonConvert.SerializeObject(u1);
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(data);
            byte[] intBytes = BitConverter.GetBytes(sendBytes.Length);
            stream.Write(intBytes, 0, intBytes.Length);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();
        }

        public void enviarUsuario(Usuario miUsuario)
        {   
            var msgEnv = JsonConvert.SerializeObject(miUsuario);
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(msgEnv);
            byte[] intBytes = BitConverter.GetBytes(sendBytes.Length);
            stream.Write(intBytes, 0, intBytes.Length);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();     
        }
        public string enviarMensaje(string msj)
        {
            var data = msj.ToString();
            var sendBytes = System.Text.Encoding.ASCII.GetBytes(data);
            byte[] intBytes = BitConverter.GetBytes(sendBytes.Length);
            stream.Write(intBytes, 0, intBytes.Length);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();
            recibirMensaje();
            return msj;
        }

        public void recibirMensaje()
        {
            byte[] bytesFrom = new byte[4];
            Usuario usuarioRival = null;
            stream.Read(bytesFrom, 0, bytesFrom.Length);
            int buffersize = BitConverter.ToInt32(bytesFrom, 0);
            bytesFrom = new byte[buffersize];
            stream.Read(bytesFrom, 0, bytesFrom.Length);
            var msgRec = System.Text.Encoding.ASCII.GetString(bytesFrom);
            if (msgRec.Contains("usuario"))
            {
                usuarioRival = JsonConvert.DeserializeObject<Usuario>(msgRec);
                uRival = usuarioRival;
            }
            else
            {
                System.Console.WriteLine(msgRec + " este es el else del recibir mensaje");
            }
        }
        public Usuario getRival()
        {
            return uRival;
        }
    }
}
