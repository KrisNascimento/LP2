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
    public partial class frmExercício2 : Form
    {
        public frmExercício2()
        {
            InitializeComponent();
        }

        private void btnGerarNum_Click(object sender, EventArgs e)
        {
            double H = 0.0;
            if (Int32.TryParse(txtValorN.Text, out int N) && N > 0)
            {
                for (double x = 1; x <= N; x++)
                {
                    H += (1.00 / x);
                }
                MessageBox.Show("O número H é: " + H);
            }
            else
                MessageBox.Show("O número informado precisa ser Inteiro, Positivo e Diferente de 0!");
        }
    }
}
