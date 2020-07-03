using System;
using RestSharp;
using Newtonsoft.Json;
using TicTacToeMasters.Models;

namespace ClienteDelJuego.Modelo
{
    class ConexionAPI
    {
        public static ConexionAPI instancia;
        RestClient client = new RestClient("https://localhost:44367/");

        public static ConexionAPI getInstancia()
        {
            if (instancia == null)
            {
                ConexionAPI.instancia = new ConexionAPI();
            }
            return instancia;

        }

        public Usuario obtenerUsuario(string user, string contrasena)
        {
            Console.WriteLine("Contactando API de web");
            var request = new RestRequest("api/" + user);
            var response = client.Get(request).Content;
            if (response == "null")
            {
                Console.WriteLine("N");
                return null;
            }
            else
            {
                var usuario = JsonConvert.DeserializeObject<UsuarioAPI>(response);
                if (usuario.contrasena == contrasena)
                {
                    Console.WriteLine("Y");
                    Usuario miUsuario = new Usuario(usuario.id, usuario.usuario,usuario.contrasena, usuario.puntaje, usuario.partidasJugadas, usuario.partidasGanadas);
                    return miUsuario;
                }
                else
                {
                    Console.WriteLine("N");
                    return null;
                }
            }

        }


        public void modificarUsuario(Usuario juga)
        {
            // Modifico una persona
            Console.Out.WriteLine("Modifico un usuario");
            var request = new RestRequest("api/" + juga.usuario);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { id = juga.id, nombre = juga.usuario, puntaje = juga.puntaje, partidasJugadas = juga.partidasJugadas, partidasGanadas = juga.partidasGanadas });
            var response = client.Put(request).Content;
            //Console.Out.WriteLine(JsonConvert.DeserializeObject(response));
        }
        

    }


}

