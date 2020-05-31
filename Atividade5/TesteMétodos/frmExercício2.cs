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
    public partial class frmExercício2 : Form
    {
        public frmExercício2()
        {
            InitializeComponent();
        }

        private void frmExercício2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
                MessageBox.Show("São iguais!");
            else
                MessageBox.Show("São diferentes!");
        }

        private void btnInsereP1_Click(object sender, EventArgs e)
        {
            //a         a           ss
            //casa      fatec       sorocaba
            //caasa     faatec      sorosscaba
            //caasa     faatec      soroacaba

            int meio = txtPalavra2.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) +
                txtPalavra1.Text +
                txtPalavra2.Text.Substring(meio,
                txtPalavra2.Text.Length - meio);
        }

        private void btnInsereAsterisco_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");

        }
    }
}
