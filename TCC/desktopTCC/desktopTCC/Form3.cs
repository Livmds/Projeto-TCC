﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopTCC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void adotanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 adotante = new Form1();
            adotante.Show();
        }
    }
}
