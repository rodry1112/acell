using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_acell
{
    internal class conexionbdacell
    {

        string cadena = "Data Source=DESKTOP-0CEU46S\\SQLEXPRESS;Initial Catalog=farmaceutica; Integrated Security=True";

        public SqlConnection conectarbd = new SqlConnection();

        public conexionbdacell()

        {

            conectarbd.ConnectionString = cadena;

        }
        public void abrir()
        {

            try

            {

                conectarbd.Open();

                Console.WriteLine("Conexion abierta");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la base" + ex.Message);
            }
        }

        public void cerrar()
        {
            conectarbd.Close();

        }
    }
}

