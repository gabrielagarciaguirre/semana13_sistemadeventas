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
using MySql.Data;
using MySql.Data.MySqlClient;


namespace semana13_sistemadeventas
{
    public partial class usuarios : Form

        
    {
        public string cadena_conexion = "server=localhostSQLEXPRESS;integrated segurity=true;database=DBTeam";




        public usuarios()
        {
            InitializeComponent();
        }

        private void Ingresodeusuarios_Load(object sender, EventArgs e)
        {

            
        }

        private void txtusuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //crear la conexion
                SqlConnection conexion = new SqlConnection(@"server=.\SQLEXPRESS; Initial Catalog = login; Integrated Security=True;");

                //abrir conexion
                conexion.Open();
                //cadena de consulta
                SqlCommand consulta = new SqlCommand("select usuario, password from tusuario where usuario = '" + txtusuario.Text + "'And password = '" + txtpassword.Text + "' ", conexion);
                //ejecuta una instruccion de sql devolviendo el numero de filas encontradas
                consulta.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                //Llenando el dataAdapter con los datos de la tabla
                da.Fill(ds, "tusuario");
                //fila de la tabla con la que se trabajara
                DataRow registro;
                registro = ds.Tables["tusuario"].Rows[0];
                //evaluando que clave y usuario sean correctos
                if ((txtusuario.Text == registro["usuario"].ToString()) || (txtpassword.Text == registro["password"].ToString()))
                {
                    
                }

            }
            catch
            {
                //en caso que la clave sea incorrecta mostrar mensaje de error
                MessageBox.Show("Error de usuario o clave de acceso", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
