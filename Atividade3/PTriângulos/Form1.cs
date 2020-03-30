using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriângulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double LadoA, LadoB, LadoC;

            if ((double.TryParse(txtLadoA.Text, out LadoA) &&
                 double.TryParse(txtLadoB.Text, out LadoB) &&
                 double.TryParse(txtLadoC.Text, out LadoC)))
            {
                if (Math.Abs(LadoB - LadoC) < LadoA && LadoA < (LadoB + LadoC) &&
                    Math.Abs(LadoA - LadoC) < LadoB && LadoB < (LadoA + LadoC) &&
                    Math.Abs(LadoA - LadoB) < LadoC && LadoC < (LadoA + LadoB))
                {
                    if (LadoA == LadoB && LadoB != LadoC || LadoA == LadoC && LadoB != LadoC ||
                        LadoB == LadoC && LadoA != LadoC)
                        MessageBox.Show("Este é um Triângulo Isóceles");

                    if (LadoA == LadoB && LadoB == LadoC)
                        MessageBox.Show("Este é um triângulo Equilátero");

                    if (LadoA != LadoB && LadoA != LadoC && LadoB != LadoC)
                        MessageBox.Show("Este é um Triângulo Escaleno");
                }
                else
                    MessageBox.Show("Informe Valores Válidos!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
