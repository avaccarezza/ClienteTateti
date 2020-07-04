using ClienteDelJuego.Modelo;

using System.Windows.Forms;

namespace ClienteDelJuego
{
    public partial class FormBuscarPartida : Form
    {

        Controlador controlador;
        Usuario u1;
        FormEstadisticasUsuario estadisticas;
        public FormBuscarPartida(Usuario u1, Controlador controlador, FormEstadisticasUsuario estadisticas)
        {
            InitializeComponent();
            this.u1 = u1;
            this.controlador = controlador;
            this.estadisticas = estadisticas;
        }       
    }
}
