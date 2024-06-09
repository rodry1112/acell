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
    public partial class realizarventacs : Form
    {
        bool p1;
        bool p2;
        bool p3;
        public realizarventacs(int cii, string usu, string nombre, string turno, string correo)
        {
            InitializeComponent();
            lbci.Text = cii.ToString();
            lbusuario.Text = usu;
            lbturno.Text = turno;
            lbtelefono.Text = correo;
            lbnombre.Text = nombre;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "Data source=RODRYPC\\SQLEXPRESS;Initial Catalog=acell;integrated security=true";
            SqlConnection conn = new SqlConnection(cadena);
            SqlCommand cmd;
            SqlDataReader reader;
            conn.Open();
            cadena = "insert into persona(ci_persona,nombre,direccion,telefono,correo) values(@ci,@nombre,@direccion,@telefono,@correo)";
            cmd = new SqlCommand(cadena, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ci", txtnombre.Text);
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
            cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
            cmd.ExecuteNonQuery();
            p1 = true;
        }

        private void realizarventacs_Load(object sender, EventArgs e)
        {

        }

        private void btncarrito_Click(object sender, EventArgs e)
        {
            p2 = true;
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            p3 = true;
        }
    }
}
