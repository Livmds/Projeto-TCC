using System;
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

           

            int tipo = 0;

            if (comboPorte.SelectedIndex == 0)
                tipo = 1;
            else if (comboPorte.SelectedIndex == 1)
                tipo = 2;
            else if (comboPorte.SelectedIndex == 2)
                tipo = 3;
            else if (comboPorte.SelectedIndex == 3)
                tipo = 4;


            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (txtInsti.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (txtRaca.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (txtCod.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (comboPorte.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            if (DAO_Conexao.CadAnimal(txtCod.Text, txtNome.Text, txtRaca.Text, comboPorte.Text, txtInsti.Text, tipo))
            {
                MessageBox.Show("Cadastro Realizado");
            }
            else
                MessageBox.Show("Erro");

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

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
