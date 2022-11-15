using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void PrincipalCP_Load(object sender, EventArgs e)
        {
            menuStripBar.ForeColor = Color.FromArgb(64, 72, 204);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getFetch()
        {
            txtFecha.Text = DateTime.Now.Day.ToString() + " " + DateTime.Now.ToString("MMMM, yyyy");
            txtTime.Text = DateTime.Now.ToString("hh:mm tt"); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getFetch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros_Notas.Instancia.MdiParent = this;
            Registros_Notas.Instancia.WindowState = FormWindowState.Maximized;
            Registros_Notas.Instancia.FormBorderStyle = FormBorderStyle.None;
            Registros_Notas.Instancia.Show();
            
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesor.Instancia.MdiParent = this;
            Profesor.Instancia.WindowState = FormWindowState.Maximized;
            Profesor.Instancia.Show();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante.Instancia.MdiParent = this;
            Estudiante.Instancia.WindowState = FormWindowState.Maximized;
            Estudiante.Instancia.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curso.Instancia.MdiParent = this;
            Curso.Instancia.WindowState = FormWindowState.Maximized;
            Curso.Instancia.Show();
        }

        private void evaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evaluacion.Instancia.MdiParent = this;
            Evaluacion.Instancia.WindowState = FormWindowState.Maximized;
            Evaluacion.Instancia.Show();
        }
    }
}
