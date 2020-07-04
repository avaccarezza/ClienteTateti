using ClienteDelJuego.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteDelJuego
{
    public partial class FormEstadisticasUsuario : Form
    {
        FormLogin l1;
        Controlador controlador;  
        Usuario u1;
        public FormEstadisticasUsuario(Usuario u1, Controlador controlador, FormLogin l1)
        {
            InitializeComponent();
            this.u1 = u1;
            this.controlador = controlador;
            this.l1 = l1;
            this.labelBienvenida.Text = "Bienvenido " + u1.usuario;
            this.labelPuntaje.Text = u1.puntaje.ToString();
            porcentaje();
            Console.WriteLine(u1.usuario);
            Console.WriteLine(u1.contrasena);
            Console.WriteLine(u1.puntaje);
            Console.WriteLine(u1.partidasGanadas);
            Console.WriteLine(u1.partidasJugadas);
        }
        bool cerrarSesion = false;
        private void buttonAjustes_Click(object sender, EventArgs e)
        {
            if (cerrarSesion)
            {
                buttonCerrarSesion.Hide();
                cerrarSesion = false;
            }
            else
            {
                buttonCerrarSesion.Show();
                cerrarSesion = true;
            }
        }
        

        private void buttonJugar_MouseEnter(object sender, EventArgs e)
        {
            buttonJugar.BackColor = Color.Yellow;
            buttonJugar.Cursor = Cursors.Hand;
        }

        private void buttonJugar_MouseLeave(object sender, EventArgs e)
        {
            buttonJugar.BackColor = Color.Gold;
            buttonJugar.Cursor = Cursors.Default;

        }
        private void buttonAjustes_MouseEnter(object sender, EventArgs e)
        {
            buttonAjustes.Cursor = Cursors.Hand;
        }
        private void buttonAjustes_MouseLeave(object sender, EventArgs e)
        {
            
            buttonAjustes.Cursor = Cursors.Default;
        }
      
       
        private void buttonJugar_Click(object sender, EventArgs e)
        {
            controlador.cartelBuscarPartida();
            controlador.jugar();
         }
           
        

        private void FormEstadisticasUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void FormEstadisticasUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Form formulario = new FormTateti(controlador,u1,this);
                formulario.Show();
                this.Hide();
            }
           
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            Form formulario = new FormLogin();
            formulario.Show();
            this.Hide();
        }
        

        private void porcentaje()
        {
            int porc = 0;
                if (u1.partidasJugadas != 0 || u1.partidasGanadas != 0)
            {
                 porc = (this.u1.partidasGanadas * 100) / this.u1.partidasJugadas;
            }
                
            this.labelCantPorcentaje.Text = porc.ToString();
        }
       
    }
}
