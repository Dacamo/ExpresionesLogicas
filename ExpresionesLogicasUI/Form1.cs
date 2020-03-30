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
        }

        private void btnBorrarDeAUno_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valorIgual = true;
            string expresion = "(" + textBoxCalculadora.Text + ")";
            var diccionario = Analizador.AnalizarExpresion(expresion);
            foreach (var item in diccionario)
            {
                dataGridView1.Columns.Add(item.Key, item.Key);
            }
            

            
            //recorer el diccionario e imprimirlo en el datagridview
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
