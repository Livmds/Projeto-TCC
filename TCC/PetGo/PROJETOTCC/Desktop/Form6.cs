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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }else if(txtCPF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }else if(txtContato.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }else if(txtEnd.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (txtNum.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (txtEstado.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            else
            {
                MessageBox.Show("Cadastro de Adotante salvo!");
            }

            int tipo = 0;

            if (txtEstado.SelectedIndex == 0)
                tipo = 1; 
            else if (txtEstado.SelectedIndex == 1)
                tipo = 2;
            else if (txtEstado.SelectedIndex == 2)
                tipo = 3;
            else if (txtEstado.SelectedIndex == 3)
                tipo = 4;
            else if (txtEstado.SelectedIndex == 4)
                tipo = 5;
            else if (txtEstado.SelectedIndex == 5)
                tipo = 6;
            else if (txtEstado.SelectedIndex == 6)
                tipo = 7;
            else if (txtEstado.SelectedIndex == 7)
                tipo = 8;
            else if (txtEstado.SelectedIndex == 8)
                tipo = 9;
            else if (txtEstado.SelectedIndex == 9)
                tipo = 10;
            else if (txtEstado.SelectedIndex == 10)
                tipo = 11;
            else if (txtEstado.SelectedIndex == 11)
                tipo = 12;
            else if (txtEstado.SelectedIndex == 12)
                tipo = 13;
            else if (txtEstado.SelectedIndex == 13)
                tipo = 14;
            else if (txtEstado.SelectedIndex == 14)
                tipo = 15;
            else if (txtEstado.SelectedIndex == 15)
                tipo = 16;
            else if (txtEstado.SelectedIndex == 16)
                tipo = 17;
            else if (txtEstado.SelectedIndex == 17)
                tipo = 18;
            else if (txtEstado.SelectedIndex == 18)
                tipo = 19;
            else if (txtEstado.SelectedIndex == 19)
                tipo = 20;
            else if (txtEstado.SelectedIndex == 20)
                tipo = 21;
            else if (txtEstado.SelectedIndex == 21)
                tipo = 22;
            else if (txtEstado.SelectedIndex == 22)
                tipo = 23;
            else if (txtEstado.SelectedIndex == 23)
                tipo = 24;
            else if (txtEstado.SelectedIndex == 24)
                tipo = 25;
            else if (txtEstado.SelectedIndex == 25)
                tipo = 26;
            else if (txtEstado.SelectedIndex == 26)
                tipo = 27;

            if (DAO_Conexao.CadAdotante(txtNome.Text, txtCPF.Text, txtContato.Text, txtEnd.Text, txtNum.Text, txtEstado.Text, txtCidade.Text, tipo))
            {                
                MessageBox.Show("Cadastro Realizado");
            }
            else
                MessageBox.Show("Erro");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
