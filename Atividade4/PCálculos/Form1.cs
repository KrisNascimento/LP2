using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCálculos
{
    public partial class Form1 : Form
    {
        double salarioBruto, numFilhos, descINSS, descIRPF, salarioFamilia, salarioLiquido;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificaDesc_Click(object sender, EventArgs e)
        {
            
            if ((double.TryParse(mskbxSalarioBruto.Text, out salarioBruto) &&
                double.TryParse(mskbxNumFilhos.Text, out numFilhos)))
            {
                if(salarioBruto <= 800.47)
                {
                    mskbxAliqINSS.Text = "7.65%";
                    descINSS = 7.65 / 100 * salarioBruto;
                    mskbxDescINSS.Text = descINSS.ToString("N2");
                }
                else if (salarioBruto <= 1050)
                {
                    mskbxAliqINSS.Text = "8.65%";
                    descINSS = 8.65 / 100 * salarioBruto;
                    mskbxDescINSS.Text = descINSS.ToString("N2");
                }
                else if (salarioBruto <= 1400.77)
                {
                    mskbxAliqINSS.Text = "9.00%";
                    descINSS = 9.00 / 100 * salarioBruto;
                    mskbxDescINSS.Text = descINSS.ToString("N2");
                }
                else if (salarioBruto <= 2801.56)
                {
                    mskbxAliqINSS.Text = "11.00%";
                    descINSS = 11.00 / 100 * salarioBruto;
                    mskbxDescINSS.Text = descINSS.ToString("N2");
                }
                else if (salarioBruto >= 2801.57)
                {
                    mskbxAliqINSS.Text = "308.17";
                    descINSS = 308.17;
                    mskbxDescINSS.Text = descINSS.ToString("N2");
                }
                 
                if (salarioBruto <= 1257.12)
                {
                    mskbxAliqIRPF.Text = "Isento";
                    descIRPF = 0.00;
                    mskbxDescIRPF.Text = descIRPF.ToString("N2");
                }
                else if (salarioBruto <= 2512.08)
                {
                    mskbxAliqIRPF.Text = "15,00%";
                    descIRPF = 15.00 / 100 * salarioBruto;
                    mskbxDescIRPF.Text = descIRPF.ToString("N2");
                }
                else if (salarioBruto >= 2512.08)
                {
                    mskbxAliqIRPF.Text = "27.5%";
                    descIRPF = 27.5 / 100 * salarioBruto;
                    mskbxDescIRPF.Text = descIRPF.ToString("N2");
                }
                if (salarioBruto <= 435.52)
                {
                    salarioFamilia = 22.33 * numFilhos;
                    mskbxSalarioFamilia.Text = salarioFamilia.ToString("N2");
                }
                else if (salarioBruto <= 654.61)
                {
                    salarioFamilia = 15.74 * numFilhos;
                    mskbxSalarioFamilia.Text = salarioFamilia.ToString("N2");
                }

                else if (salarioBruto >= 654.61)
                    mskbxSalarioFamilia.Text = "0.00";

                salarioLiquido = salarioBruto - descINSS - descIRPF + salarioFamilia;
                mskbxSalarioLiquido.Text = salarioLiquido.ToString("N2");
            }
                else MessageBox.Show("Informe valores válidos para Número de filhos / Salário Bruto");

            if (ckbxCasado.Checked)
                rchtxtResultados.Text = "Os descontos no Salário da(o) Funcionária(o) " + txtNomeFuncionario.Text +
                ", que é Casada(o) e que tem " + numFilhos + " filhos, são";
            else
                rchtxtResultados.Text = "Os descontos no Salário da(o) Funcionária(o) " + txtNomeFuncionario.Text +
                ", que é Solteira(o) e que tem " + numFilhos + " filhos, são";



        }
    }
}