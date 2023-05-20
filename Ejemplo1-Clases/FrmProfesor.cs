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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Coninss() && ConSal())
            {
                Datos.Profesores.Add(new Profesor(textBoxinss.Text, double.Parse(textBoxSal.Text)));
                DialogResult di = MessageBox.Show("Se han guardados los datos", "Confirmar", MessageBoxButtons.OK);
                if (di == DialogResult.OK)
                {
                    textBoxinss.Clear();
                    textBoxSal.Clear();
                   
                }

            }
            else
            {
                DialogResult d = MessageBox.Show("Llene los campos", "Confirmar", MessageBoxButtons.OK);
            }
        }
        private bool Coninss()
        {
            if (string.IsNullOrEmpty(textBoxinss.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConSal()
        {
            if (string.IsNullOrEmpty(textBoxSal.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
