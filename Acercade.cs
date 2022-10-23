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
    public partial class Acerca_de : Form
    {
        public Acerca_de()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Acerca_de_Load(object sender, EventArgs e)
        {

        }

        private void binterrogacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alguna pregunta consultar en el menu ", "Sera un gusto atenderlo",
          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
