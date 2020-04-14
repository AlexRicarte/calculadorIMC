using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculador_IM_V
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
            double imc, altura, peso;
            peso = Double.Parse(txtPeso.Text);
            altura = Double.Parse(txtAltura.Text);
            imc = peso / (altura * altura);
            MessageBox.Show("Seu Imc é:" + imc, "Resultado", MessageBoxButtons.OK);
        }
    }
}
