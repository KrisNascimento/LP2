using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtAltura.Text = "";
            txtVolume.Text = "";
            
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            double Raio, Altura, Volume;

            if ((double.TryParse(txtRaio.Text, out Raio) &&
                double.TryParse(txtAltura.Text, out Altura)))
            {
                double soma = Math.PI * Math.Pow(Raio, 2) * Altura;
                txtVolume.Text = soma.ToString("N2");
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            double Altura;
        }
    }
}
