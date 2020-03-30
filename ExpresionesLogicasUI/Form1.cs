using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpresionesLogicas;

namespace ExpresionesLogicasUI
{
    public partial class formCalculadora : Form
    {
        public formCalculadora()
        {
            InitializeComponent();
        }

        bool valorIgual = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textBoxCalculadora.Clear();
            textBox1.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            Analizador.LimpiarErrores();
        }

        private void btnBorrarDeAUno_Click(object sender, EventArgs e)
        {
            if (textBoxCalculadora.Text != "")
            {
                textBoxCalculadora.Text = textBoxCalculadora.Text.Substring(0, textBoxCalculadora.Text.Count() - 1);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Analizador.LimpiarErrores();
            string expresion = textBoxCalculadora.Text;
            //validaciones
            if (Analizador.ValidarExpresion(expresion))
            {

                //configuracion del dataGridValue
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                valorIgual = true;
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = null;
                dataGridView1.AllowUserToOrderColumns = false;


                //Analizar expresion
                expresion = "(" + expresion + ")";
                var diccionario = Analizador.AnalizarExpresion(expresion);

                //recorer el diccionario e imprimirlo en el datagridview
                foreach (var item in diccionario)
                {
                    dataGridView1.Columns.Add(item.Key, Analizador.ObtenerValorById(item.Key) + "=" + item.Key);
                }

                var cantidad = diccionario.ElementAt(0).Value.Count;
                int index = 0;
                var lista = new List<string>();
                for (int x = 0; x < cantidad; x++)
                {
                    for (int i = 0; i < diccionario.Count; i++)
                    {
                        var item = diccionario.ElementAt(i);
                        lista.Add(item.Value[index]);
                    }
                    var vector = lista.ToArray();
                    dataGridView1.Rows.Add(vector);
                    lista.Clear();
                    index++;
                }
                MostrarErrores();
            }
            else
            { 
                MostrarErrores();
              
            }
            
        }

        void MostrarErrores()
        {
            //consultar los errores y mostrarlos
            textBox1.Clear();
            var errores = Analizador.ObtenerErrores();
            if (errores.Count >= 1)
            {
                textBox1.Text = errores[0];
            }
            
        }



        private void btnP_Click(object sender, EventArgs e)
        {
            
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "p";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "p";
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "q";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "q";
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "r";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "r";
            }
        }

        private void btnOperadorY_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "&";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "&";
            }
        }

        private void btnOperadorO_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "|";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "|";
            }
        }

        private void btnImplicacion_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += ">";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += ">";
            }
        }

        private void btnSiYSoloSi_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "=";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "=";
            }
        }

        private void BtnParentesisAbre_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "(";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "(";
            }

        }

        private void BtnParentesisCierra_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += ")";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += ")";
            }
        }

        private void textBoxCalculadora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
