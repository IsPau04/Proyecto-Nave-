using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_2
{

    public partial class RESUMEN_DE_DATOS : Form
    {
        string Nave = Form1.Nombrenave;


        Form2 Menu = new Form2();
        string coordenadax = Form1.coordenadax;
        string coordenaday = Form1.coordenaday;
        string coordenadafinal = Form1.coordenada;
        string nombreada = Form1.Nombrenave;
        string gasolina = Form1.GASOLINALETRA;
        string configuracion = Form3.programacioncuadro;
        int iteraciones = Form1.iteraciones;
        string recorrido = Form1.RecorridoTEXTO;

        public RESUMEN_DE_DATOS()
        {
            InitializeComponent();
            Nombre();
            Coordenadas();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 Menu = new Form2();
            
           
            this.Hide();
            Menu.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void Nombre()
        {
            label7.Text = nombreada;
            label10.Text = configuracion;
        }
        public void Coordenadas()
        {
            label6.Text = coordenadafinal;
            label9.Text = Convert.ToString(iteraciones);
            label8.Text = recorrido;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
