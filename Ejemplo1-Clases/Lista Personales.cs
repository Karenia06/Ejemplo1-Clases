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
    public partial class Lista_Personales : Form
    {
        public Lista_Personales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lista_Personales_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.Personanles;
        }
    }
}
