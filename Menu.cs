using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana13_sistemadeventas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ingresoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proevedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios Nuevousuario = new usuarios();
            
            Nuevousuario.Show();

            
        }

        private void nombreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            productos Productos = new productos();

            Productos.Show();

        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedor cliente = new Proveedor();

            cliente.Show();
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void opcionesDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de opcionesdeservicio = new Acerca_de();

            opcionesdeservicio.Show();
        }

        private void nombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categorias nombre = new Categorias();

            nombre.Show();
        }

        private void imagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagen Imagen = new Imagen();

            Imagen.Show();
        }

        private void todoTipoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cosas Todotipodeproductos = new Cosas();

            Todotipodeproductos.Show();
        }

        private void descripcionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categorias descripcion = new Categorias();

            descripcion.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sectorComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void descripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
