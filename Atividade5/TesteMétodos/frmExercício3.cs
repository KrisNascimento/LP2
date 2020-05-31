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
    public partial class frmExercício3 : Form
    {
        public frmExercício3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnRemoveP1daP2_Click(object sender, EventArgs e)
        {
            //r                 ss                  r
            //arara             assessoria          sorocaba
            //posição=1         posição=1           posição=2
            //aara              aessoria            soocaba

            int posicao;
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            }
        }

        private void btnRemovePorReplace_Click(object sender, EventArgs e)
        {
            //r
            //arara
            //aaa

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            //sorocaba
            //abarocos
            //fatec
            //cetaf
            //ovo
            //ovo

            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray(); //jogo a string pra um array
            Array.Reverse(arr); //invertendo o array
            s = "";
            foreach (char c in arr)
             s = s + c.ToString();
            MessageBox.Show(s);

            //ou
            string ss = txtPalavra1.Text;
            char[] arr1 = ss.ToCharArray();
            Array.Reverse(arr1);
            ss = new string(arr1);
            MessageBox.Show(ss);

            //exemplo do new string
            string s1 = new string('a', 7); //aaaaaaa
                 
        }
    }
}
