using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace semana13_sistemadeventas
{
    public partial class Categorias : Form
    {
        //Creamos cadena de conexión como variable publica antes de la función fusuario() 
        public string cadena_conexion = "Database=productos;Data Source=localhost;User Id=dba;Password=123";
        private string id;

        public Categorias()
        {
            InitializeComponent();
        }

        private void Descripcion_Load(object sender, EventArgs e)
        {
            //Desabilitar campos, se activan al crear nuevo registro 
            txtproducto.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            try
            {
                string consulta = "select * from descripcion de productos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "producto");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "producto";
            }
            catch (MySqlException)
            {
                
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bprimero_Click(object sender, EventArgs e)
        {

        }

        private void banterior_Click(object sender, EventArgs e)
        {

        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {

        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtproducto.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtproducto.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtproducto.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "INSERT INTO Categorias(producto, clave, nivel) Values(?producto,? clave,? nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Parameters.Add("?producto", MySqlDbType.VarChar, 75).Value = txtproducto.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("producto agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string consulta = "select * from producto";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "productos");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "productos";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Producto agregado", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bnuevo.Visible = true;
            bguardar.Visible = false;
            //Desabilitar campos, se activan al crear nuevo registro
            txtproducto.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            bnuevo.Focus();
        }





        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = "Database=productos;Data Source=localhost;User Id = root; Password = ";
                }
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myInsertQuery = "DELETE FROM producto Where id=" + id + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                Categorias a = new Categorias();
                a.label1.Text = "Eliminado Con Éxito";
                a.ShowDialog();
                string cad = "Database=productos;Data Source=localhost;User Id=root;Password=";
                string query = "select * from producto";
                MySqlConnection cnn = new MySqlConnection(cad);
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "proucto");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "producto";
            }
            catch (System.Exception)
            {
                Categorias a = new Categorias();
                a.label1.Text = "Hay Campos Vacíos";
                a.ShowDialog();
            }
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtproducto.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;

            txtproducto.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            //producto_modificar = txtproducto.Text.ToString(); 
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string nom = txtproducto.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;
                //Hay dos formas de pasar los valores


                //Segunda forma de pasar los valores, usaremos esto
                string myInsertQuery = "UPDATE usuarios SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + "'";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //En caso de usar primera forma, se pasan estos parámetros.
                //myCommand.Parameters.Add("?producto", MySqlDbType.VarChar, 75).Value = txtproducto.Text;
                //myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value= txtclave.Text;
                //myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value =lstnivel.Text;
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
                MessageBox.Show("producto modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string consulta = "select * from productos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "sistemapro1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "sistemapro1";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el producto", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bmodificar.Visible = true;
            bactualizar.Visible = false;
            //Desabilitar campos, se activan al crear nuevo registro
            txtproducto.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            bmodificar.Focus();
        }


        private void bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



