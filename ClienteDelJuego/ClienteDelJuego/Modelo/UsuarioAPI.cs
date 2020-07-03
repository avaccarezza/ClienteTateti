using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMasters.Models
{
    class UsuarioAPI
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int puntaje { get; set; }
        public int partidasJugadas { get; set; }
        public int partidasGanadas { get; set; }

        public UsuarioAPI(int id, string usuario, string contrasena, int puntaje, int partidasJugadas, int partidasGanadas )
        {
            this.id = id;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.puntaje = puntaje;
            this.partidasJugadas = partidasJugadas;
            this.partidasGanadas = partidasGanadas;
        }


    }
}
