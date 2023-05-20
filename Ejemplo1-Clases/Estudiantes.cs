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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConExp() && ConTi())
            {
                Datos.Alumnos.Add(new Alumno(textBoxExp.Text, textBoxTi.Text));
                DialogResult di = MessageBox.Show("Se han guardados los datos", "Confirmar", MessageBoxButtons.OK);
                if (di == DialogResult.OK)
                {
                    textBoxExp.Clear();
                    textBoxTi.Clear();

                }

            }
            else
            {
                DialogResult d = MessageBox.Show("Llene los campos", "Confirmar", MessageBoxButtons.OK);
            }
            
        }
        private bool ConExp()
        {
            if (string.IsNullOrEmpty(textBoxExp.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConTi()
        {
            if (string.IsNullOrEmpty(textBoxExp.Text))
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
