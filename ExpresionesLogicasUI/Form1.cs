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

        bool valorIgual = false;
        String[] preposiciones = { "p", "q", "r" };
        String[] operadoresLogicos = { "&", ">", "|", "=" };

        public formCalculadora()
        {
            InitializeComponent();
        }

        
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
            this.Size = new Size(408, 431);
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
            Analizador.LimpiarValores();
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
                    var nuevaExpresion = "";
                    var valorById = Analizador.ObtenerValorById(item.Key);
                    if(valorById == null)
                    {
                        nuevaExpresion = item.Key;
                    }
                    else
                    {
                        nuevaExpresion = Analizador.ArmarExpresion(valorById);
                    }
                    
                    dataGridView1.Columns.Add(item.Key, nuevaExpresion);
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
                this.Size = new Size(1328, 431);
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
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas("p");
            }
            else { textBoxCalculadora.Text += "p"; }

        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas("q");
            }
            else { textBoxCalculadora.Text += "q"; }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas("r");
            }
            else { textBoxCalculadora.Text += "r"; }
        }


        private void btnOperadorY_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas("&");
            }
            else MessageBox.Show("no se puede usar & al inicio de una expresion");
        }

        private void btnOperadorO_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas("|");
            }
            else MessageBox.Show("no se puede usar | al inicio de una expresion");

        }

        private void btnImplicacion_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas(">");
            }
            else MessageBox.Show("no se puede usar > al inicio de una expresion");
        }

        private void btnSiYSoloSi_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas("=");
            }
            else MessageBox.Show("no se puede usar = al inicio de una expresion");
        }

        private void BtnParentesisAbre_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas("(");
            }
            else { textBoxCalculadora.Text += "("; }
            

        }

        private void BtnParentesisCierra_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                valorIgual = false;
            }
            if (textBoxCalculadora.Text != "")
            {
                compararExpresionesContinuas(")");
            }
            else MessageBox.Show("no se puede usar ) al inicio de una expresion"); 
        }

        private void textBoxCalculadora_TextChanged(object sender, EventArgs e)
        {

        }
        private void compararExpresionesContinuas(String caracter)
        {
            String ultimoCaracter = (textBoxCalculadora.Text.Substring(textBoxCalculadora.Text.Length - 1));

            if ((Array.IndexOf(preposiciones, caracter) != -1)|| caracter == "(")
            {
                if (ultimoCaracter != ")" & ultimoCaracter != "p" & ultimoCaracter != "q" & ultimoCaracter != "r")
                {
                    textBoxCalculadora.Text += caracter;
                }
                else
                {
                    MessageBox.Show("no se puede usar " + caracter + " despues de " + ultimoCaracter);
                }
            }
            else if (Array.IndexOf(operadoresLogicos, caracter) != -1 | caracter == ")")
            {
                if ((Array.IndexOf(operadoresLogicos, ultimoCaracter) != -1) | ultimoCaracter == "(")
                {
                    MessageBox.Show("no se puede usar el operador " + caracter + " despues de " + ultimoCaracter);
                }
                else
                {
                    textBoxCalculadora.Text += caracter;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            textBoxCalculadora.Text = comboBox1.Text;
        }
    }
}
