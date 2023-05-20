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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentrocs frmCent = new FrmCentrocs();
            frmCent.Show();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros liscen = new ListaCentros();
            liscen.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesor frmProfesor = new FrmProfesor();
            frmProfesor.Show();

        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas_Profesores listas_Profesores = new Listas_Profesores();
            listas_Profesores.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.Show();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Estudiantes estudiantes = new Lista_Estudiantes();
            estudiantes.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonal personal = new FrmPersonal();
            personal.Show();
        }

        private void listaDeTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Personales lista_Personales = new Lista_Personales();
            lista_Personales.Show();
        }
    }
}
