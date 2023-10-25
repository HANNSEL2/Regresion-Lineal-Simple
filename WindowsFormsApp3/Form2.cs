using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        //variables
        public int cantidad = 1;
        double[] datosX = new double[5];
        double[] datosY = new double[5];
        double[] datos;
        double sumatoriaX = 0;
        double sumatoriaY = 0;
        double sumatoria_X_Cuadrada = 0;
        double sumatoria_Y_Cuadrada = 0;
        double sumatoriaXY = 0;
        double desviacionX = 0;
        double desviacionY = 0;
        double VarianzaX = 0;
        double VarianzaY = 0;
        double covarianza = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertar();
        }

       

        public void insertar()
        {

           //cantidad de datos elegidos por el usuario
            cantidad = int.Parse(textBoxCant.Text);
           
            //Matriz de datos del tamaño elegido por el usuario
            datos = new double[cantidad];

            dataGridView1.DataSource = datos;


            // Agregar datos a la matriz

            // Obtener el texto del textbox
            string textoX = textBoxVx.Text;
            string textoY = textBoxVy.Text;

            // Dividir el texto por comas
            string[] valoresX = textoX.Split(',');
            string[] valoresY = textoY.Split(',');

            // Agregar los valores al arreglo
            datosX = new double[datos.Length];
            datosY = new double[datos.Length];

            for (int i = 0; i < datos.Length; i++)
            {
                datosX[i] = double.Parse(valoresX[i]);
                datosY[i] = double.Parse(valoresY[i]);
                sumatoriaX += datosX[i];
                sumatoriaY += datosY[i];
                sumatoria_X_Cuadrada += (datosX[i] * datosX[i]);
                sumatoria_Y_Cuadrada += (datosY[i] * datosY[i]);
                sumatoriaXY += (datosX[i] * datosY[i]);
            }



            for (int i = 0; i < datos.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = datosX[i];
                dataGridView1.Rows[i].Cells[1].Value = datosY[i];
                dataGridView1.Rows[i].Cells[2].Value = (datosX[i] * datosX[i]);
                dataGridView1.Rows[i].Cells[3].Value = (datosY[i] * datosY[i]);
                dataGridView1.Rows[i].Cells[4].Value = (datosX[i] * datosY[i]);

                //insertamos puntos a la grafica
                chart1.Series[0].Points.AddXY(datosX[i], datosY[i]);

            }


            dataGridView1.Show();

        }
        public void sumatoria()
        {

            textBoxSumaX.Text = sumatoriaX.ToString();
            textBoxSumaY.Text = sumatoriaY.ToString();
            textBoxMediaX.Text = (sumatoriaX / cantidad).ToString();
            textBoxMediaY.Text = (sumatoriaY / cantidad).ToString();

            textBoxXcuadrado.Text = sumatoria_X_Cuadrada.ToString();
            textBoxYcuadrado.Text = sumatoria_Y_Cuadrada.ToString();
            textBoxXY.Text = sumatoriaXY.ToString();

        }

        public void desviacion()
        {
            desviacionX = ((sumatoria_X_Cuadrada / cantidad) - (Math.Pow((sumatoriaX / cantidad), 2)));
            desviacionY = ((sumatoria_Y_Cuadrada / cantidad) - (Math.Pow((sumatoriaY / cantidad), 2)));
        }

        public void varianza()
        {

            VarianzaX = Math.Sqrt(desviacionX);
            VarianzaY = Math.Sqrt(desviacionY);
        }

        public void Covarianza()
        {

            covarianza = ((sumatoriaXY / cantidad) - ((sumatoriaX / cantidad) * (sumatoriaY / cantidad)));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            sumatoria();
            desviacion();
            varianza();
            Covarianza();


           
            

            textBoxDesviacionX.Text = desviacionX.ToString();
            textBoxDesviacionY.Text = desviacionY.ToString();
            textBoxVarianzaX.Text = VarianzaX.ToString();
            textBoxVarianzaY.Text = VarianzaY.ToString();

            

            textBoxCovarianza.Text = covarianza.ToString();






        }
    }
}
