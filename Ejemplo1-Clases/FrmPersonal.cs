using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejemplo1_Clases
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void textBoxUni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCate_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ConUni() && ConCa())
            {
                Datos.Personanles.Add(new Personal(textBoxUni.Text, textBoxCate.Text));
                DialogResult di = MessageBox.Show("Se han guardados los datos", "Confirmar", MessageBoxButtons.OK);
                if (di == DialogResult.OK)
                {
                    textBoxUni.Clear();
                    textBoxCate.Clear();

                }

            }
            else
            {
                DialogResult d = MessageBox.Show("Llene los campos", "Confirmar", MessageBoxButtons.OK);
            }
        }
        private bool ConUni()
        {
            if (string.IsNullOrEmpty(textBoxUni.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ConCa()
        {
            if (string.IsNullOrEmpty(textBoxCate.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
