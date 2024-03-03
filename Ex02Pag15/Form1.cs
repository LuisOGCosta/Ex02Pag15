using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02Pag15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variaveis 
            double n1, n2, gasolina;

            // Entrada de Dados 

            n1 = double.Parse(txtPrecoGasosa.Text);
            n2 = double.Parse(txtPagamento.Text);

            // Procedimento

            gasolina = n2 / n1;

            // Saidas de Dados

            txtResultado.Text = gasolina.ToString(); 



        }
    }
}
