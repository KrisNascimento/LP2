using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbtnFeminino.Checked)
            {
                double Altura, PesoAtual, PesoIdeal;
                if (double.TryParse(mskbxAltura.Text, out Altura) &&
                double.TryParse(mskbxPesoAtual.Text, out PesoAtual))
                {
                    PesoIdeal = (62.1 * Altura) - 44.7;
                    Math.Round(PesoIdeal, 2);
                    txtPesoIdeal.Text = PesoIdeal.ToString("N2");

                    if (PesoAtual > PesoIdeal)
                    {
                        txtOqfazer.Text = ("Regime Obrigatório Já!");
                    }
                    else if (PesoAtual == PesoIdeal)
                        txtOqfazer.Text = ("Você está com o peso ideal!");
                    else
                        txtOqfazer.Text = ("Coma bastante massas e doces!");
                }
                else
                    MessageBox.Show("Informe apenas numeros");
            }
            else
            {
                double Altura, PesoAtual, PesoIdeal;
                if (double.TryParse(mskbxAltura.Text, out Altura) &&
                    double.TryParse(mskbxPesoAtual.Text, out PesoAtual))
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    Math.Round(PesoIdeal, 2);
                    txtPesoIdeal.Text = PesoIdeal.ToString("N2");

                    if (PesoAtual > PesoIdeal)
                    {
                        txtOqfazer.Text = ("Regime Obrigatório Já!");
                    }
                    else if (PesoAtual == PesoIdeal)
                        txtOqfazer.Text = ("Você está com o peso ideal!");
                    else
                        txtOqfazer.Text = ("Coma bastante massas e doces!");
                }
                else
                    MessageBox.Show("Informe apenas numeros");
            }



        }

    }
}