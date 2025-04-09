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
    
    public partial class Form3 : Form
    {
        public static string Nombre = "";
        public static string Apellido = "";
        public static string DIMENSIONM = "";
        public static string DIMENSIONN = "";
        public static string asteroides = "";

        public static int CONTADORASTEROIDES = 0;
        public static int CONTADORCELDAS = 0;

        int CELDASX;
        int CELDASY;

        public Form3()
        {
            InitializeComponent();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            Nombre = textBox1.Text;
            Apellido = textBox2.Text;
            DIMENSIONM = textBox3.Text;
            DIMENSIONN= textBox4.Text;
            asteroides = textBox5.Text;
            Form1 formn1 = new Form1();
            

            double m = Convert.ToDouble (DIMENSIONM); //validaciones de numeros de dimensiones
            double n = Convert.ToDouble(DIMENSIONN);
            double ast = Convert.ToDouble(asteroides);
            double porc = Math.Round(((m * n) * (ast /100)));
            double celdas = Math.Round(m * n);

            // Separar el texto en filas y columnas
            string[] arrFilas = programacioncuadro.Split('\n');
           
            char[,] DATOSDEARCHIVO = new char[arrFilas.Length, arrFilas[0].Length];


            for (int i = 0; i < arrFilas.Length; i++)
            {
                for (int j = 0; j < arrFilas[i].Length; j++)
                {
                    DATOSDEARCHIVO[i, j] = arrFilas[i][j];
                   
                }
            }

            //buscamos la cantidad de letras que queremos (C,D,B)
            string C = "C";
            string D = "D";
            string B = "B";

            for (int i = 0; i < arrFilas.Length; i++)
            {
                for (int j = 0; j < arrFilas[i].Length; j++)
                {
                    if (DATOSDEARCHIVO[i, j] == C[0])
                    {
                        bool palabraEncontrada = true;
                        for (int k = 1; k < C.Length; k++)
                        {
                            if (j + k >= DATOSDEARCHIVO.GetLength(1) || DATOSDEARCHIVO[i, j + k] != C[k])
                            {
                                palabraEncontrada = false;
                                break;
                            }
                        }
                        if (palabraEncontrada)
                        {
                            CONTADORASTEROIDES++;
                        }
                        
                    }
                }
            }

            for (int i = 1; i < arrFilas.Length; i++)
            {
                for (int j = 1; j < arrFilas[i].Length; j++)
                {
                    CONTADORCELDAS++;
                }
            }

         
            

            if ((ast < porc)|(ast>0)) //VALIDACION DE LOS ASTEROIDES SI EL PORCENTAJE COINCIDE CON EL CODIGO
            { //SE NECESITA REFRESCAR EL FORM PARA QUE ME LO ACEPTE SI COMETO UN ERROR

                if ((m < 0) | (n < 0) | (m > 10) | (n > 10))
                {
                  
                    MessageBox.Show("Dimensiones no validas, el porcentaje debe ser ,menor que el 60%", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form3 form = new Form3();
                    this.Hide();
                    this.Reset();
                    form.ShowDialog();
                    
                }
                else
                {
                    if ((CONTADORASTEROIDES == porc)|(CONTADORCELDAS == celdas ))//si los asteroides y las celdas son como lo ingresado
                    {
                       
                        this.Hide();
                        this.Reset();
                        formn1.ShowDialog();
                    }
                    else
                    {
                        string mensaje = "Numero de asteroides no coincide. Revisar datos";
                        string titulo = "ERROR";
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(mensaje, titulo, botones);
                        if (result == DialogResult.OK)
                        {
                            Form3 form = new Form3();
                            this.Hide();
                            this.Reset();
                            form.ShowDialog();
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("No de asteroides no valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Form3 form = new Form3();
                this.Hide();
                this.Reset();
                form.ShowDialog();
            }


           


        }
        public void Reset()
        {
            
                Nombre = string.Empty;
                Apellido = string.Empty;
                DIMENSIONM= string.Empty;
            DIMENSIONN = string.Empty;
            asteroides = string.Empty;
            programacioncuadro = string.Empty;

            
        }
            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //validacion de letras para el nombre
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64)||(e.KeyChar > 91 && e.KeyChar <= 96)||(e.KeyChar > 123 && e.KeyChar <= 255))
            {
             MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             e.Handled= true;
             return;
            }
                
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //validacion del apellido
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar > 91 && e.KeyChar <= 96) || (e.KeyChar > 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) //validacion dimension m
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar > 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) //validacion dimension n
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar > 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e) //validacion asteroides
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar > 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public static string programacioncuadro = "";
        private void button2_Click(object sender, EventArgs e)
        {
            
            // abre un archivo creado

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Documento de texto|*.txt";
            abrir.Title = "Abrir...";
            abrir.FileName = "TableroSpaceBox";
            var resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                programacioncuadro = leer.ReadToEnd();
                leer.Close();
            }

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
