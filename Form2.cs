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

namespace prueba_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void empezarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Simulacion = new Form1();
            Form2 menu = new Form2();
            //Simulacion.MdiParent = this; //el contenedor padre de la ventana de personalizacion es esta "this"
            Simulacion.Show();
            menu.Hide();
        }

        private void instruccionesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            instrucciones instrucciones = new instrucciones();
            Form2 menu = new Form2();
            instrucciones.ShowDialog();
            this.Hide();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que desea salir?";
            string titulo = "¿Salir?";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, botones);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
           
        }

        private void fase2SimulacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
                Form1 Simulacion = new Form1();
            Form2 menu = new Form2();
            //Simulacion.MdiParent = this; //el contenedor padre de la ventana de personalizacion es esta "this"
            Simulacion.Show();
            menu.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
