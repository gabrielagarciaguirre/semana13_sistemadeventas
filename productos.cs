using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;


namespace semana13_sistemadeventas
{
    public partial class productos : Form
    {
        public string cadena_conexion = "server=localhostSQLEXPRESS;integrated segurity=true;database=DBTeam";
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public productos()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objent.codigo = txtcodigo.Text;
            objent.nombre = txtnombre.Text;
            objent.edad = Convert.ToInt32(txtcantidad.Text);
            objent.telefono = Convert.ToInt32(txtprecio.Text);
            objent.accion = accion;
            String men = objneg.semana13_sistemadeventas(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtcantidad.Text = "";
            txtprecio.Text = "";
            txtbuscar.Text = "";
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }




        private void productos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + txtnombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtnombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtnombre.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void txtbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                objent.nombre = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_cliente(objent);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = objneg.N_listar_clientes();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtnombre.Text = dataGridView1[1, fila].Value.ToString();
            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtcantidad.Text = dataGridView1[2, fila].Value.ToString();
            txtprecio.Text = dataGridView1[3, fila].Value.ToString();
        }
    }
}
