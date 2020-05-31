using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteMétodos
{
    public partial class frmExercício4 : Form
    {
        public frmExercício4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dias 10 melhores 1000 - 21 caracteres
            MessageBox.Show(rchtxtTexto.Text.Length.ToString());
            int contador = 0;

            for (var x = 0; x <= rchtxtTexto.Text.Length - 1; x++)
            {
            //if (Char.IsNumber(Convert.ToChar(rchtxtTexto.Text.Substring (x, 1))))

                if (Char.IsNumber(rchtxtTexto.Text[x]))
                    contador += 1; // contador=contador+1
            }

            MessageBox.Show("Caracteres Numéricos : "+contador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            //hoje tem chuva - 14 caracteres
            //4 - desenvolvedor 5 - usuário

            while (x<rchtxtTexto.Text.Length)
            {
                //if (rcgtxtTexto.Text[x]==' ')

                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro Caracter Branco :" + (x +1));
                    break;
                }
                x += 1; // x=x+1
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //vejo flores 123 em você

            int contador = 0;
            foreach (char cara in rchtxtTexto.Text)
            {
                if (char.IsLetter(cara))
                    contador += 1;

            }
            MessageBox.Show("Caracteres Alfabéticos:" + contador);
        }
    }
}
