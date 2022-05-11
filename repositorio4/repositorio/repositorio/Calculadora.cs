using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace repositorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Valor1 =Convert.ToInt32(txtValor1.Text);
            int Valor2 = Convert.ToInt32(txtValor2.Text);
            int Total = Valor1 + Valor2;
            txtTotal.Text = Total.ToString();
        //    MessageBox.Show(Total.ToString());

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Valor1 = Convert.ToInt32(txtValor1.Text);
            int Valor2 = Convert.ToInt32(txtValor2.Text);
            int Total = Valor2 -Valor1;
            txtTotal.Text = Total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Valor1 = Convert.ToInt32(txtValor1.Text);
            int Valor2 = Convert.ToInt32(txtValor2.Text);
            int Total = Valor1 * Valor2;
            txtTotal.Text = Total.ToString();
        }

        private void Resto_Click(object sender, EventArgs e)
        {
            decimal Valor1 = Convert.ToDecimal(txtValor1.Text);
            decimal Valor2 = Convert.ToDecimal (txtValor2.Text);
            decimal Total = 0;
            if (Valor1 != 0)
            {
                Total = Valor2 / Valor1;
            }
            else { MessageBox.Show("No se puede dividir entre 0"); }

            txtTotal.Text = Total.ToString();
        }

        
       
    }
}
