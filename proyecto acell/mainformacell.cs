using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_acell
{
    public partial class mainformacell : Form
    {
        string usu;
            int cii;
        string turno;
        string correo;
        string nombre;
        public mainformacell(int cii, string usu,string nombre,string turno,string correo)
        {
            InitializeComponent();
            lbci.Text = cii.ToString();
            lbusuario.Text = usu;
            lbturno.Text = turno;
            lbtelefono.Text = correo;
            lbnombre.Text = nombre;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            inventario inven = new inventario();
            inven.Show();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            cii = int.Parse(lbci.Text);
            turno = lbturno.Text;
            usu = lbusuario.Text;
            nombre = lbnombre.Text;
            correo = lbtelefono.Text;
            realizarventacs vent = new realizarventacs(cii, usu, nombre, turno, correo);
            vent.Show();
        }

        private void registrarNuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearnuevoempleado nuev = new crearnuevoempleado();
            nuev.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbnombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainformacell_Load(object sender, EventArgs e)
        {

        }
    }
}
