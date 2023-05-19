using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class FrmCentrocs : Form
    {
        List<Centro> listascentros = new List<Centro>();
        
        public FrmCentrocs()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCentro();
            EliminarCentro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void AgregarCentro()
        {
            Centro centro = new Centro();
            centro.Nombre = textBoxNombre.Text;
            centro.Dir = textBoxDireccion.Text;
            listascentros.Add(centro);
            
        }
        private void EliminarCentro()
        {
            textBoxNombre.Clear();
            textBoxDireccion.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
