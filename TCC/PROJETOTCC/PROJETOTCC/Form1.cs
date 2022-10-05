using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOTCC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (DAO_Conexao.getConexao("143.106.241.3", "cl201452", "cl201452", "cl*15022003"))
                Console.WriteLine("conectado");
            else
                Console.WriteLine("Erro");


            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(5000);
            InitializeComponent();

            thread.Abort();
        }

        private void splashScreen()
        {
            
            
        }

        private void adotanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count()==0)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
            }
        
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() == 0)
            {
                Form3 f3 = new Form3();
                f3.MdiParent = this;
                f3.Show();
            }
        }

        private void cadastroAdotanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form6>().Count() == 0)
            {
                Form6 f6 = new Form6();
                f6.MdiParent = this;
                f6.Show();
            }
        }

        private void cadastroAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form7>().Count() == 0)
            {
                Form7 f7 = new Form7();
                f7.MdiParent = this;
                f7.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
