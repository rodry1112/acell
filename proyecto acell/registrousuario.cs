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
    public partial class registrousuario : Form
    {
        string usuario;
         string contrasena;
        public registrousuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            
            usuario =txtusuario.Text;
            contrasena = txtcontrasena.Text;
            string cadena = "Data source=RODRYPC\\SQLEXPRESS;Initial Catalog=acell;integrated security=true";
            SqlConnection conn = new SqlConnection(cadena);

            try
            {

                
            }catch (SqlException ex) {
                MessageBox.Show("error: "+ex);
                throw;
            }
            string sql = "Select ci_usuario from usuario where usuario = '" + usuario + "'and contrasena ='" + contrasena + "' "; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int cii = (int)cmd.ExecuteScalar();

            cmd.ExecuteNonQuery();
            
            SqlDataReader reader= cmd.ExecuteReader();
            
            if (reader.Read())
            {
                
                this.Hide();
                MessageBox.Show("bienvenido "+usuario);
                reader.Close();
                SqlConnection conne = new SqlConnection(cadena);
                string pers = "select nombre from persona where ci_persona=@ci";
                SqlCommand cmdd = new SqlCommand(pers, conne);
                conne.Open();
                cmdd.Parameters.AddWithValue("@ci", cii);
                string nombre=cmdd.ExecuteScalar().ToString();
                cmdd.ExecuteNonQuery();
                conne.Close();
                pers = "select turno from persona where ci_persona=@ci";
                cmdd = new SqlCommand(pers, conne);
                conne.Open() ;
                cmdd.Parameters.AddWithValue("@ci", cii);
                string turno=cmdd.ExecuteScalar().ToString();
                
                cmdd.ExecuteNonQuery();
                conne.Close();

                pers = "select correo from persona where ci_persona=@ci";
                cmdd = new SqlCommand(pers, conne);
                conne.Open();
                cmdd.Parameters.AddWithValue("@ci", cii);
                string correo=cmdd.ExecuteScalar().ToString();
               
                cmdd.ExecuteNonQuery();
                conne.Close();

                string usu = usuario;
                mainformacell mform = new mainformacell(cii,usu,nombre,turno,correo);
                mform.Show();
            } else {
                MessageBox.Show(" usuario no admitido");
            }
            txtusuario.Clear();
            txtcontrasena.Clear();
        }

        private void txtcontrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
