using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int numeroDaConta;
            //numeroDaConta = 1;

            //double saldo = 100.0;
            //double valorDoSaque = 10.0;

            //saldo -= valorDoSaque;

            //int valor = 1;
            //forçando a variavel a acetar um valor maior numa short
            //short valorPequeno = (short) valor;

            string mensagem = "Minha Mensagem";


            MessageBox.Show(mensagem);
        }
    }
}
