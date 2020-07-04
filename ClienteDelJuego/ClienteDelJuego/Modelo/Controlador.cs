using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteDelJuego.Modelo
{
    public class Controlador
    {
        
        ConexionSocketServer c1 = new ConexionSocketServer();
        private Modelo.ConexionAPI api = Modelo.ConexionAPI.getInstancia();
        Usuario miUsuario;
        Usuario uRival;
        FormLogin login;
        FormEstadisticasUsuario estadisticas;
        FormCartel formCartel;
       
        public Controlador(FormLogin login)
        {
            this.login = login;
        }
        
        public void loguearse()
        {
            if (login.verificarDatos())
            {
                Console.WriteLine("Datos correctos");
                string usuario = login.getUsuario();
                string contrasena = login.getContrasena();
                miUsuario = api.obtenerUsuario(usuario, contrasena);
                Console.WriteLine(usuario);
                Console.WriteLine(contrasena);
                if (miUsuario == null)
                {
                    login.mostrarError("El usuario ingresado no existe o posee datos incorrectos");
                }
                else
                { 
                    if (!c1.conectar())
                    {
                        formCartel = new FormCartel();
                        formCartel.Show();
                    }
                    else
                    {
                        c1.enviarUsuario(miUsuario);
                        estadisticas = new FormEstadisticasUsuario(miUsuario,this, login);
                        estadisticas.Show();
                        login.Hide();
                    }
                }
            }
        }
        
        public void cartelBuscarPartida()
        {
            FormBuscarPartida matchmaking = new FormBuscarPartida(miUsuario, this, estadisticas);
            matchmaking.Show();
        }
        public void jugar()
        {
           
            c1.PonerEnCola(miUsuario);
            c1.enviarMensaje("c");
            c1.enviarUsuario(miUsuario);
           
            getRival();
            
            if (getRival() != null)
            {
                Console.WriteLine("dentro del if");
                FormTateti tablero = new FormTateti(this,miUsuario,estadisticas);
                tablero.getUsuarioRival();
                tablero.Show();
                estadisticas.Hide();
               
                c1.salirDeLaCola(miUsuario);
                tablero.obtenerJugadores(miUsuario, uRival);
                //matchmaking.Close(); 
            }
           
        }
        public Usuario getRival()
        {
            Usuario uRival = c1.getRival();
            return uRival;
        }

    }
}
