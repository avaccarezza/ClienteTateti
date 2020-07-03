using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteDelJuego.Modelo;

namespace ClienteDelJuego
{
    public partial class FormTateti : Form
    {
        ClienteDelJuego.Modelo.LogicaJuego lj1 = new ClienteDelJuego.Modelo.LogicaJuego();
        Controlador controlador;
        Usuario miUsuario;
        FormEstadisticasUsuario estadisticas;
        public FormTateti(Controlador controlador, Usuario miUsuario, FormEstadisticasUsuario estadisticas)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.estadisticas = estadisticas;
            this.miUsuario = miUsuario;
        }
        public void getUsuarioRival()
        {
            this.labelP2.Text = controlador.getRival().usuario;  
        }
        public void obtenerJugadores(Usuario miUsuario,Usuario usuarioRival)
        {
            this.labelP1.Text = miUsuario.usuario;
            this.labelP2.Text = controlador.getRival().usuario;
        }
        private void buttonJugar_Click(object sender, EventArgs e)
        {
           // Form formulario = new FormEstadisticasUsuario();
           // formulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = lj1.ponerFicha();
            button1.Enabled = false;
            //conexion.generarJugada(0);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //c1.generarJugada(1);
            button2.Text = lj1.ponerFicha();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //c1.generarJugada(2);
            button3.Text = lj1.ponerFicha();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //c1.generarJugada(3);
            button4.Text = lj1.ponerFicha();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //c1.generarJugada(4);
            button5.Text = lj1.ponerFicha();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //c1.generarJugada(5);
            button6.Text = lj1.ponerFicha();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //c1.generarJugada(6);
            button7.Text = lj1.ponerFicha();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //c1.generarJugada(7);
            button8.Text = lj1.ponerFicha();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //c1.generarJugada(8);
            button9.Text = lj1.ponerFicha();
            button9.Enabled = false;
        }

        private void FormTateti_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAjustes_Click(object sender, EventArgs e)
        {
            Form formulario = new FormLogin();
            formulario.Show();
            this.Hide();
        }
    }
}
