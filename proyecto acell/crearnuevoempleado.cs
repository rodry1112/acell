using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_acell
{
    public partial class crearnuevoempleado : Form
    {
        public crearnuevoempleado()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregistrarempleado_Click(object sender, EventArgs e)
        {
            string cadena = "Data source=RODRYPC\\SQLEXPRESS;Initial Catalog=acell;integrated security=true";
            SqlConnection conn = new SqlConnection(cadena);
            SqlCommand cmd;
            SqlDataReader reader;
            conn.Open();

            int correlativ = 0;
            string empl = "P";
            cadena = "select isnull(max(nmro_contrato),0)+1 codigo from persona";
            cmd = new SqlCommand(cadena, conn);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    correlativ = reader.GetInt32(0);

                }
            }
            reader.Close();

            cadena = "insert into persona(ci_persona ,correo ,direccion,nmro_contrato,nombre,telefono,turno) values(@ci,@correo,@direccion,@numr_contrato,@nombre,@telefono,@turno)";
            cmd = new SqlCommand(cadena, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ci", txtci.Text.Trim());
            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text.Trim());
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);
            cmd.Parameters.AddWithValue("@numr_contrato", correlativ);
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
            cmd.Parameters.AddWithValue("@turno", combturno.Text);
            cmd.ExecuteNonQuery();
            reader.Close();
            cadena = "insert into usuario (contrasena,usuario,ci_usuario,tipo_usuario) values(@contrasena,@usuario,@ci2,@tipous)";
            cmd = new SqlCommand(cadena, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ci2", txtci.Text);
            cmd.Parameters.AddWithValue("@contrasena", txtcontrasena.Text);
            cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
            cmd.Parameters.AddWithValue("@tipoUs", empl);
            cmd.ExecuteNonQuery();
            reader.Close();
            MessageBox.Show("empleado registrado");
            txtci.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtcontrasena.Clear();
            txtusuario.Clear();
            combturno.Items.Clear();

            this.Close();
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
