﻿using System;
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
    public partial class frmExercício5 : Form
    {
        public frmExercício5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            int numero = objRandom.Next(Convert.ToInt32(txtPrimeiro.Text),
                Convert.ToInt32(txtSegundo.Text));
            MessageBox.Show("O número sorteado é:" + numero);

        }
    }
}
