using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    

    public partial class frmExercício4 : Form
    {
        public frmExercício4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salbase, producao, prodB, prodC, prodD, gratificacao, salBruto;
            

            if ((double.TryParse(txtSalárioBase.Text, out salbase)
                && double.TryParse(txtProdução.Text, out producao)
                && double.TryParse(txtGratificação.Text, out gratificacao)))
            {
                if (producao >= 100)
                    prodB = 1;
                else
                    prodB = 0;
                if (producao >= 120)
                    prodC = 1;
                else
                    prodC = 0;
                if (producao >= 150)
                    prodD = 1;
                else
                    prodD = 0;

                salBruto = salbase + salbase * (0.05 * prodB + 0.1 * prodC + 0.1 * prodD)
                + gratificacao;

                if (salBruto > 7000.0)

                {

                    if (producao >= 150 && gratificacao > 0)

                    {

                        MessageBox.Show("O salário do referido funcionário é: " + salBruto.ToString("N2"));

                    }

                    else

                        MessageBox.Show("Este funcionário não cumpre os requisitos para a quantia calculada! " +
                                        "Reveja os lançamentos");

                }

               

            }
            
        }
    }
}
