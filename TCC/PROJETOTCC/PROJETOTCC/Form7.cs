﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOTCC
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }else
            {
                MessageBox.Show("Cadastro de animal foi salvo!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
