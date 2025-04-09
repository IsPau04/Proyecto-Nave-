using Accessibility;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace prueba_2
{
    public partial class Form1 : Form
    {

        string nombre = Form3.Nombre;
        string apellido = Form3.Apellido;
        string m = Form3.DIMENSIONM;
        string n = Form3.DIMENSIONN;
        string asteroides = Form3.asteroides;


        public static string coordenadax;
        public static string coordenaday;
        public static string coordenada;

        public int x;
        public double xgas;
        public double ygas;
        public int y;
        public int asteroidesNUM = Form3.CONTADORASTEROIDES;
        public string configLETRAS;
        public static int iteraciones = 0;

        string matrizletras = Form3.programacioncuadro;

        static public string lanavesemueve;
        private int cellWidth = 55;
        private int cellHeight = 55;
        private int currentX = 0;
        private int currentY = 0;
        private Image imagennave = Properties.Resources.NAVE;
        private Image imagenasteroide = Properties.Resources.asteroides;
        private Image imagentierra = Properties.Resources.tierra;
        private Image imagensombra = Properties.Resources.Spray_Gris;
        private Image imagenpuntopartida = Properties.Resources.Estrella_amarilla;

        List <int> espaciosrecorridosx = new List <int>();
        List <int> espaciosrecorridosy = new List <int>();

        public static int POSICIONXASTEROIDES;
        public static int POSICIONYASTEROIDES;
        List<int[]> ubicaciones = new List<int[]>();
        public static int POSICIONXTIERRA;
        public static int POSICIONYTIERRA;
        public static int POSICIONXADA;
        public static int POSICIONYADA;
        public static int POSICIONINICIOX;
        public static int POSICIONINICIOY;


        public static double gasolina = 0;
        public static double gasolinarestante= 0;
        public static double GASOLINAFINAL;
        public static string GASOLINALETRA;
        public static double Recorrido;
        public static double Recorridorestante;
        public static string RecorridoTEXTO;

        public static string Nombrenave;
        public Form1()
        {
            x = Convert.ToInt32(m);
            y = Convert.ToInt32(n);
            asteroidesNUM = Convert.ToInt32(asteroides);
            configLETRAS = Convert.ToString(matrizletras);



            InitializeComponent();


            pictureBox2.TabStop = true;


            // Separar el texto en filas y columnas
            string[] arrFilas = configLETRAS.Split('\n');
            char[,] DATOSDEARCHIVO = new char[arrFilas.Length, arrFilas[0].Length];

            //meter los datos a la matriz
            for (int i = 0; i < arrFilas.Length; i++)
            {
                for (int j = 0; j < arrFilas[i].Length; j++)
                {
                    DATOSDEARCHIVO[i, j] = arrFilas[i][j];
                }
            }

            char letraD = 'D'; //TIERRA
            char letraB = 'B'; //ADA
            char letraC = 'C'; //asteroides


            //POSICION ADA Y TIERRA y ASTEROIDES
            for (int i = 0; i < arrFilas.Length; i++) //TIERRA
            {
                for (int j = 0; j < arrFilas[i].Length; j++)
                {
                    if (DATOSDEARCHIVO[i, j] == letraD)
                    {
                        POSICIONXTIERRA = j;
                        POSICIONYTIERRA = i;
                        
                        break;
                    }
                }


            }
            for (int i = 0; i < arrFilas.Length; i++) //ADA
            {
                for (int j = 0; j < arrFilas[i].Length; j++)
                {
                    if (DATOSDEARCHIVO[i, j] == letraB)
                    {
                        POSICIONXADA = j;
                        POSICIONYADA = i;
                        
                        break;
                    }
                }

            }
            for (int i = 0; i < arrFilas.Length; i++) //Asteroides
            {
                for (int j = 0; j < arrFilas[i].Length; j++)
                {
                    if (DATOSDEARCHIVO[i, j] == letraC)
                    {
                        ubicaciones.Add(new int[] { i, j });//MATRIZ CORRECTA
                    }
                }

            }



        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void DrawRectangleInt(PaintEventArgs e)
        {


        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            NOMBREDELANAVE();
            DIMENSIONESTEXTO();
            this.KeyPreview = true; // Habilitar la recepción de eventos de teclado para el formulario

            this.Focus();
            xgas = Convert.ToDouble(m);
            ygas = Convert.ToDouble(n);

            gasolina = Math.Round (0.4 * (x * y));
            gasolinarestante = Math.Round(gasolina * 0.05);

            Recorrido =  (1000 * (x*y));
            Recorridorestante = Math.Round (Recorrido * 0.05);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void NOMBREDELANAVE() //validado 
        {
            string appelido1 = Convert.ToString(apellido.First()); //primera letra del apellido
            string Nombre = Convert.ToString(nombre.Last()); //ultima letra del nombre 
            int letras = Convert.ToInt32(nombre.Length) + Convert.ToInt32(apellido.Length);
            string sumadenumeros = Convert.ToString(letras);

            Nombrenave = "";
            Nombrenave = "GUA_" + "_" + appelido1 + Nombre + "_" + sumadenumeros;
            label1.Text = Nombrenave;
        }

        public void COLISION()
        {
            


        }

        public void DIMENSIONESTEXTO()
        {
            string dimensiones = "";
            dimensiones = "X: " + m.ToString() + " Y: " + n.ToString();
            label3.Text = dimensiones;
        }
        public void DIMENSIONES() //DIMENSIONES PARA LA CUADRICULA
        {
            int diemensionM = Convert.ToInt32(m);
            int dimensionN = Convert.ToInt32(n);


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //regresar aqui si no funciona
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



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

        private void button1_Click_1(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();


            Menu.Show();
            this.Hide();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


        }
        private void DrawGrid(Graphics g, int width, int height, int cellWidth, int cellHeight, Color color, int x, int y)
        {
            // Dibuja las líneas horizontales
            for (int i = 0; i <= y * cellHeight; i += cellHeight)
            {
                g.DrawLine(new Pen(color), 0, i, x * cellWidth, i);
            }

            // Dibuja las líneas verticales
            for (int j = 0; j <= x * cellWidth; j += cellWidth)
            {
                g.DrawLine(new Pen(color), j, 0, j, y * cellHeight);
            }

            // No es necesario dibujar la nave aquí, ya que se dibuja en el evento pictureBox1_Paint
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            // Actualiza la posición del cohete según la tecla presionada


            switch (e.KeyCode)
            {
                case Keys.W:
                    lanavesemueve = "W";
                    timer1.Enabled = true;
                    iteraciones++;
                    break;

                case Keys.S:
                    lanavesemueve = "S";
                    timer1.Enabled = true;
                    iteraciones++;
                    break;

                case Keys.A:
                    lanavesemueve = "A";
                    timer1.Enabled = true;
                    iteraciones++;
                    break;

                case Keys.D:
                    lanavesemueve = "D";
                    timer1.Enabled = true;
                    iteraciones++;
                    break;


            }
        
            pictureBox2.Invalidate();

            if (iteraciones < 20)
            {
                label6.Text = iteraciones.ToString();

            }
            else
            {
                string mensaje = "Ha superado el límite de movimientos";
                string titulo = "ERROR";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mensaje, titulo, botones);
                if (result == DialogResult.Yes)
                {
                    RESUMEN_DE_DATOS Resumen = new RESUMEN_DE_DATOS();


                    Resumen.Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }

            }

            coordenadax = Convert.ToString(POSICIONXADA);
            coordenaday = Convert.ToString(POSICIONYADA);

            coordenada = "(" + coordenadax + "," + coordenaday + ")";
            label7.Text = coordenada;

            

       }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            string[] arrFilas = configLETRAS.Split('\n');
            char[,] DATOSDEARCHIVO = new char[arrFilas.Length, arrFilas[0].Length];
            char letraC = 'C'; //asteroides

            //Creación del objeto graphics
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);

            // Dibuja la cuadrícula
            DrawGrid(e.Graphics, pictureBox2.Width, pictureBox2.Height, cellWidth, cellHeight, Color.Black, x, y);

            // Dibuja el cohete en la posición actual
            g.DrawImage(imagennave, POSICIONXADA * cellWidth, POSICIONYADA * cellHeight, cellWidth, cellHeight); //la nave se posiciona desde 0 CAMBIAR AL VALOR DE LA MATRIZ
            g.DrawImage(imagentierra, POSICIONXTIERRA * cellWidth, POSICIONYTIERRA * cellHeight, cellWidth, cellHeight); //Posicion de la tierra
           





            for (int i = 0; i < ubicaciones.Count; i++) //CREACION DE ASTEROIDES LISTO
            {
                POSICIONYASTEROIDES = Convert.ToInt32(ubicaciones[i].First());
                POSICIONXASTEROIDES = Convert.ToInt32(ubicaciones[i].Last());
                g.DrawImage(imagenasteroide, POSICIONXASTEROIDES * cellWidth, POSICIONYASTEROIDES * cellHeight, cellWidth, cellHeight);
            }

            for (int i =0; i<espaciosrecorridosx.Count; i++) 
            {
                espaciosrecorridosx.ElementAt(i);
                espaciosrecorridosy.ElementAt(i);

                e.Graphics.DrawImage(imagensombra,espaciosrecorridosx.ElementAt(i)*cellWidth, espaciosrecorridosy.ElementAt(i)* cellHeight, cellWidth, cellHeight);
            }




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void Movimiento()
        {
            if (POSICIONXADA == POSICIONXTIERRA && POSICIONYADA == POSICIONYTIERRA)
            {
                switch (lanavesemueve)
                {
                    case "W":
                        timer1.Enabled = false;

                        break;

                    case "S":
                        timer1.Enabled = false;

                        break;
                    case "A":
                        timer1.Enabled = false;

                        break;

                    case "D":
                        timer1.Enabled = false;

                        break;

                }
                string mensaje = "Felicidades, ¡Ha llegado a la tierra!. ¿Desea ver los resultados?";
                string titulo = "Felicidades";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mensaje, titulo, botones);
                if (result == DialogResult.Yes)
                {
                    RESUMEN_DE_DATOS Resumen = new RESUMEN_DE_DATOS();


                    Resumen.Show();
                    this.Hide();
                }
                else
                {
                    string anuncio = "¿Está seguro que desea salir?";
                    string titu = "Salida";
                    MessageBoxButtons opciones = MessageBoxButtons.YesNo;
                    DialogResult resultado = MessageBox.Show(anuncio, titu, opciones);

                    if (resultado == DialogResult.Yes)
                    {


                        Application.Exit();

                    }
                }
                
            }
            else
            {
             switch (lanavesemueve)
             {
              case "W":
              POSICIONYADA = ( POSICIONYADA - 1);
              espaciosrecorridosx.Add(POSICIONXADA);
              espaciosrecorridosy.Add(POSICIONYADA +1);
              iteraciones++;
                                    
              break;

              case "S":
              POSICIONYADA = ( POSICIONYADA + 1);
             espaciosrecorridosx.Add(POSICIONXADA);
              espaciosrecorridosy.Add(POSICIONYADA - 1);
              iteraciones++;
                                
               break;
               case "A":
               POSICIONXADA = (POSICIONXADA - 1);
                espaciosrecorridosx.Add(POSICIONXADA+1);
               espaciosrecorridosy.Add(POSICIONYADA);
               iteraciones++;
                                    
              break;

             case "D":
              POSICIONXADA = ( POSICIONXADA + 1);
                        espaciosrecorridosx.Add(POSICIONXADA-1);
                        espaciosrecorridosy.Add(POSICIONYADA);
                        iteraciones++;
                                    
               break;
             }
                        
             


              if (iteraciones < 20)
                 {
                 label6.Text = iteraciones.ToString();

                 }
               else
                {

                switch (lanavesemueve)
                 {
                   case "W":
                  timer1.Enabled = false;

                 break;
                     case "S":
                     timer1.Enabled = false;

                      break;
                      case "A":
                      timer1.Enabled = false;

                       break;
                        case "D":
                       timer1.Enabled = false;

                         break;

                 }
                    string mensaje = "ERROR EN LA SIMULACION, ¡Se ha quedado sin combustible!. ¿Desea ver los resultados?";
                    string titulo = "Sin combustible";
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(mensaje, titulo, botones);

                    if (result == DialogResult.Yes)
                    {
                        RESUMEN_DE_DATOS Resumen = new RESUMEN_DE_DATOS();

                        Resumen.Show();
                        this.Hide();
                    }
                    else
                    {
                        string anuncio = "¿Está seguro que desea salir?";
                        string titu = "Salida";
                        MessageBoxButtons opciones = MessageBoxButtons.YesNo;
                        DialogResult resultado = MessageBox.Show(anuncio, titu, opciones);

                        if (resultado == DialogResult.Yes)
                        {


                            Application.Exit();

                        }
                    }
                    
               }

             coordenadax = Convert.ToString(POSICIONXADA);
             coordenaday = Convert.ToString(POSICIONYADA);

             coordenada = "(" + coordenadax + "," + coordenaday + ")";
             label7.Text = coordenada;

             GASOLINAFINAL = gasolina;
             gasolina = gasolina - gasolinarestante;

             GASOLINALETRA = Convert.ToString(gasolina)+ " Galones";
             label5.Text = GASOLINALETRA;

                RecorridoTEXTO = Convert.ToString(Recorrido);
                Recorrido = Recorrido - Recorridorestante;
              RecorridoTEXTO = Convert.ToString(Recorrido) + " Kilómetros";
                label11.Text = RecorridoTEXTO;

                for (int i = 0; i < ubicaciones.Count; i++) //FUNCIONA
                {
                    if (POSICIONXADA == ubicaciones[i].Last() & POSICIONYADA == ubicaciones[i].First())
                    {
                        timer1.Enabled = false;


                        string mensaje = "ERROR EN LA SIMULACION, ¡Ha chocado con un asteroide!. ¿Desea ver los resultados?";
                        string titulo = "Usted ha chocado";
                        MessageBoxButtons botones = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(mensaje, titulo, botones);

                        if (result == DialogResult.Yes)
                        {
                            RESUMEN_DE_DATOS Resumen = new RESUMEN_DE_DATOS();

                            Resumen.Show();
                            this.Hide();
                        }
                        else
                        {
                            string anuncio = "¿Está seguro que desea salir?";
                            string titu = "Salida";
                            MessageBoxButtons opciones = MessageBoxButtons.YesNo;
                            DialogResult resultado = MessageBox.Show(anuncio, titu, opciones);

                            if (resultado == DialogResult.Yes)
                            {


                                Application.Exit();

                            }
                        }
                    }
                        if (POSICIONXADA < 0 || POSICIONXADA >= x || POSICIONYADA < 0 || POSICIONYADA >= y)
                        {
                            timer1.Enabled = false;
                        string mensaje = "ERROR. Usted ha salido del borde ¿Desea ver sus resultados?";
                        string titulo = "salio del borde";
                        MessageBoxButtons botones = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(mensaje, titulo, botones);
                        if (result == DialogResult.Yes)
                        {
                            RESUMEN_DE_DATOS form = new RESUMEN_DE_DATOS();
                            this.Hide();
                            form.ShowDialog();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }

                    

                    pictureBox2.Invalidate();
                }

            }

                
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Movimiento();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}