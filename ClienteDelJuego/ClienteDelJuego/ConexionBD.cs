using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteDelJuego
{
    class ConexionBD
    {
        string cadena = "Data Source = DESKTOP-SM0K4D4\\SQLEXPRESS;Initial Catalog = tatetiBD;Integrated Security = true";
        public SqlConnection conectarBD = new SqlConnection();

        public ConexionBD()
        {
            conectarBD.ConnectionString = cadena;
        }
        public void abrir()
        {
            try
            {
                conectarBD.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);
            }
        }
        public void cerrar()
        {
            conectarBD.Close();
        }
    }
}
