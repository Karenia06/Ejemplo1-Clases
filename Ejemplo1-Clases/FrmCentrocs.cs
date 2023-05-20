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
        //List<Centro> listascentros = new List<Centro>();
        
        public FrmCentrocs()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConNom() && ConDir() && ConTel() && ConEmail())
            {
                Datos.Centros.Add(new Centro(textBoxNombre.Text,textBoxDireccion.Text,textBoxTelefono.Text,textBoxEmail.Text));
                DialogResult di = MessageBox.Show("Se han guardados los datos", "Confirmar", MessageBoxButtons.OK);
                if(di == DialogResult.OK)
                {
                    textBoxNombre.Clear();
                    textBoxDireccion.Clear();
                    textBoxTelefono.Clear();
                    textBoxEmail.Clear();
                }

            }
            else
            {
                DialogResult d = MessageBox.Show("Llene los campos","Confirmar", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ConNom()
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConDir()
        {
            if (string.IsNullOrEmpty(textBoxDireccion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConTel()
        {
            if (string.IsNullOrEmpty(textBoxTelefono.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConEmail()
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
