using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_acell
{
    public partial class inventario : Form
    {
        int gridFilaIndex = -1;
        public inventario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionbdacell conexionbdacell = new conexionbdacell();
            conexionbdacell.abrir();
            conexionbdacell.cerrar();
            
            string connectionString1 = "Data source=RODRYPC\\SQLEXPRESS;Initial Catalog=acell;Integrated Security=true";
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();
            dtgproductos.Columns.Add("id_producto", "id producto");
            dtgproductos.Columns.Add("tipo", "tipo");
            dtgproductos.Columns.Add("marca", "marca");
            dtgproductos.Columns.Add("modelo", "modelo");
            dtgproductos.Columns.Add("precio", "precio");
            dtgproductos.Columns.Add("cantidad_disponible", "cantidad disponible");
            dtgproductos.Columns.Add("nombre_producto", "producto");
            string consultaInsercion = "select * from producto";
            SqlCommand cmdInsercion1 = new SqlCommand(consultaInsercion, connection1);
            cmdInsercion1.CommandType = CommandType.Text;
            SqlDataReader reader1 = cmdInsercion1.ExecuteReader();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    dtgproductos.Rows.Add(reader1.GetInt32(0), reader1.GetString(1), reader1.GetString(2), reader1.GetString(3), reader1.GetDecimal(4), reader1.GetInt32(5), reader1.GetString(6));
                }
            }
            connection1.Close();
            reader1.Close();
        
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnintroducir_Click(object sender, EventArgs e)
        {
            string connectionString = "Data source=RODRYPC\\SQLEXPRESS;Initial Catalog=acell;Integrated Security=true";
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    int correlativo = 0;
                    string cadena = "Select isnull(Max(id_producto),0)+1 codigo from producto";
                    SqlCommand cmd;
                    SqlDataReader reader;
                    conexionbdacell conexion = new conexionbdacell();
                    cmd = new SqlCommand(cadena, connection);
                    cmd.CommandType = CommandType.Text;

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            correlativo = reader.GetInt32(0);
                        }
                    }
                    reader.Close();
                    // Verificar si el nombre ya existe en la base de datos
                    string nombreProducto = txtproductos.Text;
                    string consultaExistencia = "SELECT COUNT(*) FROM producto WHERE nombre_producto = @nombre";
                    SqlCommand cmdExistencia = new SqlCommand(consultaExistencia, connection);
                    cmdExistencia.Parameters.AddWithValue("@nombre", nombreProducto);
                    int existencia = Convert.ToInt32(cmdExistencia.ExecuteScalar());

                    if (existencia > 0)
                    {
                        // El producto ya existe, mostrar MessageBox
                        DialogResult result = MessageBox.Show("Este producto ya existe. ¿Desea registrarlo como otro producto?",
                                                              "Producto existente",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            // No se desea registrar como otro producto, realizar alguna acción
                            // como mostrar un mensaje o ejecutar una operación adicional.
                            MessageBox.Show("No se realizará la inserción adicional del producto.", "Acción cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (result == DialogResult.Yes)
                        {
                            // Insertar el producto como otro registro
                            string consultaInsercion = "INSERT INTO producto (id_producto,nombre_producto, tipo, marca, modelo, cantidad_disponible, precio) " +
                                                       "VALUES (@idproducto,@nombre_producto, @tipo, @marca, @modelo, @cantidad_disponible, @precio)";
                            SqlCommand cmdInsercion = new SqlCommand(consultaInsercion, connection);
                            cmdInsercion.CommandType = CommandType.Text;
                            cmdInsercion.Parameters.AddWithValue("@idproducto", correlativo);
                            cmdInsercion.Parameters.AddWithValue("@nombre_producto", txtproductos.Text);
                            cmdInsercion.Parameters.AddWithValue("@tipo", txttipo.Text);
                            cmdInsercion.Parameters.AddWithValue("@marca", txtmarca.Text);
                            cmdInsercion.Parameters.AddWithValue("@modelo", txtmodelo.Text);
                            cmdInsercion.Parameters.AddWithValue("@cantidad_disponible", txtcantidad.Text.Trim());
                            cmdInsercion.Parameters.AddWithValue("@precio", txtpreciun.Text.Trim());
                            cmdInsercion.ExecuteNonQuery();
                            dtgproductos.Rows.Clear();
                            dtgproductos.Columns.Add("id_producto", "id producto");
                            dtgproductos.Columns.Add("nombre_producto", "producto");
                            dtgproductos.Columns.Add("tipo", "tipo");
                            dtgproductos.Columns.Add("marca", "marca");
                            dtgproductos.Columns.Add("modelo", "modelo");
                            dtgproductos.Columns.Add("cantidad_disponible", "cantidad disponible");
                            dtgproductos.Columns.Add("precio", "precio");
                            consultaInsercion = "select * from producto";
                            cmdInsercion = new SqlCommand(consultaInsercion, connection);

                            cmdInsercion.CommandType = CommandType.Text;
                            reader = cmdInsercion.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    dtgproductos.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), reader.GetInt32(5), reader.GetString(6));
                                }
                            }
                            MessageBox.Show("El producto se ha registrado como otro producto.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // El producto no existe, realizar la inserción normalmente
                        string consultaInsercion = "INSERT INTO producto (id_producto,nombre_producto, tipo, marca, modelo, cantidad_disponible, precio) " +
                                                   "VALUES (@idproducto,@nombre_producto, @tipo, @marca, @modelo, @cantidad_disponible, @precio)";
                        SqlCommand cmdInsercion = new SqlCommand(consultaInsercion, connection);
                        cmdInsercion.CommandType = CommandType.Text;
                        cmdInsercion.Parameters.AddWithValue("@idproducto", correlativo);
                        cmdInsercion.Parameters.AddWithValue("@nombre_producto", txtproductos.Text);
                        cmdInsercion.Parameters.AddWithValue("@tipo", txttipo.Text);
                        cmdInsercion.Parameters.AddWithValue("@marca", txtmarca.Text);
                        cmdInsercion.Parameters.AddWithValue("@modelo", txtmodelo.Text);
                        cmdInsercion.Parameters.AddWithValue("@cantidad_disponible", txtcantidad.Text.Trim());
                        cmdInsercion.Parameters.AddWithValue("@precio", txtpreciun.Text.Trim());
                        cmdInsercion.ExecuteNonQuery();
                        dtgproductos.Rows.Clear();
                        dtgproductos.Columns.Add("id_producto", "id producto");
                        dtgproductos.Columns.Add("tipo", "tipo");
                        dtgproductos.Columns.Add("marca", "marca");
                        dtgproductos.Columns.Add("modelo", "modelo");
                        dtgproductos.Columns.Add("precio", "precio");
                        dtgproductos.Columns.Add("cantidad_disponible", "cantidad disponible");
                        dtgproductos.Columns.Add("nombre_producto", "producto");
                        consultaInsercion = "select * from producto";
                        cmdInsercion = new SqlCommand(consultaInsercion, connection);
                        cmdInsercion.CommandType = CommandType.Text;
                        reader = cmdInsercion.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                dtgproductos.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDecimal(4), reader.GetInt32(5), reader.GetString(6));
                            }
                        }

                        MessageBox.Show("El producto se ha registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la conexión o la inserción de datos
                MessageBox.Show(

            "Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtproductos_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            dtgproductos.Rows.Clear();
            string connectionString = "Data source=RODRYPC\\SQLEXPRESS;Initial Catalog=acell;Integrated Security=true";
            try
            {
            string consultnommarca = "select cantidad_disponible from producto where nombre_producto=@nombre and marca=@marca";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand result = new SqlCommand(consultnommarca, con);
            con.Open();
            result.Parameters.AddWithValue("@nombre", txtproductos.Text);
            result.Parameters.AddWithValue("@marca", txtmarca.Text);
            int idr = (int)result.ExecuteScalar();
            result.ExecuteNonQuery();
            con.Close();
            string nom = txtproductos.Text;
            string marc = txtmarca.Text;
            string upda = "update producto set cantidad_disponible=@cantidad where nombre_producto" +
                "=@nombre and marca = @marca";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand existeprod = new SqlCommand(upda,conn);
            conn.Open();
            existeprod.Parameters.AddWithValue("@nombre", txtproductos.Text);
            existeprod.Parameters.AddWithValue("@marca", txtmarca.Text);
            existeprod.Parameters.AddWithValue("@cantidad",idr + int.Parse(txtcantidad.Text));
            existeprod.ExecuteNonQuery();
            conn.Close();


            dtgproductos.Columns.Add("id_producto", "id producto");
                                    dtgproductos.Columns.Add("tipo", "tipo");
                                    dtgproductos.Columns.Add("marca", "marca");
                                    dtgproductos.Columns.Add("modelo", "modelo");
                                    dtgproductos.Columns.Add("precio", "precio");
                                    dtgproductos.Columns.Add("cantidad_disponible", "cantidad disponible");
                                    dtgproductos.Columns.Add("nombre_producto", "producto");
                                    string consulta = "select * from producto";
            SqlConnection connn = new SqlConnection(connectionString);
            SqlCommand upcmd = new SqlCommand(consulta, connn);
            connn.Open();
                                    upcmd.CommandType = CommandType.Text;
                                   SqlDataReader read = upcmd.ExecuteReader();
                                    if (read.HasRows)
                                    {
                                        while (read.Read())
                                        {
                                            dtgproductos.Rows.Add(read.GetInt32(0), read.GetString(1), read.GetString(2), read.GetString(3), read.GetDecimal(4), read.GetInt32(5), read.GetString(6));
                                        }
                                    }
                                    connn.Close();
            }
            catch (SqlException ex)
            { MessageBox.Show(ex + " error al leer los datos", "error al ingresar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data source=RODRYPC\\SQLEXPRESS;Initial Catalog=acell;Integrated Security=true";
            try
            {
                string consultdatos = "select * from producto where nombre_producto=@prod and marca=@marca"
                    +"tipo=@tipo";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand result = new SqlCommand(consultdatos, con);
                con.Open();
                result.Parameters.AddWithValue("@nombre", txtproductos.Text);
                result.Parameters.AddWithValue("@marca", txtmarca.Text);
                result.Parameters.AddWithValue("@tipo",txttipo.Text);
              
                result.ExecuteNonQuery();
                con.Close();
                DialogResult desi = MessageBox.Show("seguro desea eliminar este producto?",
                                                              "seguridad",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);
                if (desi == DialogResult.Yes) {
                string borrar = "delete from producto where nombre_producto=@prod and marca=@marca and tipo=@tipo"; 
                SqlConnection conne = new SqlConnection(connectionString);
                SqlCommand elim =new SqlCommand(borrar, conne);
                    conne.Open();
                    int rows=elim.ExecuteNonQuery();
                    conne.Close();
                    if (rows > 0)
                    { MessageBox.Show("dato encontrado y eliminado","ejecutado exitosamente");
                        dtgproductos.Rows.Clear();
                        dtgproductos.Columns.Add("id_producto", "id producto");
                        dtgproductos.Columns.Add("tipo", "tipo");
                        dtgproductos.Columns.Add("marca", "marca");
                        dtgproductos.Columns.Add("modelo", "modelo");
                        dtgproductos.Columns.Add("precio", "precio");
                        dtgproductos.Columns.Add("cantidad_disponible", "cantidad disponible");
                        dtgproductos.Columns.Add("nombre_producto", "producto");
                        string consulta = "select * from producto";
                        SqlConnection connn = new SqlConnection(connectionString);
                        SqlCommand upcmd = new SqlCommand(consulta, connn);
                        connn.Open();
                        upcmd.CommandType = CommandType.Text;
                        SqlDataReader read = upcmd.ExecuteReader();
                        if (read.HasRows)
                        {
                            while (read.Read())
                            {
                                dtgproductos.Rows.Add(read.GetInt32(0), read.GetString(1), read.GetString(2), read.GetString(3), read.GetDecimal(4), read.GetInt32(5), read.GetString(6));
                            }
                        }
                        connn.Close();
                    }
                    else {
                        MessageBox.Show("dato no encontrato","producto no existe");
                    }
                }

            } catch (Exception ex) 
            {
                MessageBox.Show(

               "Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void dtgproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexDeCelda= e.RowIndex;
            filaselecionada(indexDeCelda);
        }
         private void filaselecionada(int index) {
                     
            if (index < 0) {
                MessageBox.Show("Seleccione una Fila con Datos");
            }
            else if (index > 0)
            {

            }

        }
    }
                        }
                    

                

            

        
    

