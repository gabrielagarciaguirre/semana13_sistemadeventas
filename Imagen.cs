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
    public partial class Imagen : Form
    {
        public Imagen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void bproducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Productos en ofertas,con el 10% de descuentos", "RADO");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo mas vendido", "RADO");
            

        }

        private void Imagen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
