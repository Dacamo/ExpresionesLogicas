using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            textBoxCalculadora.Clear();
            valorIgual = true;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "P";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "P";
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "Q";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "Q";
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "R";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "R";
            }
        }

        private void btnOperadorY_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "∧";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "∧";
            }
        }

        private void btnOperadorO_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "V";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "V";
            }
        }

        private void btnImplicacion_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "→";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "→";
            }
        }

        private void btnSiYSoloSi_Click(object sender, EventArgs e)
        {
            if (valorIgual == true)
            {
                textBoxCalculadora.Clear();
                textBoxCalculadora.Text += "↔";
                valorIgual = false;
            }
            else
            {
                textBoxCalculadora.Text += "↔";
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
    }
}
