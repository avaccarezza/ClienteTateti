using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ClienteDelJuego.Modelo;

namespace ClienteDelJuego
{
    public partial class FormLogin : Form
    {

        
        LogicaJuego t1 = new LogicaJuego();

        public FormLogin()
        {
            InitializeComponent();
           
            t1.tableroDefault();
            
        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "usuario")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.Font = new System.Drawing.Font("Britannic", 10F, System.Drawing.FontStyle.Bold);
                textBoxUsuario.ForeColor = Color.Black;
            }
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                
                textBoxUsuario.Text = "usuario";
                textBoxUsuario.Font = new System.Drawing.Font("Candara", 8.50F, System.Drawing.FontStyle.Italic);
                textBoxUsuario.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBoxContrasena_Enter(object sender, EventArgs e)
        {
            if (textBoxContrasena.Text == "contraseña")
            {
                textBoxContrasena.Text = "";
                textBoxContrasena.UseSystemPasswordChar = true;
                textBoxContrasena.Font = new System.Drawing.Font("Britannic", 10F, System.Drawing.FontStyle.Bold);
                textBoxContrasena.ForeColor = Color.Black;
            }
        }

        private void textBoxContrasena_Leave(object sender, EventArgs e)
        {
            if (textBoxContrasena.Text == "")
            {
                textBoxContrasena.Text = "contraseña";
                textBoxContrasena.UseSystemPasswordChar = false;
                textBoxContrasena.Font = new System.Drawing.Font("Candara", 8.50F, System.Drawing.FontStyle.Italic);
                textBoxContrasena.ForeColor = Color.WhiteSmoke;

            }
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
           // if (c1.conectar())
            //{
                Controlador c = new Controlador(this);
                c.loguearse();
            /*}
            else
            {
                Form formulario = new FormCartel();
                formulario.Show();
            }*/
        }

        private void buttonIngresar_MouseEnter(object sender, EventArgs e)
        {
            buttonIngresar.BackColor = Color.Yellow;
            buttonIngresar.Cursor = Cursors.Hand;
         
        }

        private void buttonIngresar_MouseLeave(object sender, EventArgs e)
        {
            buttonIngresar.BackColor = Color.Gold;
            buttonIngresar.Cursor = Cursors.Default;
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxContrasena.Focus();
                e.Handled = true;
            }
        }

        public bool verificarDatos()
        {
            var usuario = textBoxUsuario.Text;
            var contrasena = textBoxContrasena.Text;
                //var error = "";

            if (String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(contrasena) || (String.IsNullOrEmpty(usuario) && String.IsNullOrEmpty(contrasena)))
            {
                //error.Visible = true;
                return false;
            }
            else if (usuario == "Ingresar usuario" || contrasena == "Ingresar contraseña" || (usuario == "Ingresar usuario" && contrasena == "Ingresar contraseña"))
            {
                //error.Visible = true;
                return false;
            }
            else
            {
                //error.Visible = false;
                return true;
            }
        }
        public string getUsuario()
        {
            string user = textBoxUsuario.Text;
            return user;
        }
        public string getContrasena()
        {
            string pass = textBoxContrasena.Text;
            return pass;
        }
        public void mostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ConexionBD bd = new ConexionBD();
            bd.abrir();
        }
    }
}
